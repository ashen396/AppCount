using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppCount
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		public string[] file_app_name;
		Label[] time;
		int timec=0,app_name_counter=0;
		void MainFormLoad(object sender, EventArgs e)
		{
			//VARIABLES
			StreamReader input_file;
			int pos_x=30,pos_y=80;
			int ico_pos_x=68,ico_pos_y=100;
			int app_txt_pos_x=50,app_txt_pos_y=240;
			int time_txt_pos_x=50,time_txt_pos_y=300;
			int counter = 0;
			string temp;
			
			input_file = new StreamReader("./app_config");
			while(input_file.ReadLine() != null){
				counter++;
			}
			input_file.BaseStream.Position = 0;
			input_file.DiscardBufferedData();
			
			file_app_name = new string[counter];
			string[] file_app_time = new string[counter];
			time = new Label[counter];
			string app_icon_path;
			int app_name_count = 0, app_time_count = 0;
			counter = 0;

			while((temp = input_file.ReadLine()) != null){
				if((counter % 2) == 0){
					file_app_name[app_name_count] = temp;	
					app_name_count++;
				}else{
					file_app_time[app_time_count] = temp;
					app_time_count++;
				}
				counter++;
			}
			input_file.Close();
			timec = app_time_count;
			
			this.BackColor = Color.FromArgb(30,30,30);
			for(int x=0;x<(counter/2);x++){
				PictureBox pic = new PictureBox();
				PictureBox icon = new PictureBox();
				
				pic.Image = Image.FromFile("app_bg.png");
				pic.SizeMode = PictureBoxSizeMode.StretchImage;
				pic.Size = new Size(195,270);
				pic.Location = new Point(pos_x,pos_y);
				pic.Refresh();
				
				if(File.Exists(file_app_name[x]+".png")){
				   	app_icon_path = file_app_name[x] + ".png";
				}else{
				   	app_icon_path = "app_icon_unavailable.png";
				}
				
				icon.Image = Image.FromFile(app_icon_path);
				icon.Size = new Size(120,120);
				icon.Location = new Point(ico_pos_x,ico_pos_y);
				icon.Refresh();
				
				Label app_name = new Label();
				app_name.Size = new Size(156,30);
				app_name.Font = new Font("Arial",18,FontStyle.Regular);
				app_name.Text = file_app_name[x].ToUpper();											//APP NAME
				app_name.TextAlign = ContentAlignment.MiddleCenter;
				app_name.BackColor = Color.FromArgb(42,42,42);
				app_name.ForeColor = Color.White;
				app_name.Location = new Point(app_txt_pos_x,app_txt_pos_y);
				app_name.Refresh();
				
				string[] time_array = new string[4];
				time_array = file_app_time[x].Split(':');
				
				time[x] = new Label();
				time[x].Name = "app_time_" + file_app_name[x];
				time[x].Size = new Size(158,30);
				time[x].Font = new Font("Arial",14,FontStyle.Regular);
				time[x].Text = time_array[0] + " : " + time_array[1] + " : " + time_array[2] + " : " + time_array[3] ;			//APP TIME
				time[x].TextAlign = ContentAlignment.MiddleCenter;
				time[x].BackColor = Color.FromArgb(42,42,42);
				time[x].ForeColor = Color.White;
				time[x].Location = new Point(time_txt_pos_x,time_txt_pos_y);
				time[x].Refresh();
				
				if(pos_x > 700){
					//icon position
					ico_pos_x = 68;
					ico_pos_y = ico_pos_y + 300;
					
					//app text position
					app_txt_pos_x = 50;
					app_txt_pos_y = app_txt_pos_y + 300;
					
					//time text position
					time_txt_pos_x = 50;
					time_txt_pos_y = time_txt_pos_y + 300;
					
					//background image position
					pos_x = 30;
					pos_y = pos_y + 300;
					
				}else{
					//icon position
					ico_pos_x = ico_pos_x + 240;
					ico_pos_y =  ico_pos_y + 0;
					
					//app text position
					app_txt_pos_x = app_txt_pos_x + 240;
					app_txt_pos_y = app_txt_pos_y + 0;
					
					//time text position
					time_txt_pos_x = time_txt_pos_x + 240;
					time_txt_pos_y = time_txt_pos_y + 0;
					
					//background image positon
					pos_x = pos_x + 240;
					pos_y = pos_y + 0;
				}	
				panel.Controls.Add(icon);
				panel.Controls.Add(app_name);
				panel.Controls.Add(time[x]);
				panel.Controls.Add(pic);
				
				System.Threading.Thread.Sleep(500);
			}
		}
		
		void MainFormShown(object sender, EventArgs e)
		{
			Timer t = new Timer();
			t.Interval = 1500;
			t.Tick += new EventHandler(t_Tick);
			t.Start();
		}

		void t_Tick(object sender, EventArgs e)
		{
			//CHECK		
			Process[] proc;
			int proc_length;
			string app_name_text;
			app_name_text = file_app_name[app_name_counter];
			proc = Process.GetProcesses();
			proc_length = proc.Length;
			
			for(int x=0;x<proc_length;x++){
				DateTime b = System.DateTime.Now;
				if(proc[x].ProcessName == app_name_text){
					DateTime a = proc[x].StartTime;
					TimeSpan c = (b-a);
					string day_text,hour_text,min_text,sec_text;
					int days = c.Days;
					int hours = c.Hours;
					int min = c.Minutes;
					int sec = c.Seconds;
					
					if(days<10){
						day_text = "0" + days.ToString();
					}else{
						day_text = days.ToString();
					}
					
					if(hours<10){
						hour_text = "0" + hours.ToString();
					}else{
						hour_text = hours.ToString();
					}
					
					if(min<10){
						min_text = "0" + min.ToString();
					}else{
						min_text = min.ToString();
					}
					
					if(sec<10){
						sec_text = "0" + sec.ToString();
					}else{
						sec_text = sec.ToString();
					}
					time[app_name_counter].Text = day_text + " : " + hour_text + " : " + min_text + " : " + sec_text;
					break;
				}
				if(app_name_counter >= timec){
					app_name_counter = -1;
				}
					
			}	
				GC.Collect();		//GARBAGE COLLECTOR
				GC.WaitForPendingFinalizers();		//CLEARS THE GARBAGEs
				app_name_counter++;
		} 
	}
}

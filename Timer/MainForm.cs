/*
 * Created by SharpDevelop.
 * User: LAB-04
 * Date: 15/10/2021
 * Time: 8:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Timer
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public int seg,min,hor;
		public MainForm()
		{
			
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		
		}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		
		
			void Tmr_CronometroTick(object sender, EventArgs e)
			{
				
				if (seg<60){
					seg++;
				}else if (min<60){
					min++;
					seg=0;
				}else{
					hor++;
					min=0;
				}
				
				txt_segundos.Text=Convert.ToString(seg);
				txt_horas.Text=Convert.ToString(hor);
				txt_minutos.Text=Convert.ToString(min);
		}
		void Btn_pausaClick(object sender, EventArgs e)
		{
			if(tmr_Cronometro.Enabled == false){
				tmr_Cronometro.Enabled=true;
				btn_pausa.Text = "Pausar";
			}else{
				tmr_Cronometro.Enabled=false;
				btn_pausa.Text = "Iniciar";
			}
		 
			
		}
		
		void Btn_reinicioClick(object sender, EventArgs e)
		{
			btn_pausa.Text = "Iniciar";
			tmr_Cronometro.Enabled = false;
			seg=0;
			min=0;
			hor=0;
			txt_segundos.Text=Convert.ToString(seg);
			txt_horas.Text=Convert.ToString(hor);
			txt_minutos.Text=Convert.ToString(min);
		}
	}
}

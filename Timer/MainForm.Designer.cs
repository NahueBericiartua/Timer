/*
 * Created by SharpDevelop.
 * User: LAB-04
 * Date: 15/10/2021
 * Time: 8:49 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Timer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tmr_Cronometro = new System.Windows.Forms.Timer(this.components);
			this.txt_horas = new System.Windows.Forms.Label();
			this.txt_minutos = new System.Windows.Forms.Label();
			this.txt_segundos = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_pausa = new System.Windows.Forms.Button();
			this.btn_reinicio = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// tmr_Cronometro
			// 
			this.tmr_Cronometro.Interval = 1000;
			this.tmr_Cronometro.Tick += new System.EventHandler(this.Tmr_CronometroTick);
			// 
			// txt_horas
			// 
			this.txt_horas.Location = new System.Drawing.Point(40, 67);
			this.txt_horas.Name = "txt_horas";
			this.txt_horas.Size = new System.Drawing.Size(37, 37);
			this.txt_horas.TabIndex = 0;
			this.txt_horas.Text = "0";
			this.txt_horas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_minutos
			// 
			this.txt_minutos.Location = new System.Drawing.Point(121, 67);
			this.txt_minutos.Name = "txt_minutos";
			this.txt_minutos.Size = new System.Drawing.Size(37, 37);
			this.txt_minutos.TabIndex = 1;
			this.txt_minutos.Text = "0";
			this.txt_minutos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_segundos
			// 
			this.txt_segundos.Location = new System.Drawing.Point(209, 67);
			this.txt_segundos.Name = "txt_segundos";
			this.txt_segundos.Size = new System.Drawing.Size(37, 37);
			this.txt_segundos.TabIndex = 2;
			this.txt_segundos.Text = "0";
			this.txt_segundos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(97, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = ":";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(172, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 23);
			this.label2.TabIndex = 4;
			this.label2.Text = ":";
			// 
			// btn_pausa
			// 
			this.btn_pausa.Location = new System.Drawing.Point(40, 136);
			this.btn_pausa.Name = "btn_pausa";
			this.btn_pausa.Size = new System.Drawing.Size(82, 33);
			this.btn_pausa.TabIndex = 5;
			this.btn_pausa.Text = "Iniciar";
			this.btn_pausa.UseVisualStyleBackColor = true;
			this.btn_pausa.Click += new System.EventHandler(this.Btn_pausaClick);
			// 
			// btn_reinicio
			// 
			this.btn_reinicio.Location = new System.Drawing.Point(164, 136);
			this.btn_reinicio.Name = "btn_reinicio";
			this.btn_reinicio.Size = new System.Drawing.Size(82, 33);
			this.btn_reinicio.TabIndex = 6;
			this.btn_reinicio.Text = "Reiniciar";
			this.btn_reinicio.UseVisualStyleBackColor = true;
			this.btn_reinicio.Click += new System.EventHandler(this.Btn_reinicioClick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Ravie", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.label3.Location = new System.Drawing.Point(40, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 49);
			this.label3.TabIndex = 8;
			this.label3.Text = "Cronometro";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_reinicio);
			this.Controls.Add(this.btn_pausa);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txt_segundos);
			this.Controls.Add(this.txt_minutos);
			this.Controls.Add(this.txt_horas);
			this.Name = "MainForm";
			this.Text = "Timer";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label txt_segundos;
		private System.Windows.Forms.Label txt_minutos;
		private System.Windows.Forms.Label txt_horas;
		private System.Windows.Forms.Timer tmr_Cronometro;
		private System.Windows.Forms.Button btn_pausa;
		private System.Windows.Forms.Button btn_reinicio;
		private System.Windows.Forms.Label label3;
	}
}

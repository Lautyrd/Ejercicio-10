/*
 * Created by SharpDevelop.
 * User: LAB-02
 * Date: 11/11/2021
 * Time: 09:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_10
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbl_resultado;
		private System.Windows.Forms.Button btn_resultado;
		private System.Windows.Forms.Button btn_suma;
		private System.Windows.Forms.Button btn_resta;
		private System.Windows.Forms.Button btn_multiplicacion;
		private System.Windows.Forms.Button btn_division;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_cambsig;
		private System.Windows.Forms.Button btn_coma;
		private System.Windows.Forms.Button btn_cero;
		private System.Windows.Forms.Button btn_uno;
		private System.Windows.Forms.Button btn_dos;
		private System.Windows.Forms.Button btn_tres;
		private System.Windows.Forms.Button btn_cuatro;
		private System.Windows.Forms.Button btn_cinco;
		private System.Windows.Forms.Button btn_seis;
		private System.Windows.Forms.Button btn_siete;
		private System.Windows.Forms.Button btn_ocho;
		private System.Windows.Forms.Label lbl_cuenta;
		private System.Windows.Forms.Button btn_nueve;
		
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
			this.lbl_resultado = new System.Windows.Forms.Label();
			this.btn_resultado = new System.Windows.Forms.Button();
			this.btn_suma = new System.Windows.Forms.Button();
			this.btn_resta = new System.Windows.Forms.Button();
			this.btn_multiplicacion = new System.Windows.Forms.Button();
			this.btn_division = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_cambsig = new System.Windows.Forms.Button();
			this.btn_coma = new System.Windows.Forms.Button();
			this.btn_cero = new System.Windows.Forms.Button();
			this.btn_uno = new System.Windows.Forms.Button();
			this.btn_dos = new System.Windows.Forms.Button();
			this.btn_tres = new System.Windows.Forms.Button();
			this.btn_cuatro = new System.Windows.Forms.Button();
			this.btn_cinco = new System.Windows.Forms.Button();
			this.btn_seis = new System.Windows.Forms.Button();
			this.btn_siete = new System.Windows.Forms.Button();
			this.btn_ocho = new System.Windows.Forms.Button();
			this.btn_nueve = new System.Windows.Forms.Button();
			this.lbl_cuenta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbl_resultado
			// 
			this.lbl_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_resultado.Location = new System.Drawing.Point(3, 57);
			this.lbl_resultado.Name = "lbl_resultado";
			this.lbl_resultado.Size = new System.Drawing.Size(351, 61);
			this.lbl_resultado.TabIndex = 0;
			this.lbl_resultado.Text = "0";
			this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btn_resultado
			// 
			this.btn_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_resultado.Location = new System.Drawing.Point(277, 318);
			this.btn_resultado.Name = "btn_resultado";
			this.btn_resultado.Size = new System.Drawing.Size(75, 132);
			this.btn_resultado.TabIndex = 1;
			this.btn_resultado.Text = "=";
			this.btn_resultado.UseVisualStyleBackColor = true;
			this.btn_resultado.Click += new System.EventHandler(this.Btn_resultadoClick);
			this.btn_resultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_suma
			// 
			this.btn_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_suma.Location = new System.Drawing.Point(277, 250);
			this.btn_suma.Name = "btn_suma";
			this.btn_suma.Size = new System.Drawing.Size(75, 62);
			this.btn_suma.TabIndex = 2;
			this.btn_suma.Text = "+";
			this.btn_suma.UseVisualStyleBackColor = true;
			this.btn_suma.Click += new System.EventHandler(this.Btn_sumaClick);
			this.btn_suma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_resta
			// 
			this.btn_resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_resta.Location = new System.Drawing.Point(277, 180);
			this.btn_resta.Name = "btn_resta";
			this.btn_resta.Size = new System.Drawing.Size(75, 63);
			this.btn_resta.TabIndex = 3;
			this.btn_resta.Text = "-";
			this.btn_resta.UseVisualStyleBackColor = true;
			this.btn_resta.Click += new System.EventHandler(this.Btn_sumaClick);
			this.btn_resta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_multiplicacion
			// 
			this.btn_multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_multiplicacion.Location = new System.Drawing.Point(277, 121);
			this.btn_multiplicacion.Name = "btn_multiplicacion";
			this.btn_multiplicacion.Size = new System.Drawing.Size(75, 53);
			this.btn_multiplicacion.TabIndex = 4;
			this.btn_multiplicacion.Text = "*";
			this.btn_multiplicacion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btn_multiplicacion.UseVisualStyleBackColor = true;
			this.btn_multiplicacion.Click += new System.EventHandler(this.Btn_sumaClick);
			this.btn_multiplicacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_division
			// 
			this.btn_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_division.Location = new System.Drawing.Point(187, 121);
			this.btn_division.Name = "btn_division";
			this.btn_division.Size = new System.Drawing.Size(84, 53);
			this.btn_division.TabIndex = 5;
			this.btn_division.Text = "/";
			this.btn_division.UseVisualStyleBackColor = true;
			this.btn_division.Click += new System.EventHandler(this.Btn_sumaClick);
			this.btn_division.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_delete
			// 
			this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_delete.Location = new System.Drawing.Point(93, 121);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(88, 53);
			this.btn_delete.TabIndex = 6;
			this.btn_delete.Text = "←";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.Btn_deleteClick);
			this.btn_delete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_clear
			// 
			this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_clear.Location = new System.Drawing.Point(1, 121);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(86, 53);
			this.btn_clear.TabIndex = 7;
			this.btn_clear.Text = "C";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.Btn_clearClick);
			this.btn_clear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_cambsig
			// 
			this.btn_cambsig.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_cambsig.Location = new System.Drawing.Point(3, 387);
			this.btn_cambsig.Name = "btn_cambsig";
			this.btn_cambsig.Size = new System.Drawing.Size(86, 63);
			this.btn_cambsig.TabIndex = 8;
			this.btn_cambsig.Text = "+/-";
			this.btn_cambsig.UseVisualStyleBackColor = true;
			this.btn_cambsig.Click += new System.EventHandler(this.Btn_cambsigClick);
			// 
			// btn_coma
			// 
			this.btn_coma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_coma.Location = new System.Drawing.Point(189, 387);
			this.btn_coma.Name = "btn_coma";
			this.btn_coma.Size = new System.Drawing.Size(84, 63);
			this.btn_coma.TabIndex = 9;
			this.btn_coma.Text = ",";
			this.btn_coma.UseVisualStyleBackColor = true;
			this.btn_coma.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_coma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_cero
			// 
			this.btn_cero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_cero.Location = new System.Drawing.Point(95, 387);
			this.btn_cero.Name = "btn_cero";
			this.btn_cero.Size = new System.Drawing.Size(88, 63);
			this.btn_cero.TabIndex = 10;
			this.btn_cero.Text = "0";
			this.btn_cero.UseVisualStyleBackColor = true;
			this.btn_cero.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_cero.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_uno
			// 
			this.btn_uno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_uno.Location = new System.Drawing.Point(1, 318);
			this.btn_uno.Name = "btn_uno";
			this.btn_uno.Size = new System.Drawing.Size(86, 63);
			this.btn_uno.TabIndex = 11;
			this.btn_uno.Text = "1";
			this.btn_uno.UseVisualStyleBackColor = true;
			this.btn_uno.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_uno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_dos
			// 
			this.btn_dos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_dos.Location = new System.Drawing.Point(95, 318);
			this.btn_dos.Name = "btn_dos";
			this.btn_dos.Size = new System.Drawing.Size(86, 63);
			this.btn_dos.TabIndex = 12;
			this.btn_dos.Text = "2";
			this.btn_dos.UseVisualStyleBackColor = true;
			this.btn_dos.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_dos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_tres
			// 
			this.btn_tres.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_tres.Location = new System.Drawing.Point(187, 318);
			this.btn_tres.Name = "btn_tres";
			this.btn_tres.Size = new System.Drawing.Size(86, 63);
			this.btn_tres.TabIndex = 13;
			this.btn_tres.Text = "3";
			this.btn_tres.UseVisualStyleBackColor = true;
			this.btn_tres.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_tres.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_cuatro
			// 
			this.btn_cuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_cuatro.Location = new System.Drawing.Point(1, 250);
			this.btn_cuatro.Name = "btn_cuatro";
			this.btn_cuatro.Size = new System.Drawing.Size(86, 63);
			this.btn_cuatro.TabIndex = 14;
			this.btn_cuatro.Text = "4";
			this.btn_cuatro.UseVisualStyleBackColor = true;
			this.btn_cuatro.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_cuatro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_cinco
			// 
			this.btn_cinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_cinco.Location = new System.Drawing.Point(95, 249);
			this.btn_cinco.Name = "btn_cinco";
			this.btn_cinco.Size = new System.Drawing.Size(86, 63);
			this.btn_cinco.TabIndex = 15;
			this.btn_cinco.Text = "5";
			this.btn_cinco.UseVisualStyleBackColor = true;
			this.btn_cinco.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_cinco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_seis
			// 
			this.btn_seis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_seis.Location = new System.Drawing.Point(187, 249);
			this.btn_seis.Name = "btn_seis";
			this.btn_seis.Size = new System.Drawing.Size(86, 63);
			this.btn_seis.TabIndex = 16;
			this.btn_seis.Text = "6";
			this.btn_seis.UseVisualStyleBackColor = true;
			this.btn_seis.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_seis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_siete
			// 
			this.btn_siete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_siete.Location = new System.Drawing.Point(1, 181);
			this.btn_siete.Name = "btn_siete";
			this.btn_siete.Size = new System.Drawing.Size(86, 63);
			this.btn_siete.TabIndex = 17;
			this.btn_siete.Text = "7";
			this.btn_siete.UseVisualStyleBackColor = true;
			this.btn_siete.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_siete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_ocho
			// 
			this.btn_ocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_ocho.Location = new System.Drawing.Point(95, 180);
			this.btn_ocho.Name = "btn_ocho";
			this.btn_ocho.Size = new System.Drawing.Size(86, 63);
			this.btn_ocho.TabIndex = 18;
			this.btn_ocho.Text = "8";
			this.btn_ocho.UseVisualStyleBackColor = true;
			this.btn_ocho.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_ocho.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// btn_nueve
			// 
			this.btn_nueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
			this.btn_nueve.Location = new System.Drawing.Point(187, 180);
			this.btn_nueve.Name = "btn_nueve";
			this.btn_nueve.Size = new System.Drawing.Size(86, 63);
			this.btn_nueve.TabIndex = 19;
			this.btn_nueve.Text = "9";
			this.btn_nueve.UseVisualStyleBackColor = true;
			this.btn_nueve.Click += new System.EventHandler(this.Btn_unoClick);
			this.btn_nueve.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keydown);
			// 
			// lbl_cuenta
			// 
			this.lbl_cuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.lbl_cuenta.Location = new System.Drawing.Point(3, 9);
			this.lbl_cuenta.Name = "lbl_cuenta";
			this.lbl_cuenta.Size = new System.Drawing.Size(351, 48);
			this.lbl_cuenta.TabIndex = 20;
			this.lbl_cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(356, 463);
			this.Controls.Add(this.lbl_cuenta);
			this.Controls.Add(this.btn_nueve);
			this.Controls.Add(this.btn_ocho);
			this.Controls.Add(this.btn_siete);
			this.Controls.Add(this.btn_seis);
			this.Controls.Add(this.btn_cinco);
			this.Controls.Add(this.btn_cuatro);
			this.Controls.Add(this.btn_tres);
			this.Controls.Add(this.btn_dos);
			this.Controls.Add(this.btn_uno);
			this.Controls.Add(this.btn_cero);
			this.Controls.Add(this.btn_coma);
			this.Controls.Add(this.btn_cambsig);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_division);
			this.Controls.Add(this.btn_multiplicacion);
			this.Controls.Add(this.btn_resta);
			this.Controls.Add(this.btn_suma);
			this.Controls.Add(this.btn_resultado);
			this.Controls.Add(this.lbl_resultado);
			this.Name = "MainForm";
			this.Text = "Ejercicio 10";
			this.ResumeLayout(false);

		}
	}
}

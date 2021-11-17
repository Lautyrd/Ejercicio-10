using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_10
{

	public partial class MainForm : Form
	{
		double n1,n2;
		string operador;
		public MainForm()
		{
			
			InitializeComponent();
			
		
		}
		public class calculadora{
			public double suma(double n1,double n2){
				double auxsuma=(n1+n2);
				return auxsuma;
			}
			public double resta(double n1,double n2){
				double auxresta=(n1+n2);
				return auxresta;
			}
			public double multiplicacion(double n1,double n2){
				double auxmult=(n1+n2);
				return auxmult;
			}
			public double division(double n1,double n2){
				double auxdiv=(n1+n2);
				return auxdiv;
			}
		}
		void Btn_clearClick(object sender, EventArgs e)
		{
			lbl_resultado.Text = "0";
			lbl_cuenta.Text = "";
		}
		void Btn_unoClick(object sender, EventArgs e)
		{
			Button aux1 = (Button) sender;
			if(lbl_resultado.Text == "0"){
				lbl_resultado.Text = "";
			}
			lbl_resultado.Text += aux1.Text;
		}
		void Btn_deleteClick(object sender, EventArgs e)
		{
			if(lbl_resultado.Text.Length > 1){
				lbl_resultado.Text = lbl_resultado.Text.Substring(0, lbl_resultado.Text.Length-1);
			}
			else{
				lbl_resultado.Text=("0");
			}
		}
		void Btn_sumaClick(object sender, EventArgs e)
		{
			calculadora objcalculadora = new calculadora();
			Button aux2 = (Button) sender;
			lbl_cuenta.Text = lbl_resultado.Text;
			lbl_cuenta.Text += aux2.Text;
			operador = aux2.Text;
			lbl_resultado.Text = "0";
			switch (operador){
				case "+" :
					objcalculadora.suma(n1,n2);
					break;
				case "-" :
					objcalculadora.resta(n1,n2);
					break;
				case "*" :
					objcalculadora.multiplicacion(n1,n2);
					break;
				case "/" :
					objcalculadora.division(n1,n2);
					break;
			}
		}
		void Btn_cambsigClick(object sender, EventArgs e)
		{
			n1= Convert.ToDouble(lbl_resultado.Text);
			n1= n1*(-1);
			lbl_resultado.Text = Convert.ToString(n1);
		}
		void Btn_resultadoClick(object sender, EventArgs e)
		{
			
		}
		void keydown(object sender, KeyEventArgs e){
			if(e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0){
				btn_cero.PerformClick();
			}
			if(e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1){
				btn_uno.PerformClick();
			}
			if(e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2){
				btn_dos.PerformClick();
			}
			if(e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3){
				btn_tres.PerformClick();
			}
			if(e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4){
				btn_cuatro.PerformClick();
			}
			if(e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5){
				btn_cinco.PerformClick();
			}
			if(e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6){
				btn_seis.PerformClick();
			}
			if(e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7){
				btn_siete.PerformClick();
			}
			if(e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8){
				btn_ocho.PerformClick();
			}
			if(e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9){
				btn_nueve.PerformClick();
			}
			if(e.KeyCode == Keys.Divide){
				btn_division.PerformClick();
			}
			if(e.KeyCode == Keys.Subtract){
				btn_resta.PerformClick();
			}
			if(e.KeyCode == Keys.Add){
				btn_suma.PerformClick();
			}
			if(e.KeyCode == Keys.Multiply){
				btn_multiplicacion.PerformClick();
			}
			if(e.KeyCode == Keys.Enter){
				btn_resultado.PerformClick();
			}
			if(e.KeyCode == Keys.Back){
				btn_delete.PerformClick();
			}
		}
	}
}

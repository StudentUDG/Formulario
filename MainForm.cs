using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Formulario
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void ButTerminarClick(object sender, EventArgs e)
		{
			int aciertos = 0;
		
		string codigo = textcod.Text;
		string nombre = textnom.Text;
		
		if(this.radDF.Checked){
			aciertos++;
		}
		if(this.checkportugal.Checked){
			aciertos++;
		}
		if(this.checkmacedonia.Checked){
			aciertos++;
		}
		if(this.rd.Checked){
			aciertos++;
		}
		
		
		
		string estados = this.numericUpDown1.Text;
		if(estados == "31"){
			aciertos++;
		}



            string valorCalendario = Calendario.SelectionRange.Start.ToShortDateString();
            if (valorCalendario == "07/05/1945")
            {
				aciertos++;	
			}
      
			
			
			
			MessageBox.Show("Nombre: " + nombre + "\n" +"Codigo: "+ codigo + "\n"+
			                "Aciertos: " + aciertos);
			                
			
		}
	
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
	}
}

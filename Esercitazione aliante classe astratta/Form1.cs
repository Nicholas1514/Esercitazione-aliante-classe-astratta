using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esercitazione_aliante_classe_astratta
{
	public partial class Form1 : Form
	{
		Aliante aliante;
		public Form1()
		{
			InitializeComponent();
			aliante = new Aliante();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Ala ala = new Ala(double.Parse(textBox1.Text), double.Parse(textBox2.Text));
			aliante.Aggiunta(ala);
			MessageBox.Show("Componenti ala aggiunti");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Fusoliera fusoliera = new Fusoliera(double.Parse(textBox3.Text), textBox4.Text);
			aliante.Aggiunta(fusoliera);
			MessageBox.Show("Componenti fusoliera aggiunti");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Coda coda = new Coda(double.Parse(textBox5.Text));
			aliante.Aggiunta(coda);
			MessageBox.Show("Componenti coda aggiunti");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Cerchione cerchione = new Cerchione(double.Parse(textBox6.Text),textBox7.Text);
			aliante.Aggiunta(cerchione);
			MessageBox.Show("Componenti cerchione aggiunti");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Gomma gomma = new Gomma(double.Parse(textBox8.Text), double.Parse(textBox9.Text), double.Parse(textBox10.Text));
			aliante.Aggiunta(gomma);
			MessageBox.Show("Componenti gomma aggiunti");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			listView1.Items.Add("Descrizione componenti: " + aliante.ToString() + " ");
			listView1.Items.Add("Prezzo componenti: " + aliante.Prezzo() + " ");


		}
	}
}

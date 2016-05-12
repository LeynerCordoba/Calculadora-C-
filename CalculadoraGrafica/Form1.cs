using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CalculadoraGrafica
{
    public partial class Form1 : Form
    {
        int Numero_uno, Numero_dos, Resultado;
        Manejador_Operaciones Mop = new Manejador_Operaciones();
        DataBases db = new DataBases();
        Operaciones op = new Operaciones();
        public Form1()
        {
            InitializeComponent();
            this.label1.Text = "";
            db.ObtenerConexion();
            

        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text+"7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "8";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "9";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = this.textBox1.Text + "0";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            string dat1 = this.label1.Text;
            string num1="";
            if (dat1.Contains("+"))
            {
                Numero_dos= int.Parse(this.textBox1.Text);
                Resultado = Numero_uno + Numero_dos;
                op.Operacion = "Sumar";
                op.Resultado = Resultado + "";
                Mop.RegistrarOperacion(op);
                textBox1.Text = Resultado + "";
                label1.Text = "";
                Numero_dos = 0;
                Numero_uno = 0;
                Resultado = 0;
            }
            else if (dat1.Contains("-"))
            {
                Numero_dos = int.Parse(this.textBox1.Text);
                Resultado = Numero_uno - Numero_dos;
                op.Operacion = "Restar";
                op.Resultado = Resultado + "";
                Mop.RegistrarOperacion(op);
                textBox1.Text = Resultado + "";
                label1.Text = "";
                Numero_dos = 0;
                Numero_uno = 0;
                Resultado = 0;

            }
            else if (dat1.Contains("*"))
            {
                Numero_dos = int.Parse(this.textBox1.Text);
                Resultado = Numero_uno * Numero_dos;
                op.Operacion = "Multiplicar";
                op.Resultado = Resultado + "";
                Mop.RegistrarOperacion(op);
                textBox1.Text = Resultado + "";
                label1.Text = "";
                Numero_dos = 0;
                Numero_uno = 0;
                Resultado = 0;
            }
            else if (dat1.Contains("/"))
            {
                Numero_dos = int.Parse(this.textBox1.Text);
                Resultado = Numero_uno / Numero_dos;
                op.Operacion = "Dividir";
                op.Resultado = Resultado + "";
                Mop.RegistrarOperacion(op);
                textBox1.Text = Resultado + "";
                label1.Text = "";
                Numero_dos = 0;
                Numero_uno = 0;
                Resultado = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.textBox1.Text + " +";
            this.textBox1.Text = "";
            string num1 = "";
            string dat1 = this.label1.Text;
            for (int x = 0; x < dat1.Length; x++)
            {
                if (dat1.ElementAt(x).ToString() != " " && dat1.ElementAt(x).ToString() != "+")
                {
                    num1 = num1 + dat1.ElementAt(x).ToString();                    
                }
                
            }
            Numero_uno = int.Parse(num1);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.textBox1.Text + " -";
            this.textBox1.Text = "";
            string num1 = "";
            string dat1 = this.label1.Text;
            for (int x = 0; x < dat1.Length; x++)
            {
                if (dat1.ElementAt(x).ToString() != " " && dat1.ElementAt(x).ToString() != "-")
                {
                    num1 = num1 + dat1.ElementAt(x).ToString();
                }

            }
            Numero_uno = int.Parse(num1);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Operaciones> l = Mop.Listar();
            ListarOperaciones lp = new ListarOperaciones(l);
            lp.Show();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LinkLabel.Link enlace = new LinkLabel.Link();
            enlace.LinkData = "www.google.com";
            LinkVisitanos.Links.Add(enlace);

        }

        private void visitameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void LinkVisitanos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.textBox1.Text + " *";
            this.textBox1.Text = "";
            string num1 = "";
            string dat1 = this.label1.Text;
            for (int x = 0; x < dat1.Length; x++)
            {
                if (dat1.ElementAt(x).ToString() != " " && dat1.ElementAt(x).ToString() != "*")
                {
                    num1 = num1 + dat1.ElementAt(x).ToString();
                }

            }
            Numero_uno = int.Parse(num1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.textBox1.Text + " /";
            this.textBox1.Text = "";
            string num1 = "";
            string dat1 = this.label1.Text;
            for (int x = 0; x < dat1.Length; x++)
            {
                if (dat1.ElementAt(x).ToString() != " " && dat1.ElementAt(x).ToString() != "/")
                {
                    num1 = num1 + dat1.ElementAt(x).ToString();
                }

            }
            Numero_uno = int.Parse(num1);
        }
    }
}

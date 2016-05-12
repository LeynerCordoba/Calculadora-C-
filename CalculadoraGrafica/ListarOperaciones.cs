using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalculadoraGrafica
{
    public partial class ListarOperaciones : Form
    {
        List<Operaciones> lista = new List<Operaciones>();
        
        public ListarOperaciones()
        {
            InitializeComponent();
        }


        public ListarOperaciones(List<Operaciones> l)
        {
          
            InitializeComponent();
            lista = l;
            dataGridView1.DataSource = lista;

        }




        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter Archivo = File.AppendText("export.csv");
            for (int i = 0; i < lista.Count; i++) {
                Archivo.WriteLine(lista.ElementAt(i).Operacion+","+lista.ElementAt(i).Resultado);
            }
            Archivo.Close();  
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}

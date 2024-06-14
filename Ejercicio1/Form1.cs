using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FormRegistro registro = new FormRegistro();

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistro ejemplo = new FormRegistro();
            if (registro.ShowDialog() == DialogResult.OK)
            {
                string nombre = registro.tbNombre.Text;
                int documento = Convert.ToInt32(registro.tbDocumento.Text);
                double nota = Convert.ToDouble(registro.tbNota.Text);
            }
        }
    }
}

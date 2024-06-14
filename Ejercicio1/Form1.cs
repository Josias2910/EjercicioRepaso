using Ejercicio1.Models;
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
            ejemplo.AgregarAlumno("Josias", 45387523, 10);
            ejemplo.AgregarAlumno("Pedro", 16787922, 5);
            ejemplo.AgregarAlumno("Luis", 55555555, 8);
            ejemplo.AgregarAlumno("Uciel", 44444444, 3);
        }

        Controlador ejemplo = new Controlador();

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistro registro = new FormRegistro();
            if (registro.ShowDialog() == DialogResult.OK)
            {
                string nombre = registro.tbNombre.Text;
                int documento = Convert.ToInt32(registro.tbDocumento.Text);
                double nota = Convert.ToDouble(registro.tbNota.Text);
                ejemplo.AgregarAlumno(nombre, documento, nota);
            }
        }

        private void btnMostrarPromedio_Click(object sender, EventArgs e)
        {
            double Promedio = ejemplo.CalcularPromedio();
            lblPromedio.Text = Convert.ToString($"{Promedio}");
        }

        private void btnSuperaronPromedio_Click(object sender, EventArgs e)
        {
            FormVer promedio = new FormVer();
            ejemplo.AlumnosQueSuperanAlPromedio();
            for (int i = 0; i < ejemplo.ContadorProm; i++)
            {
                string nombre = ejemplo.nombreProm[i];
                int documento = ejemplo.documentoProm[i];
                double nota = ejemplo.notasProm[i];
                promedio.lbSuperaronPromedio.Items.Add($"Nombre: {nombre} Documento: {documento} Nota: {nota}");
            }
            promedio.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormVer buscar = new FormVer();
            int documento = Convert.ToInt32(tbBuscar.Text);
            int pos = ejemplo.busquedaSecuencial(documento);
            if (pos > -1)
            {
                string Nombre = ejemplo.Nombres[pos];
                int Documento = ejemplo.Documentos[pos];
                double Nota = ejemplo.Notas[pos];
                buscar.lbBuscar.Items.Add($"Nombre: {Nombre} Documento: {Documento} Nota: {Nota}");
            }
            else
            {
                buscar.lbBuscar.Items.Add("No se encontro el alumno buscado");
            }
            buscar.ShowDialog();
        }

        private void btnMostrarAlumnos_Click(object sender, EventArgs e)
        {
            FormVer alumnos = new FormVer();
            for (int i = 0; i < ejemplo.Contador; i++)
            {
                string nombre = ejemplo.Nombres[i];
                int documento = ejemplo.Documentos[i];
                double nota = ejemplo.Notas[i];
                alumnos.lbAlumnos.Items.Add($"Nombre: {nombre} Documento: {documento} Nota: {nota}");
            }
            alumnos.ShowDialog();
        }
    }
}

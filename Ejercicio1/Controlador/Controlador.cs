using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Controlador
{
    public class Controlador
    {
        public string[] Nombre = new string[1000];
        public int[] Documento = new int[1000];
        public double[] Notas = new double[1000];
        public string[] nombreProm = new string[1000];
        public int[] documentoProm = new int[1000];
        public double[] notasProm = new double[1000];
        public int Contador = 0;

        public void AgregarAlumno(string nombre, int documento, double notas)
        {
            Nombre[Contador] = nombre;
            Documento[Contador] = documento;
            Notas[Contador] = notas;
            Contador++;
        }

        public double CalcularPromedio()
        {
            double Acumulador = 0;
            for (int i = 0; i < Contador; i++)
            {
                Acumulador += Notas[i];
            }
            return Acumulador / Contador;
        }

        private void AlumnosQueSuperanAlPromedio()
        {
            double Promedio = CalcularPromedio();
            for (int i = 0;i < Contador; i++)
            {
                if (Notas[i] > Promedio)
                {
                    nombreProm[Contador] = Nombre[i];
                    documentoProm[Contador] = Documento[i];
                    notasProm[Contador] = Notas[i];
                    Contador++; 
                }
            }
        }
    }
}

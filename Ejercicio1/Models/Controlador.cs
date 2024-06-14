using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Controlador
    {
        public string[] Nombres = new string[1000];
        public int[] Documentos = new int[1000];
        public double[] Notas = new double[1000];
        public int Contador = 0;
        //
        public string[] nombreProm = new string[1000];
        public int[] documentoProm = new int[1000];
        public double[] notasProm = new double[1000];
        public int ContadorProm = 0;

        public void AgregarAlumno(string nombre, int documento, double notas)
        {
            Nombres[Contador] = nombre;
            Documentos[Contador] = documento;
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

        public void AlumnosQueSuperanAlPromedio()
        {
            ContadorProm=0;
            double Promedio = CalcularPromedio();
            for (int i = 0;i < Contador; i++)
            {
                if (Notas[i] > Promedio)
                {
                    nombreProm[ContadorProm] = Nombres[i];
                    documentoProm[ContadorProm] = Documentos[i];
                    notasProm[ContadorProm] = Notas[i];
                    ContadorProm++; 
                }
            }
        }

        public int busquedaSecuencial(int documento)
        {
            int i = 0;
            int pos = -1;
            while ((pos == -1) && (i < Contador))
            {
                if (Documentos[i] == documento)
                {
                    pos = i;
                }
                i++;
            }
            return pos;
        }
    }
}

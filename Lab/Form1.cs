using Lab.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab
{

    public partial class Form1 : Form
    {
        public string[] ArregloNotas;
        
      
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Porfa Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\7010\Downloads";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                
                
                textBoxResultado.Text = resultado;
            }
        }
        private int FncPromedios(string[,] matriz, int columna)
        {
            int acumulador = 0;
            int promedio;
            int totalFilas = matriz.GetLength(0);
            int totalColumnas = matriz.GetLength(1);
            for (int fila = 1; fila < totalFilas; fila++)
            {
                
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);
            }
            promedio = (acumulador + totalFilas);
            return promedio;
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {

            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;


            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(';');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosUnitarios[1]; 
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2]; 
                ArregloDosDimensiones[NumeroLinea, enumColumnas.parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.parcial3] = datosUnitarios[4]; 
                ArregloDosDimensiones[NumeroLinea, enumColumnas.seccion] = datosUnitarios[5];

                NumeroLinea++; 

                
                listBoxResultado.Items.Add($"{datosUnitarios[enumColumnas.Nombre]} Nota: {datosUnitarios[enumColumnas.parcial2]}");
            }
  


            MessageBox.Show($"Promedio General (A,B,C,D): \n" +
                $"Parcial I:\t{DPROME(ArregloDosDimensiones, enumColumnas.Parcial1).ToString()} pts.\n" +
                $"Parcial II:\t{DPROME(ArregloDosDimensiones, enumColumnas.parcial2).ToString()} pts.\n" +
                $"Parcil III:\t{DPROME(ArregloDosDimensiones, enumColumnas.parcial3).ToString()} pts.", "Promedios");


            var PromA = Resultados(ArregloDosDimensiones, "A");
            var PromB = Resultados(ArregloDosDimensiones, "B");
            var PromC = Resultados(ArregloDosDimensiones, "C");
            var PromD = Resultados(ArregloDosDimensiones, "D"); 







        }


       
        private int DPROME(string[,] matriz, int col)
        {
            int acum = 0;
            int prom = 0;
            int cantFilas = matriz.GetLength(0);

            for (int i = 1; i < cantFilas; i++) 
            {
                acum += Convert.ToInt32(matriz[i, col]);
            }

            prom = acum / (cantFilas - 1);

            return prom;
        }


        private int Prom_Por_Sec(string[,] matriz, int col, string seccion)
        {
            int acum = 0; 
            int acumEstudiantes = 0;
            int promedio = 0;
            int cantFilas = matriz.GetLength(0);


            for (int i = 1; i < cantFilas; i++) 
            {
                if (matriz[i, 5] == seccion) 
                {
                    acum += Convert.ToInt32(matriz[i, col]);

                    acumEstudiantes++;
                }
            }

            promedio = acum / acumEstudiantes;

            return promedio;
        }

        private int Prom_General(int prom1, int prom2, int prom3)
        {
            return ((prom1 + prom2 + prom3) / (3));
        }


        private int Resultados(string[,] matriz, string seccion)
        {
           
            var promP1 = Prom_Por_Sec(matriz, enumColumnas.Parcial1, seccion);
            var promP2 = Prom_Por_Sec(matriz, enumColumnas.parcial2, seccion);
            var promP3 = Prom_Por_Sec(matriz, enumColumnas.parcial3, seccion);

            var promedios = Prom_General(promP1, promP2, promP3);


            MessageBox.Show($"PARCIAL I - PROMEDIO: {promP1} PTS.\n" +
                            $"PARCIAL II - PROMEDIO: {promP2} PTS.\n" +
                            $"PARCIAL III - PROMEDIO: {promP3} PTS.\n\n" +
                            $"PROM. GENERAL = {promedios} PTS EN TOTAL.", $"SECCION {seccion}");

            return promedios;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }

       
    
}

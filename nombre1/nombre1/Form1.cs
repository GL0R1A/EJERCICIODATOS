using nombre1.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nombre1
{
    public partial class Form1 : Form
    {
        private string[] arreglonotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[5];
            arreglo[0] = 10;
            arreglo[1] = 9;
            arreglo[2] = 15;
            arreglo[3] = 16;
            arreglo[4] = 5;

            clsarreglos objetcarreglo = new clsarreglos(arreglo);
            int[] resultado = objetcarreglo.MetodoBurbuja();

            foreach (int r in resultado)
            {
                listBox1resultado.Items.Add(r);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsarchivos ar = new clsarchivos();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "seleciona tu archivo plano porfavor";
            ofd.InitialDirectory = @"C:\Users\mita\Documents\ARCHIVOS PLANOS";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                String resultado = ar.LeertodoArchivo(archivo);
                arreglonotas = ar.LeerArchivo(archivo);
                textBox1resultado .Text = resultado;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3PROMEDIO_Click(object sender, EventArgs e)
        {
            int par1;
            int par2;
            int par3;
            int sumatoriafinal;
            int division;
            int resultadofinal;

            foreach (string ca in arreglonotas)
            {
                string[] datosu = ca.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                par1 = Convert.ToInt32(datosu[2]);
                par2 = Convert.ToInt32(datosu[3]);
                par3 = Convert.ToInt32(datosu[4]);

                sumatoriafinal = (par1 + par2 + par3);
                division = (sumatoriafinal / 3);
                resultadofinal = division;

                listBox1resultado.Items.Add($"{datosu[1]});su promedio total es:{resultadofinal}");

            



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int par1;
            int par2;
            int par3;
            int suma1=0;
            int suma2=0;
            int suma3=0;
            int pro1=0;
            int pro2=0;
            int pro3=0;

            foreach (string ca in arreglonotas)
            {
                string[] datosu = ca.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                par1 = Convert.ToInt32(datosu[2]);
                par2 = Convert.ToInt32(datosu[3]);
                par3 = Convert.ToInt32(datosu[4]);
                suma1 += par1;
                suma2 += par2;
                suma3 += par3;
            }
            pro1 = suma1 / 60;
            pro1 = suma2 / 60;
            pro3 = suma3 / 60;

            listBox1resultado.Items.Add($"su promedio del primer parcial es:{pro1}///su promedio del segundo parcial es:{pro2}///su promedio del tercer parcial es:{pro3}");
        }

        private void button3maxmin_Click(object sender, EventArgs e)
        {
            int par1;
            int par2;
            int par3;
            int sumatoriafinal;
            int division;
            int resultadofinal;
            int maxi =0;
            int min =20;

            foreach (string ca in arreglonotas)
            {
                string[] datosu = ca.Split(';');
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                par1 = Convert.ToInt32(datosu[2]);
                par2 = Convert.ToInt32(datosu[3]);
                par3 = Convert.ToInt32(datosu[4]);

                sumatoriafinal = (par1 + par2 + par3);
                division = (sumatoriafinal / 3);
                resultadofinal = division;
                if (resultadofinal!=0)
                    {
                    if (resultadofinal>maxi)
                    {
                        maxi = resultadofinal;
                    }
                    if (resultadofinal<min)
                    {
                        min = resultadofinal;

                    }

                }
                else
                {
                    maxi = resultadofinal;
                    min = resultadofinal;
                }


            }

            listBox1resultado.Items.Add($"Su promedio mayor fue:{maxi},El promedio Minimo es:{min}");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            listBox1resultado.Items.Clear();
        }
    }
}



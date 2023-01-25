using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_de_linq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> ListagenteLima = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Estudiante> estudiantes = new List<Estudiante>()
            {
                new Estudiante
                {
                    Nombre = "Sofia",
                    Apellido = "Pereyra",
                    Id = 1,
                    Ciudad = "Lima",
                    Puntaje = new List<int> { 12, 16, 19, 12 }
                },
                new Estudiante
                {
                    Nombre = "Maria",
                    Apellido = "Altamirano",
                    Id= 2,
                    Ciudad = "Callao",
                    Puntaje = new List<int> { 11, 18, 19, 14 }
                },
                new Estudiante
                {
                    Nombre = "Susana",
                    Apellido = "Andrade",
                    Id = 3,
                    Ciudad = "Huancayo",
                    Puntaje = new List<int> { 15, 18, 14, 17 }
                },
                 new Estudiante
                {
                    Nombre = "Alejandro",
                    Apellido = "Snachez",
                    Id = 4,
                    Ciudad = "Chincha",
                    Puntaje = new List<int> { 18, 16, 12, 13 }
                },
            };
            List<Profesor> profesores = new List<Profesor>()
            {
                new Profesor { Nombre = "Victor", Apellido = "Soto", Id = 1, Ciudad = "Lima" },
                new Profesor { Nombre = "Guillerom", Apellido = "Marre", Id = 2, Ciudad = "Callao" },
                new Profesor { Nombre = "Alejandro", Apellido = "Andrade", Id = 3, Ciudad = "Huancayo" },
                new Profesor { Nombre = "Pedro", Apellido = "Adriarem", Id = 4, Ciudad = "Chincha" },
            };


            if (comboBox1.Text == "Lima")
            {
                var gentelima = (from elemento in estudiantes where elemento.Ciudad == "Lima" select elemento.Nombre + " - " + elemento.Apellido + " - " + elemento.Id)
                .Concat(from elemeto2 in profesores where elemeto2.Ciudad == "Lima" select elemeto2.Nombre + " - " + elemeto2.Apellido + " - " + elemeto2.Id);
                foreach (var persona in gentelima)
                {
                    listBox1.Items.Add(persona);
                }
                ListagenteLima = (gentelima).ToList();


            }
            else if (comboBox1.Text == "Callao")
            {
                var gentelima = (from elemento in estudiantes where elemento.Ciudad == "Callao" select elemento.Nombre + " - " + elemento.Apellido + " - " + elemento.Id)
                .Concat(from elemeto2 in profesores where elemeto2.Ciudad == "Callao" select elemeto2.Nombre + " - " + elemeto2.Apellido + " - " + elemeto2.Id);
                foreach (var persona in gentelima)
                {
                    listBox1.Items.Add(persona);
                    
                }
                ListagenteLima = (gentelima).ToList();

            }
            else if (comboBox1.Text == "Huancayo")
            {
                var gentelima = (from elemento in estudiantes where elemento.Ciudad == "Huancayo" select elemento.Nombre + " - " + elemento.Apellido + " - " + elemento.Id)
                .Concat(from elemeto2 in profesores where elemeto2.Ciudad == "Huancayo" select elemeto2.Nombre + " - " + elemeto2.Apellido + " - " + elemeto2.Id);
                foreach (var persona in gentelima)
                {
                    listBox1.Items.Add(persona);
                }
                ListagenteLima = (gentelima).ToList();

            }
            else
            {
                var gentelima = (from elemento in estudiantes where elemento.Ciudad == "Chincha" select elemento.Nombre + " - " + elemento.Apellido + " - " + elemento.Id)
               .Concat(from elemeto2 in profesores where elemeto2.Ciudad == "Chincha" select elemeto2.Nombre + " - " + elemeto2.Apellido + " - " + elemeto2.Id);
                foreach (var persona in gentelima)
                {
                    listBox1.Items.Add(persona);
                }
                ListagenteLima = (gentelima).ToList();
            }

            dataGridView1.DataSource = ListagenteLima;

            
           
        }
    }
 }
    


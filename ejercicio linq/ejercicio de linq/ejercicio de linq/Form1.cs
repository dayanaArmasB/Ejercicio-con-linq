using System;
using System.Collections;
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
        
        List<Estudiante> estudiantes = new List<Estudiante>()
            {
                new Estudiante()
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
                      new Profesor { Nombre = "Luis", Apellido = "Morales", Id = 4, Ciudad = "Chincha" },
            };

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Metodo2();
        }

        private void Metodo1()
        {
            ClearControis();
            DataTable dt = new DataTable();
            var gentelima = (from elemento in estudiantes where elemento.Ciudad == comboBox1.Text select elemento.Nombre + " - " + elemento.Apellido + " - " + elemento.Id)
            .Concat(from elemeto2 in profesores where elemeto2.Ciudad == comboBox1.Text select elemeto2.Nombre + " - " + elemeto2.Apellido + " - " + elemeto2.Id);
            foreach (var persona in gentelima)
            {
                listBox1.Items.Add(persona);
            }
            dt.Columns.Add("personas");
            foreach (var persona in gentelima)
            {
                DataRow dr = dt.NewRow();
                dr["personas"] = persona;
                dt.Rows.Add(dr);
                dataGridView1.DataSource = dt;
            }
        }


        //iterando dos listas tipadas
        private void Metodo2()
        {
            ClearControis();
            DataTable dt = new DataTable();
            List<Estudiante> gentelima = (from elemento in estudiantes where elemento.Ciudad == comboBox1.Text select new Estudiante(elemento.Nombre, elemento.Apellido,elemento.Id)).ToList();
            List<Profesor> gentelima2 = (from elemento in profesores where elemento.Ciudad == comboBox1.Text select new Profesor(elemento.Nombre, elemento.Apellido, elemento.Id)).ToList();
            listBox1.Items.Add("ESTUDIANTES");
            foreach (Estudiante persona in gentelima)
            {   
                listBox1.Items.Add(persona.Nombre + " - " + persona.Apellido + " - " + persona.Id);
            }

            listBox1.Items.Add("PROFESORES");
            foreach (Profesor persona in gentelima2)
            {
                listBox1.Items.Add(persona.Nombre + " - " + persona.Apellido + " - " + persona.Id);
            }
            dt.Columns.Add("Nombres");
            dt.Columns.Add("Apellidos");
            dt.Columns.Add("ID");
            foreach (Estudiante persona in gentelima)
            {
                DataRow dr = dt.NewRow();
                dr["Nombres"] = persona.Nombre;
                dr["Apellidos"] = persona.Apellido;
                dr["ID"] = persona.Id;
                dt.Rows.Add(dr);
            }

            foreach (Profesor prof in gentelima2)
            {
                DataRow dr = dt.NewRow();
                dr["Nombres"] = prof.Nombre;
                dr["Apellidos"] = prof.Apellido;
                dr["ID"] = prof.Id;
                dt.Rows.Add(dr);
            }
            dataGridView1.DataSource = dt;
        }

        private void ClearControis()
        {
            listBox1.Items.Clear();
            dataGridView1.DataSource = null;
        }
    }
 }
    


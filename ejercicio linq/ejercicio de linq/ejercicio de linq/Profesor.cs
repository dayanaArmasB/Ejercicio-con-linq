using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_de_linq
{
    internal class Profesor
    {
        public Profesor() { }   

        public Profesor(string nombre , string apellido, int id)
        {
            this.Nombre = nombre; 
            this.Apellido = apellido;   
            this.Id = id;
        }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }
        public string Ciudad { get; set; }
    }
}

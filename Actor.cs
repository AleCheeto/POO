using System;

namespace Practica_baseDPeliculas_03_03_2021
{
   public class Actor
    {
        private int id;
        private string nombre;
        private string nacionalidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Id { get => id; }

        public Actor(int id, string nombre, string nacionalidad)
        {
            this.id = id;
            Nombre = nombre;
            Nacionalidad = nacionalidad;
        }

        public Actor(string nombre, string nacionalidad)
        {
            this.nombre = nombre;
            this.nacionalidad = nacionalidad;
        }

        public void Imprime()
        {
            Console.WriteLine($"    {nombre}({Nacionalidad})");
        }
    }
}

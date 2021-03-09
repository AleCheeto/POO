using System;
using System.Collections.Generic;
using System.Linq;

namespace Practica_baseDPeliculas_03_03_2021
{
    public class Pelicula
    {

        

        private string titulo;
        private int año;
        private Categoria categoria;
        private List<Actor> actores = new List<Actor>();
        private Clasificación clasificación;

        public Pelicula(string titulo, int año, Categoria categoria, Clasificación clasificación)
        {
            this.titulo = titulo;
            this.año = año;
            this.categoria = categoria;
            this.Clasificación = clasificación;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Año { get => año; set => año = value; }
        private Clasificación Clasificación { get => clasificación; set => clasificación = value; }

        public void AgregaActor(Actor actor)
        {
            actores.Add(actor);

        }

        public void AgregaActor(string nombre, string nacionalidad)
        {
            actores.Add(new Actor(nombre, nacionalidad));
        }

        public void Imprime()
        {
            Console.WriteLine($"{Titulo} ({Año}) {Clasificación} {categoria.Nombre}");
            //categoria.Imprime();
            //Console.WriteLine();
            foreach (Actor a in actores)
            {
                a.Imprime();
            }
        }

        public void BorraActor(Actor a)
        {
            actores.Remove(a);
        }

        
        public void BorraActor(string nombre)
        {
            actores.RemoveAll(a => a.Nombre.Contains(nombre));


            /*
            for (int i = 0; i < actores.Count; i++) 
            {
                if (actores[i].Nombre.Contains(nombre))
                    actores.RemoveAt(i);
            }
            */
        }
        

    }
}

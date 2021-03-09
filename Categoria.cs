using System;

namespace Practica_baseDPeliculas_03_03_2021
{
    public class Categoria
    {
        private string nombre;
        private string nombreCorto;

        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreCorto { get => nombreCorto; set => nombreCorto = value; }

        public Categoria(string nombre, string nombrecorto)
        {
            Nombre = nombre;
            NombreCorto = nombrecorto;
        }

        public void Imprime() => Console.Write(nombre);
        public void ImprimeCorto() => Console.Write(nombreCorto);

    }
}

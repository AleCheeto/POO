using System;
using System.Text;
using System.Threading.Tasks;

namespace Practica_baseDPeliculas_03_03_2021
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            

            Actor benedict = (new Actor(1000, "Benedict Cumberbatch" ,"Hammersmith, London, England, Uk"));

            Pelicula p1 = new Pelicula("El code enigma", 2014, new Categoria("Biográfica", "Biopic"), Clasificación.PG13);
            p1.AgregaActor(benedict);
            p1.AgregaActor(new Actor(1001, "Keira Knightley " ,"Teddington, Middlesex, England, UK"));
            p1.Imprime();

            Pelicula p2 = new Pelicula("1917", 2019, new Categoria("Drama", "Drama "), Clasificación.R);
            p2.AgregaActor(new Actor(1002, "George MacKay " ,"London, England, Uk"));
            p2.AgregaActor(benedict);
            p2.Imprime();

            //string actor = Console.ReadLine();

            p2.BorraActor("Benedict");
            // p2.BorraActor(benedict); gei
            p2.Imprime();


            Console.ReadKey();
        }

    }
}

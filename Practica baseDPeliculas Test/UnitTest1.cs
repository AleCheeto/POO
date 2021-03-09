using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practica_baseDPeliculas_03_03_2021;
using System.IO;

namespace Practica_baseDPeliculas_Test
{
    [TestClass]
    public class PeliculaTest
    {
        [TestMethod]
        public void Constructor()
        {
            Pelicula p1 = new Pelicula("El código enigma", 2014, new Categoria("Biográfica", "Biopic"), Clasificación.PG13);
            Assert.AreEqual("El código enigma", p1.Titulo );
            Assert.AreEqual(2014 ,p1.Año);
            
        }
    }
    [TestClass]
    public class ActorTest 
    {
        [TestMethod]
        public void ImprimeTest()
        {
            Actor benedict = (new Actor(1000, "Benedict Cumberbatch", "Hammersmith, London, England, Uk"));
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                benedict.Imprime();
                var result = sw.ToString().Trim();
                Assert.AreEqual("Benedict Cumberbatch(Hammersmith, London, England, Uk", result);
            }
                
        }
    }
}

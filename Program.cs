using System;
using System.Collections.Generic;

namespace Estrocutra_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {   
            //generics: <>
            List<string> nombrePeliculas = new List<string>();

            nombrePeliculas.Add("Monster inc");
            nombrePeliculas.Add("wall-e");
            nombrePeliculas.Add("Hp");

            Console.WriteLine(nombrePeliculas[1]);

            //HashSet el set no permite valores duplicados
            HashSet<string> nombrePeliculas2 = new HashSet<string>();
            //un elemento aunque sea repetido
            nombrePeliculas2.Add("Hp");
            nombrePeliculas2.Add("Hp");
            nombrePeliculas2.Add("Hp");
            //otro elemento
            nombrePeliculas2.Add("Toy story");
            Console.WriteLine(nombrePeliculas2.Count);

            HashSet<Peliculas> peliculasSet = new HashSet<Peliculas>();
        
            peliculasSet.Add(new Peliculas("Bad Boys", 1983));
            peliculasSet.Add(new Peliculas("Bad Boys", 1995));
            // se agrega un nuevo valor porque es un nuevo
            peliculasSet.Add(new Peliculas("Bad Boys", 1995));

            Console.WriteLine(peliculasSet.Count);

            Dictionary<string, string> coloresFavoritos = new Dictionary<string, string>();

            coloresFavoritos.Add("Jhonny", "Azul");
            coloresFavoritos.Add("Jack", "Negro");
            coloresFavoritos.Add("Roberto","Gris");

            //¿cual es el color favorito de Jack?
            string colorFavoritos = coloresFavoritos.GetValueOrDefault("Jack");
            int[] numeros = new int [3] {1, 2, 3};

            for (int i = 0; i < numeros.Length; i++)
            {
                System.Console.WriteLine(numeros[1]);
            }

            foreach (var numero in numeros){
                System.Console.WriteLine(numero);

            }

            foreach (var key in coloresFavoritos.Keys)
            {
                System.Console.WriteLine(key);
            }

            foreach (var value in coloresFavoritos.Values)
            {
                System.Console.WriteLine(value);
            }
            // System.Console.WriteLine($"JackcolorFavorito = {JackcolorFavorito}");
            // for (int i = 0; i < coloresFavoritos.Keys.Count; i++)
            // {
            //     coloresFavoritos.Keys.
            // }
        }
    }
}

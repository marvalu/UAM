using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAM.OOP
{
    public class Colecciones



    {
        private void Imprimir(List<string> salmons)
        {
            foreach (var salmon in salmons)
            {
                Console.WriteLine(salmon + " ");
            }
        }
        public void ListaString()
        {

            // Create a list of strings.
            var salmons = new List<string>();
            salmons.Add("chinook");
            salmons.Add("coho");
            salmons.Add("pink");
            salmons.Add("sockeye");

            // Iterate through the list.

            // Output: chinook coho pink sockeye

            Imprimir(salmons);

            Console.WriteLine("remove");

            salmons.Remove("coho");

            Imprimir(salmons);

            // Iterate through the list.


            try
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Insert");
                salmons.Insert(1, "Nuevo");

            }
            catch (Exception ex)
            {

                Console.WriteLine("error {0}", ex.Message);

            }
            // Output: chinook pink sockeye
            Console.WriteLine("-----");
            Console.WriteLine("RemoveAT");
            salmons.RemoveAt(2);
            Imprimir(salmons);

            try
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine("[]");
                var salmon = salmons[0];
                Console.WriteLine("Salmon 0 {0}", salmon);

                Console.WriteLine("--------------------------------");
                Console.WriteLine("Index");
                var salmon1 = salmons.IndexOf("sockeye");
                Console.WriteLine("Index= {0}", salmon1);
                


                    Console.WriteLine("--------------------------------");
                Console.WriteLine("conteins");
                var existe = salmons.Contains("chinook");
                Console.WriteLine("existe= {0}", existe);



                Console.WriteLine("--------------------------------");
                Console.WriteLine("Cantidad");
                var cantidad = salmons.Count;
                Console.WriteLine("Cantidad= {0}", cantidad);



            }
            catch (Exception ex)
            {

                Console.WriteLine("error {0}", ex.Message);

            }

        }

        

       
    }
}

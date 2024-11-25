using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_26_11_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InventarioProdotti Inventario = new InventarioProdotti();

            Inventario.AggiungiProdotto(1, "Mela", 10);
            Inventario.AggiungiProdotto(2, "Banana", 5);
            Inventario.AggiungiProdotto(3, "Arancia", 15);

            Console.WriteLine(Inventario.VisualizzaInventario());

            Inventario.AggiornaProdotto(2, "Banana biologica", 8);

            Console.WriteLine(Inventario.RicercaPerNome("Banana"));

            Console.WriteLine(Inventario.ControllaScorte(10));

            Console.ReadKey();
        }
    }
}

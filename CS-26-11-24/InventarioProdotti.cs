using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_26_11_24
{
    internal class InventarioProdotti
    {
        Dictionary<int, (string, int)> Inventario = new Dictionary<int, (string, int)>();

        public void AggiungiProdotto(int ID, string Nome, int Quantity)
        {
            if (Inventario.ContainsKey(ID))
            {
                Inventario[ID] = (Nome, Quantity);
            }
            else
            {
                Inventario.Add(ID, (Nome, Quantity));
            }
        }

        public void AggiornaProdotto(int ID, string newNome, int newQuantity)
        {
            if (!Inventario.ContainsKey(ID))
            {
                throw new KeyNotFoundException("Prodotto non trovato.");
            }

            Inventario[ID] = (newNome, newQuantity);
        }

        public void RimuoviProdotto(int ID)
        {
            if (!Inventario.ContainsKey(ID))
            {
                throw new KeyNotFoundException("Prodotto non trovato.");
            }

            Inventario.Remove(ID);
        }

        public string VisualizzaInventario()
        {
            string inventarioStringa = "";

            foreach (var prodotto in Inventario)
            {
                inventarioStringa += $"ID: {prodotto.Key}, Nome: {prodotto.Value.Item1}, Quantità: {prodotto.Value.Item2}\n";
            }

            return inventarioStringa;
        }

        public string RicercaPerNome(string nome)
        {
            string risultati = "";

            foreach (var prodotto in Inventario)
            {
                if (prodotto.Value.Item1 == nome)
                {
                    risultati += $"ID: {prodotto.Key}, Nome: {prodotto.Value.Item1}, Quantità: {prodotto.Value.Item2}\n";
                }
            }

            return risultati;
        }

        public string ControllaScorte(int soglia)
        {
            string prodottiDaRiasortire = "";

            foreach (var prodotto in Inventario)
            {
                if (prodotto.Value.Item2 < soglia)
                {
                    prodottiDaRiasortire += $"ID: {prodotto.Key}, Nome: {prodotto.Value.Item1}, Quantità: {prodotto.Value.Item2}\n";
                }
            }

            if (prodottiDaRiasortire == "")
            {
                return "Tutte le scorte sono sufficienti.";
            }
            else
            {
                return prodottiDaRiasortire;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace progetto_settimanaleS15L5
{
    public partial class Carrello

    {
        private Carrello carrello;

        public List<Prodotto> Prodotti { get; } = new List<Prodotto>();

        public void AggiungiProdotto(Prodotto prodotto)
        {
            Prodotti.Add(prodotto);
        }

        public void RimuoviProdotto(Prodotto prodotto)
        {
            Prodotti.Remove(prodotto);
        }

        public decimal CalcolaTotale()
        {
            return Prodotti.Sum(prodotto => prodotto.Prezzo);
        }

        public void SvuotaProdotti()
        {
            Prodotti.Clear();
        }
    }
}

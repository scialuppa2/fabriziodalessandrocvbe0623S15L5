using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace progetto_settimanaleS15L5
{
    public class Prodotto
    {
        public int IdProdotto { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string ImgUrl { get; set; }
    }
}
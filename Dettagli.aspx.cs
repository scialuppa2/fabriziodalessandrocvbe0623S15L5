using System;
using System.Collections.Generic;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace progetto_settimanaleS15L5
{
    public partial class Dettagli : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (int.TryParse(Request.QueryString["id"], out int productId))
                {
                    Prodotto prodotto = Database.GetProdottoById(productId);

                    if (prodotto != null)
                    {
                        NomeProdotto.Text = prodotto.Nome;
                        DescrizioneProdotto.Text = prodotto.Descrizione;
                        Prezzo.Text = prodotto.Prezzo.ToString("0.00");
                        ImmagineProdotto.ImageUrl = prodotto.ImgUrl;


                    }
                }
            }
        }


        protected void AggiungiAlCarrello(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["id"]))
            {
                int productId;
                if (int.TryParse(Request.QueryString["id"], out productId))
                {
                    Prodotto prodotto = Database.GetProdottoById(productId);

                    Carrello carrello = Session["Carrello"] as Carrello;
                    if (carrello == null)
                    {
                        carrello = new Carrello();
                    }

                    carrello.AggiungiProdotto(prodotto);

                    Session["Carrello"] = carrello;
                }
            }
        }


    }
}

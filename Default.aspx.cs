using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace progetto_settimanaleS15L5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Prodotto> prodotti = Database.GetProdotti();
                productRepeater.DataSource = prodotti;
                productRepeater.DataBind();
            }

        }

        protected void AggiungiAlCarrello(object sender, EventArgs e)
        {
            Button btnAggiungiAlCarrello = (Button)sender;

            int productId;
            if (int.TryParse(btnAggiungiAlCarrello.CommandArgument, out productId))
            {
                Prodotto prodotto = Database.GetProdottoById(productId);

                Carrello carrello = Session["Carrello"] as Carrello;
                if (carrello == null)
                {
                    carrello = new Carrello();
                    Session["Carrello"] = carrello;
                }

                carrello.AggiungiProdotto(prodotto);

                Session["Carrello"] = carrello;
            }
        }


    }
}
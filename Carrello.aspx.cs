using System;
using System.Linq;
using System.Web.UI.WebControls;

namespace progetto_settimanaleS15L5
{
    public partial class Carrello : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                carrello = Session["Carrello"] as Carrello;

                if (carrello != null)
                {
                   
                    carrelloRepeater.DataSource = carrello.Prodotti;
                    carrelloRepeater.DataBind();
                    totaleLabel.Text = carrello.CalcolaTotale().ToString("0.00");
                }
                else
                {
                    carrello = new Carrello();
                    Session["Carrello"] = carrello;
                }
            }
        }

        private void BindCarrello(Carrello carrello)
        {
            if (carrello != null)
            {
                carrelloRepeater.DataSource = carrello.Prodotti;
                carrelloRepeater.DataBind();
                totaleLabel.Text = carrello.CalcolaTotale().ToString("0.00");
                Session["Carrello"] = carrello;
            }
        }

        protected void EliminaProdotto(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Rimuovi")
            {
                int productIdToRemove;
                if (int.TryParse(e.CommandArgument.ToString(), out productIdToRemove))
                {
                    Carrello carrello = Session["Carrello"] as Carrello;
                    if (carrello != null)
                    {
                        Prodotto prodottoDaRimuovere = carrello.Prodotti.FirstOrDefault(p => p.IdProdotto == productIdToRemove);
                        if (prodottoDaRimuovere != null)
                        {
                            carrello.RimuoviProdotto(prodottoDaRimuovere);
                            BindCarrello(carrello);
                        }
                    }
                }
            }
        }



        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            Session["Carrello"] = null;
            Response.Redirect("Carrello.aspx");
        }
    }
}

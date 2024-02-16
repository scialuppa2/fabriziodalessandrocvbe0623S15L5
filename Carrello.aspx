<%@ Page Title="Carrello" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="progetto_settimanaleS15L5.Carrello" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h2>Il Tuo Carrello</h2>
        <asp:Repeater ID="carrelloRepeater" runat="server" OnItemCommand="EliminaProdotto">
            <ItemTemplate>
                <div class="col-md-4 mb-4">
                <div class="card">
                    <div class="card-body">
                        <h5 class="card-title"><%# Eval("Nome") %></h5>
                        <img src='<%# Eval("ImgUrl") %>' class="card-img-top h-50" alt='<%# Eval("Nome") %>'>
                        <p class="card-text"><%# Eval("Descrizione") %></p>
                        <p class="card-text">Prezzo: <%# Eval("Prezzo", "{0:C}") %></p>
                        <asp:Button ID="RimuoviDalCarrelloButton" runat="server" Text="Rimuovi dal Carrello" CssClass="btn btn-danger" CommandName="Rimuovi" CommandArgument='<%# Eval("IdProdotto") %>' />
                    </div>
                </div>
              </div>
            </ItemTemplate>
        </asp:Repeater>
        <p class="total-label">Totale: <asp:Label ID="totaleLabel" runat="server" CssClass="total-amount" Text='<%# string.Format("{0:C}", Convert.ToDecimal(Eval("Totale"))) %>'></asp:Label></p>
        <asp:Button ID="SvuotaCarrelloButton" runat="server" Text="Svuota Carrello" CssClass="btn btn-danger" OnClick="SvuotaCarrello_Click" />
    </div>
</asp:Content>

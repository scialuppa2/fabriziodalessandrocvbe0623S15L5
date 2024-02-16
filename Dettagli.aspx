<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="progetto_settimanaleS15L5.Dettagli" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
    <h2>Dettaglio Prodotto</h2>
    <div class="col-md-6">
        <div class="card">
            <div class="card-body">
                <h3><asp:Label ID="NomeProdotto" class="card-title" runat="server" Text='<%# Eval("Nome") %>'></asp:Label></h3>
                <asp:Image ID="ImmagineProdotto" runat="server" class="card-img-top h-50" ImageUrl='<%# Eval("ImgUrl") %>' />
                <p><asp:Label ID="DescrizioneProdotto" class="card-text" runat="server" Text='<%# Eval("Descrizione") %>'></asp:Label></p>
                <p><strong><asp:Label ID="Prezzo" runat="server" Text='<%# Eval("Prezzo", "{0:C}") %>'></asp:Label></strong></p>
                <asp:Button runat="server" Text="Aggiungi al Carrello" CssClass="btn btn-success" 
                    OnClick="AggiungiAlCarrello" CommandArgument='<%# Eval("IdProdotto") %>' />
            </div>
        </div>
    </div>
</div>

</asp:Content>

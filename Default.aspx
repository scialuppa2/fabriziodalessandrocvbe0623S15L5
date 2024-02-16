<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="progetto_settimanaleS15L5.Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <h1>Benvenuto nel nostro Store !</h1>
        <h4>Qui puoi trovare i migliori prodotti sportivi</h4>
        
      
    <div class="row">
        <asp:Repeater ID="productRepeater" runat="server">
            <ItemTemplate>
                <div class="col-md-4 mb-4">
                    <div class="card h-100">
                        <img src='<%# Eval("ImgUrl") %>' class="card-img-top h-50" alt='<%# Eval("Nome") %>'>
                        <div class="card-body">
                            <h5 class="card-title"><%# Eval("Nome") %></h5>
                            <p class="card-text"><%# Eval("Descrizione") %></p>
                            <p class="card-text">Prezzo: <%# Eval("Prezzo", "{0:C}") %></p>
                            <a href='<%# "Dettagli.aspx?id=" + Eval("IdProdotto") %>' class="btn btn-primary">Dettagli</a>
                            <asp:Button runat="server" Text="Aggiungi al Carrello" CssClass="btn btn-success" 
                                OnClick="AggiungiAlCarrello" CommandArgument='<%# Eval("IdProdotto") %>' />
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</div>

    
</asp:Content>

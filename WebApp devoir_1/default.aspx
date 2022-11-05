<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApp_devoir_1._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="stylesheet.css"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap.css" rel="stylesheet" />
</head>
<body>
    <form id="form2" runat="server">
        <br />
        <div class="row">
        <div class="col-lg-12">
        <div class="col-lg-6">
            <div class="col-lg-3">
                <asp:label for="txtNom" runat="server" class="form-label">Nom</asp:label>
                <asp:TextBox ID="txtNom"  runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                <asp:label for="txtPrenom1" runat="server" class="form-label">Prenom1</asp:label>
                <asp:TextBox ID="txtPrenom1" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                <asp:label for="txtPrenom2" runat="server" class="form-label">Prenom2</asp:label>
                <asp:TextBox ID="txtPrenom2" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                <asp:label for="txtAge" runat="server" class="form-label">Age</asp:label>
                <asp:TextBox ID="txtAge" runat="server" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                 <asp:label for="txtTelephone" runat="server" class="form-label">Telephone</asp:label>
                <asp:TextBox ID="txtTelephone" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                <asp:label for="txtAdresse" runat="server" class="form-label">Adresse</asp:label>
                <asp:TextBox ID="txtAdresse" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                 <asp:label for="txtVille" runat="server" class="form-label">Ville</asp:label>
                <asp:TextBox ID="txtVille" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                <asp:label for="txtPays" runat="server" class="form-label">Pays</asp:label>
                <asp:TextBox ID="txtPays" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="col-lg-3">
                <asp:label for="txtNationalite" runat="server" class="form-label">Nationalite</asp:label>
                <asp:TextBox ID="txtNationalite" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
          </div>
       
        <div class="col-lg-6" style="padding-left:5px">
            <asp:GridView ID="gvPersonne" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="628px">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
        </div>


         </div>
       </div>
        <br />
        <br />
        <br />

        <div class="row" style="margin:30px;">
            <div class="col-lg-12">
                   <asp:label ID="Message" runat="server" forecolor="Red"></asp:label>
            </div>
              
            <div class ="col-lg-3">
                <asp:Button class ="btn btn-primary btn-lg" ID="btnSave" runat="server" Text="Save" OnClick ="btnSave_Click" type ="Submit"></asp:Button>
            </div>
            <div class ="col-lg-3">
                <asp:Button class ="btn btn-primary btn-lg" ID="btnCancel" runat="server" Text="Cancel" OnClick ="btnCancel_Click" type ="Submit"></asp:Button>
            </div>
        </div>
    </form>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/bootstrap.js"></script>
   </body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gerir.aspx.cs" Inherits="M17E_INTRO_12H.Utilizador.Codigo.gerir" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Utilizadores</h1>
            <asp:GridView EmptyDataText="Sem dados" CssClass="table" ID="gvUtilizadores" runat="server"></asp:GridView>
            <h1>Adicionar Utilizador</h1>
            Nome:<asp:TextBox CssClass="form-control" runat="server" ID="tb_nome"></asp:TextBox><br />
            Email:<asp:TextBox CssClass="form-control" runat="server" ID="tb_email"></asp:TextBox><br />
            Password:<asp:TextBox CssClass="form-control" runat="server" ID="tb_password" TextMode="Password"></asp:TextBox><br />
            Perfil:<asp:DropDownList CssClass="form-select" runat="server" ID="dd_perfil">
                <asp:ListItem Value="0">Admin</asp:ListItem>
                <asp:ListItem Value="1">Funcionário</asp:ListItem>
                <asp:ListItem Value="2">Cliente</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Button CssClass="btn btn-lg btn-danger" runat="server" ID="bt_guardar" Text="Adicionar" OnClick="bt_guardar_Click" /><br />
            <asp:Label runat="server" ID="lb_erro"></asp:Label>
        </div>
    </form>
</body>
</html>

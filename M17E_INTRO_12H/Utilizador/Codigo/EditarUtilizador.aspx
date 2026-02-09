<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditarUtilizador.aspx.cs" Inherits="M17E_INTRO_12H.Utilizador.Codigo.EditarUtilizador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-sRIl4kxILFvY47J16cr9ZwB07vP4J8+LH7qKQnuqkuIAvNWLzeN8tE5YBujZqJLB" crossorigin="anonymous">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.8/dist/js/bootstrap.bundle.min.js" integrity="sha384-FKyoEForCGlyvwx9Hj09JcYn3nv7wiPVlz7YYwJrWVcXK/BmnVDxM+D2scQbITxI" crossorigin="anonymous"></script>
    <script src="/public/js/codigo.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Editar Utilizador</h1>
            <br />
            Nome:<asp:TextBox CssClass="form-control" runat="server" ID="tbNome"></asp:TextBox>
            <br />
            <asp:Button CssClass="btn btn-lg btn-danger" OnClick="btEditar_Click" runat="server" ID="btEditar" Text="Editar" />
            <asp:Button CssClass="btn btn-lg btn-info"
                runat="server"
                ID="btVoltar"
                Text="Voltar"
                PostBackUrl="~/Utilizador/Codigo/gerir.aspx" />
            <br />
            <asp:Label runat="server" ID="lbErro" Text="" />
        </div>
    </form>
</body>
</html>
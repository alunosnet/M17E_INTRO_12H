<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="admin.aspx.cs" Inherits="M17E_INTRO_12H.admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write(Session["nome"]); %>
            <h1>Admin Dashboard</h1>
            <% if (Session["perfil"].ToString()=="0") {   %>
                <h2>Olá administrador</h2>
            <% } else {  %>
                <h2>Olá qualquer coisa</h2>
            <% } %>
            <asp:Button ID="bt_logout" runat="server" Text="Terminar sessão" OnClick="bt_logout_Click" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="recuperarpassword.aspx.cs" Inherits="M17E_INTRO_12H.recuperarpassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Recuperação da palavra passe</h1>
            Nova palavra passe:<asp:TextBox ID="tb_palavra_passe" 
                runat="server" TextMode="Password" />
            <br />
            <asp:Button ID="bt_recuperar" Text="Definir nova palavra passe"
                runat="server" OnClick="bt_recuperar_Click" />
        </div>
    </form>
</body>
</html>

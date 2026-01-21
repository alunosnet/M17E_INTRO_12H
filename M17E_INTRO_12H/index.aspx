<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="M17E_INTRO_12H.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="X:"></asp:Label>
            <asp:TextBox ID="tb_x" runat="server" ></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Y:"></asp:Label>
            <asp:TextBox  ID="tb_y" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="bt_soma" runat="server" Text="Somar" OnClick="bt_soma_Click" />
            <br />
            <asp:Label ID="lb_resultado" runat="server"></asp:Label>
            <br />
            <asp:Button ID="bt_redirect" runat="server" 
                    Text="Página resultado" OnClick="bt_redirect_Click" />
        </div>
    </form>
</body>
</html>

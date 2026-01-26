<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="compra.aspx.cs" Inherits="M17E_INTRO_12H.compra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Comprar PC</h1>
            <!--Nome -->
            Nome:<asp:TextBox ID="tb_nome" runat="server" 
                required="true" placeholder="Nome do cliente" MaxLength="50"  />
            <br />
            <!--Data Nascimento-->
            Data Nascimento
            <asp:TextBox ID="c_data_nasc" runat="server" type="date" required="false" />
            <br />
            <!--Email -->
            Email: <asp:TextBox ID="tb_email" runat="server" required="true"
                type="email" placeholder="Email do cliente" />
            <br />
            <!--Marca DropDownList -->
            Marca:
            <asp:DropDownList ID="dd_marca" runat="server" AutoPostBack="true"
                OnSelectedIndexChanged="dd_marca_SelectedIndexChanged">
                <asp:ListItem Text="Escolha uma marca" Value="0"></asp:ListItem>
                <asp:ListItem Text="Asus" Value="1"></asp:ListItem>
                <asp:ListItem Text="HP" Value="2"></asp:ListItem>
            </asp:DropDownList>
            <br />
            <!--Modelo DropDownlist -->
            Modelo:
            <asp:DropDownList ID="dd_modelo" runat="server"></asp:DropDownList>
            <br />
            <!--Processador radio button -->
            Processador:<br />
            <asp:RadioButton GroupName="processador" id="rb_intel" runat="server" Text="Intel" /><br />
            <asp:RadioButton GroupName="processador" id="rb_amd" runat="server" Text="AMD" /><br />
            <asp:RadioButton GroupName="processador" id="rb_outro" runat="server" Text="Outro" /><br />

            <!--Aceitar condições chk_bx -->
            <asp:CheckBox ID="cb_aceitar" runat="server" Text="Aceito as condições" />
            <br />
            <!--Foto perfil -->
            <asp:FileUpload ID="foto" runat="server" />
            <br />
            <!--Button Finalizar -->
            <asp:Button ID="bt_comprar" runat="server" Text="Finalizar a compra" 
                OnClick="bt_comprar_Click" />
            <br />
            <asp:Label ID="lb_erro" runat="server" />
            <% Response.Write(DateTime.Now);  %>
        </div>
    </form>
</body>
</html>

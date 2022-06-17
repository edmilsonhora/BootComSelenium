<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ESH_MyBoot.AppWeb.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Css/Css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <fieldset>
            <legend>Edit - Usuarios</legend>
            <label>
                Nome:
            <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
            </label>
            <label>
                CPF:
            <asp:TextBox ID="txtCPF" runat="server"></asp:TextBox>
            </label>
            <label>
                Email:
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </label>
            
            <label>
                Sexo:<asp:DropDownList ID="dropSexo" runat="server">
                    <asp:ListItem Value="" Text="--Selecione--"></asp:ListItem>
                    <asp:ListItem Value="Masculino" Text="Masculino"></asp:ListItem>
                    <asp:ListItem Value="Feminino" Text="Feminino"></asp:ListItem>
                     </asp:DropDownList>
            </label>
            <label>
                Perfil:<asp:DropDownList ID="dropPerfil" runat="server">
                    <asp:ListItem Value="" Text="--Selecione--"></asp:ListItem>
                    <asp:ListItem Value="User" Text="User"></asp:ListItem>
                    <asp:ListItem Value="Admin" Text="Admin"></asp:ListItem>
                    <asp:ListItem Value="SuperUser" Text="SuperUser"></asp:ListItem>
                       </asp:DropDownList>
            </label>
        </fieldset>
        <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
        <br />
        <br />
        <asp:Label ID="lblErro" runat="server" ForeColor="Red" ></asp:Label>
    </form>
</body>
</html>

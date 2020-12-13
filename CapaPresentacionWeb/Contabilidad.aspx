<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contabilidad.aspx.cs" Inherits="CapaPresentacionWeb.Contabilidad" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 370px;
        }
        .auto-style3 {
            width: 370px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 371px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">Ingrese nombre</td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtNombre" runat="server" OnTextChanged="txtNombre_TextChanged"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Ingrese el saldo</td>
                <td>
                    <asp:TextBox ID="txtSueldo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="lblSueldo" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Ingrse numero del mes</td>
                <td>
                    <asp:TextBox ID="txtNumMes" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Button ID="btnCalcular" runat="server" OnClick="btnCalcular_Click" Text="Calcular" />
                </td>
                <td>
                    <asp:Label ID="lblMes" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style5">
                    <br />
                    Ingrese una fecha</td>
                <td>
                    Dia&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Mes&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Año
                    <br />
                    <asp:TextBox ID="txtDia" runat="server" Width="96px"></asp:TextBox>
                    <asp:TextBox ID="txtMes" runat="server" Width="111px"></asp:TextBox>
                    <asp:TextBox ID="txtAn" runat="server" Width="102px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td>
                    <asp:Label ID="lblFecha" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <br />
    </form>
</body>
</html>

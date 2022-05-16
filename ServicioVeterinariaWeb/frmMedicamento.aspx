<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMedicamento.aspx.cs" Inherits="ServicioVeterinariaWeb.frmMedicamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        id</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        Medicamento id</td>
                    <td>
                        <asp:TextBox ID="txtMedicamento_id" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        Dosis</td>
                    <td>
                        <asp:TextBox ID="txtDosis" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:DropDownList ID="DDLTratamiento" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td>
                        Observaciones</td>
                    <td>
                        <asp:TextBox ID="txtObservaciones" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnRegresar" runat="server" OnClick="btnRegresar_Click" Text="Volver" />
                    </td>
                </tr>
                
                <tr>
                    <td>
                        estado</td>
                    <td>
                        <asp:TextBox ID="txtEstado" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Button ID="btnCargarDatos" runat="server" OnClick="btnCargarDatos_Click" Text="Cargar Datos" />
                    </td>
                </tr>
                
                
                <tr>
                    <td>
                        <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnModificar" runat="server"  Text="Modificar" />
                    </td>
                    <td>
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" />
                    </td>
                </tr>
                
                
            </table>
        </div>
        <asp:GridView ID="GVTratamientro" runat="server">
        </asp:GridView>
    </form>
</body>
</html>

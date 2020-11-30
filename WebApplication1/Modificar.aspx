<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Modificar.aspx.cs" Inherits="WebApplication1.Modificar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="card-header"><h3 class="text-center font-weight-light my-4" style="background-color: #CCCCCC">Modificar Producto</h3></div>

    
    <table style="width: 37%; margin-left: 288px; margin: 0 auto;background-color: #CCCCCC" class="table-active">
       <tr> 
            <td style="width: 140px">
                <asp:Label ID="Label3" runat="server" Text="Seleccionar :" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" style="margin-left: 5px" Width="322px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            </td>
        </tr>

        <tr> 
            <td style="width: 140px">
                <asp:Label ID="Label1" runat="server" Text="Producto :" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" class="form-control" style="margin-left: 5px" Width="322px" placeholder="Nombre del Producto"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td style="width: 140px">
                <asp:Label ID="Label2" runat="server" Text="Precio :" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" class="form-control" style="margin-left: 5px" Width="322px" placeholder="Precio del Producto"></asp:TextBox>
            </td>
        </tr>
    </table>

    <br />

    <table style="width: 37%; margin-left: 288px; margin: 0 auto;">
        <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Modificar Producto" class="btn btn-primary btn-block" Height="51px" OnClick="Button1_Click" />
        </td>
       </tr>
    </table>


</asp:Content>

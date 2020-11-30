<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="WebApplication1.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

            <div class="card-header"><h3 class="text-center font-weight-light my-4" style="background-color: #CCCCCC">Eliminar Producto</h3></div>

    
    <table style="width: 37%; margin-left: 288px; margin: 0 auto;background-color: #CCCCCC" class="table-active">
       <tr> 
            <td style="width: 140px">
                <asp:Label ID="Label3" runat="server" Text="Seleccionar :" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" class="form-control" style="margin-left: 5px" Width="322px"></asp:DropDownList>
            </td>
        </tr>
    </table>

    <br />

    <table style="width: 37%; margin-left: 288px; margin: 0 auto;">
        <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Eliminar Producto" class="btn btn-primary btn-block" Height="51px" OnClick="Button1_Click" />
        </td>
       </tr>
    </table>


</asp:Content>

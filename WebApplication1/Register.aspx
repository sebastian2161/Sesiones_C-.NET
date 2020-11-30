<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    

    <div class="card-header"><h3 class="text-center font-weight-light my-4" style="background-color: #CCCCCC">Registrar Producto</h3></div>

    
    <table style="width: 37%; margin-left: 288px; margin: 0 auto;background-color: #CCCCCC" class="table-active">
        <tr> 
            <td style="width: 140px">
                <asp:Label ID="Label1" runat="server" Text="Producto :" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server" class="form-control" style="margin-left: 5px" Width="322px" placeholder="Nombre del Producto" minlength="5" maxlength="40" CausesValidation="True"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td style="width: 140px">
                <asp:Label ID="Label2" runat="server" Text="Precio :" Font-Bold="True"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" class="form-control" style="margin-left: 5px" Width="322px" placeholder="Precio del Producto" type ="number" CausesValidation="True" minlength="500" ></asp:TextBox>
            </td>
        </tr>
    </table>



    <br />

    <table style="width: 37%; margin-left: 288px; margin: 0 auto;">
        <tr>
        <td>
            <asp:Button ID="Button1" runat="server" Text="Registrar Producto" class="btn btn-primary btn-block" Height="51px" OnClick="Button1_Click" />
        </td>
       </tr>
    </table>


 
</asp:Content>


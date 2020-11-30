<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Consultar.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Custom fonts for this template -->
<!--<link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css"/> -->
<!--<link href="https://fonts.googleapis.com/css?family=Nunito:200,200i,300,300i,400,400i,600,600i,700,700i,800,800i,900,900i" rel="stylesheet"/> -->

<!-- Custom styles for this template -->
<!--<link href="css/sb-admin-2.min.css" rel="stylesheet"/> -->

<!-- Custom styles for this page -->
<link href="vendor/datatables/dataTables.bootstrap4.min.css" rel="stylesheet"/>



<script src="js/jquery.min.js" type="22ac64e260f4b6e42c1e57d7-text/javascript"></script>
<script src="js/bootstrap.min.js" type="22ac64e260f4b6e42c1e57d7-text/javascript"></script>

                    <!-- Begin Page Content -->
                <div class="container-fluid">

                    <!-- DataTales Example -->
                    <div class="card shadow mb-4">
                        <div class="card-header py-3">
                            <h6 class="m-0 font-weight-bold text-primary">DataTables Example</h6>
                        </div>
                        <div class="card-body">
                            <div class="table-responsive">
                                <table class="table table-bordered" id="dataTable" width="100%" cellspacing="0">
                                    <thead>
                                        <tr>
                                            <th>ID</th>
                                            <th>Product</th>
                                            <th>Price</th>
                                            <th>Years old</th>
                                            <th>Start date</th>
                                            <th>Salary</th>
                                        </tr>
                                    </thead>

                                    <%=getWhileLoopData1()%>


                                    <tfoot>
                                        <tr>
                                            <th>Name</th>
                                            <th>Position</th>
                                            <th>Office</th>
                                            <th>Age</th>
                                            <th>Start date</th>
                                            <th>Salary</th>
                                        </tr>
                                    </tfoot>

                                </table>   
                            </div>
                        </div>
                    </div>

                </div>


</asp:Content>

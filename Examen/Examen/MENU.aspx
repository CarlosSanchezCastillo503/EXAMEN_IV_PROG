<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MENU.aspx.cs" Inherits="Examen.MENU" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
                    <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" class="btn btn-outline-primary">EJERCICIO DEL ATLETA</asp:LinkButton> <br /><br />
                    <asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" class="btn btn-outline-primary">Ejercicio de los numeros</asp:LinkButton><br /><br /><br />
            <asp:Label ID="Label1" runat="server" Text="HECHO POR CARLOS ALBERTO SANCHEZ CASTIILLO"></asp:Label> <br /><br />
            <asp:Label ID="Label2" runat="server" Text="CARNET:17-0656-2019"></asp:Label>
        </center>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuModulo.aspx.cs" Inherits="FormularioModulo.MenuModulo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Evaluacion 3 .NET</title>
    <style>
        body{
            background-color:beige;
        }
        #titulo {
            padding:20px;
            text-align:center;
            font-size: 200%;
        }
        p {
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="_formMod" runat="server">
        <div ID="titulo">
            <asp:Label ID="_lblTtl" runat="server" Text="Formulario para encontrar el módulo de dos números"></asp:Label>
        </div>
        <p>
            <asp:Label ID="_lblPrimNum" runat="server" Text="Ingrese el primer número: "></asp:Label>
            <asp:TextBox ID="_txbxPrimNum" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="_lblSegNum" runat="server" Text="Ingrese el segundo número: "></asp:Label>
            <asp:TextBox ID="_txbxSegNum" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="_btnCalcularMod" runat="server" Text="Calcular Módulo" OnClick="_btnCalcularMod_Click" />
        </p>
        <p>
            <asp:Label ID="_lblRes" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

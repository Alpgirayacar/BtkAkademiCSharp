<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Detay.aspx.cs" Inherits="AjaxOrnek.Detay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
       <form id="form1" runat="server">
        <div style="text-align:center;">
            <asp:Label ID="label1" runat="server" Text="Ürün Adı : " />
            <asp:Label ID="lblUrunAdi" runat="server" /><br /><br />
            <asp:Label ID="label2" runat="server" Text="Ürün Resmi : " /> 
            <asp:Image ID="imgUrun" Width="600" Height="600"  runat="server" /> <br /> <br />
             <asp:Label ID="label3" runat="server" Text="Ürün Fiyatı : "></asp:Label>
            <asp:Label ID="lblUrunFiyati" runat="server" />
        </div>
    </form>
</body>
</html>

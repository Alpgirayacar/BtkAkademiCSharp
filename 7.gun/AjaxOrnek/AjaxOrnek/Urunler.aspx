<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Urunler.aspx.cs" Inherits="AjaxOrnek.Urunler" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtUrunAd" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <div id="sonuc"></div>
        </div>
        <script>
            $('#txtUrunAd').on('input', function (e) {
                UrunBilgiGetir();
            });
            function UrunBilgiGetir() {
                var qTextboxDeger = $('#txtUrunAd').val();
                if (qTextboxDeger != '') {
                    $.support.cors = true;
                    $.ajax({
                        type: "POST",
                        url: "../Ajax.aspx/YeniMetod",
                        data: "{ 'abc': '" + qTextboxDeger + "' }",
                        contentType: 'application/json; charset=utf-8',
                        dataType: "json",
                        success: function (result) {
                            //$('#prf').html('');
                            console.log(result);
                            console.log(result.d);
                            $.each(result.d, function (index,item) {
                                //$('#sonuc').append('<a href=\'#\'>' + item.urunAdi + '</a>'+item.fiyat+'<br />');
                                $('#sonuc').append("<b>Urun Id : <b>" + Number(index + 1) + " " + item.urunAdi +
                                     "<a href='Detay.aspx?Id=" + item.Id
                                     + "&Adi=" + item.urunAdi + "&urunResim=" + item.resim
                                     + "&urunFiyati=" + item.fiyat + "'><img src=" + item.resim
                                     + " width='100' height='100' /></a> <b>Fiyat :</b> " + item.fiyat + " <br />");
                            });

                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            //alert(jqXHR.responseText);
                            $('#sonuc').html('' + jqXHR.responseText);
                            $('#sonuc').html('işlem başarısız!!!');
                        },

                    });
                }
            }
        </script>
    </form>
</body>
</html>

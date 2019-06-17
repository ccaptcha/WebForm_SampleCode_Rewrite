<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SampleCCaptcha.aspx.cs" Inherits="SampleCCaptchaASP.Net.SampleCCaptcha" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<script src="https://widget.ccaptcha.com/js/ccaptcha_version2_M1.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div  id="Ccaptcha_M1" data-ccaptcha_apicode="YOUR DOMAIN API CODE"></div>


        <br />
        <asp:Button Text="Confirm" runat="server"  OnClick="Confirm_Click" /> 
        <br />
        <asp:Label Text="" ID="lbl" runat="server" />
    </form>
</body>
</html>

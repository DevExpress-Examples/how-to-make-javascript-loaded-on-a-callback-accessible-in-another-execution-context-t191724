<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Correct.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Correct</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxCallbackPanel ID="CallbackPanel" runat="server" ClientInstanceName="clientCallbackPanel" OnCallback="CallbackPanel_Callback">
                <ClientSideEvents Init="function(s,e){ clientCallbackPanel.PerformCallback();}" />
            </dx:ASPxCallbackPanel>
            <dx:ASPxButton ID="button" runat="server" Text="Click Me">
                <ClientSideEvents Click="function(s,e){ OnClick(s,e); }" />
            </dx:ASPxButton>
            <br />
            <a href="Incorrect.aspx">See the incorrect behavior</a>
        </div>
    </form>
</body>
</html>
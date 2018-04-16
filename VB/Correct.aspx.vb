Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub CallbackPanel_Callback(ByVal sender As Object, ByVal e As CallbackEventArgsBase)
        Dim callbackPanel As ASPxCallbackPanel = TryCast(sender, ASPxCallbackPanel)
        Dim script As String = "<script id=""dxss_myScript"" type=""javascript""> window.OnClick = function(s,e){ alert('Click!');} </script>"
        callbackPanel.Controls.Add(New LiteralControl With {.ID = "scriptBlock", .Text = script})

        Dim button As ASPxButton = New ASPxButton With {.ID = "cbpButton"}
        callbackPanel.Controls.Add(button)
        button.AutoPostBack = False
        button.Text = "Click Me (Loaded via Callback)"
        button.ClientSideEvents.Click = "function(s,e){ OnClick(s,e);}"
    End Sub
End Class
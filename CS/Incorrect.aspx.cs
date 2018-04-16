using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

	protected void CallbackPanel_Callback(object sender, CallbackEventArgsBase e) {
		ASPxCallbackPanel callbackPanel = sender as ASPxCallbackPanel;
		string script = "<script id=\"dxss_myScript\" type=\"javascript\"> function OnClick(s,e){ alert('Click!');} </script>";
		callbackPanel.Controls.Add(new LiteralControl { ID = "scriptBlock", Text = script });

		ASPxButton button = new ASPxButton { ID = "cbpButton" };
		callbackPanel.Controls.Add(button);
		button.AutoPostBack = false;
		button.Text = "Click Me (Loaded via Callback)";
		button.ClientSideEvents.Click = "function(s,e){ OnClick(s,e);}";
	}
}
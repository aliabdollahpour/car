using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace VIP
{
	/// <summary>
	/// Summary description for ClaimReport1.
	/// </summary>
	public class ClaimReport1 : System.Web.UI.Page
	{
		private void Page_Load(object sender, System.EventArgs e)
		{
			
			//if(!Page.IsPostBack)
			//{
				
			//	string s=Request.QueryString["FK_PNO"];
			//	Session["FK_PNO"]=s;
			//}
			// Put user code to initialize the page here
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion
	}
}
using System;
using System.Web.UI;

namespace RemoteDebuggingDemo
{
	// ReSharper disable once InconsistentNaming
	public partial class _Default : Page
	{
		private static int i;

		protected void Page_Load(object sender, EventArgs e)
		{
			Button1.Text = i.ToString();
		}

		protected void Button1_Click(object sender, EventArgs e)
		{
			Button1.Text = (++i).ToString();
		}
	}
}
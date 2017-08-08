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
using System.Web.Hosting;
using System.Text;
using System.IO;

namespace TestAspnetHost.Host
{

	/// <summary>
	/// Host 的摘要说明。
	/// </summary>
	public class Host : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button button1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			
			
		}

		#region Web 窗体设计器生成的代码
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: 该调用是 ASP.NET Web 窗体设计器所必需的。
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{    
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void button1_Click(object sender, System.EventArgs e)
		{
			MyExeHost host = (MyExeHost) ApplicationHost.CreateApplicationHost(typeof(MyExeHost), "/", Request.PhysicalApplicationPath);
			host.ProcessRequest("WebForm1.aspx");
			Response.Write("生成成功");
		}
	}


	
	public class MyExeHost : MarshalByRefObject
	{
		public void ProcessRequest(string page)
		{
			StreamWriter writer = new StreamWriter(@"C:\Inetpub\wwwroot\TestAspnetHost\temp.htm", false, Encoding.GetEncoding("gb2312"));
			HttpRuntime.ProcessRequest(new SimpleWorkerRequest(page, null, writer));
			writer.Flush();
			writer.Close();
		}
	}
}

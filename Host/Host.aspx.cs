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
	/// Host ��ժҪ˵����
	/// </summary>
	public class Host : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Button button1;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			
			
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
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
			Response.Write("���ɳɹ�");
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

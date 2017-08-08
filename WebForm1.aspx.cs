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

namespace TestAspnetHost
{
	/// <summary>
	/// WebForm1 的摘要说明。
	/// </summary>
	public class WebForm1 : System.Web.UI.Page
	{
		protected System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		protected System.Data.SqlClient.SqlCommand sqlSelectCommand1;
		protected System.Data.SqlClient.SqlCommand sqlInsertCommand1;
		protected System.Data.SqlClient.SqlConnection sqlConnection1;
		protected TestAspnetHost.DataSet1 dataSet11;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			
		}

		public string Hello
		{
			get
			{
				string retval = string.Empty;
				for (int i = 0; i < 10; i++)
				{
					retval += "Hello" + "<br>";
				}
				return retval;
			}
		}

		public string Hello2
		{
			get
			{
				string retval = string.Empty;
				retval = @"<table><tr><td>1</td></tr><tr><td>2</td></tr><tr><td>3</td></tr></table>";
				sqlDataAdapter1.Fill(dataSet11);
				for (int i = 0; i < 11; i++)
				{
					retval += dataSet11.Tables[0].Rows[i][2].ToString() + "<br>";
				}
				
				return retval;
			}
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
			this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
			this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			this.dataSet11 = new TestAspnetHost.DataSet1();
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
			// 
			// sqlDataAdapter1
			// 
			this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
			this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
			this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
																									  new System.Data.Common.DataTableMapping("Table", "classid", new System.Data.Common.DataColumnMapping[] {
																																																				 new System.Data.Common.DataColumnMapping("cid", "cid"),
																																																				 new System.Data.Common.DataColumnMapping("name", "name"),
																																																				 new System.Data.Common.DataColumnMapping("ename", "ename")})});
			// 
			// sqlSelectCommand1
			// 
			this.sqlSelectCommand1.CommandText = "SELECT cid, name, ename FROM classid";
			this.sqlSelectCommand1.Connection = this.sqlConnection1;
			// 
			// sqlInsertCommand1
			// 
			this.sqlInsertCommand1.CommandText = "INSERT INTO classid(cid, name, ename) VALUES (@cid, @name, @ename); SELECT cid, n" +
				"ame, ename FROM classid";
			this.sqlInsertCommand1.Connection = this.sqlConnection1;
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@cid", System.Data.SqlDbType.TinyInt, 1, "cid"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@name", System.Data.SqlDbType.VarChar, 50, "name"));
			this.sqlInsertCommand1.Parameters.Add(new System.Data.SqlClient.SqlParameter("@ename", System.Data.SqlDbType.VarChar, 50, "ename"));
			// 
			// sqlConnection1
			// 			
			this.sqlConnection1.ConnectionString = "user id=sa; password=123456; database=drvshome209; server=SOURCSERVER; Connect Timeout=30";
			// 
			// dataSet11
			// 
			this.dataSet11.DataSetName = "DataSet1";
			this.dataSet11.Locale = new System.Globalization.CultureInfo("zh-CN");
			this.Load += new System.EventHandler(this.Page_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();

		}
		#endregion
	}
}

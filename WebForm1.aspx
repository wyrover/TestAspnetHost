<%@ Page language="c#" Codebehind="WebForm1.aspx.cs" AutoEventWireup="false" Inherits="TestAspnetHost.WebForm1" enableViewState="False"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
	</HEAD>
	<body>
		<%
			for (int i = 0; i < 10; i++)
			{
				Response.Write("test");
				Response.Write(Request.PhysicalApplicationPath + "<br>");
			}
		%>
		<%=Hello%>
		<%=Hello2%>
	</body>
</HTML>

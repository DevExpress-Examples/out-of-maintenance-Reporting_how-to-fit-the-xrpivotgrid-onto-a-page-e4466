Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.XtraReports.Web
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports.UI

Namespace WebApplication1
	Partial Public Class WebForm1
		Inherits System.Web.UI.Page

		Protected Sub Page_PreRender(ByVal sender As Object, ByVal e As EventArgs)
		End Sub
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Session("report") Is Nothing Then
				Dim report As New XtraReport1()
				report.CreateDocument(False)
				report.PrintingSystem.Document.AutoFitToPagesWidth = 1
			   Session("report") = report
			End If
			ReportViewer1.Report = TryCast(Session("report"), XtraReport)
		End Sub

		Protected Sub ASPxButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Protected Sub ReportViewer1_Unload(ByVal sender As Object, ByVal e As EventArgs)
			DirectCast(sender, ReportViewer).Report = Nothing
		End Sub
	End Class
End Namespace

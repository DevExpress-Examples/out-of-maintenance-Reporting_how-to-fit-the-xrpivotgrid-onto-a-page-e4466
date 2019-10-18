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

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			Dim report As New XtraReport1()
			AddHandler report.AfterPrint, AddressOf Report_AfterPrint
			ASPxWebDocumentViewer1.OpenReport(report)

		End Sub
		Private Sub Report_AfterPrint(ByVal sender As Object, ByVal e As EventArgs)
			Dim report As XtraReport = TryCast(sender, XtraReport)
			report.PrintingSystem.Document.AutoFitToPagesWidth = 1
		End Sub
	End Class
End Namespace

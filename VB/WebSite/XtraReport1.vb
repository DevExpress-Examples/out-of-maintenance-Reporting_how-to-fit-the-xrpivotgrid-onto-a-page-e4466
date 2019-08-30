Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

Namespace WebApplication1
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrLabel1_HtmlItemCreated(ByVal sender As Object, ByVal e As HtmlEventArgs)
		End Sub

		Private Sub xrPivotGrid1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles xrPivotGrid1.BeforePrint
			xrPivotGrid1.BestFit()
		End Sub

	End Class
End Namespace

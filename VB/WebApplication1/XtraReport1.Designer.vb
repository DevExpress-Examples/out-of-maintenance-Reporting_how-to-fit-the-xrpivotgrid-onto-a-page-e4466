Imports Microsoft.VisualBasic
Imports System
Namespace WebApplication1
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.dataSet11 = New DataSet1()
            Me.productsTableAdapter = New DataSet1TableAdapters.ProductsTableAdapter()
			Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.fieldProductID1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldProductName1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldSupplierID1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldCategoryID1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldQuantityPerUnit1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldUnitPrice1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldUnitsInStock1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldUnitsOnOrder1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldReorderLevel1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldDiscontinued1 = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.HeightF = 0F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' xrPivotGrid1
			' 
			Me.xrPivotGrid1.DataAdapter = Me.productsTableAdapter
			Me.xrPivotGrid1.DataMember = "Products"
			Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() { Me.fieldProductID1, Me.fieldProductName1, Me.fieldSupplierID1, Me.fieldCategoryID1, Me.fieldQuantityPerUnit1, Me.fieldUnitPrice1, Me.fieldUnitsInStock1, Me.fieldUnitsOnOrder1, Me.fieldReorderLevel1, Me.fieldDiscontinued1})
			Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrPivotGrid1.Name = "xrPivotGrid1"
			Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(640F, 90F)
'			Me.xrPivotGrid1.BeforePrint += New System.Drawing.Printing.PrintEventHandler(Me.xrPivotGrid1_BeforePrint);
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPivotGrid1})
			Me.ReportHeader.HeightF = 90F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' fieldProductID1
			' 
			Me.fieldProductID1.AreaIndex = 0
			Me.fieldProductID1.FieldName = "ProductID"
			Me.fieldProductID1.Name = "fieldProductID1"
			' 
			' fieldProductName1
			' 
			Me.fieldProductName1.AreaIndex = 1
			Me.fieldProductName1.FieldName = "ProductName"
			Me.fieldProductName1.Name = "fieldProductName1"
			' 
			' fieldSupplierID1
			' 
			Me.fieldSupplierID1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldSupplierID1.AreaIndex = 0
			Me.fieldSupplierID1.FieldName = "SupplierID"
			Me.fieldSupplierID1.Name = "fieldSupplierID1"
			' 
			' fieldCategoryID1
			' 
			Me.fieldCategoryID1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCategoryID1.AreaIndex = 0
			Me.fieldCategoryID1.FieldName = "CategoryID"
			Me.fieldCategoryID1.Name = "fieldCategoryID1"
			' 
			' fieldQuantityPerUnit1
			' 
			Me.fieldQuantityPerUnit1.AreaIndex = 2
			Me.fieldQuantityPerUnit1.FieldName = "QuantityPerUnit"
			Me.fieldQuantityPerUnit1.Name = "fieldQuantityPerUnit1"
			' 
			' fieldUnitPrice1
			' 
			Me.fieldUnitPrice1.AreaIndex = 3
			Me.fieldUnitPrice1.FieldName = "UnitPrice"
			Me.fieldUnitPrice1.Name = "fieldUnitPrice1"
			' 
			' fieldUnitsInStock1
			' 
			Me.fieldUnitsInStock1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitsInStock1.AreaIndex = 0
			Me.fieldUnitsInStock1.Caption = "Stock"
			Me.fieldUnitsInStock1.FieldName = "UnitsInStock"
			Me.fieldUnitsInStock1.Name = "fieldUnitsInStock1"
			' 
			' fieldUnitsOnOrder1
			' 
			Me.fieldUnitsOnOrder1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldUnitsOnOrder1.AreaIndex = 1
			Me.fieldUnitsOnOrder1.Caption = "Order"
			Me.fieldUnitsOnOrder1.FieldName = "UnitsOnOrder"
			Me.fieldUnitsOnOrder1.Name = "fieldUnitsOnOrder1"
			' 
			' fieldReorderLevel1
			' 
			Me.fieldReorderLevel1.AreaIndex = 4
			Me.fieldReorderLevel1.FieldName = "ReorderLevel"
			Me.fieldReorderLevel1.Name = "fieldReorderLevel1"
			' 
			' fieldDiscontinued1
			' 
			Me.fieldDiscontinued1.AreaIndex = 5
			Me.fieldDiscontinued1.FieldName = "Discontinued"
			Me.fieldDiscontinued1.Name = "fieldDiscontinued1"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.dataSet11
			Me.Version = "12.2"
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private dataSet11 As DataSet1
		Private productsTableAdapter As DataSet1TableAdapters.ProductsTableAdapter
		Private WithEvents xrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
		Private fieldProductID1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldProductName1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldSupplierID1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldCategoryID1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldQuantityPerUnit1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldUnitPrice1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldUnitsInStock1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldUnitsOnOrder1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldReorderLevel1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldDiscontinued1 As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
	End Class
End Namespace

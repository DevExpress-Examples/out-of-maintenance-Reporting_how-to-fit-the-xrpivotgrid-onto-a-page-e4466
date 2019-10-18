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
			Me.components = New System.ComponentModel.Container()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table2 As New DevExpress.DataAccess.Sql.Table()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table3 As New DevExpress.DataAccess.Sql.Table()
			Dim join1 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo1 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim join2 As New DevExpress.DataAccess.Sql.Join()
			Dim relationColumnInfo2 As New DevExpress.DataAccess.Sql.RelationColumnInfo()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
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
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
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
			' xrPivotGrid1
			' 
			Me.xrPivotGrid1.DataMember = "Products"
			Me.xrPivotGrid1.DataSource = Me.sqlDataSource1
			Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() { Me.fieldProductID1, Me.fieldProductName1, Me.fieldSupplierID1, Me.fieldCategoryID1, Me.fieldQuantityPerUnit1, Me.fieldUnitPrice1, Me.fieldUnitsInStock1, Me.fieldUnitsOnOrder1, Me.fieldReorderLevel1, Me.fieldDiscontinued1})
			Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrPivotGrid1.Name = "xrPivotGrid1"
			Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(650F, 90F)
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.xrPivotGrid1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPivotGrid1_BeforePrint);
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "NorthwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "ProductID"
			table1.MetaSerializable = "<Meta X=""30"" Y=""30"" Width=""125"" Height=""267"" />"
			table1.Name = "Products"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "ProductName"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "QuantityPerUnit"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "UnitPrice"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "UnitsInStock"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "UnitsOnOrder"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "ReorderLevel"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "Discontinued"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "EAN13"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			column10.Alias = "SupplierID"
			columnExpression10.ColumnName = "ContactName"
			table2.MetaSerializable = "<Meta X=""185"" Y=""30"" Width=""125"" Height=""286"" />"
			table2.Name = "Suppliers"
			columnExpression10.Table = table2
			column10.Expression = columnExpression10
			column11.Alias = "CategoryID"
			columnExpression11.ColumnName = "CategoryName"
			table3.MetaSerializable = "<Meta X=""340"" Y=""30"" Width=""125"" Height=""134"" />"
			table3.Name = "Categories"
			columnExpression11.Table = table3
			column11.Expression = columnExpression11
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Name = "Products"
			relationColumnInfo1.NestedKeyColumn = "SupplierID"
			relationColumnInfo1.ParentKeyColumn = "SupplierID"
			join1.KeyColumns.Add(relationColumnInfo1)
			join1.Nested = table2
			join1.Parent = table1
			relationColumnInfo2.NestedKeyColumn = "CategoryID"
			relationColumnInfo2.ParentKeyColumn = "CategoryID"
			join2.KeyColumns.Add(relationColumnInfo2)
			join2.Nested = table3
			join2.Parent = table1
			selectQuery1.Relations.Add(join1)
			selectQuery1.Relations.Add(join2)
			selectQuery1.Tables.Add(table1)
			selectQuery1.Tables.Add(table2)
			selectQuery1.Tables.Add(table3)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
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
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPivotGrid1})
			Me.ReportHeader.HeightF = 90F
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.Version = "18.2"
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
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
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
	End Class
End Namespace

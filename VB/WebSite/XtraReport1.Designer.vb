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
			Dim crossTabColumnDefinition1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F)
			Dim crossTabColumnDefinition2 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F)
			Dim crossTabColumnDefinition3 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F)
			Dim crossTabColumnDefinition4 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F)
			Dim crossTabColumnDefinition5 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(104F)
			Dim crossTabColumnField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
			Dim crossTabDataField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
			Dim crossTabDataField2 As New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
			Dim crossTabRowField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.xrCrossTab1 = New DevExpress.XtraReports.UI.XRCrossTab()
			Me.xrCrossTabCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell10 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell11 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell12 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell13 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell14 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell15 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell16 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell17 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			CType(Me.xrCrossTab1, System.ComponentModel.ISupportInitialize).BeginInit()
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
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCrossTab1})
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' xrCrossTab1
			' 
			Me.xrCrossTab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCrossTabCell1, Me.xrCrossTabCell2, Me.xrCrossTabCell3, Me.xrCrossTabCell4, Me.xrCrossTabCell5, Me.xrCrossTabCell6, Me.xrCrossTabCell7, Me.xrCrossTabCell8, Me.xrCrossTabCell9, Me.xrCrossTabCell10, Me.xrCrossTabCell11, Me.xrCrossTabCell12, Me.xrCrossTabCell13, Me.xrCrossTabCell14, Me.xrCrossTabCell15, Me.xrCrossTabCell16, Me.xrCrossTabCell17})
			crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition2.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition3.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition4.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition5.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			Me.xrCrossTab1.ColumnDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition() { crossTabColumnDefinition1, crossTabColumnDefinition2, crossTabColumnDefinition3, crossTabColumnDefinition4, crossTabColumnDefinition5})
			crossTabColumnField1.FieldName = "CategoryID"
			Me.xrCrossTab1.ColumnFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField() { crossTabColumnField1})
			crossTabDataField1.FieldName = "UnitsInStock"
			crossTabDataField2.FieldName = "UnitsOnOrder"
			Me.xrCrossTab1.DataFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField() { crossTabDataField1, crossTabDataField2})
			Me.xrCrossTab1.DataMember = "Products"
			Me.xrCrossTab1.DataSource = Me.sqlDataSource1
			Me.xrCrossTab1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrCrossTab1.Name = "xrCrossTab1"
			Me.xrCrossTab1.OriginalPivotGridLayout = resources.GetString("xrCrossTab1.OriginalPivotGridLayout")
			Me.xrCrossTab1.PrintOptions.PrintTotalsForSingleValues = False
			Me.xrCrossTab1.PrintOptions.RepeatColumnHeaders = False
			Me.xrCrossTab1.PrintOptions.RepeatRowHeaders = False
			Me.xrCrossTab1.RowDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition() {
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F)
			})
			crossTabRowField1.FieldName = "SupplierID"
			Me.xrCrossTab1.RowFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField() { crossTabRowField1})
			Me.xrCrossTab1.SizeF = New System.Drawing.SizeF(520F, 100F)
			' 
			' xrCrossTabCell1
			' 
			Me.xrCrossTabCell1.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell1.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell1.BorderWidth = 1F
			Me.xrCrossTabCell1.ColumnIndex = 0
			Me.xrCrossTabCell1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell1.Name = "xrCrossTabCell1"
			Me.xrCrossTabCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell1.RowIndex = 0
			Me.xrCrossTabCell1.RowSpan = 2
			Me.xrCrossTabCell1.Text = "Supplier ID"
			Me.xrCrossTabCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell2
			' 
			Me.xrCrossTabCell2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell2.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell2.BorderWidth = 1F
			Me.xrCrossTabCell2.ColumnIndex = 1
			Me.xrCrossTabCell2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell2.Name = "xrCrossTabCell2"
			Me.xrCrossTabCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell2.RowIndex = 2
			Me.xrCrossTabCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell3
			' 
			Me.xrCrossTabCell3.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell3.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell3.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell3.BorderWidth = 1F
			Me.xrCrossTabCell3.ColumnIndex = 1
			Me.xrCrossTabCell3.ColumnSpan = 2
			Me.xrCrossTabCell3.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell3.Name = "xrCrossTabCell3"
			Me.xrCrossTabCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell3.RowIndex = 0
			Me.xrCrossTabCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell4
			' 
			Me.xrCrossTabCell4.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell4.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell4.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell4.BorderWidth = 1F
			Me.xrCrossTabCell4.ColumnIndex = 0
			Me.xrCrossTabCell4.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell4.Name = "xrCrossTabCell4"
			Me.xrCrossTabCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell4.RowIndex = 2
			Me.xrCrossTabCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell5
			' 
			Me.xrCrossTabCell5.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell5.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell5.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell5.BorderWidth = 1F
			Me.xrCrossTabCell5.ColumnIndex = 0
			Me.xrCrossTabCell5.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell5.Name = "xrCrossTabCell5"
			Me.xrCrossTabCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell5.RowIndex = 3
			Me.xrCrossTabCell5.Text = "Grand Total"
			Me.xrCrossTabCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell6
			' 
			Me.xrCrossTabCell6.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell6.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell6.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell6.BorderWidth = 1F
			Me.xrCrossTabCell6.ColumnIndex = 1
			Me.xrCrossTabCell6.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell6.Name = "xrCrossTabCell6"
			Me.xrCrossTabCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell6.RowIndex = 3
			Me.xrCrossTabCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell7
			' 
			Me.xrCrossTabCell7.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell7.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell7.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell7.BorderWidth = 1F
			Me.xrCrossTabCell7.ColumnIndex = 3
			Me.xrCrossTabCell7.ColumnSpan = 2
			Me.xrCrossTabCell7.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell7.Name = "xrCrossTabCell7"
			Me.xrCrossTabCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell7.RowIndex = 0
			Me.xrCrossTabCell7.Text = "Grand Total"
			Me.xrCrossTabCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell8
			' 
			Me.xrCrossTabCell8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell8.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell8.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell8.BorderWidth = 1F
			Me.xrCrossTabCell8.ColumnIndex = 3
			Me.xrCrossTabCell8.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell8.Name = "xrCrossTabCell8"
			Me.xrCrossTabCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell8.RowIndex = 2
			Me.xrCrossTabCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell9
			' 
			Me.xrCrossTabCell9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell9.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell9.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell9.BorderWidth = 1F
			Me.xrCrossTabCell9.ColumnIndex = 3
			Me.xrCrossTabCell9.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell9.Name = "xrCrossTabCell9"
			Me.xrCrossTabCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell9.RowIndex = 3
			Me.xrCrossTabCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell10
			' 
			Me.xrCrossTabCell10.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell10.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell10.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell10.BorderWidth = 1F
			Me.xrCrossTabCell10.ColumnIndex = 1
			Me.xrCrossTabCell10.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell10.Name = "xrCrossTabCell10"
			Me.xrCrossTabCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell10.RowIndex = 1
			Me.xrCrossTabCell10.Text = "Stock"
			Me.xrCrossTabCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell11
			' 
			Me.xrCrossTabCell11.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell11.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell11.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell11.BorderWidth = 1F
			Me.xrCrossTabCell11.ColumnIndex = 2
			Me.xrCrossTabCell11.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell11.Name = "xrCrossTabCell11"
			Me.xrCrossTabCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell11.RowIndex = 1
			Me.xrCrossTabCell11.Text = "Order"
			Me.xrCrossTabCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell12
			' 
			Me.xrCrossTabCell12.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell12.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell12.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell12.BorderWidth = 1F
			Me.xrCrossTabCell12.ColumnIndex = 3
			Me.xrCrossTabCell12.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell12.Name = "xrCrossTabCell12"
			Me.xrCrossTabCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell12.RowIndex = 1
			Me.xrCrossTabCell12.Text = "Stock"
			Me.xrCrossTabCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell13
			' 
			Me.xrCrossTabCell13.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell13.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell13.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell13.BorderWidth = 1F
			Me.xrCrossTabCell13.ColumnIndex = 4
			Me.xrCrossTabCell13.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell13.Name = "xrCrossTabCell13"
			Me.xrCrossTabCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell13.RowIndex = 1
			Me.xrCrossTabCell13.Text = "Order"
			Me.xrCrossTabCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell14
			' 
			Me.xrCrossTabCell14.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell14.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell14.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell14.BorderWidth = 1F
			Me.xrCrossTabCell14.ColumnIndex = 2
			Me.xrCrossTabCell14.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell14.Name = "xrCrossTabCell14"
			Me.xrCrossTabCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell14.RowIndex = 2
			Me.xrCrossTabCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell15
			' 
			Me.xrCrossTabCell15.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell15.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell15.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell15.BorderWidth = 1F
			Me.xrCrossTabCell15.ColumnIndex = 4
			Me.xrCrossTabCell15.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell15.Name = "xrCrossTabCell15"
			Me.xrCrossTabCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell15.RowIndex = 2
			Me.xrCrossTabCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell16
			' 
			Me.xrCrossTabCell16.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell16.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell16.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell16.BorderWidth = 1F
			Me.xrCrossTabCell16.ColumnIndex = 2
			Me.xrCrossTabCell16.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell16.Name = "xrCrossTabCell16"
			Me.xrCrossTabCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell16.RowIndex = 3
			Me.xrCrossTabCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell17
			' 
			Me.xrCrossTabCell17.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell17.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell17.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell17.BorderWidth = 1F
			Me.xrCrossTabCell17.ColumnIndex = 4
			Me.xrCrossTabCell17.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell17.Name = "xrCrossTabCell17"
			Me.xrCrossTabCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell17.RowIndex = 3
			Me.xrCrossTabCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.Version = "19.2"
			CType(Me.xrCrossTab1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
		Private xrCrossTab1 As DevExpress.XtraReports.UI.XRCrossTab
		Private xrCrossTabCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell10 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell11 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell12 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell13 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell14 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell15 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell16 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell17 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
	End Class
End Namespace

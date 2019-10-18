namespace WebApplication1 {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
            DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column2 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression2 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column3 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression3 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column4 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression4 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column5 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression5 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column6 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression6 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column7 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression7 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column8 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression8 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column9 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression9 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Column column10 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression10 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table2 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Column column11 = new DevExpress.DataAccess.Sql.Column();
            DevExpress.DataAccess.Sql.ColumnExpression columnExpression11 = new DevExpress.DataAccess.Sql.ColumnExpression();
            DevExpress.DataAccess.Sql.Table table3 = new DevExpress.DataAccess.Sql.Table();
            DevExpress.DataAccess.Sql.Join join1 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            DevExpress.DataAccess.Sql.Join join2 = new DevExpress.DataAccess.Sql.Join();
            DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo2 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraReport1));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.fieldProductID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldProductName1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldSupplierID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCategoryID1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldQuantityPerUnit1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldUnitPrice1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldUnitsInStock1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldUnitsOnOrder1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldReorderLevel1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDiscontinued1 = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataMember = "Products";
            this.xrPivotGrid1.DataSource = this.sqlDataSource1;
            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldProductID1,
            this.fieldProductName1,
            this.fieldSupplierID1,
            this.fieldCategoryID1,
            this.fieldQuantityPerUnit1,
            this.fieldUnitPrice1,
            this.fieldUnitsInStock1,
            this.fieldUnitsOnOrder1,
            this.fieldReorderLevel1,
            this.fieldDiscontinued1});
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(650F, 90F);
            this.xrPivotGrid1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPivotGrid1_BeforePrint);
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "NorthwindConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            columnExpression1.ColumnName = "ProductID";
            table1.MetaSerializable = "<Meta X=\"30\" Y=\"30\" Width=\"125\" Height=\"267\" />";
            table1.Name = "Products";
            columnExpression1.Table = table1;
            column1.Expression = columnExpression1;
            columnExpression2.ColumnName = "ProductName";
            columnExpression2.Table = table1;
            column2.Expression = columnExpression2;
            columnExpression3.ColumnName = "QuantityPerUnit";
            columnExpression3.Table = table1;
            column3.Expression = columnExpression3;
            columnExpression4.ColumnName = "UnitPrice";
            columnExpression4.Table = table1;
            column4.Expression = columnExpression4;
            columnExpression5.ColumnName = "UnitsInStock";
            columnExpression5.Table = table1;
            column5.Expression = columnExpression5;
            columnExpression6.ColumnName = "UnitsOnOrder";
            columnExpression6.Table = table1;
            column6.Expression = columnExpression6;
            columnExpression7.ColumnName = "ReorderLevel";
            columnExpression7.Table = table1;
            column7.Expression = columnExpression7;
            columnExpression8.ColumnName = "Discontinued";
            columnExpression8.Table = table1;
            column8.Expression = columnExpression8;
            columnExpression9.ColumnName = "EAN13";
            columnExpression9.Table = table1;
            column9.Expression = columnExpression9;
            column10.Alias = "SupplierID";
            columnExpression10.ColumnName = "ContactName";
            table2.MetaSerializable = "<Meta X=\"185\" Y=\"30\" Width=\"125\" Height=\"286\" />";
            table2.Name = "Suppliers";
            columnExpression10.Table = table2;
            column10.Expression = columnExpression10;
            column11.Alias = "CategoryID";
            columnExpression11.ColumnName = "CategoryName";
            table3.MetaSerializable = "<Meta X=\"340\" Y=\"30\" Width=\"125\" Height=\"134\" />";
            table3.Name = "Categories";
            columnExpression11.Table = table3;
            column11.Expression = columnExpression11;
            selectQuery1.Columns.Add(column1);
            selectQuery1.Columns.Add(column2);
            selectQuery1.Columns.Add(column3);
            selectQuery1.Columns.Add(column4);
            selectQuery1.Columns.Add(column5);
            selectQuery1.Columns.Add(column6);
            selectQuery1.Columns.Add(column7);
            selectQuery1.Columns.Add(column8);
            selectQuery1.Columns.Add(column9);
            selectQuery1.Columns.Add(column10);
            selectQuery1.Columns.Add(column11);
            selectQuery1.Name = "Products";
            relationColumnInfo1.NestedKeyColumn = "SupplierID";
            relationColumnInfo1.ParentKeyColumn = "SupplierID";
            join1.KeyColumns.Add(relationColumnInfo1);
            join1.Nested = table2;
            join1.Parent = table1;
            relationColumnInfo2.NestedKeyColumn = "CategoryID";
            relationColumnInfo2.ParentKeyColumn = "CategoryID";
            join2.KeyColumns.Add(relationColumnInfo2);
            join2.Nested = table3;
            join2.Parent = table1;
            selectQuery1.Relations.Add(join1);
            selectQuery1.Relations.Add(join2);
            selectQuery1.Tables.Add(table1);
            selectQuery1.Tables.Add(table2);
            selectQuery1.Tables.Add(table3);
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // fieldProductID1
            // 
            this.fieldProductID1.AreaIndex = 0;
            this.fieldProductID1.FieldName = "ProductID";
            this.fieldProductID1.Name = "fieldProductID1";
            // 
            // fieldProductName1
            // 
            this.fieldProductName1.AreaIndex = 1;
            this.fieldProductName1.FieldName = "ProductName";
            this.fieldProductName1.Name = "fieldProductName1";
            // 
            // fieldSupplierID1
            // 
            this.fieldSupplierID1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldSupplierID1.AreaIndex = 0;
            this.fieldSupplierID1.FieldName = "SupplierID";
            this.fieldSupplierID1.Name = "fieldSupplierID1";
            // 
            // fieldCategoryID1
            // 
            this.fieldCategoryID1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCategoryID1.AreaIndex = 0;
            this.fieldCategoryID1.FieldName = "CategoryID";
            this.fieldCategoryID1.Name = "fieldCategoryID1";
            // 
            // fieldQuantityPerUnit1
            // 
            this.fieldQuantityPerUnit1.AreaIndex = 2;
            this.fieldQuantityPerUnit1.FieldName = "QuantityPerUnit";
            this.fieldQuantityPerUnit1.Name = "fieldQuantityPerUnit1";
            // 
            // fieldUnitPrice1
            // 
            this.fieldUnitPrice1.AreaIndex = 3;
            this.fieldUnitPrice1.FieldName = "UnitPrice";
            this.fieldUnitPrice1.Name = "fieldUnitPrice1";
            // 
            // fieldUnitsInStock1
            // 
            this.fieldUnitsInStock1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitsInStock1.AreaIndex = 0;
            this.fieldUnitsInStock1.Caption = "Stock";
            this.fieldUnitsInStock1.FieldName = "UnitsInStock";
            this.fieldUnitsInStock1.Name = "fieldUnitsInStock1";
            // 
            // fieldUnitsOnOrder1
            // 
            this.fieldUnitsOnOrder1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldUnitsOnOrder1.AreaIndex = 1;
            this.fieldUnitsOnOrder1.Caption = "Order";
            this.fieldUnitsOnOrder1.FieldName = "UnitsOnOrder";
            this.fieldUnitsOnOrder1.Name = "fieldUnitsOnOrder1";
            // 
            // fieldReorderLevel1
            // 
            this.fieldReorderLevel1.AreaIndex = 4;
            this.fieldReorderLevel1.FieldName = "ReorderLevel";
            this.fieldReorderLevel1.Name = "fieldReorderLevel1";
            // 
            // fieldDiscontinued1
            // 
            this.fieldDiscontinued1.AreaIndex = 5;
            this.fieldDiscontinued1.FieldName = "Discontinued";
            this.fieldDiscontinued1.Name = "fieldDiscontinued1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.ReportHeader.HeightF = 90F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.Version = "18.2";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldProductID1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldProductName1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldSupplierID1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCategoryID1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldQuantityPerUnit1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldUnitPrice1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldUnitsInStock1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldUnitsOnOrder1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldReorderLevel1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDiscontinued1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
    }
}

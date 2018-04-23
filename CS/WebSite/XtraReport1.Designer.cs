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
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.dataSet11 = new WebApplication1.DataSet1();
            this.productsTableAdapter = new WebApplication1.DataSet1TableAdapters.ProductsTableAdapter();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
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
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataAdapter = this.productsTableAdapter;
            this.xrPivotGrid1.DataMember = "Products";
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
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(640F, 90F);
            this.xrPivotGrid1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrPivotGrid1_BeforePrint);
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.ReportHeader.HeightF = 90F;
            this.ReportHeader.Name = "ReportHeader";
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
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataAdapter = this.productsTableAdapter;
            this.DataMember = "Products";
            this.DataSource = this.dataSet11;
            this.Version = "12.2";
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DataSet1 dataSet11;
        private DataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
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
    }
}

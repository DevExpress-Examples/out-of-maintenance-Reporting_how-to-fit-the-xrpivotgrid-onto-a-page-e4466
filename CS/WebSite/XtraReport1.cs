using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace WebApplication1 {
    public partial class XtraReport1: DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
        }

        private void xrLabel1_HtmlItemCreated(object sender, HtmlEventArgs e)
        {
        }

        private void xrPivotGrid1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            xrPivotGrid1.BestFit();
        }

    }
}

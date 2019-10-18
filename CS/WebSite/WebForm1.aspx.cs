using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.XtraReports.Web;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;

namespace WebApplication1 {
    public partial class WebForm1 : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            report.AfterPrint += Report_AfterPrint;
            ASPxWebDocumentViewer1.OpenReport(report);

        }
        private void Report_AfterPrint(object sender, EventArgs e) {
            XtraReport report = sender as XtraReport;
            report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
        }
    }
}

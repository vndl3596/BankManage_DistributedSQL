using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNH_PhanTan.Report
{
    public partial class DSTK : DevExpress.XtraReports.UI.XtraReport
    {
        public DSTK(DateTime dateFrom, DateTime dateTo, Boolean toanBo)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value =dateFrom;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = dateTo;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = toanBo;
        }

    }
}

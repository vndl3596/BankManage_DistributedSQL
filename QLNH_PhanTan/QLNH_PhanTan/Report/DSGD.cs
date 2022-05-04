using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLNH_PhanTan.Report
{
    public partial class DSGD : DevExpress.XtraReports.UI.XtraReport
    {
        public DSGD(String soTK, DateTime dateFrom, DateTime dateTo)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = soTK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = dateFrom;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = dateTo;

        }

    }
}

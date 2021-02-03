﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Chart;
using DataDynamics.ActiveReports.Design;
using DataDynamics.ActiveReports.Chart.Graphics;
using Epoint.Systems.Data;
using System.Drawing.Printing;

namespace Epoint.Controller
{
    public partial class rptReportChart : DataDynamics.ActiveReports.ActiveReport3
    {
        private DataTable dtDoanhThu;
        private string strColumnName;
        private string strColumnNum;
        public float fHeight = 0f;
        public float fWidth = 0f;
        public rptReportChart()
        {
            InitializeComponent();
        }
        public void Load(DataTable dtDoanhThu,string strColumnName, string  strColumnNum)
        {
            this.fHeight = 700f;
            this.fWidth = 600f;
            this.dtDoanhThu = dtDoanhThu;
            this.strColumnNum = strColumnNum;
            this.strColumnName = strColumnName;
            this.SetPrintSize();
            this.LoadChart();
        }

        private void LoadChart()
        {
            Series series = this.chartControl1.Series[0];
            object obj2 = this.dtDoanhThu.Compute("SUM(" + this.strColumnNum + ")", "");
            double numSum = (obj2 == DBNull.Value) ? 0.0 : Convert.ToDouble(obj2);
            foreach (DataRow row in this.dtDoanhThu.Rows)
            {
                double num2 = Convert.ToDouble(row[this.strColumnNum]);
                //string num2Format = Common.FormatNumToString(num2.ToString(), "0", ".");
                string strColumn = this.strColumnName;
                DataDynamics.ActiveReports.Chart.
                DataPoint point = new DataPoint("X", new DoubleArray(new double[] { num2 }), false, true, (string)row[strColumn]);
                series.Points.Add(point);
                Font font = new Font("Arial", 8f);
                Backdrop backdrop = new Backdrop();

                DataDynamics.ActiveReports.Chart.Graphics.Line line = new DataDynamics.ActiveReports.Chart.Graphics.Line();
                Backdrop backdrop2 = new Backdrop();
                DataDynamics.ActiveReports.Chart.Graphics.Line border = new DataDynamics.ActiveReports.Chart.Graphics.Line();
                double numPercent = num2 / numSum;
                Marker marker = new Marker(8, MarkerStyle.Triangle, backdrop, line, new LabelInfo(border, backdrop2, new FontInfo(Color.Black, font),row["Ma_Vt"] + " : " + numPercent.ToString("#,###.##%"), Alignment.Bottom));
                point.Marker = marker;
            }
        }

        private void SetPrintSize()
        {
            float num = 100f;
            this.chartControl1.Height = (this.fHeight / num) - 0.3f;
            this.chartControl1.Width = (this.fWidth / num) - 0.3f;
            this.pageHeader.Height = (this.fHeight / num) - 0.3f;
            this.PageSettings.PaperHeight = (this.fHeight / num) - 0.2f;
            this.PageSettings.PaperKind = PaperKind.Custom;
            this.PageSettings.PaperName = "Custom paper";
            this.PageSettings.PaperWidth = (this.fWidth / num) - 0.22f;
            this.PrintWidth = (this.fWidth / num) - 0.22f;
        }

    }
}

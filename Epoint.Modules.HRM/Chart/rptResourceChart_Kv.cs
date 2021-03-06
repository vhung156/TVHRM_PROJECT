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

namespace Epoint.Modules.HRM
{
    public partial class rptResourceChart_Kv : DataDynamics.ActiveReports.ActiveReport3
    {
        private DataTable dtDataResource;
        private string strColumnName;
        private string strColumnNum;
        public float fHeight = 0f;
        public float fWidth = 0f;
        public rptResourceChart_Kv()
        {
            InitializeComponent();
        }
        public void Load(DataTable dtData,string strColumnName, string  strColumnNum)
        {
            this.fHeight = 500f;
            this.fWidth = 600f;
            
            this.dtDataResource = dtData;
            this.strColumnNum = strColumnNum;
            this.strColumnName = strColumnName;
            this.SetPrintSize();
            this.LoadChart(dtData);
        }
        public void Load2(DataTable dtData, string strColumnName, string strColumnNum)
        {
            this.fHeight = 500f;
            this.fWidth = 600f;

            this.dtDataResource = dtData;
            this.strColumnNum = strColumnNum;
            this.strColumnName = strColumnName;
            this.SetPrintSize();
            this.LoadChart(dtData);
        }

        private void LoadChart(DataTable dtHuMan)
        {

           /* //Load char tang giam nhan sự
            Series series1 = this.chartControlHR.Series[0];
            
            series1.Type = DataDynamics.ActiveReports.Chart.ChartType.StackedBar3D;
            series1.Properties = new DataDynamics.ActiveReports.Chart.CustomProperties(new DataDynamics.ActiveReports.Chart.KeyValuePair[] {
            new DataDynamics.ActiveReports.Chart.KeyValuePair("BarType", DataDynamics.ActiveReports.Chart.BarType.Bar),
            new DataDynamics.ActiveReports.Chart.KeyValuePair("HoleSize", 0.3F),
            new DataDynamics.ActiveReports.Chart.KeyValuePair("Radius", 1F)});
            object obj2 = this.dtDataResource.Compute("SUM(" + this.strColumnNum + ")", "");
            double numSum = (obj2 == DBNull.Value) ? 0.0 : Convert.ToDouble(obj2);
            foreach (DataRow row in this.dtDataResource.Rows)
            {
                double num2 = Convert.ToDouble(row[this.strColumnNum]);
                //string num2Format = Common.FormatNumToString(num2.ToString(), "0", ".");
                string strColumn = this.strColumnName;
                DataDynamics.ActiveReports.Chart.DataPoint point = new DataPoint("X", new DoubleArray(new double[] { num2 }), false, true, (string)row[strColumn]);
                
                series1.Points.Add(point);
                Font font = new Font("Arial", 8f);
                Backdrop backdrop = new Backdrop();

                DataDynamics.ActiveReports.Chart.Graphics.Line line = new DataDynamics.ActiveReports.Chart.Graphics.Line();
                Backdrop backdrop2 = new Backdrop();
                DataDynamics.ActiveReports.Chart.Graphics.Line border = new DataDynamics.ActiveReports.Chart.Graphics.Line();
                double numPercent = num2 / numSum;
                Marker marker = new Marker(8, MarkerStyle.Square, backdrop, line, new LabelInfo(border, backdrop2, new FontInfo(Color.Black, font), num2.ToString("#,###"), Alignment.Top));
                point.Marker = marker;
            }
            */


            //Load chart danh giá nhân sự

            //DataTable dtHuMan = SQLExec.ExecuteReturnDt("EXEC sp_HRM_GetHumanValue 'KHUVUC'");
            Series series2 = this.chartControl1.Series[0];


            object obj22 = dtHuMan.Compute("SUM(Value)", "");
            double numSum2 = (obj22 == DBNull.Value) ? 0.0 : Convert.ToDouble(obj22);
            series2.Points.Clear();
            foreach (DataRow row in dtHuMan.Rows)
            {
                double num2 = Convert.ToDouble(row["Value"]);
                double numPercent = num2 / numSum2;
                //string num2Format = Common.FormatNumToString(num2.ToString(), "0", ".");
                string strColumn = "ID";
                DataDynamics.ActiveReports.Chart.DataPoint point = new DataPoint("X", new DoubleArray(new double[] { num2 }), false, true, (string)row[strColumn]);

                series2.Points.Add(point);
                Font font = new Font("Arial", 8f);
                Backdrop backdrop = new Backdrop();

                DataDynamics.ActiveReports.Chart.Graphics.Line line = new DataDynamics.ActiveReports.Chart.Graphics.Line();
                Backdrop backdrop2 = new Backdrop();
                DataDynamics.ActiveReports.Chart.Graphics.Line border = new DataDynamics.ActiveReports.Chart.Graphics.Line();
               
                Marker marker = new Marker(8, MarkerStyle.Square, backdrop, line, new LabelInfo(border, backdrop2, new FontInfo(Color.Black, font), row[strColumn] + " : " + num2.ToString(), Alignment.Top));
                point.Marker = marker;
            }


        }
        private void LoadChart2(DataTable dtHuMan)
        {
            //this.chartControlHR.Series.Clear();
            //this.chartControlHR.Series.Add(new Series );
            //DataTable dtHuMan = SQLExec.ExecuteReturnDt("EXEC sp_HRM_GetHumanValue 'KHUVUC'");
            Series series2 = this.chartControlHR.Series[0];


            object obj22 = dtHuMan.Compute("SUM(Value)", "");
            double numSum2 = (obj22 == DBNull.Value) ? 0.0 : Convert.ToDouble(obj22);
            series2.Points.Clear();
            foreach (DataRow row in dtHuMan.Rows)
            {
                double num2 = Convert.ToDouble(row["Value"]);
                double numPercent = num2 / numSum2;
                //string num2Format = Common.FormatNumToString(num2.ToString(), "0", ".");
                string strColumn = "ID";
                DataDynamics.ActiveReports.Chart.DataPoint point = new DataPoint("X", new DoubleArray(new double[] { num2 }), false, true, (string)row[strColumn]);

                series2.Points.Add(point);
                Font font = new Font("Arial", 8f);
                Backdrop backdrop = new Backdrop();

                DataDynamics.ActiveReports.Chart.Graphics.Line line = new DataDynamics.ActiveReports.Chart.Graphics.Line();
                Backdrop backdrop2 = new Backdrop();
                DataDynamics.ActiveReports.Chart.Graphics.Line border = new DataDynamics.ActiveReports.Chart.Graphics.Line();

                Marker marker = new Marker(8, MarkerStyle.Square, backdrop, line, new LabelInfo(border, backdrop2, new FontInfo(Color.Black, font), row[strColumn] + " : " + num2.ToString(), Alignment.Top));
                point.Marker = marker;
            }


        }
        private void SetPrintSize()
        {
            float num = 100f;
            //this.chartControl1.Height = (this.fHeight / num) - 0.3f;
            //this.chartControl1.Width = (this.fWidth / num) - 0.3f;

            //this.chartControl2.Height = (this.fHeight / num) - 0.3f;
            //this.chartControl2.Width = (this.fWidth / num) - 0.3f;

            //this.pageHeader.Height = (this.fHeight / num) - 0.3f;
            //this.PageSettings.PaperHeight = (this.fHeight / num) - 0.2f;
            //this.PageSettings.PaperKind = PaperKind.Custom;
            //this.PageSettings.PaperName = "Printer Default";
            //this.PageSettings.PaperWidth = (this.fWidth / num) - 0.22f;
            //this.PrintWidth = (this.fWidth / num) - 0.22f;
        }

    }
}

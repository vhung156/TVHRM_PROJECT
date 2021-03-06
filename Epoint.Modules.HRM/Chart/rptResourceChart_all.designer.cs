﻿using System.Resources;
using DataDynamics.ActiveReports.Chart;
using DataDynamics.ActiveReports;
using System.Data;
using System.Drawing;
using DataDynamics.ActiveReports.Chart.Graphics;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using DDCssLib;
namespace Epoint.Modules.HRM
{
    partial class rptResourceChart_all
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
               
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataDynamics.ActiveReports.Chart.ChartArea chartArea1 = new DataDynamics.ActiveReports.Chart.ChartArea();
            DataDynamics.ActiveReports.Chart.Axis axis1 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis2 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis3 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis4 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis5 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Legend legend1 = new DataDynamics.ActiveReports.Chart.Legend();
            DataDynamics.ActiveReports.Chart.Title title1 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.Title title2 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.Series series1 = new DataDynamics.ActiveReports.Chart.Series();
            DataDynamics.ActiveReports.Chart.Title title3 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.Title title4 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.ChartArea chartArea2 = new DataDynamics.ActiveReports.Chart.ChartArea();
            DataDynamics.ActiveReports.Chart.Axis axis6 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis7 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis8 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis9 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Axis axis10 = new DataDynamics.ActiveReports.Chart.Axis();
            DataDynamics.ActiveReports.Chart.Legend legend2 = new DataDynamics.ActiveReports.Chart.Legend();
            DataDynamics.ActiveReports.Chart.Title title5 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.Title title6 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.Series series2 = new DataDynamics.ActiveReports.Chart.Series();
            DataDynamics.ActiveReports.Chart.Title title7 = new DataDynamics.ActiveReports.Chart.Title();
            DataDynamics.ActiveReports.Chart.Title title8 = new DataDynamics.ActiveReports.Chart.Title();
            this.pageHeader = new DataDynamics.ActiveReports.PageHeader();
            this.chartControl2 = new DataDynamics.ActiveReports.ChartControl();
            this.chartControl1 = new DataDynamics.ActiveReports.ChartControl();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.pageFooter = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // pageHeader
            // 
            this.pageHeader.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.chartControl2,
            this.chartControl1});
            this.pageHeader.Height = 5.041667F;
            this.pageHeader.Name = "pageHeader";
            // 
            // chartControl2
            // 
            this.chartControl2.AutoRefresh = true;
            this.chartControl2.Backdrop = new DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.SteelBlue);
            this.chartControl2.Border.BottomColor = System.Drawing.Color.Black;
            this.chartControl2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.chartControl2.Border.LeftColor = System.Drawing.Color.Black;
            this.chartControl2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.chartControl2.Border.RightColor = System.Drawing.Color.Black;
            this.chartControl2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.chartControl2.Border.TopColor = System.Drawing.Color.Black;
            this.chartControl2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            chartArea1.AntiAliasMode = DataDynamics.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics;
            axis1.AxisType = DataDynamics.ActiveReports.Chart.AxisType.Categorical;
            axis1.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis1.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 1D, 0F, false);
            axis1.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis1.Title = "Axis X";
            axis1.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis2.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis2.LabelsGap = 0;
            axis2.LabelsVisible = false;
            axis2.Line = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None);
            axis2.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis2.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis2.Position = 0D;
            axis2.TickOffset = 0D;
            axis2.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis2.Visible = false;
            axis3.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis3.LabelsVisible = false;
            axis3.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis3.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis3.Position = 0D;
            axis3.Title = "Axis Y";
            axis3.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F), -90F);
            axis4.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis4.LabelsVisible = false;
            axis4.Line = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None);
            axis4.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis4.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis4.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis4.Visible = false;
            axis5.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis5.LabelsGap = 0;
            axis5.LabelsVisible = false;
            axis5.Line = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None);
            axis5.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis5.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis5.Position = 0D;
            axis5.TickOffset = 0D;
            axis5.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis5.Visible = false;
            chartArea1.Axes.AddRange(new DataDynamics.ActiveReports.Chart.AxisBase[] {
            axis1,
            axis2,
            axis3,
            axis4,
            axis5});
            chartArea1.Backdrop = new DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
            chartArea1.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            chartArea1.Light = new DataDynamics.ActiveReports.Chart.Light(new DataDynamics.ActiveReports.Chart.Graphics.Point3d(10F, 40F, 20F), DataDynamics.ActiveReports.Chart.LightType.InfiniteDirectional, 0.3F);
            chartArea1.Name = "defaultArea";
            chartArea1.Projection = new DataDynamics.ActiveReports.Chart.Projection(DataDynamics.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.1F, 0.1F, 0F, 37F);
            this.chartControl2.ChartAreas.AddRange(new DataDynamics.ActiveReports.Chart.ChartArea[] {
            chartArea1});
            this.chartControl2.ChartBorder = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            this.chartControl2.Height = 4.875F;
            this.chartControl2.Left = 0.0625F;
            legend1.Alignment = DataDynamics.ActiveReports.Chart.Alignment.Bottom;
            legend1.Backdrop = new DataDynamics.ActiveReports.Chart.BackdropItem(System.Drawing.Color.White, ((byte)(128)));
            legend1.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(), 0, System.Drawing.Color.Black);
            legend1.DockArea = chartArea1;
            title1.Backdrop = new DataDynamics.ActiveReports.Chart.Graphics.Backdrop(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
            title1.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            title1.DockArea = null;
            title1.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title1.Name = "";
            title1.Text = "";
            title1.Visible = false;
            legend1.Footer = title1;
            legend1.GridLayout = new DataDynamics.ActiveReports.Chart.GridLayout(2, 4);
            title2.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 2), 0, System.Drawing.Color.Black);
            title2.DockArea = null;
            title2.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title2.Name = "";
            title2.Text = "Legend";
            title2.Visible = false;
            legend1.Header = title2;
            legend1.LabelsFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            legend1.Name = "defaultLegend";
            this.chartControl2.Legends.AddRange(new DataDynamics.ActiveReports.Chart.Legend[] {
            legend1});
            this.chartControl2.Name = "chartControl2";
            series1.AxisX = axis1;
            series1.AxisY = axis3;
            series1.ChartArea = chartArea1;
            series1.ColorPalette = DataDynamics.ActiveReports.Chart.ColorPalette.Default;
            series1.Legend = legend1;
            series1.LegendText = "";
            series1.Name = "Series1";
            series1.Properties = new DataDynamics.ActiveReports.Chart.CustomProperties(new DataDynamics.ActiveReports.Chart.KeyValuePair[] {
            new DataDynamics.ActiveReports.Chart.KeyValuePair("HoleSize", 0F),
            new DataDynamics.ActiveReports.Chart.KeyValuePair("Marker", new DataDynamics.ActiveReports.Chart.Marker(7, DataDynamics.ActiveReports.Chart.MarkerStyle.Triangle, new DataDynamics.ActiveReports.Chart.Graphics.Backdrop(), new DataDynamics.ActiveReports.Chart.Graphics.Line(), new DataDynamics.ActiveReports.Chart.LabelInfo(new DataDynamics.ActiveReports.Chart.Graphics.Line(), new DataDynamics.ActiveReports.Chart.Graphics.Backdrop(), new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Arial", 8F)), "{Value}", DataDynamics.ActiveReports.Chart.Alignment.Bottom))),
            new DataDynamics.ActiveReports.Chart.KeyValuePair("BarType", DataDynamics.ActiveReports.Chart.BarType.Bar)});
            series1.Type = DataDynamics.ActiveReports.Chart.ChartType.Doughnut3D;
            series1.ValueMembersY = null;
            series1.ValueMemberX = null;
            this.chartControl2.Series.AddRange(new DataDynamics.ActiveReports.Chart.Series[] {
            series1});
            title3.Alignment = DataDynamics.ActiveReports.Chart.Alignment.Center;
            title3.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            title3.DockArea = null;
            title3.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title3.Name = "header";
            title3.Text = "Chart title";
            title3.Visible = false;
            title4.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            title4.DockArea = null;
            title4.Docking = DataDynamics.ActiveReports.Chart.DockType.Bottom;
            title4.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title4.Name = "footer";
            title4.Text = "Chart Footer";
            title4.Visible = false;
            this.chartControl2.Titles.AddRange(new DataDynamics.ActiveReports.Chart.Title[] {
            title3,
            title4});
            this.chartControl2.Top = 0.125F;
            this.chartControl2.UIOptions = DataDynamics.ActiveReports.Chart.UIOptions.ForceHitTesting;
            this.chartControl2.Width = 4.625F;
            // 
            // chartControl1
            // 
            this.chartControl1.AutoRefresh = true;
            this.chartControl1.Backdrop = new DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Color.White, System.Drawing.Color.SteelBlue);
            this.chartControl1.Border.BottomColor = System.Drawing.Color.Black;
            this.chartControl1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.chartControl1.Border.LeftColor = System.Drawing.Color.Black;
            this.chartControl1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.chartControl1.Border.RightColor = System.Drawing.Color.Black;
            this.chartControl1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.chartControl1.Border.TopColor = System.Drawing.Color.Black;
            this.chartControl1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            chartArea2.AntiAliasMode = DataDynamics.ActiveReports.Chart.Graphics.AntiAliasMode.Graphics;
            axis6.AxisType = DataDynamics.ActiveReports.Chart.AxisType.Categorical;
            axis6.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis6.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 1D, 0F, false);
            axis6.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis6.Title = "Axis X";
            axis6.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis7.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis7.LabelsGap = 0;
            axis7.LabelsVisible = false;
            axis7.Line = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None);
            axis7.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis7.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis7.Position = 0D;
            axis7.TickOffset = 0D;
            axis7.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis7.Visible = false;
            axis8.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis8.LabelsVisible = false;
            axis8.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis8.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis8.Position = 0D;
            axis8.Title = "Axis Y";
            axis8.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F), -90F);
            axis9.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis9.LabelsVisible = false;
            axis9.Line = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None);
            axis9.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis9.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis9.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis9.Visible = false;
            axis10.LabelFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis10.LabelsGap = 0;
            axis10.LabelsVisible = false;
            axis10.Line = new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None);
            axis10.MajorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis10.MinorTick = new DataDynamics.ActiveReports.Chart.Tick(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0D, 0F, false);
            axis10.Position = 0D;
            axis10.TickOffset = 0D;
            axis10.TitleFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            axis10.Visible = false;
            chartArea2.Axes.AddRange(new DataDynamics.ActiveReports.Chart.AxisBase[] {
            axis6,
            axis7,
            axis8,
            axis9,
            axis10});
            chartArea2.Backdrop = new DataDynamics.ActiveReports.Chart.BackdropItem(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
            chartArea2.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            chartArea2.Light = new DataDynamics.ActiveReports.Chart.Light(new DataDynamics.ActiveReports.Chart.Graphics.Point3d(10F, 40F, 20F), DataDynamics.ActiveReports.Chart.LightType.InfiniteDirectional, 0.3F);
            chartArea2.Name = "defaultArea";
            chartArea2.Projection = new DataDynamics.ActiveReports.Chart.Projection(DataDynamics.ActiveReports.Chart.Graphics.ProjectionType.Orthogonal, 0.1F, 0.1F);
            this.chartControl1.ChartAreas.AddRange(new DataDynamics.ActiveReports.Chart.ChartArea[] {
            chartArea2});
            this.chartControl1.ChartBorder = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            this.chartControl1.Height = 4.875F;
            this.chartControl1.Left = 4.8125F;
            legend2.Alignment = DataDynamics.ActiveReports.Chart.Alignment.Bottom;
            legend2.Backdrop = new DataDynamics.ActiveReports.Chart.BackdropItem(System.Drawing.Color.White, ((byte)(128)));
            legend2.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(), 0, System.Drawing.Color.Black);
            legend2.DockArea = chartArea2;
            title5.Backdrop = new DataDynamics.ActiveReports.Chart.Graphics.Backdrop(DataDynamics.ActiveReports.Chart.Graphics.BackdropStyle.Transparent, System.Drawing.Color.White, System.Drawing.Color.White, DataDynamics.ActiveReports.Chart.Graphics.GradientType.Vertical, System.Drawing.Drawing2D.HatchStyle.DottedGrid, null, DataDynamics.ActiveReports.Chart.Graphics.PicturePutStyle.Stretched);
            title5.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            title5.DockArea = null;
            title5.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title5.Name = "";
            title5.Text = "Tháng ";
            title5.Visible = false;
            legend2.Footer = title5;
            legend2.GridLayout = new DataDynamics.ActiveReports.Chart.GridLayout(2, 4);
            title6.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.White, 2), 0, System.Drawing.Color.Black);
            title6.DockArea = null;
            title6.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title6.Name = "";
            title6.Text = "Legend";
            title6.Visible = false;
            legend2.Header = title6;
            legend2.LabelsFont = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            legend2.Name = "defaultLegend";
            this.chartControl1.Legends.AddRange(new DataDynamics.ActiveReports.Chart.Legend[] {
            legend2});
            this.chartControl1.Name = "chartControl1";
            series2.AxisX = axis6;
            series2.AxisY = axis8;
            series2.ChartArea = chartArea2;
            series2.ColorPalette = DataDynamics.ActiveReports.Chart.ColorPalette.Default;
            series2.Legend = legend2;
            series2.LegendText = "";
            series2.Name = "Series1";
            series2.Properties = new DataDynamics.ActiveReports.Chart.CustomProperties(new DataDynamics.ActiveReports.Chart.KeyValuePair[] {
            new DataDynamics.ActiveReports.Chart.KeyValuePair("HoleSize", 0F),
            new DataDynamics.ActiveReports.Chart.KeyValuePair("Marker", new DataDynamics.ActiveReports.Chart.Marker(7, DataDynamics.ActiveReports.Chart.MarkerStyle.Triangle, new DataDynamics.ActiveReports.Chart.Graphics.Backdrop(), new DataDynamics.ActiveReports.Chart.Graphics.Line(), new DataDynamics.ActiveReports.Chart.LabelInfo(new DataDynamics.ActiveReports.Chart.Graphics.Line(), new DataDynamics.ActiveReports.Chart.Graphics.Backdrop(), new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Arial", 8F)), "{Value}", DataDynamics.ActiveReports.Chart.Alignment.Bottom))),
            new DataDynamics.ActiveReports.Chart.KeyValuePair("BarType", DataDynamics.ActiveReports.Chart.BarType.Bar)});
            series2.Type = DataDynamics.ActiveReports.Chart.ChartType.Bar3D;
            series2.ValueMembersY = null;
            series2.ValueMemberX = null;
            this.chartControl1.Series.AddRange(new DataDynamics.ActiveReports.Chart.Series[] {
            series2});
            title7.Alignment = DataDynamics.ActiveReports.Chart.Alignment.Center;
            title7.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            title7.DockArea = null;
            title7.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title7.Name = "header";
            title7.Text = "BIỂU ĐỒ PHÂN TÍCH NHÂN SỰ;";
            title7.Visible = false;
            title8.Border = new DataDynamics.ActiveReports.Chart.Border(new DataDynamics.ActiveReports.Chart.Graphics.Line(System.Drawing.Color.Transparent, 0, DataDynamics.ActiveReports.Chart.Graphics.LineStyle.None), 0, System.Drawing.Color.Black);
            title8.DockArea = null;
            title8.Docking = DataDynamics.ActiveReports.Chart.DockType.Bottom;
            title8.Font = new DataDynamics.ActiveReports.Chart.FontInfo(System.Drawing.Color.Black, new System.Drawing.Font("Microsoft Sans Serif", 8F));
            title8.Name = "footer";
            title8.Text = "Chart Footer";
            title8.Visible = false;
            this.chartControl1.Titles.AddRange(new DataDynamics.ActiveReports.Chart.Title[] {
            title7,
            title8});
            this.chartControl1.Top = 0.125F;
            this.chartControl1.UIOptions = DataDynamics.ActiveReports.Chart.UIOptions.ForceHitTesting;
            this.chartControl1.Width = 4.9375F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Height = 0F;
            this.detail.Name = "detail";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = 0F;
            this.pageFooter.Name = "pageFooter";
            // 
            // rptResourceChart_all
            // 
            this.PageSettings.Margins.Bottom = 0F;
            this.PageSettings.Margins.Left = 0F;
            this.PageSettings.Margins.Right = 0F;
            this.PageSettings.Margins.Top = 0F;
            this.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape;
            this.PageSettings.PaperHeight = 11.69291F;
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.PageSettings.PaperWidth = 4F;
            this.PrintWidth = 9.8125F;
            this.Sections.Add(this.pageHeader);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.pageFooter);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
            "l; font-size: 10pt; color: Black; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
            "lic; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"));
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        private ChartControl chartControl1;
        private Detail detail;
        
        private PageFooter pageFooter;
        private PageHeader pageHeader;



 


        #endregion
        private ChartControl chartControl2;
    }
}

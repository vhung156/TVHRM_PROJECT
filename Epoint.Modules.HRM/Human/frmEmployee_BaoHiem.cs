﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Epoint.Systems;
using Epoint.Lists;
using Epoint.Controllers;
using Epoint.Systems.Data;
using Epoint.Systems.Commons;
using Epoint.Systems.Controls;
using Epoint.Systems.Customizes;
using Epoint.Systems.Librarys;
using Epoint.Systems.Elements;

namespace Epoint.Modules.HRM
{
	public partial class frmEmployee_BaoHiem : Epoint.Lists.frmView
	{
		#region Khai bao bien
		private tlControl tlDmCbNv = new tlControl();

		DataTable dtEmployee;	
        DataTable dtBHXH;
        DataTable dtBHYT;
        DataTable dtTyLe;
        DataTable dtTroCap;
        

		BindingSource bdsEmployee = new BindingSource();		
        BindingSource bdsBHXH = new BindingSource();
        BindingSource bdsBHYT = new BindingSource();
        BindingSource bdsTyLe = new BindingSource();        
        BindingSource bdsTroCap = new BindingSource();
        

		private DataRow drCurrent;

		#endregion

		#region Contructor

		public frmEmployee_BaoHiem()
		{
			InitializeComponent();

			bdsEmployee.PositionChanged += new EventHandler(bdsEmployee_PositionChanged);            
		}
		public override void Load()
		{
			this.Build();
			this.FillData(string.Empty);
			this.BindingData();
			this.BindingLanguage();

			this.Show();
		}

		#endregion

		#region Build, FillData

		private void Build()
		{
            //tlDmCbNv.KeyFieldName = "MA_CBNV";
            //tlDmCbNv.ParentFieldName = "MA_BP";
            //tlDmCbNv.Dock = DockStyle.Fill;
            
            //tlDmCbNv.strZone = "EMPLOYEE";
            //tlDmCbNv.BuildTreeList(this.isLookup);
            //dtEmployee = HRMCommon.GetCustomerTable("MA_KV");
            tlDmCbNv = HRMCommon.GetTreeViewCust(this.isLookup);
            this.splControl1.Visible = false;
			this.pageEmployee.Controls.Add(tlDmCbNv);
			
            dgvBHXH.strZone = "BHXH";
            dgvBHXH.BuildGridView();

            dgvBHYT.strZone = "BHYT";
            dgvBHYT.BuildGridView();

            dgvTroCap.strZone = "TROCAP";
            dgvTroCap.BuildGridView();

            dgvTyLe.strZone = "TYLE";
            dgvTyLe.BuildGridView();
            
		}

		private void FillData(string strKey)
		{
            //dtEmployee = SQLExec.ExecuteReturnDt("EXEC Sp_GetDmCbNv");
            dtEmployee = HRMCommon.GetCustomerTable("MA_KV",this.cboFill.Text);
			bdsEmployee.DataSource = dtEmployee;
			tlDmCbNv.DataSource = bdsEmployee;
			//bdsEmployee.Position = 0;

            //BHXH
            dtBHXH = DataTool.SQLGetDataTable("HRBHXH", null, strKey, "Ngay_Begin, Ngay_Tang_BH");
            bdsBHXH.DataSource = dtBHXH;
            dgvBHXH.DataSource = bdsBHXH;

            //BHYT
            dtBHYT = DataTool.SQLGetDataTable("HRBHYT", null, strKey, "Ngay_Begin, Ngay_End");
            bdsBHYT.DataSource = dtBHYT;
            dgvBHYT.DataSource = bdsBHYT;

            //TyLe
            string strSQLExec1 =
                "SELECT T1.*, T2.Ten_Tn, T2.Dvt FROM HRPARAVALUE0 T1 LEFT JOIN HRPARALIST T2 ON T1.Ma_Tn = T2.Ma_Tn " +
                    " WHERE T1.Ma_Tn LIKE 'BH%' OR T1.Ma_Tn LIKE 'KP%' ORDER BY Ngay_Ap";

            dtTyLe = SQLExec.ExecuteReturnDt(strSQLExec1);
            bdsTyLe.DataSource = dtTyLe;
            dgvTyLe.DataSource = bdsTyLe;

            //TroCap
            string strSQLExec2 =
                "SELECT T1.*, T2.Ten_Tn, T2.Dvt FROM HRPARAVALUE0 T1 LEFT JOIN HRPARALIST T2 ON T1.Ma_Tn = T2.Ma_Tn " +
                    " WHERE T1.Ma_Tn LIKE 'PHUCAP%' ORDER BY Ngay_Ap";

            dtTroCap = SQLExec.ExecuteReturnDt(strSQLExec2);
            bdsTroCap.DataSource = dtTroCap;
            dgvTroCap.DataSource = bdsTroCap;                       

			//Uy quyen cho lop co so tim kiem           
			bdsSearch = bdsEmployee;
			ExportControl = tlDmCbNv;

			tlDmCbNv.Expand = (bool)SQLExec.ExecuteReturnValue("SELECT Expand FROM SYSZONE WHERE ZONE = '" + tlDmCbNv.strZone + "'");
		}

		private void BindingData()
		{
			foreach (Control ctrl in tpTTNV.Controls)
			{
				if (ctrl.GetType() == typeof(txtTextBox) || ctrl.GetType() == typeof(TextBox) || ctrl.GetType() == typeof(txtDateTime) || ctrl.GetType() == typeof(cboControl) || ctrl.GetType() == typeof(ComboBox))
				{
					string strFieldName = ctrl.Name.Substring(3);

					if (((DataTable)bdsEmployee.DataSource).Columns.Contains(strFieldName))
						ctrl.DataBindings.Add("Text", bdsEmployee, strFieldName);
				}
			}

			//picHinh.DataBindings.Add("Image", bdsEmployee, "Hinh");
		}

		#endregion

		#region Update

		public override void Edit(enuEdit enuNew_Edit)
		{	
            if (tabDetail.SelectedTab == pageBHXH || dgvBHXH.Focused)
                this.EditBHXH(enuNew_Edit);
            if (tabDetail.SelectedTab == pageBHYT || dgvBHYT.Focused)
                this.EditBHYT(enuNew_Edit);
            if (tabDetail.SelectedTab == pageTyLe || dgvTyLe.Focused)
                this.EditTyLe(enuNew_Edit);
            if (tabDetail.SelectedTab == pageTroCap || dgvTroCap.Focused)
                this.EditTroCap(enuNew_Edit);            
		}        
		public override void Delete()
		{	
            if (tabDetail.SelectedTab == pageBHXH || dgvBHXH.Focused)
                this.DeleteBHXH();
            if (tabDetail.SelectedTab == pageBHYT || dgvBHYT.Focused)
                this.DeleteBHYT();
            if (tabDetail.SelectedTab == pageTyLe || dgvTyLe.Focused)
                this.DeleteTyLe();
            if (tabDetail.SelectedTab == pageTroCap || dgvTroCap.Focused)
                this.DeleteTroCap();            
		}       
        
        void EditBHXH(enuEdit enuNew_Edit)
        {
            if (bdsEmployee.Position < 0)
                return;

            if (bdsBHXH.Position < 0 && enuNew_Edit == enuEdit.Edit)
                return;

            DataRow drEmployee = ((DataRowView)bdsEmployee.Current).Row;

            //Copy hang hien tai            
            if (bdsBHXH.Position >= 0)
                Common.CopyDataRow(((DataRowView)bdsBHXH.Current).Row, ref drCurrent);
            else
                drCurrent = dtBHXH.NewRow();

            drCurrent["Ma_CbNv"] = (string)drEmployee["Ma_CbNv"];

            frmBHXH_Edit frmEdit = new frmBHXH_Edit();
            frmEdit.Load(enuNew_Edit, drCurrent);

            //Accept
            if (frmEdit.isAccept)
            {
                if (enuNew_Edit == enuEdit.New)
                {
                    if (bdsBHXH.Position >= 0)
                        dtBHXH.ImportRow(drCurrent);
                    else
                        dtBHXH.Rows.Add(drCurrent);

                    bdsBHXH.Position = bdsBHXH.Find("Ident00", drCurrent["Ident00"]);
                }
                else
                    Common.CopyDataRow(drCurrent, ((DataRowView)bdsBHXH.Current).Row);

                dtBHXH.AcceptChanges();
            }
            else
                dtBHXH.RejectChanges();
        }        
        void EditBHYT(enuEdit enuNew_Edit)
        {
            if (bdsEmployee.Position < 0)
                return;

            if (bdsBHYT.Position < 0 && enuNew_Edit == enuEdit.Edit)
                return;

            DataRow drEmployee = ((DataRowView)bdsEmployee.Current).Row;

            //Copy hang hien tai            
            if (bdsBHYT.Position >= 0)
                Common.CopyDataRow(((DataRowView)bdsBHYT.Current).Row, ref drCurrent);
            else
                drCurrent = dtBHYT.NewRow();

            drCurrent["Ma_CbNv"] = (string)drEmployee["Ma_CbNv"];

            frmBHYT_Edit frmEdit = new frmBHYT_Edit();
            frmEdit.Load(enuNew_Edit, drCurrent);

            //Accept
            if (frmEdit.isAccept)
            {
                if (enuNew_Edit == enuEdit.New)
                {
                    if (bdsBHYT.Position >= 0)
                        dtBHYT.ImportRow(drCurrent);
                    else
                        dtBHYT.Rows.Add(drCurrent);

                    bdsBHYT.Position = bdsBHYT.Find("Ident00", drCurrent["Ident00"]);
                }
                else
                    Common.CopyDataRow(drCurrent, ((DataRowView)bdsBHYT.Current).Row);

                dtBHYT.AcceptChanges();
            }
            else
                dtBHYT.RejectChanges();
        }
        void EditTyLe(enuEdit enuNew_Edit)
        {
            if (bdsEmployee.Position < 0)
                return;

            if (bdsTyLe.Position < 0 && enuNew_Edit == enuEdit.Edit)
                return;

            DataRow drEmployee = ((DataRowView)bdsEmployee.Current).Row;

            //Copy hang hien tai            
            if (bdsTyLe.Position >= 0)
                Common.CopyDataRow(((DataRowView)bdsTyLe.Current).Row, ref drCurrent);
            else
                drCurrent = dtTyLe.NewRow();

            drCurrent["Ma_CbNv"] = (string)drEmployee["Ma_CbNv"];

            frmTsTn0_Edit frmEdit = new frmTsTn0_Edit();
            frmEdit.Load(enuNew_Edit, drCurrent);

            //Accept
            if (frmEdit.isAccept)
            {
                if (enuNew_Edit == enuEdit.New)
                {
                    if (bdsTyLe.Position >= 0)
                        dtTyLe.ImportRow(drCurrent);
                    else
                        dtTyLe.Rows.Add(drCurrent);

                    bdsTyLe.Position = bdsTyLe.Find("Ident00", drCurrent["Ident00"]);
                }
                else
                    Common.CopyDataRow(drCurrent, ((DataRowView)bdsTyLe.Current).Row);

                dtTyLe.AcceptChanges();
            }
            else
                dtTyLe.RejectChanges();
        }
        void EditTroCap(enuEdit enuNew_Edit)
        {
            if (bdsEmployee.Position < 0)
                return;

            if (bdsTroCap.Position < 0 && enuNew_Edit == enuEdit.Edit)
                return;

            DataRow drEmployee = ((DataRowView)bdsEmployee.Current).Row;

            //Copy hang hien tai            
            if (bdsTroCap.Position >= 0)
                Common.CopyDataRow(((DataRowView)bdsTroCap.Current).Row, ref drCurrent);
            else
                drCurrent = dtTroCap.NewRow();

            drCurrent["Ma_CbNv"] = (string)drEmployee["Ma_CbNv"];

            frmTroCap_Edit frmEdit = new frmTroCap_Edit();
            frmEdit.Load(enuNew_Edit, drCurrent);

            //Accept
            if (frmEdit.isAccept)
            {
                if (enuNew_Edit == enuEdit.New)
                {
                    if (bdsTroCap.Position >= 0)
                        dtTroCap.ImportRow(drCurrent);
                    else
                        dtTroCap.Rows.Add(drCurrent);

                    bdsTroCap.Position = bdsTroCap.Find("Ident00", drCurrent["Ident00"]);
                }
                else
                    Common.CopyDataRow(drCurrent, ((DataRowView)bdsTroCap.Current).Row);

                dtTroCap.AcceptChanges();
            }
            else
                dtTroCap.RejectChanges();
        }       
        void DeleteBHXH()
        {
            if (bdsBHXH.Position < 0)
                return;

            DataRow drCurrent = ((DataRowView)bdsBHXH.Current).Row;

            if (!Common.MsgYes_No(Languages.GetLanguage("SURE_DELETE")))
                return;

            if (DataTool.SQLDelete("HRBHXH", drCurrent))
            {
                bdsBHXH.RemoveAt(bdsBHXH.Position);
                dtBHXH.AcceptChanges();
            }
        }
        void DeleteBHYT()
        {
            if (bdsBHYT.Position < 0)
                return;

            DataRow drCurrent = ((DataRowView)bdsBHYT.Current).Row;

            if (!Common.MsgYes_No(Languages.GetLanguage("SURE_DELETE")))
                return;

            if (DataTool.SQLDelete("HRBHYT", drCurrent))
            {
                bdsBHYT.RemoveAt(bdsBHYT.Position);
                dtBHYT.AcceptChanges();
            }
        }

        void DeleteTyLe()
        {
            if (bdsTyLe.Position < 0)
                return;

            DataRow drCurrent = ((DataRowView)bdsTyLe.Current).Row;

            if (!Common.MsgYes_No(Languages.GetLanguage("SURE_DELETE")))
                return;

            if (DataTool.SQLDelete("HRPARAVALUE0", drCurrent))
            {
                bdsTyLe.RemoveAt(bdsTyLe.Position);
                dtTyLe.AcceptChanges();
            }
        }    

        void DeleteTroCap()
        {
            if (bdsTroCap.Position < 0)
                return;

            DataRow drCurrent = ((DataRowView)bdsTroCap.Current).Row;

            if (!Common.MsgYes_No(Languages.GetLanguage("SURE_DELETE")))
                return;

            if (DataTool.SQLDelete("HRPARAVALUE0", drCurrent))
            {
                bdsTroCap.RemoveAt(bdsTroCap.Position);
                dtTroCap.AcceptChanges();
            }
        }       

		#endregion

		#region EnterProcess

		bool EnterValid()
		{
			if (this.strLookupKeyValid == string.Empty || this.strLookupKeyValid == null)
				return true;

			if (bdsEmployee == null || bdsEmployee.Position < 0)
				return false;

			drCurrent = ((DataRowView)bdsEmployee.Current).Row;
			DataTable dtTemp = dtEmployee.Clone();
			dtTemp.ImportRow(drCurrent);

			if ((dtTemp.Select(this.strLookupKeyValid)).Length == 1)
				return true;
			else
				return false;

		}

		public override void EnterProcess()
		{
			if (bdsEmployee.Position < 0)
				return;

			if (isLookup && EnterValid())
			{
				drLookup = ((DataRowView)bdsEmployee.Current).Row;
				this.Close();
			}
		}

		#endregion

		#region Su kien

		void bdsEmployee_PositionChanged(object sender, EventArgs e)
		{
			drCurrent = ((DataRowView)bdsEmployee.Current).Row;

            bdsBHXH.Filter = "Ma_CbNv = '" + drCurrent["Ma_CbNv"] + "'";
            bdsBHYT.Filter = "Ma_CbNv = '" + drCurrent["Ma_CbNv"] + "'";
            bdsTyLe.Filter = "Ma_CbNv = '" + drCurrent["Ma_CbNv"] + "'";        
            bdsTroCap.Filter = "Ma_CbNv = '" + drCurrent["Ma_CbNv"] + "'";       

			object objPic = SQLExec.ExecuteReturnValue("SELECT Hinh FROM LINHANVIEN WHERE Ma_CbNv = '" + (string)drCurrent["Ma_CbNv"] + "'");
			Byte[] bytePic = (Byte[])objPic;
			if (objPic != null && objPic != DBNull.Value && bytePic.Length != 0)
			{
				byte[] barrImg = bytePic;
				string strFileName = Convert.ToString(DateTime.Now.ToFileTime());
				System.IO.FileStream fs = new System.IO.FileStream(strFileName, System.IO.FileMode.CreateNew, System.IO.FileAccess.Write);
				fs.Write(barrImg, 0, barrImg.Length);
				fs.Flush();
				fs.Close();
				picHinh.Image = Image.FromFile(strFileName);
				picHinh.SizeMode = PictureBoxSizeMode.Zoom;
			}
			else
				picHinh.Image = null;
		}        
		#endregion
	}
}

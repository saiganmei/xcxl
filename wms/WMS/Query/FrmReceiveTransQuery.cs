﻿using WMS.WebService;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WMS.Query
{
    public partial class FrmReceiveTransQuery : Common.FrmBasic
    {
        private DividPage _serverMainPage;
        private ReceiveTransInfo queryMain;
        private List<ReceiveTransInfo> lstMain;

        public FrmReceiveTransQuery()
        {
            InitializeComponent();
        }

        private void FrmReceiveTransQuery_Load(object sender, EventArgs e)
        {
            SetSearchBtn();
            InitForm();
        }

        private void FrmReceiveTransQuery_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.Common_Func.RemoveTabPageForm(this);
        }

        private void tsmiExport_Click(object sender, EventArgs e)
        {
            ExportList();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    this.Cursor = Cursors.WaitCursor;

                    BindList();
                }
            }
            catch (Exception ex)
            {
                Common.Common_Func.ErrorMessage(ex.Message, "程序异常");
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindList();
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pageList_ChensPageChange(object sender, EventArgs e)
        {
            GetListQueryData();
        }

        #region Function

        private void InitForm()
        {
            InitMainQuery();

            //GetListQueryData();
        }

        private void InitMainQuery()
        {
            _serverMainPage = new DividPage();
            queryMain = new ReceiveTransInfo();
            lstMain = new List<ReceiveTransInfo>();

            pageList.GetShowCountsByDGV(dgvList);
            bsMain.DataSource = queryMain;
        }

        private void BindList()
        {
            pageList.dDividPage.CurrentPageNumber = 1;
            GetListQueryData();
        }

        private void GetListQueryData()
        {
            bsMain.EndEdit();

            bool bResult = false;
            string strErr = string.Empty;
            GetQueryMain();

            ChensControl.DividPage clientPage = pageList.dDividPage;
            Common.Common_Func.GetServerPageFromClientPage(ref _serverMainPage, clientPage);
            bResult = Query_Func.GetReceiveTransListByPage(ref lstMain, queryMain, ref _serverMainPage, ref strErr);
            Common.Common_Func.GetClientPageFromServerPage(_serverMainPage, ref clientPage);
            pageList.ShowPage();
            //添加总计
            ReceiveTransInfo sum_info = new ReceiveTransInfo();
            foreach (ReceiveTransInfo tt_info in lstMain)
            {
                sum_info.ReceiveQty += tt_info.ReceiveQty;
            }
            sum_info.MaterialDocDate = "总计";
            lstMain.Add(sum_info);
            dgvList.DataSource = lstMain;

            if (!bResult || !string.IsNullOrEmpty(strErr)) Common.Common_Func.ErrorMessage(strErr, "查询失败");
            txtDeliveryNo.Focus();
        }

        private void GetQueryMain()
        {
            if (queryMain == null) { queryMain = new ReceiveTransInfo(); bsMain.DataSource = queryMain; }
            if (dtpStartTime.Checked) queryMain.StartTime = dtpStartTime.Value; else queryMain.StartTime = null;
            if (dtpEndTime.Checked) queryMain.EndTime = dtpEndTime.Value; else queryMain.EndTime = null;
        }

        private void ExportList()
        {
            ExcelLibrary.ExcelLibrary_Func.SaveDataGridViewToExcelByNPOI(dgvList);
        }

        private void SetSearchBtn()
        {
            Common.Common_Func.SetSearchBtn(this, txtSupplierNo, btnSearch, tsmiSearch);
        }

        #endregion
    }
}

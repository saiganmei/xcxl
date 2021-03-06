﻿namespace WMS.Print
{
    partial class FrmAreaPrint
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            ChensControl.DividPage dividPage1 = new ChensControl.DividPage();
            this.bsMain = new System.Windows.Forms.BindingSource(this.components);
            this.gbBottom = new ChensControl.ChensGroupBox();
            this.cbxSelectAll = new System.Windows.Forms.CheckBox();
            this.dgvList = new ChensControl.ChensDataGridView();
            this.colSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colBEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colBID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBWarehouseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBWarehouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHouseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHouseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBAreaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBAreaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBAreaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBStrAreaType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBContactUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBLocationDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBAreaStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBStrAreaStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBHouseID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBIsDel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCreater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBCreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBModifyer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBModifyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrintQty = new ChensControl.ChensDataGridViewNumericUpDownColumn();
            this.pageList = new ChensControl.ChensPage();
            this.gbHeader = new ChensControl.ChensGroupBox();
            this.txtAreaNo = new ChensControl.ChensTextBox();
            this.chensLabel1 = new ChensControl.ChensLabel();
            this.txtHouseNo = new ChensControl.ChensTextBox();
            this.txtWarehouseNo = new ChensControl.ChensTextBox();
            this.chensLabel2 = new ChensControl.ChensLabel();
            this.chensLabel5 = new ChensControl.ChensLabel();
            this.dtpEndTime = new ChensControl.ChensDateTimePicker();
            this.chensLabel4 = new ChensControl.ChensLabel();
            this.chensLabel3 = new ChensControl.ChensLabel();
            this.dtpStartTime = new ChensControl.ChensDateTimePicker();
            this.btnSearch = new ChensControl.ChensButton();
            this.msMain = new ChensControl.ChensMenuStrip();
            this.tsmiSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditArea = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangePrinter = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).BeginInit();
            this.gbBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.gbHeader.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsMain
            // 
            this.bsMain.DataSource = typeof(WMS.WebService.AreaInfo);
            // 
            // gbBottom
            // 
            this.gbBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbBottom.Controls.Add(this.cbxSelectAll);
            this.gbBottom.Controls.Add(this.dgvList);
            this.gbBottom.Controls.Add(this.pageList);
            this.gbBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBottom.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gbBottom.Location = new System.Drawing.Point(0, 122);
            this.gbBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBottom.Name = "gbBottom";
            this.gbBottom.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbBottom.Size = new System.Drawing.Size(992, 651);
            this.gbBottom.TabIndex = 4;
            this.gbBottom.TabStop = false;
            this.gbBottom.Text = "查询结果";
            // 
            // cbxSelectAll
            // 
            this.cbxSelectAll.AutoSize = true;
            this.cbxSelectAll.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxSelectAll.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.cbxSelectAll.Location = new System.Drawing.Point(12, 19);
            this.cbxSelectAll.Name = "cbxSelectAll";
            this.cbxSelectAll.Size = new System.Drawing.Size(51, 21);
            this.cbxSelectAll.TabIndex = 3;
            this.cbxSelectAll.Text = "选择";
            this.cbxSelectAll.UseVisualStyleBackColor = false;
            this.cbxSelectAll.CheckedChanged += new System.EventHandler(this.cbxSelectAll_CheckedChanged);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelect,
            this.colBEdit,
            this.colBID,
            this.colBWarehouseNo,
            this.colBWarehouseName,
            this.colBHouseNo,
            this.colBHouseName,
            this.colBAreaNo,
            this.colBAreaName,
            this.colBAreaType,
            this.colBStrAreaType,
            this.colBContactUser,
            this.colBContactPhone,
            this.colBLocationDesc,
            this.colBAreaStatus,
            this.colBStrAreaStatus,
            this.colBAddress,
            this.colBHouseID,
            this.colBIsDel,
            this.colBCreater,
            this.colBCreateTime,
            this.colBModifyer,
            this.colBModifyTime,
            this.colPrintQty});
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.dgvList.GridColor = System.Drawing.Color.LightGray;
            this.dgvList.HaveCopyMenu = true;
            this.dgvList.Location = new System.Drawing.Point(3, 20);
            this.dgvList.Name = "dgvList";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvList.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvList.RowHeadersVisible = false;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(986, 607);
            this.dgvList.TabIndex = 2;
            this.dgvList.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvList_Scroll);
            // 
            // colSelect
            // 
            this.colSelect.FalseValue = "False";
            this.colSelect.HeaderText = "选择";
            this.colSelect.Name = "colSelect";
            this.colSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSelect.TrueValue = "True";
            this.colSelect.Width = 60;
            // 
            // colBEdit
            // 
            dataGridViewCellStyle3.NullValue = "编辑";
            this.colBEdit.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBEdit.HeaderText = "编辑";
            this.colBEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.colBEdit.Name = "colBEdit";
            this.colBEdit.Visible = false;
            this.colBEdit.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // colBID
            // 
            this.colBID.DataPropertyName = "ID";
            this.colBID.HeaderText = "ID";
            this.colBID.Name = "colBID";
            this.colBID.ReadOnly = true;
            this.colBID.Visible = false;
            // 
            // colBWarehouseNo
            // 
            this.colBWarehouseNo.DataPropertyName = "WarehouseNo";
            this.colBWarehouseNo.HeaderText = "仓库编号";
            this.colBWarehouseNo.Name = "colBWarehouseNo";
            this.colBWarehouseNo.ReadOnly = true;
            this.colBWarehouseNo.Visible = false;
            // 
            // colBWarehouseName
            // 
            this.colBWarehouseName.DataPropertyName = "WarehouseName";
            this.colBWarehouseName.HeaderText = "仓库名称";
            this.colBWarehouseName.Name = "colBWarehouseName";
            this.colBWarehouseName.ReadOnly = true;
            // 
            // colBHouseNo
            // 
            this.colBHouseNo.DataPropertyName = "HouseNo";
            this.colBHouseNo.HeaderText = "库区编号";
            this.colBHouseNo.Name = "colBHouseNo";
            this.colBHouseNo.ReadOnly = true;
            this.colBHouseNo.Visible = false;
            // 
            // colBHouseName
            // 
            this.colBHouseName.DataPropertyName = "HouseName";
            this.colBHouseName.HeaderText = "库区名称";
            this.colBHouseName.Name = "colBHouseName";
            this.colBHouseName.ReadOnly = true;
            // 
            // colBAreaNo
            // 
            this.colBAreaNo.DataPropertyName = "AreaNo";
            this.colBAreaNo.HeaderText = "货位编号";
            this.colBAreaNo.Name = "colBAreaNo";
            this.colBAreaNo.ReadOnly = true;
            // 
            // colBAreaName
            // 
            this.colBAreaName.DataPropertyName = "AreaName";
            this.colBAreaName.HeaderText = "货位名称";
            this.colBAreaName.Name = "colBAreaName";
            this.colBAreaName.ReadOnly = true;
            // 
            // colBAreaType
            // 
            this.colBAreaType.DataPropertyName = "AreaType";
            this.colBAreaType.HeaderText = "货位类型";
            this.colBAreaType.Name = "colBAreaType";
            this.colBAreaType.ReadOnly = true;
            this.colBAreaType.Visible = false;
            // 
            // colBStrAreaType
            // 
            this.colBStrAreaType.DataPropertyName = "StrAreaType";
            this.colBStrAreaType.HeaderText = "货位类型";
            this.colBStrAreaType.Name = "colBStrAreaType";
            this.colBStrAreaType.ReadOnly = true;
            this.colBStrAreaType.Visible = false;
            // 
            // colBContactUser
            // 
            this.colBContactUser.DataPropertyName = "ContactUser";
            this.colBContactUser.HeaderText = "联系人";
            this.colBContactUser.Name = "colBContactUser";
            this.colBContactUser.ReadOnly = true;
            this.colBContactUser.Visible = false;
            // 
            // colBContactPhone
            // 
            this.colBContactPhone.DataPropertyName = "ContactPhone";
            this.colBContactPhone.HeaderText = "联系电话";
            this.colBContactPhone.Name = "colBContactPhone";
            this.colBContactPhone.ReadOnly = true;
            this.colBContactPhone.Visible = false;
            // 
            // colBLocationDesc
            // 
            this.colBLocationDesc.DataPropertyName = "LocationDesc";
            this.colBLocationDesc.HeaderText = "货位描述";
            this.colBLocationDesc.Name = "colBLocationDesc";
            this.colBLocationDesc.ReadOnly = true;
            this.colBLocationDesc.Visible = false;
            // 
            // colBAreaStatus
            // 
            this.colBAreaStatus.DataPropertyName = "AreaStatus";
            this.colBAreaStatus.HeaderText = "货位状态";
            this.colBAreaStatus.Name = "colBAreaStatus";
            this.colBAreaStatus.ReadOnly = true;
            this.colBAreaStatus.Visible = false;
            // 
            // colBStrAreaStatus
            // 
            this.colBStrAreaStatus.DataPropertyName = "StrAreaStatus";
            this.colBStrAreaStatus.HeaderText = "货位状态";
            this.colBStrAreaStatus.Name = "colBStrAreaStatus";
            this.colBStrAreaStatus.ReadOnly = true;
            this.colBStrAreaStatus.Visible = false;
            // 
            // colBAddress
            // 
            this.colBAddress.DataPropertyName = "Address";
            this.colBAddress.HeaderText = "地址";
            this.colBAddress.Name = "colBAddress";
            this.colBAddress.ReadOnly = true;
            this.colBAddress.Visible = false;
            // 
            // colBHouseID
            // 
            this.colBHouseID.DataPropertyName = "HouseID";
            this.colBHouseID.HeaderText = "库区ID";
            this.colBHouseID.Name = "colBHouseID";
            this.colBHouseID.ReadOnly = true;
            this.colBHouseID.Visible = false;
            // 
            // colBIsDel
            // 
            this.colBIsDel.DataPropertyName = "IsDel";
            this.colBIsDel.HeaderText = "删除标识";
            this.colBIsDel.Name = "colBIsDel";
            this.colBIsDel.ReadOnly = true;
            this.colBIsDel.Visible = false;
            // 
            // colBCreater
            // 
            this.colBCreater.DataPropertyName = "Creater";
            this.colBCreater.HeaderText = "创建人";
            this.colBCreater.Name = "colBCreater";
            this.colBCreater.ReadOnly = true;
            // 
            // colBCreateTime
            // 
            this.colBCreateTime.DataPropertyName = "CreateTime";
            this.colBCreateTime.HeaderText = "创建时间";
            this.colBCreateTime.Name = "colBCreateTime";
            this.colBCreateTime.ReadOnly = true;
            // 
            // colBModifyer
            // 
            this.colBModifyer.DataPropertyName = "Modifyer";
            this.colBModifyer.HeaderText = "修改人";
            this.colBModifyer.Name = "colBModifyer";
            this.colBModifyer.ReadOnly = true;
            this.colBModifyer.Visible = false;
            // 
            // colBModifyTime
            // 
            this.colBModifyTime.DataPropertyName = "ModifyTime";
            this.colBModifyTime.HeaderText = "修改时间";
            this.colBModifyTime.Name = "colBModifyTime";
            this.colBModifyTime.ReadOnly = true;
            this.colBModifyTime.Visible = false;
            // 
            // colPrintQty
            // 
            this.colPrintQty.DecimalPlaces = 0;
            dataGridViewCellStyle4.NullValue = "1";
            this.colPrintQty.DefaultCellStyle = dataGridViewCellStyle4;
            this.colPrintQty.HeaderText = "打印份数";
            this.colPrintQty.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.colPrintQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.colPrintQty.Name = "colPrintQty";
            this.colPrintQty.Width = 80;
            // 
            // pageList
            // 
            this.pageList.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pageList.CurrentPageNumber = 0;
            dividPage1.CurrentPageNumber = 0;
            dividPage1.CurrentPageRecordCounts = 0;
            dividPage1.CurrentPageShowCounts = 10;
            dividPage1.DefaultPageShowCounts = 10;
            dividPage1.PagesCount = 0;
            dividPage1.RecordCounts = 0;
            this.pageList.dDividPage = dividPage1;
            this.pageList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pageList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageList.Location = new System.Drawing.Point(3, 627);
            this.pageList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageList.Name = "pageList";
            this.pageList.Size = new System.Drawing.Size(986, 20);
            this.pageList.TabIndex = 1;
            this.pageList.ChensPageChange += new ChensControl.ChensPage.PageChangeHandle(this.pageList_ChensPageChange);
            // 
            // gbHeader
            // 
            this.gbHeader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbHeader.Controls.Add(this.txtAreaNo);
            this.gbHeader.Controls.Add(this.chensLabel1);
            this.gbHeader.Controls.Add(this.txtHouseNo);
            this.gbHeader.Controls.Add(this.txtWarehouseNo);
            this.gbHeader.Controls.Add(this.chensLabel2);
            this.gbHeader.Controls.Add(this.chensLabel5);
            this.gbHeader.Controls.Add(this.dtpEndTime);
            this.gbHeader.Controls.Add(this.chensLabel4);
            this.gbHeader.Controls.Add(this.chensLabel3);
            this.gbHeader.Controls.Add(this.dtpStartTime);
            this.gbHeader.Controls.Add(this.btnSearch);
            this.gbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbHeader.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gbHeader.Location = new System.Drawing.Point(0, 27);
            this.gbHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbHeader.Size = new System.Drawing.Size(992, 95);
            this.gbHeader.TabIndex = 3;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "查询条件";
            // 
            // txtAreaNo
            // 
            this.txtAreaNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtAreaNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAreaNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "AreaNo", true));
            this.txtAreaNo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtAreaNo.HotTrack = false;
            this.txtAreaNo.Location = new System.Drawing.Point(571, 23);
            this.txtAreaNo.Name = "txtAreaNo";
            this.txtAreaNo.Size = new System.Drawing.Size(150, 23);
            this.txtAreaNo.TabIndex = 3;
            this.txtAreaNo.TextEnabled = false;
            this.txtAreaNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // chensLabel1
            // 
            this.chensLabel1.AutoSize = true;
            this.chensLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chensLabel1.Location = new System.Drawing.Point(509, 25);
            this.chensLabel1.Name = "chensLabel1";
            this.chensLabel1.Size = new System.Drawing.Size(32, 17);
            this.chensLabel1.TabIndex = 13;
            this.chensLabel1.Text = "货位";
            // 
            // txtHouseNo
            // 
            this.txtHouseNo.BackColor = System.Drawing.Color.White;
            this.txtHouseNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHouseNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "HouseNo", true));
            this.txtHouseNo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtHouseNo.HotTrack = false;
            this.txtHouseNo.Location = new System.Drawing.Point(329, 23);
            this.txtHouseNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHouseNo.Name = "txtHouseNo";
            this.txtHouseNo.Size = new System.Drawing.Size(150, 23);
            this.txtHouseNo.TabIndex = 2;
            this.txtHouseNo.TextEnabled = false;
            this.txtHouseNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txtWarehouseNo
            // 
            this.txtWarehouseNo.BackColor = System.Drawing.Color.White;
            this.txtWarehouseNo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtWarehouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtWarehouseNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMain, "WarehouseNo", true));
            this.txtWarehouseNo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txtWarehouseNo.HotTrack = false;
            this.txtWarehouseNo.Location = new System.Drawing.Point(87, 23);
            this.txtWarehouseNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWarehouseNo.Name = "txtWarehouseNo";
            this.txtWarehouseNo.Size = new System.Drawing.Size(150, 23);
            this.txtWarehouseNo.TabIndex = 1;
            this.txtWarehouseNo.TextEnabled = false;
            this.txtWarehouseNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // chensLabel2
            // 
            this.chensLabel2.AutoSize = true;
            this.chensLabel2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chensLabel2.Location = new System.Drawing.Point(267, 25);
            this.chensLabel2.Name = "chensLabel2";
            this.chensLabel2.Size = new System.Drawing.Size(32, 17);
            this.chensLabel2.TabIndex = 10;
            this.chensLabel2.Text = "库区";
            // 
            // chensLabel5
            // 
            this.chensLabel5.AutoSize = true;
            this.chensLabel5.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chensLabel5.Location = new System.Drawing.Point(25, 25);
            this.chensLabel5.Name = "chensLabel5";
            this.chensLabel5.Size = new System.Drawing.Size(32, 17);
            this.chensLabel5.TabIndex = 9;
            this.chensLabel5.Text = "仓库";
            // 
            // dtpEndTime
            // 
            this.dtpEndTime.Checked = false;
            this.dtpEndTime.Location = new System.Drawing.Point(329, 58);
            this.dtpEndTime.Name = "dtpEndTime";
            this.dtpEndTime.ShowCheckBox = true;
            this.dtpEndTime.Size = new System.Drawing.Size(150, 23);
            this.dtpEndTime.TabIndex = 5;
            this.dtpEndTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // chensLabel4
            // 
            this.chensLabel4.AutoSize = true;
            this.chensLabel4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chensLabel4.Location = new System.Drawing.Point(267, 60);
            this.chensLabel4.Name = "chensLabel4";
            this.chensLabel4.Size = new System.Drawing.Size(34, 17);
            this.chensLabel4.TabIndex = 7;
            this.chensLabel4.Text = "——";
            // 
            // chensLabel3
            // 
            this.chensLabel3.AutoSize = true;
            this.chensLabel3.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.chensLabel3.Location = new System.Drawing.Point(25, 60);
            this.chensLabel3.Name = "chensLabel3";
            this.chensLabel3.Size = new System.Drawing.Size(56, 17);
            this.chensLabel3.TabIndex = 6;
            this.chensLabel3.Text = "创建日期";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.Checked = false;
            this.dtpStartTime.Location = new System.Drawing.Point(87, 58);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.ShowCheckBox = true;
            this.dtpStartTime.Size = new System.Drawing.Size(150, 23);
            this.dtpStartTime.TabIndex = 4;
            this.dtpStartTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(174)))), ((int)(((byte)(253)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(913, 19);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(67, 29);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // msMain
            // 
            this.msMain.BackColor = System.Drawing.Color.LightSteelBlue;
            this.msMain.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSearch,
            this.tsmiPrint,
            this.tsmiEditArea,
            this.tsmiChangePrinter});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.msMain.Size = new System.Drawing.Size(992, 27);
            this.msMain.TabIndex = 2;
            this.msMain.Text = "chensMenuStrip1";
            // 
            // tsmiSearch
            // 
            this.tsmiSearch.Name = "tsmiSearch";
            this.tsmiSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.tsmiSearch.Size = new System.Drawing.Size(68, 21);
            this.tsmiSearch.Text = "查询数据";
            this.tsmiSearch.Visible = false;
            this.tsmiSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.tsmiPrint.Size = new System.Drawing.Size(68, 21);
            this.tsmiPrint.Text = "货位打印";
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // tsmiEditArea
            // 
            this.tsmiEditArea.Name = "tsmiEditArea";
            this.tsmiEditArea.Size = new System.Drawing.Size(68, 21);
            this.tsmiEditArea.Text = "编辑货位";
            this.tsmiEditArea.Visible = false;
            this.tsmiEditArea.Click += new System.EventHandler(this.tsmiEditArea_Click);
            // 
            // tsmiChangePrinter
            // 
            this.tsmiChangePrinter.Name = "tsmiChangePrinter";
            this.tsmiChangePrinter.Size = new System.Drawing.Size(80, 21);
            this.tsmiChangePrinter.Text = "设置打印机";
            this.tsmiChangePrinter.Click += new System.EventHandler(this.tsmiChangePrinter_Click);
            // 
            // FrmAreaPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 773);
            this.Controls.Add(this.gbBottom);
            this.Controls.Add(this.gbHeader);
            this.Controls.Add(this.msMain);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "FrmAreaPrint";
            this.Text = "货位标签打印";
            this.Load += new System.EventHandler(this.FrmAreaPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsMain)).EndInit();
            this.gbBottom.ResumeLayout(false);
            this.gbBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.gbHeader.ResumeLayout(false);
            this.gbHeader.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ChensControl.ChensMenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangePrinter;
        private ChensControl.ChensGroupBox gbHeader;
        private ChensControl.ChensButton btnSearch;
        private ChensControl.ChensGroupBox gbBottom;
        private ChensControl.ChensPage pageList;
        private ChensControl.ChensDataGridView dgvList;
        private System.Windows.Forms.BindingSource bsMain;
        private System.Windows.Forms.CheckBox cbxSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiSearch;
        private ChensControl.ChensDateTimePicker dtpStartTime;
        private ChensControl.ChensLabel chensLabel3;
        private ChensControl.ChensDateTimePicker dtpEndTime;
        private ChensControl.ChensLabel chensLabel4;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditArea;
        private ChensControl.ChensTextBox txtAreaNo;
        private ChensControl.ChensLabel chensLabel1;
        private ChensControl.ChensTextBox txtHouseNo;
        private ChensControl.ChensTextBox txtWarehouseNo;
        private ChensControl.ChensLabel chensLabel2;
        private ChensControl.ChensLabel chensLabel5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelect;
        private System.Windows.Forms.DataGridViewLinkColumn colBEdit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBWarehouseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBWarehouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHouseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHouseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBAreaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBAreaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBAreaType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBStrAreaType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBContactUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBLocationDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBAreaStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBStrAreaStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBHouseID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBIsDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCreater;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBCreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBModifyer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBModifyTime;
        private ChensControl.ChensDataGridViewNumericUpDownColumn colPrintQty;
    }
}
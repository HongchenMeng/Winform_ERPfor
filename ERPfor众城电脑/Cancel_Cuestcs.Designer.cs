namespace ERPfor众城电脑
{
    partial class Cancel_Cuestcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cancel_Cuestcs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dateTimeInput1 = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.textBoxX7 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX5 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX4 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX3 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX2 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.textBoxX1 = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dataGridViewX1 = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.欠款人 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.应还款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.已换款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.欠款开始日期 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.商品名称 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.销售订单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否偿还余款 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.应再还款金额 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.操作者 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).BeginInit();
            this.groupPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(747, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "销账";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Enabled = false;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton2.Text = "修改";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton3.Text = "刷新";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton4.Text = "退出";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.dateTimeInput1);
            this.groupPanel1.Controls.Add(this.textBoxX7);
            this.groupPanel1.Controls.Add(this.labelX7);
            this.groupPanel1.Controls.Add(this.labelX6);
            this.groupPanel1.Controls.Add(this.textBoxX5);
            this.groupPanel1.Controls.Add(this.labelX5);
            this.groupPanel1.Controls.Add(this.textBoxX4);
            this.groupPanel1.Controls.Add(this.labelX4);
            this.groupPanel1.Controls.Add(this.textBoxX3);
            this.groupPanel1.Controls.Add(this.labelX3);
            this.groupPanel1.Controls.Add(this.textBoxX2);
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.textBoxX1);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Location = new System.Drawing.Point(0, 40);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(747, 150);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.Class = "";
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.Class = "";
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "基本信息";
            // 
            // dateTimeInput1
            // 
            // 
            // 
            // 
            this.dateTimeInput1.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dateTimeInput1.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dateTimeInput1.ButtonDropDown.Visible = true;
            this.dateTimeInput1.Location = new System.Drawing.Point(316, 56);
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dateTimeInput1.MonthCalendar.BackgroundStyle.Class = "";
            this.dateTimeInput1.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dateTimeInput1.MonthCalendar.CommandsBackgroundStyle.Class = "";
            this.dateTimeInput1.MonthCalendar.DisplayMonth = new System.DateTime(2015, 3, 1, 0, 0, 0, 0);
            this.dateTimeInput1.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dateTimeInput1.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dateTimeInput1.MonthCalendar.NavigationBackgroundStyle.Class = "";
            this.dateTimeInput1.MonthCalendar.TodayButtonVisible = true;
            this.dateTimeInput1.MonthCalendar.WeeklyMarkedDays = new System.DayOfWeek[0];
            this.dateTimeInput1.Name = "dateTimeInput1";
            this.dateTimeInput1.Size = new System.Drawing.Size(121, 21);
            this.dateTimeInput1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dateTimeInput1.TabIndex = 14;
            // 
            // textBoxX7
            // 
            // 
            // 
            // 
            this.textBoxX7.Border.Class = "TextBoxBorder";
            this.textBoxX7.Location = new System.Drawing.Point(569, 58);
            this.textBoxX7.Name = "textBoxX7";
            this.textBoxX7.Size = new System.Drawing.Size(100, 21);
            this.textBoxX7.TabIndex = 13;
            // 
            // labelX7
            // 
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.Class = "";
            this.labelX7.Location = new System.Drawing.Point(455, 57);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(75, 23);
            this.labelX7.TabIndex = 12;
            this.labelX7.Text = "操作人：";
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.Class = "";
            this.labelX6.Location = new System.Drawing.Point(219, 59);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(75, 23);
            this.labelX6.TabIndex = 10;
            this.labelX6.Text = "还款日期：";
            // 
            // textBoxX5
            // 
            // 
            // 
            // 
            this.textBoxX5.Border.Class = "TextBoxBorder";
            this.textBoxX5.Location = new System.Drawing.Point(100, 56);
            this.textBoxX5.Name = "textBoxX5";
            this.textBoxX5.Size = new System.Drawing.Size(100, 21);
            this.textBoxX5.TabIndex = 9;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.Class = "";
            this.labelX5.Location = new System.Drawing.Point(19, 57);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "欠款日期：";
            // 
            // textBoxX4
            // 
            // 
            // 
            // 
            this.textBoxX4.Border.Class = "TextBoxBorder";
            this.textBoxX4.Location = new System.Drawing.Point(100, 102);
            this.textBoxX4.Multiline = true;
            this.textBoxX4.Name = "textBoxX4";
            this.textBoxX4.Size = new System.Drawing.Size(569, 21);
            this.textBoxX4.TabIndex = 7;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.Class = "";
            this.labelX4.Location = new System.Drawing.Point(19, 102);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(75, 23);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "商品名称：";
            // 
            // textBoxX3
            // 
            // 
            // 
            // 
            this.textBoxX3.Border.Class = "TextBoxBorder";
            this.textBoxX3.Location = new System.Drawing.Point(569, 6);
            this.textBoxX3.Name = "textBoxX3";
            this.textBoxX3.Size = new System.Drawing.Size(100, 21);
            this.textBoxX3.TabIndex = 5;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.Class = "";
            this.labelX3.Location = new System.Drawing.Point(454, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(75, 23);
            this.labelX3.TabIndex = 4;
            this.labelX3.Text = "付款金额：";
            // 
            // textBoxX2
            // 
            // 
            // 
            // 
            this.textBoxX2.Border.Class = "TextBoxBorder";
            this.textBoxX2.Location = new System.Drawing.Point(316, 7);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 21);
            this.textBoxX2.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.Class = "";
            this.labelX2.Location = new System.Drawing.Point(219, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "欠款人：";
            // 
            // textBoxX1
            // 
            // 
            // 
            // 
            this.textBoxX1.Border.Class = "TextBoxBorder";
            this.textBoxX1.Location = new System.Drawing.Point(100, 5);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 21);
            this.textBoxX1.TabIndex = 1;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.Class = "";
            this.labelX1.Location = new System.Drawing.Point(19, 3);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "商品编号：";
            // 
            // groupPanel2
            // 
            this.groupPanel2.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel2.Controls.Add(this.dataGridViewX1);
            this.groupPanel2.Location = new System.Drawing.Point(12, 196);
            this.groupPanel2.Name = "groupPanel2";
            this.groupPanel2.Size = new System.Drawing.Size(735, 183);
            // 
            // 
            // 
            this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel2.Style.BackColorGradientAngle = 90;
            this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderBottomWidth = 1;
            this.groupPanel2.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderLeftWidth = 1;
            this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderRightWidth = 1;
            this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel2.Style.BorderTopWidth = 1;
            this.groupPanel2.Style.Class = "";
            this.groupPanel2.Style.CornerDiameter = 4;
            this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel2.StyleMouseDown.Class = "";
            // 
            // 
            // 
            this.groupPanel2.StyleMouseOver.Class = "";
            this.groupPanel2.TabIndex = 2;
            this.groupPanel2.Text = "欠款信息";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.欠款人,
            this.应还款金额,
            this.已换款金额,
            this.商品编号,
            this.欠款开始日期,
            this.商品名称,
            this.销售订单号,
            this.是否偿还余款,
            this.应再还款金额,
            this.操作者});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(7, 3);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.ReadOnly = true;
            this.dataGridViewX1.RowTemplate.Height = 23;
            this.dataGridViewX1.Size = new System.Drawing.Size(698, 155);
            this.dataGridViewX1.TabIndex = 0;
            this.dataGridViewX1.Click += new System.EventHandler(this.dataGridViewX1_Click);
            // 
            // 欠款人
            // 
            this.欠款人.DataPropertyName = "LOAD_PERSON";
            this.欠款人.HeaderText = "欠款人";
            this.欠款人.Name = "欠款人";
            this.欠款人.ReadOnly = true;
            // 
            // 应还款金额
            // 
            this.应还款金额.DataPropertyName = "LOAD_MUCH";
            this.应还款金额.HeaderText = "应还款金额";
            this.应还款金额.Name = "应还款金额";
            this.应还款金额.ReadOnly = true;
            // 
            // 已换款金额
            // 
            this.已换款金额.DataPropertyName = "HAVE_PAY";
            this.已换款金额.HeaderText = "已还款金额";
            this.已换款金额.Name = "已换款金额";
            this.已换款金额.ReadOnly = true;
            // 
            // 商品编号
            // 
            this.商品编号.DataPropertyName = "GOOD_ID";
            this.商品编号.HeaderText = "商品编号";
            this.商品编号.Name = "商品编号";
            this.商品编号.ReadOnly = true;
            // 
            // 欠款开始日期
            // 
            this.欠款开始日期.DataPropertyName = "LOAD_DATE";
            this.欠款开始日期.HeaderText = "欠款开始日期";
            this.欠款开始日期.Name = "欠款开始日期";
            this.欠款开始日期.ReadOnly = true;
            // 
            // 商品名称
            // 
            this.商品名称.DataPropertyName = "GOOD_NAME";
            this.商品名称.HeaderText = "商品名称";
            this.商品名称.Name = "商品名称";
            this.商品名称.ReadOnly = true;
            // 
            // 销售订单号
            // 
            this.销售订单号.DataPropertyName = "ORDER_ID";
            this.销售订单号.HeaderText = "销售订单号";
            this.销售订单号.Name = "销售订单号";
            this.销售订单号.ReadOnly = true;
            // 
            // 是否偿还余款
            // 
            this.是否偿还余款.DataPropertyName = "DO_PAY_ALL";
            this.是否偿还余款.HeaderText = "是否偿还余款";
            this.是否偿还余款.Name = "是否偿还余款";
            this.是否偿还余款.ReadOnly = true;
            // 
            // 应再还款金额
            // 
            this.应再还款金额.DataPropertyName = "INSPECT_PAY";
            this.应再还款金额.HeaderText = "应再偿还金额";
            this.应再还款金额.Name = "应再还款金额";
            this.应再还款金额.ReadOnly = true;
            // 
            // 操作者
            // 
            this.操作者.DataPropertyName = "OPERATER";
            this.操作者.HeaderText = "操作者";
            this.操作者.Name = "操作者";
            this.操作者.ReadOnly = true;
            // 
            // Cancel_Cuestcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 391);
            this.Controls.Add(this.groupPanel2);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cancel_Cuestcs";
            this.Text = "对客户销账";
            this.Load += new System.EventHandler(this.Cancel_Cuestcs_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeInput1)).EndInit();
            this.groupPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX5;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX4;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX3;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX2;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxX7;
        private DevComponents.DotNetBar.LabelX labelX7;
        private System.Windows.Forms.DataGridViewTextBoxColumn 欠款人;
        private System.Windows.Forms.DataGridViewTextBoxColumn 应还款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 已换款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 欠款开始日期;
        private System.Windows.Forms.DataGridViewTextBoxColumn 商品名称;
        private System.Windows.Forms.DataGridViewTextBoxColumn 销售订单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 是否偿还余款;
        private System.Windows.Forms.DataGridViewTextBoxColumn 应再还款金额;
        private System.Windows.Forms.DataGridViewTextBoxColumn 操作者;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dateTimeInput1;
    }
}
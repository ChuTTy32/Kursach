namespace crmAutoService
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.RepairInfo = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AutoInfo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ClientInfo = new System.Windows.Forms.Label();
            this.StatButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainText = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.autoServiceDataSet = new crmAutoService.AutoServiceDataSet();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientTableAdapter = new crmAutoService.AutoServiceDataSetTableAdapters.ClientTableAdapter();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bankClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountCardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carTableAdapter = new crmAutoService.AutoServiceDataSetTableAdapters.CarTableAdapter();
            this.carIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceDueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodsTableAdapter = new crmAutoService.AutoServiceDataSetTableAdapters.GoodsTableAdapter();
            this.goodsIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repairPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensorsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.counttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BottomPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BottomPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BottomPanel.BackgroundImage")));
            this.BottomPanel.Controls.Add(this.panel6);
            this.BottomPanel.Controls.Add(this.panel5);
            this.BottomPanel.Controls.Add(this.panel4);
            this.BottomPanel.Controls.Add(this.StatButton);
            this.BottomPanel.Controls.Add(this.AddButton);
            this.BottomPanel.Controls.Add(this.ClearButton);
            this.BottomPanel.Controls.Add(this.panel2);
            this.BottomPanel.Controls.Add(this.panel1);
            this.BottomPanel.Controls.Add(this.panel3);
            this.BottomPanel.Controls.Add(this.textBox1);
            this.BottomPanel.Controls.Add(this.RefreshButton);
            this.BottomPanel.Controls.Add(this.TopPanel);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(960, 720);
            this.BottomPanel.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Controls.Add(this.RepairInfo);
            this.panel6.Location = new System.Drawing.Point(643, 128);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(314, 64);
            this.panel6.TabIndex = 17;
            // 
            // RepairInfo
            // 
            this.RepairInfo.BackColor = System.Drawing.Color.Transparent;
            this.RepairInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RepairInfo.Location = new System.Drawing.Point(0, 0);
            this.RepairInfo.Name = "RepairInfo";
            this.RepairInfo.Size = new System.Drawing.Size(314, 64);
            this.RepairInfo.TabIndex = 1;
            this.RepairInfo.Text = "Информация о ремонте";
            this.RepairInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.AutoInfo);
            this.panel5.Location = new System.Drawing.Point(323, 125);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(314, 64);
            this.panel5.TabIndex = 17;
            // 
            // AutoInfo
            // 
            this.AutoInfo.BackColor = System.Drawing.Color.Transparent;
            this.AutoInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutoInfo.Location = new System.Drawing.Point(0, 0);
            this.AutoInfo.Name = "AutoInfo";
            this.AutoInfo.Size = new System.Drawing.Size(314, 64);
            this.AutoInfo.TabIndex = 1;
            this.AutoInfo.Text = "Информация по автомобилю";
            this.AutoInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.ClientInfo);
            this.panel4.Location = new System.Drawing.Point(3, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(314, 64);
            this.panel4.TabIndex = 16;
            // 
            // ClientInfo
            // 
            this.ClientInfo.BackColor = System.Drawing.Color.Transparent;
            this.ClientInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClientInfo.Location = new System.Drawing.Point(0, 0);
            this.ClientInfo.Name = "ClientInfo";
            this.ClientInfo.Size = new System.Drawing.Size(314, 64);
            this.ClientInfo.TabIndex = 0;
            this.ClientInfo.Text = "Информация о клиенте";
            this.ClientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatButton
            // 
            this.StatButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatButton.Location = new System.Drawing.Point(482, 55);
            this.StatButton.Name = "StatButton";
            this.StatButton.Size = new System.Drawing.Size(155, 64);
            this.StatButton.TabIndex = 15;
            this.StatButton.Text = "Получить статистику";
            this.StatButton.UseVisualStyleBackColor = true;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(323, 55);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(155, 64);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Добавить Элемент";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.ClearButton.Location = new System.Drawing.Point(162, 55);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(155, 64);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Удалить Элемент";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(3, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 580);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(323, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 580);
            this.panel1.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.dataGridView3);
            this.panel3.Location = new System.Drawing.Point(643, 128);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 580);
            this.panel3.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(643, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 61);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Поиск поля...";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(3, 55);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(155, 64);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Обновить страницу";
            this.RefreshButton.UseVisualStyleBackColor = true;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.TopPanel.Controls.Add(this.CloseButton);
            this.TopPanel.Controls.Add(this.TitleLabel);
            this.TopPanel.Controls.Add(this.MainText);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(960, 52);
            this.TopPanel.TabIndex = 2;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.AutoSize = true;
            this.CloseButton.BackColor = System.Drawing.SystemColors.Control;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(916, 12);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 34);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLabel.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold);
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(221, 52);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "#CTO_CRM";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MainText
            // 
            this.MainText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainText.Font = new System.Drawing.Font("Arial Black", 25F, System.Drawing.FontStyle.Bold);
            this.MainText.Location = new System.Drawing.Point(0, 0);
            this.MainText.Name = "MainText";
            this.MainText.Size = new System.Drawing.Size(960, 52);
            this.MainText.TabIndex = 0;
            this.MainText.Text = "Главное меню";
            this.MainText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainText.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Mainframe_MouseDown);
            this.MainText.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Mainframe_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.phoneClientDataGridViewTextBoxColumn,
            this.addressClientDataGridViewTextBoxColumn,
            this.bankClientDataGridViewTextBoxColumn,
            this.accountClientDataGridViewTextBoxColumn,
            this.carBrandDataGridViewTextBoxColumn,
            this.dateStartDataGridViewTextBoxColumn,
            this.discountCardDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(5, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(306, 504);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carIDDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn1,
            this.carModelDataGridViewTextBoxColumn,
            this.carTypeDataGridViewTextBoxColumn,
            this.carNumberDataGridViewTextBoxColumn,
            this.serviceDueDateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.carBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(308, 504);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.goodsIDDataGridViewTextBoxColumn,
            this.goodsNameDataGridViewTextBoxColumn,
            this.viewwDataGridViewTextBoxColumn,
            this.repairPriceDataGridViewTextBoxColumn,
            this.sensorsDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.unitDataGridViewTextBoxColumn,
            this.costUnitDataGridViewTextBoxColumn,
            this.counttDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.goodsBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 70);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(308, 507);
            this.dataGridView3.TabIndex = 2;
            // 
            // autoServiceDataSet
            // 
            this.autoServiceDataSet.DataSetName = "AutoServiceDataSet";
            this.autoServiceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.autoServiceDataSet;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            // 
            // phoneClientDataGridViewTextBoxColumn
            // 
            this.phoneClientDataGridViewTextBoxColumn.DataPropertyName = "PhoneClient";
            this.phoneClientDataGridViewTextBoxColumn.HeaderText = "PhoneClient";
            this.phoneClientDataGridViewTextBoxColumn.Name = "phoneClientDataGridViewTextBoxColumn";
            // 
            // addressClientDataGridViewTextBoxColumn
            // 
            this.addressClientDataGridViewTextBoxColumn.DataPropertyName = "AddressClient";
            this.addressClientDataGridViewTextBoxColumn.HeaderText = "AddressClient";
            this.addressClientDataGridViewTextBoxColumn.Name = "addressClientDataGridViewTextBoxColumn";
            // 
            // bankClientDataGridViewTextBoxColumn
            // 
            this.bankClientDataGridViewTextBoxColumn.DataPropertyName = "BankClient";
            this.bankClientDataGridViewTextBoxColumn.HeaderText = "BankClient";
            this.bankClientDataGridViewTextBoxColumn.Name = "bankClientDataGridViewTextBoxColumn";
            // 
            // accountClientDataGridViewTextBoxColumn
            // 
            this.accountClientDataGridViewTextBoxColumn.DataPropertyName = "AccountClient";
            this.accountClientDataGridViewTextBoxColumn.HeaderText = "AccountClient";
            this.accountClientDataGridViewTextBoxColumn.Name = "accountClientDataGridViewTextBoxColumn";
            // 
            // carBrandDataGridViewTextBoxColumn
            // 
            this.carBrandDataGridViewTextBoxColumn.DataPropertyName = "CarBrand";
            this.carBrandDataGridViewTextBoxColumn.HeaderText = "CarBrand";
            this.carBrandDataGridViewTextBoxColumn.Name = "carBrandDataGridViewTextBoxColumn";
            // 
            // dateStartDataGridViewTextBoxColumn
            // 
            this.dateStartDataGridViewTextBoxColumn.DataPropertyName = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.HeaderText = "DateStart";
            this.dateStartDataGridViewTextBoxColumn.Name = "dateStartDataGridViewTextBoxColumn";
            // 
            // discountCardDataGridViewTextBoxColumn
            // 
            this.discountCardDataGridViewTextBoxColumn.DataPropertyName = "DiscountCard";
            this.discountCardDataGridViewTextBoxColumn.HeaderText = "DiscountCard";
            this.discountCardDataGridViewTextBoxColumn.Name = "discountCardDataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataMember = "Car";
            this.carBindingSource.DataSource = this.autoServiceDataSet;
            // 
            // carTableAdapter
            // 
            this.carTableAdapter.ClearBeforeFill = true;
            // 
            // carIDDataGridViewTextBoxColumn
            // 
            this.carIDDataGridViewTextBoxColumn.DataPropertyName = "CarID";
            this.carIDDataGridViewTextBoxColumn.HeaderText = "CarID";
            this.carIDDataGridViewTextBoxColumn.Name = "carIDDataGridViewTextBoxColumn";
            // 
            // clientNameDataGridViewTextBoxColumn1
            // 
            this.clientNameDataGridViewTextBoxColumn1.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn1.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn1.Name = "clientNameDataGridViewTextBoxColumn1";
            // 
            // carModelDataGridViewTextBoxColumn
            // 
            this.carModelDataGridViewTextBoxColumn.DataPropertyName = "CarModel";
            this.carModelDataGridViewTextBoxColumn.HeaderText = "CarModel";
            this.carModelDataGridViewTextBoxColumn.Name = "carModelDataGridViewTextBoxColumn";
            // 
            // carTypeDataGridViewTextBoxColumn
            // 
            this.carTypeDataGridViewTextBoxColumn.DataPropertyName = "CarType";
            this.carTypeDataGridViewTextBoxColumn.HeaderText = "CarType";
            this.carTypeDataGridViewTextBoxColumn.Name = "carTypeDataGridViewTextBoxColumn";
            // 
            // carNumberDataGridViewTextBoxColumn
            // 
            this.carNumberDataGridViewTextBoxColumn.DataPropertyName = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.HeaderText = "CarNumber";
            this.carNumberDataGridViewTextBoxColumn.Name = "carNumberDataGridViewTextBoxColumn";
            // 
            // serviceDueDateDataGridViewTextBoxColumn
            // 
            this.serviceDueDateDataGridViewTextBoxColumn.DataPropertyName = "ServiceDueDate";
            this.serviceDueDateDataGridViewTextBoxColumn.HeaderText = "ServiceDueDate";
            this.serviceDueDateDataGridViewTextBoxColumn.Name = "serviceDueDateDataGridViewTextBoxColumn";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.autoServiceDataSet;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // goodsIDDataGridViewTextBoxColumn
            // 
            this.goodsIDDataGridViewTextBoxColumn.DataPropertyName = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.HeaderText = "GoodsID";
            this.goodsIDDataGridViewTextBoxColumn.Name = "goodsIDDataGridViewTextBoxColumn";
            // 
            // goodsNameDataGridViewTextBoxColumn
            // 
            this.goodsNameDataGridViewTextBoxColumn.DataPropertyName = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.HeaderText = "GoodsName";
            this.goodsNameDataGridViewTextBoxColumn.Name = "goodsNameDataGridViewTextBoxColumn";
            // 
            // viewwDataGridViewTextBoxColumn
            // 
            this.viewwDataGridViewTextBoxColumn.DataPropertyName = "Vieww";
            this.viewwDataGridViewTextBoxColumn.HeaderText = "Vieww";
            this.viewwDataGridViewTextBoxColumn.Name = "viewwDataGridViewTextBoxColumn";
            // 
            // repairPriceDataGridViewTextBoxColumn
            // 
            this.repairPriceDataGridViewTextBoxColumn.DataPropertyName = "RepairPrice";
            this.repairPriceDataGridViewTextBoxColumn.HeaderText = "RepairPrice";
            this.repairPriceDataGridViewTextBoxColumn.Name = "repairPriceDataGridViewTextBoxColumn";
            // 
            // sensorsDataGridViewTextBoxColumn
            // 
            this.sensorsDataGridViewTextBoxColumn.DataPropertyName = "Sensors";
            this.sensorsDataGridViewTextBoxColumn.HeaderText = "Sensors";
            this.sensorsDataGridViewTextBoxColumn.Name = "sensorsDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // unitDataGridViewTextBoxColumn
            // 
            this.unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            this.unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            this.unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            // 
            // costUnitDataGridViewTextBoxColumn
            // 
            this.costUnitDataGridViewTextBoxColumn.DataPropertyName = "CostUnit";
            this.costUnitDataGridViewTextBoxColumn.HeaderText = "CostUnit";
            this.costUnitDataGridViewTextBoxColumn.Name = "costUnitDataGridViewTextBoxColumn";
            // 
            // counttDataGridViewTextBoxColumn
            // 
            this.counttDataGridViewTextBoxColumn.DataPropertyName = "Countt";
            this.counttDataGridViewTextBoxColumn.HeaderText = "Countt";
            this.counttDataGridViewTextBoxColumn.Name = "counttDataGridViewTextBoxColumn";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 720);
            this.Controls.Add(this.BottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autoServiceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label MainText;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button StatButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label ClientInfo;
        private System.Windows.Forms.Label RepairInfo;
        private System.Windows.Forms.Label AutoInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private AutoServiceDataSet autoServiceDataSet;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private AutoServiceDataSetTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bankClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountCardDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carBindingSource;
        private AutoServiceDataSetTableAdapters.CarTableAdapter carTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn carIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn carModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn carNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceDueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private AutoServiceDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn viewwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensorsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counttDataGridViewTextBoxColumn;
    }
}
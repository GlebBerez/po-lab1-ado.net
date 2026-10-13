namespace Lab1_ADO_NET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvTypes = new DataGridView();
            btnLoadTypes = new Button();
            btnSaveTypes = new Button();
            btnAddType = new Button();
            btnDeleteType = new Button();
            tab_equipment = new TabControl();
            tabTypes = new TabPage();
            tabEquipment = new TabPage();
            btnDeleteEquipment = new Button();
            btnAddEquipment = new Button();
            btnSaveEquipment = new Button();
            btnLoadEquipment = new Button();
            dgvEquipment = new DataGridView();
            tabSql = new TabPage();
            dgvRawSql = new DataGridView();
            btnExecuteSql = new Button();
            cmbTypeFilter = new ComboBox();
            label2 = new Label();
            nudMinCost = new NumericUpDown();
            label1 = new Label();
            tabProc = new TabPage();
            dgvProc = new DataGridView();
            btnExecuteProc = new Button();
            cmbProcType = new ComboBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTypes).BeginInit();
            tab_equipment.SuspendLayout();
            tabTypes.SuspendLayout();
            tabEquipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).BeginInit();
            tabSql.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRawSql).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinCost).BeginInit();
            tabProc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProc).BeginInit();
            SuspendLayout();
            // 
            // dgvTypes
            // 
            dgvTypes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTypes.Location = new Point(-2, 0);
            dgvTypes.Name = "dgvTypes";
            dgvTypes.Size = new Size(1591, 476);
            dgvTypes.TabIndex = 0;
            // 
            // btnLoadTypes
            // 
            btnLoadTypes.Location = new Point(144, 506);
            btnLoadTypes.Name = "btnLoadTypes";
            btnLoadTypes.Size = new Size(116, 40);
            btnLoadTypes.TabIndex = 1;
            btnLoadTypes.Text = "Загрузить";
            btnLoadTypes.UseVisualStyleBackColor = true;
            btnLoadTypes.Click += btnLoadTypes_Click;
            // 
            // btnSaveTypes
            // 
            btnSaveTypes.Location = new Point(384, 506);
            btnSaveTypes.Name = "btnSaveTypes";
            btnSaveTypes.Size = new Size(116, 40);
            btnSaveTypes.TabIndex = 2;
            btnSaveTypes.Text = "Сохранить";
            btnSaveTypes.UseVisualStyleBackColor = true;
            btnSaveTypes.Click += btnSaveTypes_Click;
            // 
            // btnAddType
            // 
            btnAddType.Location = new Point(601, 506);
            btnAddType.Name = "btnAddType";
            btnAddType.Size = new Size(116, 40);
            btnAddType.TabIndex = 3;
            btnAddType.Text = "Добавить";
            btnAddType.UseVisualStyleBackColor = true;
            btnAddType.Click += btnAddType_Click;
            // 
            // btnDeleteType
            // 
            btnDeleteType.Location = new Point(813, 506);
            btnDeleteType.Name = "btnDeleteType";
            btnDeleteType.Size = new Size(116, 40);
            btnDeleteType.TabIndex = 4;
            btnDeleteType.Text = "Удалить";
            btnDeleteType.UseVisualStyleBackColor = true;
            btnDeleteType.Click += btnDeleteType_Click;
            // 
            // tab_equipment
            // 
            tab_equipment.Controls.Add(tabTypes);
            tab_equipment.Controls.Add(tabEquipment);
            tab_equipment.Controls.Add(tabSql);
            tab_equipment.Controls.Add(tabProc);
            tab_equipment.Location = new Point(1, 1);
            tab_equipment.Name = "tab_equipment";
            tab_equipment.SelectedIndex = 0;
            tab_equipment.Size = new Size(1600, 667);
            tab_equipment.TabIndex = 5;
            // 
            // tabTypes
            // 
            tabTypes.Controls.Add(dgvTypes);
            tabTypes.Controls.Add(btnDeleteType);
            tabTypes.Controls.Add(btnLoadTypes);
            tabTypes.Controls.Add(btnAddType);
            tabTypes.Controls.Add(btnSaveTypes);
            tabTypes.Location = new Point(4, 24);
            tabTypes.Name = "tabTypes";
            tabTypes.Padding = new Padding(3);
            tabTypes.Size = new Size(1592, 639);
            tabTypes.TabIndex = 0;
            tabTypes.Text = "Справочник типов";
            tabTypes.UseVisualStyleBackColor = true;
            // 
            // tabEquipment
            // 
            tabEquipment.Controls.Add(btnDeleteEquipment);
            tabEquipment.Controls.Add(btnAddEquipment);
            tabEquipment.Controls.Add(btnSaveEquipment);
            tabEquipment.Controls.Add(btnLoadEquipment);
            tabEquipment.Controls.Add(dgvEquipment);
            tabEquipment.Location = new Point(4, 24);
            tabEquipment.Name = "tabEquipment";
            tabEquipment.Padding = new Padding(3);
            tabEquipment.Size = new Size(791, 425);
            tabEquipment.TabIndex = 1;
            tabEquipment.Text = "Оборудование";
            tabEquipment.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEquipment
            // 
            btnDeleteEquipment.Location = new Point(573, 317);
            btnDeleteEquipment.Name = "btnDeleteEquipment";
            btnDeleteEquipment.Size = new Size(118, 45);
            btnDeleteEquipment.TabIndex = 4;
            btnDeleteEquipment.Text = "Удалить";
            btnDeleteEquipment.UseVisualStyleBackColor = true;
            btnDeleteEquipment.Click += btnDeleteEquipment_Click;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.Location = new Point(405, 317);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(118, 45);
            btnAddEquipment.TabIndex = 3;
            btnAddEquipment.Text = "Добавить";
            btnAddEquipment.UseVisualStyleBackColor = true;
            btnAddEquipment.Click += btnAddEquipment_Click;
            // 
            // btnSaveEquipment
            // 
            btnSaveEquipment.Location = new Point(229, 317);
            btnSaveEquipment.Name = "btnSaveEquipment";
            btnSaveEquipment.Size = new Size(118, 45);
            btnSaveEquipment.TabIndex = 2;
            btnSaveEquipment.Text = "Сохранить";
            btnSaveEquipment.UseVisualStyleBackColor = true;
            btnSaveEquipment.Click += btnSaveEquipment_Click;
            // 
            // btnLoadEquipment
            // 
            btnLoadEquipment.Location = new Point(52, 317);
            btnLoadEquipment.Name = "btnLoadEquipment";
            btnLoadEquipment.Size = new Size(118, 45);
            btnLoadEquipment.TabIndex = 1;
            btnLoadEquipment.Text = "Загрузить";
            btnLoadEquipment.UseVisualStyleBackColor = true;
            btnLoadEquipment.Click += btnLoadEquipment_Click;
            // 
            // dgvEquipment
            // 
            dgvEquipment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEquipment.Location = new Point(0, 0);
            dgvEquipment.Name = "dgvEquipment";
            dgvEquipment.Size = new Size(791, 266);
            dgvEquipment.TabIndex = 0;
            // 
            // tabSql
            // 
            tabSql.Controls.Add(dgvRawSql);
            tabSql.Controls.Add(btnExecuteSql);
            tabSql.Controls.Add(cmbTypeFilter);
            tabSql.Controls.Add(label2);
            tabSql.Controls.Add(nudMinCost);
            tabSql.Controls.Add(label1);
            tabSql.Location = new Point(4, 24);
            tabSql.Name = "tabSql";
            tabSql.Padding = new Padding(3);
            tabSql.Size = new Size(791, 425);
            tabSql.TabIndex = 2;
            tabSql.Text = "SQL-запрос";
            tabSql.UseVisualStyleBackColor = true;
            // 
            // dgvRawSql
            // 
            dgvRawSql.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRawSql.Location = new Point(0, 194);
            dgvRawSql.Name = "dgvRawSql";
            dgvRawSql.Size = new Size(791, 228);
            dgvRawSql.TabIndex = 5;
            // 
            // btnExecuteSql
            // 
            btnExecuteSql.Location = new Point(270, 64);
            btnExecuteSql.Name = "btnExecuteSql";
            btnExecuteSql.Size = new Size(178, 59);
            btnExecuteSql.TabIndex = 4;
            btnExecuteSql.Text = "Выполнить запрос";
            btnExecuteSql.UseVisualStyleBackColor = true;
            btnExecuteSql.Click += btnExecuteSql_Click;
            // 
            // cmbTypeFilter
            // 
            cmbTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTypeFilter.FormattingEnabled = true;
            cmbTypeFilter.Location = new Point(48, 148);
            cmbTypeFilter.Name = "cmbTypeFilter";
            cmbTypeFilter.Size = new Size(121, 23);
            cmbTypeFilter.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 116);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "Тип";
            // 
            // nudMinCost
            // 
            nudMinCost.DecimalPlaces = 2;
            nudMinCost.Location = new Point(48, 64);
            nudMinCost.Maximum = new decimal(new int[] { 99999999, 0, 0, 0 });
            nudMinCost.Name = "nudMinCost";
            nudMinCost.Size = new Size(120, 23);
            nudMinCost.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 37);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 0;
            label1.Text = "Мин.стоимость";
            // 
            // tabProc
            // 
            tabProc.Controls.Add(dgvProc);
            tabProc.Controls.Add(btnExecuteProc);
            tabProc.Controls.Add(cmbProcType);
            tabProc.Controls.Add(label3);
            tabProc.Location = new Point(4, 24);
            tabProc.Name = "tabProc";
            tabProc.Padding = new Padding(3);
            tabProc.Size = new Size(791, 425);
            tabProc.TabIndex = 3;
            tabProc.Text = "Хранимая процедура";
            tabProc.UseVisualStyleBackColor = true;
            // 
            // dgvProc
            // 
            dgvProc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProc.Location = new Point(3, 126);
            dgvProc.Name = "dgvProc";
            dgvProc.Size = new Size(788, 296);
            dgvProc.TabIndex = 3;
            // 
            // btnExecuteProc
            // 
            btnExecuteProc.Location = new Point(243, 46);
            btnExecuteProc.Name = "btnExecuteProc";
            btnExecuteProc.Size = new Size(153, 43);
            btnExecuteProc.TabIndex = 2;
            btnExecuteProc.Text = "Выполнить процедуру";
            btnExecuteProc.UseVisualStyleBackColor = true;
            btnExecuteProc.Click += btnExecuteProc_Click;
            // 
            // cmbProcType
            // 
            cmbProcType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProcType.FormattingEnabled = true;
            cmbProcType.Location = new Point(29, 66);
            cmbProcType.Name = "cmbProcType";
            cmbProcType.Size = new Size(121, 23);
            cmbProcType.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 30);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 0;
            label3.Text = "Тип оборудования";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1597, 709);
            Controls.Add(tab_equipment);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTypes).EndInit();
            tab_equipment.ResumeLayout(false);
            tabTypes.ResumeLayout(false);
            tabEquipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEquipment).EndInit();
            tabSql.ResumeLayout(false);
            tabSql.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRawSql).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinCost).EndInit();
            tabProc.ResumeLayout(false);
            tabProc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProc).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvTypes;
        private Button btnLoadTypes;
        private Button btnSaveTypes;
        private Button btnAddType;
        private Button btnDeleteType;
        private TabControl tab_equipment;
        private TabPage tabTypes;
        private TabPage tabEquipment;
        private TabPage tabSql;
        private TabPage tabProc;
        private Button btnDeleteEquipment;
        private Button btnAddEquipment;
        private Button btnSaveEquipment;
        private Button btnLoadEquipment;
        private DataGridView dgvEquipment;
        private Button btnExecuteSql;
        private ComboBox cmbTypeFilter;
        private Label label2;
        private NumericUpDown nudMinCost;
        private Label label1;
        private DataGridView dgvRawSql;
        private DataGridView dgvProc;
        private Button btnExecuteProc;
        private ComboBox cmbProcType;
        private Label label3;
    }
}

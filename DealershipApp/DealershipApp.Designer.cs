namespace DealershipApp
{
    partial class dealershipApp
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
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            carsTab = new TabPage();
            carsListBoxLabel = new Label();
            carsListBox = new ListBox();
            employeeTab = new TabPage();
            employeeListBoxLabel = new Label();
            employeeListBox = new ListBox();
            financialsTab = new TabPage();
            dealershipComboBox = new ComboBox();
            employeesBindingSource = new BindingSource(components);
            dealershipBindingSource = new BindingSource(components);
            comboBoxLabel = new Label();
            automobilesBindingSource = new BindingSource(components);
            tabControl1.SuspendLayout();
            carsTab.SuspendLayout();
            employeeTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dealershipBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)automobilesBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(carsTab);
            tabControl1.Controls.Add(employeeTab);
            tabControl1.Controls.Add(financialsTab);
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(1, 30);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(799, 421);
            tabControl1.TabIndex = 0;
            // 
            // carsTab
            // 
            carsTab.Controls.Add(carsListBoxLabel);
            carsTab.Controls.Add(carsListBox);
            carsTab.Location = new Point(4, 26);
            carsTab.Name = "carsTab";
            carsTab.Padding = new Padding(3, 3, 3, 3);
            carsTab.Size = new Size(791, 391);
            carsTab.TabIndex = 0;
            carsTab.Text = "Cars";
            carsTab.UseVisualStyleBackColor = true;
            // 
            // carsListBoxLabel
            // 
            carsListBoxLabel.AutoSize = true;
            carsListBoxLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            carsListBoxLabel.Location = new Point(18, 14);
            carsListBoxLabel.Name = "carsListBoxLabel";
            carsListBoxLabel.Size = new Size(68, 17);
            carsListBoxLabel.TabIndex = 1;
            carsListBoxLabel.Text = "Inventory";
            // 
            // carsListBox
            // 
            carsListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            carsListBox.FormattingEnabled = true;
            carsListBox.ItemHeight = 17;
            carsListBox.Location = new Point(19, 36);
            carsListBox.Name = "carsListBox";
            carsListBox.Size = new Size(198, 157);
            carsListBox.TabIndex = 0;
            // 
            // employeeTab
            // 
            employeeTab.Controls.Add(employeeListBoxLabel);
            employeeTab.Controls.Add(employeeListBox);
            employeeTab.Location = new Point(4, 26);
            employeeTab.Name = "employeeTab";
            employeeTab.Padding = new Padding(3, 3, 3, 3);
            employeeTab.Size = new Size(791, 391);
            employeeTab.TabIndex = 1;
            employeeTab.Text = "Employees";
            employeeTab.UseVisualStyleBackColor = true;
            // 
            // employeeListBoxLabel
            // 
            employeeListBoxLabel.AutoSize = true;
            employeeListBoxLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            employeeListBoxLabel.Location = new Point(6, 28);
            employeeListBoxLabel.Name = "employeeListBoxLabel";
            employeeListBoxLabel.Size = new Size(74, 17);
            employeeListBoxLabel.TabIndex = 3;
            employeeListBoxLabel.Text = "Employees";
            // 
            // employeeListBox
            // 
            employeeListBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            employeeListBox.FormattingEnabled = true;
            employeeListBox.ItemHeight = 17;
            employeeListBox.Location = new Point(7, 50);
            employeeListBox.Name = "employeeListBox";
            employeeListBox.Size = new Size(198, 157);
            employeeListBox.TabIndex = 2;
            // 
            // financialsTab
            // 
            financialsTab.Location = new Point(4, 26);
            financialsTab.Name = "financialsTab";
            financialsTab.Padding = new Padding(3, 3, 3, 3);
            financialsTab.Size = new Size(791, 391);
            financialsTab.TabIndex = 2;
            financialsTab.Text = "Financials";
            financialsTab.UseVisualStyleBackColor = true;
            // 
            // dealershipComboBox
            // 
            dealershipComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dealershipComboBox.FormattingEnabled = true;
            dealershipComboBox.Location = new Point(82, 1);
            dealershipComboBox.Name = "dealershipComboBox";
            dealershipComboBox.Size = new Size(156, 23);
            dealershipComboBox.TabIndex = 0;
            dealershipComboBox.SelectedValueChanged += dealershipComboBox_SelectedValueChanged;
            // 
            // employeesBindingSource
            // 
            employeesBindingSource.DataMember = "Employees";
            employeesBindingSource.DataSource = dealershipBindingSource;
            // 
            // dealershipBindingSource
            // 
            dealershipBindingSource.DataSource = typeof(DealershipLibrary.Dealership);
            // 
            // comboBoxLabel
            // 
            comboBoxLabel.AutoSize = true;
            comboBoxLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxLabel.Location = new Point(7, 4);
            comboBoxLabel.Name = "comboBoxLabel";
            comboBoxLabel.Size = new Size(69, 15);
            comboBoxLabel.TabIndex = 1;
            comboBoxLabel.Text = "Dealership:";
            // 
            // automobilesBindingSource
            // 
            automobilesBindingSource.DataMember = "Automobiles";
            automobilesBindingSource.DataSource = dealershipBindingSource;
            // 
            // dealershipApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(comboBoxLabel);
            Controls.Add(dealershipComboBox);
            Controls.Add(tabControl1);
            Name = "dealershipApp";
            Text = "Dealership App";
            tabControl1.ResumeLayout(false);
            carsTab.ResumeLayout(false);
            carsTab.PerformLayout();
            employeeTab.ResumeLayout(false);
            employeeTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)employeesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dealershipBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)automobilesBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage carsTab;
        private TabPage employeeTab;
        private ComboBox dealershipComboBox;
        private Label comboBoxLabel;
        private BindingSource dealershipBindingSource;
        private BindingSource employeesBindingSource;
        private BindingSource automobilesBindingSource;
        private ListBox carsListBox;
        private Label carsListBoxLabel;
        private Label employeeListBoxLabel;
        private ListBox employeeListBox;
        private TabPage financialsTab;
    }
}
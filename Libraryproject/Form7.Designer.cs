namespace Libraryproject
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            System.Windows.Forms.Label staff_IDLabel;
            System.Windows.Forms.Label staff_nameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label designationLabel;
            this.libraryDataSet = new Libraryproject.libraryDataSet();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Libraryproject.libraryDataSetTableAdapters.staffTableAdapter();
            this.tableAdapterManager = new Libraryproject.libraryDataSetTableAdapters.TableAdapterManager();
            this.staffBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.staffDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.staffBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.staff_IDTextBox = new System.Windows.Forms.TextBox();
            this.staff_nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.designationTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            staff_IDLabel = new System.Windows.Forms.Label();
            staff_nameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            designationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).BeginInit();
            this.staffBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "libraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.libraryDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            
            this.tableAdapterManager.newbookTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.studentdataTableAdapter = null;

            /*this.tableAdapterManager.Table2TableAdapter = null;
            this.tableAdapterManager.Table4TableAdapter = null;
            this.tableAdapterManager.Table5TableAdapter = null;
            this.tableAdapterManager.Table6TableAdapter = null;
            this.tableAdapterManager.Table7TableAdapter = null;*/
            this.tableAdapterManager.UpdateOrder = Libraryproject.libraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // staffBindingNavigator
            // 
            this.staffBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.staffBindingNavigator.BindingSource = this.staffBindingSource;
            this.staffBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.staffBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.staffBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.staffBindingNavigatorSaveItem});
            this.staffBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.staffBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.staffBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.staffBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.staffBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.staffBindingNavigator.Name = "staffBindingNavigator";
            this.staffBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.staffBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.staffBindingNavigator.TabIndex = 0;
            this.staffBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // staffDataGridView
            // 
            this.staffDataGridView.AutoGenerateColumns = false;
            this.staffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.staffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.staffDataGridView.DataSource = this.staffBindingSource;
            this.staffDataGridView.Location = new System.Drawing.Point(151, 200);
            this.staffDataGridView.Name = "staffDataGridView";
            this.staffDataGridView.Size = new System.Drawing.Size(444, 220);
            this.staffDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "staff_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "staff_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "staff_name";
            this.dataGridViewTextBoxColumn2.HeaderText = "staff_name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn3.HeaderText = "password";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Designation";
            this.dataGridViewTextBoxColumn4.HeaderText = "Designation";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // staffBindingNavigatorSaveItem
            // 
            this.staffBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.staffBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("staffBindingNavigatorSaveItem.Image")));
            this.staffBindingNavigatorSaveItem.Name = "staffBindingNavigatorSaveItem";
            this.staffBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.staffBindingNavigatorSaveItem.Text = "Save Data";
            this.staffBindingNavigatorSaveItem.Click += new System.EventHandler(this.staffBindingNavigatorSaveItem_Click);
            // 
            // staff_IDLabel
            // 
            staff_IDLabel.AutoSize = true;
            staff_IDLabel.Location = new System.Drawing.Point(280, 79);
            staff_IDLabel.Name = "staff_IDLabel";
            staff_IDLabel.Size = new System.Drawing.Size(44, 13);
            staff_IDLabel.TabIndex = 2;
            staff_IDLabel.Text = "staff ID:";
            // 
            // staff_IDTextBox
            // 
            this.staff_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "staff_ID", true));
            this.staff_IDTextBox.Location = new System.Drawing.Point(352, 76);
            this.staff_IDTextBox.Name = "staff_IDTextBox";
            this.staff_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.staff_IDTextBox.TabIndex = 3;
            this.staff_IDTextBox.TextChanged += new System.EventHandler(this.staff_IDTextBox_TextChanged);
            // 
            // staff_nameLabel
            // 
            staff_nameLabel.AutoSize = true;
            staff_nameLabel.Location = new System.Drawing.Point(280, 105);
            staff_nameLabel.Name = "staff_nameLabel";
            staff_nameLabel.Size = new System.Drawing.Size(59, 13);
            staff_nameLabel.TabIndex = 4;
            staff_nameLabel.Text = "staff name:";
            // 
            // staff_nameTextBox
            // 
            this.staff_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "staff_name", true));
            this.staff_nameTextBox.Location = new System.Drawing.Point(352, 102);
            this.staff_nameTextBox.Name = "staff_nameTextBox";
            this.staff_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.staff_nameTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(280, 131);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(55, 13);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(352, 128);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBox.TabIndex = 7;
            // 
            // designationLabel
            // 
            designationLabel.AutoSize = true;
            designationLabel.Location = new System.Drawing.Point(280, 157);
            designationLabel.Name = "designationLabel";
            designationLabel.Size = new System.Drawing.Size(66, 13);
            designationLabel.TabIndex = 8;
            designationLabel.Text = "Designation:";
            // 
            // designationTextBox
            // 
            this.designationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.staffBindingSource, "Designation", true));
            this.designationTextBox.Location = new System.Drawing.Point(352, 154);
            this.designationTextBox.Name = "designationTextBox";
            this.designationTextBox.Size = new System.Drawing.Size(100, 20);
            this.designationTextBox.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(staff_IDLabel);
            this.Controls.Add(this.staff_IDTextBox);
            this.Controls.Add(staff_nameLabel);
            this.Controls.Add(this.staff_nameTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(designationLabel);
            this.Controls.Add(this.designationTextBox);
            this.Controls.Add(this.staffDataGridView);
            this.Controls.Add(this.staffBindingNavigator);
            this.Name = "Form7";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingNavigator)).EndInit();
            this.staffBindingNavigator.ResumeLayout(false);
            this.staffBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private libraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private libraryDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private libraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator staffBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton staffBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView staffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox staff_IDTextBox;
        private System.Windows.Forms.TextBox staff_nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox designationTextBox;
        private System.Windows.Forms.Button button1;
    }
}
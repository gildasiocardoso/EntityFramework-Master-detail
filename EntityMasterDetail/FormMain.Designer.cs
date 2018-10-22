namespace EntityMasterDetail
{
    partial class FormMain
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
            System.Windows.Forms.Label dSC_GROUP_PRODUCTLabel;
            System.Windows.Forms.Label iD_GROUP_PRODUCTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gROUP_PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gROUP_PRODUCTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.gROUP_PRODUCTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dSC_GROUP_PRODUCTTextBox = new System.Windows.Forms.TextBox();
            this.iD_GROUP_PRODUCTTextBox = new System.Windows.Forms.TextBox();
            this.sUBGROUP_PRODUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sUBGROUP_PRODUCTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            dSC_GROUP_PRODUCTLabel = new System.Windows.Forms.Label();
            iD_GROUP_PRODUCTLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_PRODUCTBindingNavigator)).BeginInit();
            this.gROUP_PRODUCTBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUBGROUP_PRODUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBGROUP_PRODUCTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dSC_GROUP_PRODUCTLabel
            // 
            dSC_GROUP_PRODUCTLabel.Location = new System.Drawing.Point(36, 38);
            dSC_GROUP_PRODUCTLabel.Name = "dSC_GROUP_PRODUCTLabel";
            dSC_GROUP_PRODUCTLabel.Size = new System.Drawing.Size(139, 17);
            dSC_GROUP_PRODUCTLabel.TabIndex = 1;
            dSC_GROUP_PRODUCTLabel.Text = "Group Product Description:";
            dSC_GROUP_PRODUCTLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // iD_GROUP_PRODUCTLabel
            // 
            iD_GROUP_PRODUCTLabel.Location = new System.Drawing.Point(40, 64);
            iD_GROUP_PRODUCTLabel.Name = "iD_GROUP_PRODUCTLabel";
            iD_GROUP_PRODUCTLabel.Size = new System.Drawing.Size(135, 17);
            iD_GROUP_PRODUCTLabel.TabIndex = 3;
            iD_GROUP_PRODUCTLabel.Text = "Group Product Id:";
            iD_GROUP_PRODUCTLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gROUP_PRODUCTBindingSource
            // 
            this.gROUP_PRODUCTBindingSource.DataSource = typeof(MyDataModel.GROUP_PRODUCT);
            // 
            // gROUP_PRODUCTBindingNavigator
            // 
            this.gROUP_PRODUCTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.gROUP_PRODUCTBindingNavigator.BindingSource = this.gROUP_PRODUCTBindingSource;
            this.gROUP_PRODUCTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.gROUP_PRODUCTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.gROUP_PRODUCTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.gROUP_PRODUCTBindingNavigatorSaveItem});
            this.gROUP_PRODUCTBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.gROUP_PRODUCTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.gROUP_PRODUCTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.gROUP_PRODUCTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.gROUP_PRODUCTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.gROUP_PRODUCTBindingNavigator.Name = "gROUP_PRODUCTBindingNavigator";
            this.gROUP_PRODUCTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.gROUP_PRODUCTBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.gROUP_PRODUCTBindingNavigator.TabIndex = 0;
            this.gROUP_PRODUCTBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // gROUP_PRODUCTBindingNavigatorSaveItem
            // 
            this.gROUP_PRODUCTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.gROUP_PRODUCTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("gROUP_PRODUCTBindingNavigatorSaveItem.Image")));
            this.gROUP_PRODUCTBindingNavigatorSaveItem.Name = "gROUP_PRODUCTBindingNavigatorSaveItem";
            this.gROUP_PRODUCTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.gROUP_PRODUCTBindingNavigatorSaveItem.Text = "Save Data";
            this.gROUP_PRODUCTBindingNavigatorSaveItem.Click += new System.EventHandler(this.gROUP_PRODUCTBindingNavigatorSaveItem_Click);
            // 
            // dSC_GROUP_PRODUCTTextBox
            // 
            this.dSC_GROUP_PRODUCTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gROUP_PRODUCTBindingSource, "DSC_GROUP_PRODUCT", true));
            this.dSC_GROUP_PRODUCTTextBox.Location = new System.Drawing.Point(180, 35);
            this.dSC_GROUP_PRODUCTTextBox.Name = "dSC_GROUP_PRODUCTTextBox";
            this.dSC_GROUP_PRODUCTTextBox.Size = new System.Drawing.Size(497, 20);
            this.dSC_GROUP_PRODUCTTextBox.TabIndex = 2;
            // 
            // iD_GROUP_PRODUCTTextBox
            // 
            this.iD_GROUP_PRODUCTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gROUP_PRODUCTBindingSource, "ID_GROUP_PRODUCT", true));
            this.iD_GROUP_PRODUCTTextBox.Location = new System.Drawing.Point(180, 61);
            this.iD_GROUP_PRODUCTTextBox.Name = "iD_GROUP_PRODUCTTextBox";
            this.iD_GROUP_PRODUCTTextBox.ReadOnly = true;
            this.iD_GROUP_PRODUCTTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_GROUP_PRODUCTTextBox.TabIndex = 4;
            // 
            // sUBGROUP_PRODUCTBindingSource
            // 
            this.sUBGROUP_PRODUCTBindingSource.DataMember = "SUBGROUP_PRODUCT";
            this.sUBGROUP_PRODUCTBindingSource.DataSource = this.gROUP_PRODUCTBindingSource;
            // 
            // sUBGROUP_PRODUCTDataGridView
            // 
            this.sUBGROUP_PRODUCTDataGridView.AutoGenerateColumns = false;
            this.sUBGROUP_PRODUCTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sUBGROUP_PRODUCTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.sUBGROUP_PRODUCTDataGridView.DataSource = this.sUBGROUP_PRODUCTBindingSource;
            this.sUBGROUP_PRODUCTDataGridView.Location = new System.Drawing.Point(39, 87);
            this.sUBGROUP_PRODUCTDataGridView.Name = "sUBGROUP_PRODUCTDataGridView";
            this.sUBGROUP_PRODUCTDataGridView.Size = new System.Drawing.Size(681, 242);
            this.sUBGROUP_PRODUCTDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DSC_SUBGROUP_PRODUCT";
            this.dataGridViewTextBoxColumn3.HeaderText = "Subgroup Description";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_SUBGROUP_PRODUCT";
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightGray;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn1.HeaderText = "Subgroup Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ID_GROUP_PRODUCT";
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.LightGray;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn2.HeaderText = "Group Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(0, 294);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 266);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.sUBGROUP_PRODUCTDataGridView);
            this.Controls.Add(dSC_GROUP_PRODUCTLabel);
            this.Controls.Add(this.dSC_GROUP_PRODUCTTextBox);
            this.Controls.Add(iD_GROUP_PRODUCTLabel);
            this.Controls.Add(this.iD_GROUP_PRODUCTTextBox);
            this.Controls.Add(this.gROUP_PRODUCTBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Name = "FormMain";
            this.Text = "Entity Framework Master Detail";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gROUP_PRODUCTBindingNavigator)).EndInit();
            this.gROUP_PRODUCTBindingNavigator.ResumeLayout(false);
            this.gROUP_PRODUCTBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sUBGROUP_PRODUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sUBGROUP_PRODUCTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource gROUP_PRODUCTBindingSource;
        private System.Windows.Forms.BindingNavigator gROUP_PRODUCTBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton gROUP_PRODUCTBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dSC_GROUP_PRODUCTTextBox;
        private System.Windows.Forms.TextBox iD_GROUP_PRODUCTTextBox;
        private System.Windows.Forms.BindingSource sUBGROUP_PRODUCTBindingSource;
        private System.Windows.Forms.DataGridView sUBGROUP_PRODUCTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
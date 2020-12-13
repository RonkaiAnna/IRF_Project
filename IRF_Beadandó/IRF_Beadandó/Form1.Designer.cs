
namespace IRF_Beadandó
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sorsologomb = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mentesgomb = new System.Windows.Forms.Button();
            this.sorsoltakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sorsoltakBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.sorsoltakBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.sorsoltakDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakBindingNavigator)).BeginInit();
            this.sorsoltakBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sorsologomb
            // 
            this.sorsologomb.Location = new System.Drawing.Point(28, 66);
            this.sorsologomb.Name = "sorsologomb";
            this.sorsologomb.Size = new System.Drawing.Size(138, 65);
            this.sorsologomb.TabIndex = 0;
            this.sorsologomb.Text = "Sorsolás";
            this.sorsologomb.UseVisualStyleBackColor = true;
            this.sorsologomb.Click += new System.EventHandler(this.sorsologomb_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kisorsoltak listája:";
            // 
            // mentesgomb
            // 
            this.mentesgomb.Location = new System.Drawing.Point(28, 276);
            this.mentesgomb.Name = "mentesgomb";
            this.mentesgomb.Size = new System.Drawing.Size(138, 65);
            this.mentesgomb.TabIndex = 3;
            this.mentesgomb.Text = "Kisorsoltak fájlba mentés";
            this.mentesgomb.UseVisualStyleBackColor = true;
            this.mentesgomb.Click += new System.EventHandler(this.mentesgomb_Click);
            // 
            // sorsoltakBindingSource
            // 
            this.sorsoltakBindingSource.DataSource = typeof(IRF_Beadandó.Sorsoltak);
            // 
            // sorsoltakBindingNavigator
            // 
            this.sorsoltakBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sorsoltakBindingNavigator.BindingSource = this.sorsoltakBindingSource;
            this.sorsoltakBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sorsoltakBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sorsoltakBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.sorsoltakBindingNavigatorSaveItem});
            this.sorsoltakBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sorsoltakBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sorsoltakBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sorsoltakBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sorsoltakBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sorsoltakBindingNavigator.Name = "sorsoltakBindingNavigator";
            this.sorsoltakBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sorsoltakBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.sorsoltakBindingNavigator.TabIndex = 4;
            this.sorsoltakBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // sorsoltakBindingNavigatorSaveItem
            // 
            this.sorsoltakBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sorsoltakBindingNavigatorSaveItem.Enabled = false;
            this.sorsoltakBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sorsoltakBindingNavigatorSaveItem.Image")));
            this.sorsoltakBindingNavigatorSaveItem.Name = "sorsoltakBindingNavigatorSaveItem";
            this.sorsoltakBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.sorsoltakBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // sorsoltakDataGridView
            // 
            this.sorsoltakDataGridView.AutoGenerateColumns = false;
            this.sorsoltakDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sorsoltakDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sorsoltakDataGridView.DataSource = this.sorsoltakBindingSource;
            this.sorsoltakDataGridView.Location = new System.Drawing.Point(217, 66);
            this.sorsoltakDataGridView.Name = "sorsoltakDataGridView";
            this.sorsoltakDataGridView.Size = new System.Drawing.Size(351, 259);
            this.sorsoltakDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SorsoltId";
            this.dataGridViewTextBoxColumn1.HeaderText = "SorsoltId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "SorsoltNév";
            this.dataGridViewTextBoxColumn2.HeaderText = "SorsoltNév";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SorsoltEmail_cím";
            this.dataGridViewTextBoxColumn3.HeaderText = "SorsoltEmail_cím";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sorsoltakDataGridView);
            this.Controls.Add(this.sorsoltakBindingNavigator);
            this.Controls.Add(this.mentesgomb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sorsologomb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakBindingNavigator)).EndInit();
            this.sorsoltakBindingNavigator.ResumeLayout(false);
            this.sorsoltakBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sorsologomb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mentesgomb;
        private System.Windows.Forms.BindingSource sorsoltakBindingSource;
        private System.Windows.Forms.BindingNavigator sorsoltakBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton sorsoltakBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView sorsoltakDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}


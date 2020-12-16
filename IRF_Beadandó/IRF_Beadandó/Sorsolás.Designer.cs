
namespace IRF_Beadandó
{
    partial class Sorsolás
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.sorsoltakDataGridView = new System.Windows.Forms.DataGridView();
            this.sorsologomb = new System.Windows.Forms.Button();
            this.mentesgomb = new System.Windows.Forms.Button();
            this.deletegomb = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorsoltakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kisorsoltak listája:";
            // 
            // sorsoltakDataGridView
            // 
            this.sorsoltakDataGridView.AllowUserToAddRows = false;
            this.sorsoltakDataGridView.AllowUserToDeleteRows = false;
            this.sorsoltakDataGridView.AutoGenerateColumns = false;
            this.sorsoltakDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sorsoltakDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sorsoltakDataGridView.DataSource = this.sorsoltakBindingSource;
            this.sorsoltakDataGridView.Location = new System.Drawing.Point(6, 50);
            this.sorsoltakDataGridView.Name = "sorsoltakDataGridView";
            this.sorsoltakDataGridView.ReadOnly = true;
            this.sorsoltakDataGridView.Size = new System.Drawing.Size(300, 220);
            this.sorsoltakDataGridView.TabIndex = 4;
            // 
            // sorsologomb
            // 
            this.sorsologomb.Location = new System.Drawing.Point(312, 63);
            this.sorsologomb.Name = "sorsologomb";
            this.sorsologomb.Size = new System.Drawing.Size(138, 65);
            this.sorsologomb.TabIndex = 5;
            this.sorsologomb.Text = "Sorsolás";
            this.sorsologomb.UseVisualStyleBackColor = true;
            this.sorsologomb.Click += new System.EventHandler(this.sorsologomb_Click);
            // 
            // mentesgomb
            // 
            this.mentesgomb.Location = new System.Drawing.Point(312, 134);
            this.mentesgomb.Name = "mentesgomb";
            this.mentesgomb.Size = new System.Drawing.Size(138, 65);
            this.mentesgomb.TabIndex = 6;
            this.mentesgomb.Text = "Kisorsoltak fájlba mentés";
            this.mentesgomb.UseVisualStyleBackColor = true;
            this.mentesgomb.Click += new System.EventHandler(this.mentesgomb_Click);
            // 
            // deletegomb
            // 
            this.deletegomb.Location = new System.Drawing.Point(312, 205);
            this.deletegomb.Name = "deletegomb";
            this.deletegomb.Size = new System.Drawing.Size(138, 65);
            this.deletegomb.TabIndex = 7;
            this.deletegomb.Text = "Datagridview ürítés";
            this.deletegomb.UseVisualStyleBackColor = true;
            this.deletegomb.Click += new System.EventHandler(this.deletegomb_Click);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SorsoltNév";
            this.dataGridViewTextBoxColumn3.HeaderText = "SorsoltNév";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "SorsoltEmail_cím";
            this.dataGridViewTextBoxColumn4.HeaderText = "SorsoltEmail_cím";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // sorsoltakBindingSource
            // 
            this.sorsoltakBindingSource.DataSource = typeof(IRF_Beadandó.Sorsoltak);
            // 
            // Sorsolás
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.deletegomb);
            this.Controls.Add(this.mentesgomb);
            this.Controls.Add(this.sorsologomb);
            this.Controls.Add(this.sorsoltakDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "Sorsolás";
            this.Size = new System.Drawing.Size(566, 342);
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource sorsoltakBindingSource;
        private System.Windows.Forms.DataGridView sorsoltakDataGridView;
        private System.Windows.Forms.Button sorsologomb;
        private System.Windows.Forms.Button mentesgomb;
        private System.Windows.Forms.Button deletegomb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}

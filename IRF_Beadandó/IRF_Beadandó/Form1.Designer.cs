
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
            this.sorsologomb = new System.Windows.Forms.Button();
            this.kisorsoltak = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.mentesgomb = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kisorsoltak)).BeginInit();
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
            // kisorsoltak
            // 
            this.kisorsoltak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kisorsoltak.Location = new System.Drawing.Point(214, 66);
            this.kisorsoltak.Name = "kisorsoltak";
            this.kisorsoltak.Size = new System.Drawing.Size(463, 275);
            this.kisorsoltak.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mentesgomb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kisorsoltak);
            this.Controls.Add(this.sorsologomb);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kisorsoltak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sorsologomb;
        private System.Windows.Forms.DataGridView kisorsoltak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mentesgomb;
    }
}


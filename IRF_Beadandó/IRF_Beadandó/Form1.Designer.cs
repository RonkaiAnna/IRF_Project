
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
            this.label2 = new System.Windows.Forms.Label();
            this.adatbevitelgomb = new System.Windows.Forms.Button();
            this.sorsolasgomb = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sorsoltakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Üdv a Sorsold magad programban!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adatbevitelgomb
            // 
            this.adatbevitelgomb.Location = new System.Drawing.Point(32, 62);
            this.adatbevitelgomb.Name = "adatbevitelgomb";
            this.adatbevitelgomb.Size = new System.Drawing.Size(89, 41);
            this.adatbevitelgomb.TabIndex = 7;
            this.adatbevitelgomb.Text = "Adatbevitel";
            this.adatbevitelgomb.UseVisualStyleBackColor = true;
            this.adatbevitelgomb.Click += new System.EventHandler(this.adatbevitelgomb_Click);
            // 
            // sorsolasgomb
            // 
            this.sorsolasgomb.Location = new System.Drawing.Point(32, 109);
            this.sorsolasgomb.Name = "sorsolasgomb";
            this.sorsolasgomb.Size = new System.Drawing.Size(89, 41);
            this.sorsolasgomb.TabIndex = 8;
            this.sorsolasgomb.Text = "Sorsolás";
            this.sorsolasgomb.UseVisualStyleBackColor = true;
            this.sorsolasgomb.Click += new System.EventHandler(this.sorsolasgomb_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(143, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 356);
            this.panel1.TabIndex = 9;
            // 
            // sorsoltakBindingSource
            // 
            this.sorsoltakBindingSource.DataSource = typeof(IRF_Beadandó.Sorsoltak);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sorsolasgomb);
            this.Controls.Add(this.adatbevitelgomb);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sorsoltakBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button adatbevitelgomb;
        private System.Windows.Forms.Button sorsolasgomb;
        private System.Windows.Forms.Panel panel1;
    }
}


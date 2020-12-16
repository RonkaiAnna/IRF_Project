
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.sorsoltakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sorsoltakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(206, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Üdv a Sorsold Magad programban!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // adatbevitelgomb
            // 
            this.adatbevitelgomb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adatbevitelgomb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.adatbevitelgomb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adatbevitelgomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adatbevitelgomb.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adatbevitelgomb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adatbevitelgomb.Location = new System.Drawing.Point(12, 62);
            this.adatbevitelgomb.Name = "adatbevitelgomb";
            this.adatbevitelgomb.Size = new System.Drawing.Size(120, 60);
            this.adatbevitelgomb.TabIndex = 7;
            this.adatbevitelgomb.Text = "Adatbevitel";
            this.adatbevitelgomb.UseVisualStyleBackColor = true;
            this.adatbevitelgomb.Click += new System.EventHandler(this.adatbevitelgomb_Click);
            // 
            // sorsolasgomb
            // 
            this.sorsolasgomb.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sorsolasgomb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sorsolasgomb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sorsolasgomb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sorsolasgomb.Font = new System.Drawing.Font("AR JULIAN", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sorsolasgomb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sorsolasgomb.Location = new System.Drawing.Point(12, 140);
            this.sorsolasgomb.Name = "sorsolasgomb";
            this.sorsolasgomb.Size = new System.Drawing.Size(120, 60);
            this.sorsolasgomb.TabIndex = 8;
            this.sorsolasgomb.Text = "Sorsolás";
            this.sorsolasgomb.UseVisualStyleBackColor = true;
            this.sorsolasgomb.Click += new System.EventHandler(this.sorsolasgomb_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(143, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 356);
            this.panel1.TabIndex = 9;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("AR JULIAN", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.richTextBox1.Location = new System.Drawing.Point(12, 268);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(120, 150);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "Tipp: Válassza ki, hogy új adatokat akar-e bevinni a rendszerbe, vagy a rendelkez" +
    "ésre álló adatokból szeretne-e sorsolni";
            // 
            // sorsoltakBindingSource
            // 
            this.sorsoltakBindingSource.DataSource = typeof(IRF_Beadandó.Sorsoltak);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sorsolasgomb);
            this.Controls.Add(this.adatbevitelgomb);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Sorsold Magad";
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
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


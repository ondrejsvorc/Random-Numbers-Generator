namespace Random_Numbers_Generator
{
    partial class Home
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReGenerate = new System.Windows.Forms.Button();
            this.txtRandomNumbers = new System.Windows.Forms.RichTextBox();
            this.lbFrom = new System.Windows.Forms.Label();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.lbTo = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lbAmount = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(419, 304);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(193, 44);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-2, 554);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 13);
            this.panel1.TabIndex = 1;
            // 
            // btnReGenerate
            // 
            this.btnReGenerate.Location = new System.Drawing.Point(419, 360);
            this.btnReGenerate.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnReGenerate.Name = "btnReGenerate";
            this.btnReGenerate.Size = new System.Drawing.Size(193, 44);
            this.btnReGenerate.TabIndex = 5;
            this.btnReGenerate.Text = "Re-Generate";
            this.btnReGenerate.UseVisualStyleBackColor = true;
            this.btnReGenerate.Click += new System.EventHandler(this.BtnReGenerate_Click);
            // 
            // txtRandomNumbers
            // 
            this.txtRandomNumbers.BackColor = System.Drawing.Color.White;
            this.txtRandomNumbers.Location = new System.Drawing.Point(12, 43);
            this.txtRandomNumbers.Name = "txtRandomNumbers";
            this.txtRandomNumbers.ReadOnly = true;
            this.txtRandomNumbers.Size = new System.Drawing.Size(278, 448);
            this.txtRandomNumbers.TabIndex = 5;
            this.txtRandomNumbers.TabStop = false;
            this.txtRandomNumbers.Text = "";
            this.txtRandomNumbers.TextChanged += new System.EventHandler(this.TxtRandomNumbers_TextChanged);
            // 
            // lbFrom
            // 
            this.lbFrom.AutoSize = true;
            this.lbFrom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbFrom.Location = new System.Drawing.Point(390, 174);
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbFrom.Size = new System.Drawing.Size(54, 25);
            this.lbFrom.TabIndex = 3;
            this.lbFrom.Text = "From";
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(469, 171);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(100, 33);
            this.txtFrom.TabIndex = 1;
            this.txtFrom.TextChanged += new System.EventHandler(this.TxtFrom_TextChanged);
            this.txtFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtFrom_KeyPress);
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(469, 210);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(100, 33);
            this.txtTo.TabIndex = 2;
            this.txtTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTo_KeyPress);
            // 
            // lbTo
            // 
            this.lbTo.AutoSize = true;
            this.lbTo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTo.Location = new System.Drawing.Point(414, 213);
            this.lbTo.Name = "lbTo";
            this.lbTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbTo.Size = new System.Drawing.Size(30, 25);
            this.lbTo.TabIndex = 5;
            this.lbTo.Text = "To";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(469, 249);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 33);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.TextChanged += new System.EventHandler(this.TxtAmount_TextChanged);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAmount_KeyPress);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAmount.Location = new System.Drawing.Point(367, 252);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbAmount.Size = new System.Drawing.Size(77, 25);
            this.lbAmount.TabIndex = 8;
            this.lbAmount.Text = "Amount";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.IndianRed;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(-2, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(725, 12);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(634, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "© Ondřej Švorc";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnReGenerate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lbAmount);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.lbTo);
            this.Controls.Add(this.txtFrom);
            this.Controls.Add(this.lbFrom);
            this.Controls.Add(this.txtRandomNumbers);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random Numbers Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox txtRandomNumbers;
        private System.Windows.Forms.Label lbFrom;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.Label lbTo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Button btnReGenerate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}


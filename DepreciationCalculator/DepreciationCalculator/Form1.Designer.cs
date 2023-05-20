namespace DepreciationCalculator
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
            this.lstBoxTable = new System.Windows.Forms.ListBox();
            this.cBoxLife = new System.Windows.Forms.ComboBox();
            this.txtBoxInitialCost = new System.Windows.Forms.TextBox();
            this.txtBoxSalvageValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSYD = new System.Windows.Forms.RadioButton();
            this.rbtnSLN = new System.Windows.Forms.RadioButton();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBoxTable
            // 
            this.lstBoxTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxTable.FormattingEnabled = true;
            this.lstBoxTable.ItemHeight = 22;
            this.lstBoxTable.Location = new System.Drawing.Point(49, 182);
            this.lstBoxTable.Name = "lstBoxTable";
            this.lstBoxTable.Size = new System.Drawing.Size(340, 180);
            this.lstBoxTable.TabIndex = 0;
            // 
            // cBoxLife
            // 
            this.cBoxLife.FormattingEnabled = true;
            this.cBoxLife.Location = new System.Drawing.Point(196, 109);
            this.cBoxLife.Name = "cBoxLife";
            this.cBoxLife.Size = new System.Drawing.Size(109, 24);
            this.cBoxLife.TabIndex = 1;
            // 
            // txtBoxInitialCost
            // 
            this.txtBoxInitialCost.Location = new System.Drawing.Point(196, 52);
            this.txtBoxInitialCost.Name = "txtBoxInitialCost";
            this.txtBoxInitialCost.Size = new System.Drawing.Size(161, 22);
            this.txtBoxInitialCost.TabIndex = 2;
            // 
            // txtBoxSalvageValue
            // 
            this.txtBoxSalvageValue.Location = new System.Drawing.Point(196, 80);
            this.txtBoxSalvageValue.Name = "txtBoxSalvageValue";
            this.txtBoxSalvageValue.Size = new System.Drawing.Size(161, 22);
            this.txtBoxSalvageValue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Initial Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Salvage Value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(59, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Life";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSYD);
            this.groupBox1.Controls.Add(this.rbtnSLN);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(442, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Depreciation";
            // 
            // rbtnSYD
            // 
            this.rbtnSYD.AutoSize = true;
            this.rbtnSYD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSYD.Location = new System.Drawing.Point(28, 60);
            this.rbtnSYD.Name = "rbtnSYD";
            this.rbtnSYD.Size = new System.Drawing.Size(131, 24);
            this.rbtnSYD.TabIndex = 0;
            this.rbtnSYD.TabStop = true;
            this.rbtnSYD.Text = "Sum of Years";
            this.rbtnSYD.UseVisualStyleBackColor = true;
            // 
            // rbtnSLN
            // 
            this.rbtnSLN.AutoSize = true;
            this.rbtnSLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSLN.Location = new System.Drawing.Point(28, 34);
            this.rbtnSLN.Name = "rbtnSLN";
            this.rbtnSLN.Size = new System.Drawing.Size(125, 24);
            this.rbtnSLN.TabIndex = 0;
            this.rbtnSLN.TabStop = true;
            this.rbtnSLN.Text = "Straight Line";
            this.rbtnSLN.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(442, 220);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 38);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "&Update Schedule";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(442, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 38);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Depreciation Schedule";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 403);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSalvageValue);
            this.Controls.Add(this.txtBoxInitialCost);
            this.Controls.Add(this.cBoxLife);
            this.Controls.Add(this.lstBoxTable);
            this.Name = "Form1";
            this.Text = "Depreciation Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxTable;
        private System.Windows.Forms.ComboBox cBoxLife;
        private System.Windows.Forms.TextBox txtBoxInitialCost;
        private System.Windows.Forms.TextBox txtBoxSalvageValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSYD;
        private System.Windows.Forms.RadioButton rbtnSLN;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label4;
    }
}


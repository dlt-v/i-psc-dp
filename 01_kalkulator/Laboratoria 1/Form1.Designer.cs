namespace Laboratoria_1
{
    partial class Form1
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
            this.TbValue1 = new System.Windows.Forms.TextBox();
            this.CbOperations = new System.Windows.Forms.ComboBox();
            this.TbValue2 = new System.Windows.Forms.TextBox();
            this.BtCalculate = new System.Windows.Forms.Button();
            this.TbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TbValue1
            // 
            this.TbValue1.Location = new System.Drawing.Point(8, 15);
            this.TbValue1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbValue1.Name = "TbValue1";
            this.TbValue1.Size = new System.Drawing.Size(106, 23);
            this.TbValue1.TabIndex = 0;
            this.TbValue1.Text = "0";
            this.TbValue1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // CbOperations
            // 
            this.CbOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbOperations.FormattingEnabled = true;
            this.CbOperations.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.CbOperations.Location = new System.Drawing.Point(11, 46);
            this.CbOperations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CbOperations.Name = "CbOperations";
            this.CbOperations.Size = new System.Drawing.Size(103, 23);
            this.CbOperations.TabIndex = 1;
            // 
            // TbValue2
            // 
            this.TbValue2.Location = new System.Drawing.Point(8, 77);
            this.TbValue2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbValue2.Name = "TbValue2";
            this.TbValue2.Size = new System.Drawing.Size(106, 23);
            this.TbValue2.TabIndex = 2;
            this.TbValue2.Text = "0";
            this.TbValue2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtCalculate
            // 
            this.BtCalculate.Location = new System.Drawing.Point(21, 109);
            this.BtCalculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtCalculate.Name = "BtCalculate";
            this.BtCalculate.Size = new System.Drawing.Size(78, 20);
            this.BtCalculate.TabIndex = 3;
            this.BtCalculate.Text = "=";
            this.BtCalculate.UseVisualStyleBackColor = true;
            this.BtCalculate.Click += new System.EventHandler(this.BtCalculate_Click);
            // 
            // TbResult
            // 
            this.TbResult.Location = new System.Drawing.Point(8, 140);
            this.TbResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TbResult.Name = "TbResult";
            this.TbResult.ReadOnly = true;
            this.TbResult.Size = new System.Drawing.Size(106, 23);
            this.TbResult.TabIndex = 4;
            this.TbResult.Text = "0";
            this.TbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 238);
            this.Controls.Add(this.TbResult);
            this.Controls.Add(this.BtCalculate);
            this.Controls.Add(this.TbValue2);
            this.Controls.Add(this.CbOperations);
            this.Controls.Add(this.TbValue1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TbValue1;
        private ComboBox CbOperations;
        private TextBox TbValue2;
        private Button BtCalculate;
        private TextBox TbResult;
    }
}
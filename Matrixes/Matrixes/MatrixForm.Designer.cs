namespace Matrixes
{
    partial class MatrixForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.ScVertical = new System.Windows.Forms.SplitContainer();
            this.ScLeft = new System.Windows.Forms.SplitContainer();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtInv = new System.Windows.Forms.Button();
            this.BtSolve = new System.Windows.Forms.Button();
            this.BtMultiply = new System.Windows.Forms.Button();
            this.BtSubtract = new System.Windows.Forms.Button();
            this.BtAdd = new System.Windows.Forms.Button();
            this.PnlMatrixA = new System.Windows.Forms.Panel();
            this.TbMatrixA = new System.Windows.Forms.TextBox();
            this.ScRight = new System.Windows.Forms.SplitContainer();
            this.PnlMatrixB = new System.Windows.Forms.Panel();
            this.TbMatrixB = new System.Windows.Forms.TextBox();
            this.PnlResult = new System.Windows.Forms.Panel();
            this.TbResult = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).BeginInit();
            this.ScVertical.Panel1.SuspendLayout();
            this.ScVertical.Panel2.SuspendLayout();
            this.ScVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScLeft)).BeginInit();
            this.ScLeft.Panel1.SuspendLayout();
            this.ScLeft.Panel2.SuspendLayout();
            this.ScLeft.SuspendLayout();
            this.PnlButtons.SuspendLayout();
            this.PnlMatrixA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScRight)).BeginInit();
            this.ScRight.Panel1.SuspendLayout();
            this.ScRight.Panel2.SuspendLayout();
            this.ScRight.SuspendLayout();
            this.PnlMatrixB.SuspendLayout();
            this.PnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // ScVertical
            // 
            this.ScVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScVertical.Location = new System.Drawing.Point(0, 0);
            this.ScVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScVertical.Name = "ScVertical";
            // 
            // ScVertical.Panel1
            // 
            this.ScVertical.Panel1.Controls.Add(this.ScLeft);
            // 
            // ScVertical.Panel2
            // 
            this.ScVertical.Panel2.Controls.Add(this.ScRight);
            this.ScVertical.Size = new System.Drawing.Size(1553, 558);
            this.ScVertical.SplitterDistance = 765;
            this.ScVertical.TabIndex = 0;
            // 
            // ScLeft
            // 
            this.ScLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScLeft.Location = new System.Drawing.Point(0, 0);
            this.ScLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScLeft.Name = "ScLeft";
            this.ScLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScLeft.Panel1
            // 
            this.ScLeft.Panel1.Controls.Add(this.PnlButtons);
            // 
            // ScLeft.Panel2
            // 
            this.ScLeft.Panel2.Controls.Add(this.PnlMatrixA);
            this.ScLeft.Size = new System.Drawing.Size(765, 558);
            this.ScLeft.SplitterDistance = 254;
            this.ScLeft.TabIndex = 0;
            this.ScLeft.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScLeft_SplitterMoved);
            // 
            // PnlButtons
            // 
            this.PnlButtons.Controls.Add(this.BtInv);
            this.PnlButtons.Controls.Add(this.BtSolve);
            this.PnlButtons.Controls.Add(this.BtMultiply);
            this.PnlButtons.Controls.Add(this.BtSubtract);
            this.PnlButtons.Controls.Add(this.BtAdd);
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlButtons.Location = new System.Drawing.Point(0, 0);
            this.PnlButtons.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PnlButtons.Size = new System.Drawing.Size(765, 254);
            this.PnlButtons.TabIndex = 0;
            // 
            // BtInv
            // 
            this.BtInv.Location = new System.Drawing.Point(17, 159);
            this.BtInv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtInv.Name = "BtInv";
            this.BtInv.Size = new System.Drawing.Size(100, 28);
            this.BtInv.TabIndex = 6;
            this.BtInv.Text = "Inv";
            this.BtInv.UseVisualStyleBackColor = true;
            this.BtInv.Click += new System.EventHandler(this.BtInv_Click);
            // 
            // BtSolve
            // 
            this.BtSolve.Location = new System.Drawing.Point(17, 122);
            this.BtSolve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtSolve.Name = "BtSolve";
            this.BtSolve.Size = new System.Drawing.Size(100, 28);
            this.BtSolve.TabIndex = 5;
            this.BtSolve.Text = "Solve";
            this.BtSolve.UseVisualStyleBackColor = true;
            this.BtSolve.Click += new System.EventHandler(this.BtSolve_Click);
            // 
            // BtMultiply
            // 
            this.BtMultiply.Location = new System.Drawing.Point(17, 86);
            this.BtMultiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtMultiply.Name = "BtMultiply";
            this.BtMultiply.Size = new System.Drawing.Size(100, 28);
            this.BtMultiply.TabIndex = 4;
            this.BtMultiply.Text = "Multiply";
            this.BtMultiply.UseVisualStyleBackColor = true;
            this.BtMultiply.Click += new System.EventHandler(this.BtMultiply_Click);
            // 
            // BtSubtract
            // 
            this.BtSubtract.Location = new System.Drawing.Point(17, 52);
            this.BtSubtract.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtSubtract.Name = "BtSubtract";
            this.BtSubtract.Size = new System.Drawing.Size(100, 28);
            this.BtSubtract.TabIndex = 3;
            this.BtSubtract.Text = "Subtract";
            this.BtSubtract.UseVisualStyleBackColor = true;
            this.BtSubtract.Click += new System.EventHandler(this.BtSubtract_Click);
            // 
            // BtAdd
            // 
            this.BtAdd.Location = new System.Drawing.Point(16, 15);
            this.BtAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtAdd.Name = "BtAdd";
            this.BtAdd.Size = new System.Drawing.Size(100, 28);
            this.BtAdd.TabIndex = 2;
            this.BtAdd.Text = "Add";
            this.BtAdd.UseVisualStyleBackColor = true;
            this.BtAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // PnlMatrixA
            // 
            this.PnlMatrixA.Controls.Add(this.TbMatrixA);
            this.PnlMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMatrixA.Location = new System.Drawing.Point(0, 0);
            this.PnlMatrixA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlMatrixA.Name = "PnlMatrixA";
            this.PnlMatrixA.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PnlMatrixA.Size = new System.Drawing.Size(765, 300);
            this.PnlMatrixA.TabIndex = 1;
            // 
            // TbMatrixA
            // 
            this.TbMatrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixA.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMatrixA.Location = new System.Drawing.Point(7, 6);
            this.TbMatrixA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbMatrixA.Multiline = true;
            this.TbMatrixA.Name = "TbMatrixA";
            this.TbMatrixA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbMatrixA.Size = new System.Drawing.Size(751, 288);
            this.TbMatrixA.TabIndex = 0;
            this.TbMatrixA.Text = "6,6\t6,8\t1,1\t4,8\r\n9,6\t0,4\t9,5\t3,6\r\n4,7\t3,7\t2,5\t6,4\r\n8,7\t7,9\t0,8\t5,2\r\n\r\n";
            // 
            // ScRight
            // 
            this.ScRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScRight.Location = new System.Drawing.Point(0, 0);
            this.ScRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ScRight.Name = "ScRight";
            this.ScRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScRight.Panel1
            // 
            this.ScRight.Panel1.Controls.Add(this.PnlMatrixB);
            // 
            // ScRight.Panel2
            // 
            this.ScRight.Panel2.Controls.Add(this.PnlResult);
            this.ScRight.Size = new System.Drawing.Size(784, 558);
            this.ScRight.SplitterDistance = 254;
            this.ScRight.TabIndex = 1;
            this.ScRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.ScRight_SplitterMoved);
            // 
            // PnlMatrixB
            // 
            this.PnlMatrixB.Controls.Add(this.TbMatrixB);
            this.PnlMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlMatrixB.Location = new System.Drawing.Point(0, 0);
            this.PnlMatrixB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlMatrixB.Name = "PnlMatrixB";
            this.PnlMatrixB.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PnlMatrixB.Size = new System.Drawing.Size(784, 254);
            this.PnlMatrixB.TabIndex = 1;
            // 
            // TbMatrixB
            // 
            this.TbMatrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbMatrixB.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbMatrixB.Location = new System.Drawing.Point(7, 6);
            this.TbMatrixB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbMatrixB.Multiline = true;
            this.TbMatrixB.Name = "TbMatrixB";
            this.TbMatrixB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbMatrixB.Size = new System.Drawing.Size(770, 242);
            this.TbMatrixB.TabIndex = 1;
            this.TbMatrixB.Text = "1,000\t0,000\t0,000\t0,000\t2,300\r\n0,000\t1,000\t0,000\t0,000\t0,800\r\n0,000\t0,000\t1,000\t0" +
    ",000\t2,800\r\n0,000\t0,000\t0,000\t1,000\t5,300\r\n\r\n";
            // 
            // PnlResult
            // 
            this.PnlResult.Controls.Add(this.TbResult);
            this.PnlResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlResult.Location = new System.Drawing.Point(0, 0);
            this.PnlResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PnlResult.Name = "PnlResult";
            this.PnlResult.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.PnlResult.Size = new System.Drawing.Size(784, 300);
            this.PnlResult.TabIndex = 1;
            // 
            // TbResult
            // 
            this.TbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbResult.Font = new System.Drawing.Font("Lucida Console", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbResult.Location = new System.Drawing.Point(7, 6);
            this.TbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TbResult.Multiline = true;
            this.TbResult.Name = "TbResult";
            this.TbResult.ReadOnly = true;
            this.TbResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TbResult.Size = new System.Drawing.Size(770, 288);
            this.TbResult.TabIndex = 1;
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 558);
            this.Controls.Add(this.ScVertical);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MatrixForm";
            this.Text = "Form1";
            this.ScVertical.Panel1.ResumeLayout(false);
            this.ScVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScVertical)).EndInit();
            this.ScVertical.ResumeLayout(false);
            this.ScLeft.Panel1.ResumeLayout(false);
            this.ScLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScLeft)).EndInit();
            this.ScLeft.ResumeLayout(false);
            this.PnlButtons.ResumeLayout(false);
            this.PnlMatrixA.ResumeLayout(false);
            this.PnlMatrixA.PerformLayout();
            this.ScRight.Panel1.ResumeLayout(false);
            this.ScRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScRight)).EndInit();
            this.ScRight.ResumeLayout(false);
            this.PnlMatrixB.ResumeLayout(false);
            this.PnlMatrixB.PerformLayout();
            this.PnlResult.ResumeLayout(false);
            this.PnlResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer ScVertical;
        private System.Windows.Forms.SplitContainer ScLeft;
        private System.Windows.Forms.Panel PnlButtons;
        private System.Windows.Forms.Panel PnlMatrixA;
        private System.Windows.Forms.TextBox TbMatrixA;
        private System.Windows.Forms.SplitContainer ScRight;
        private System.Windows.Forms.Panel PnlMatrixB;
        private System.Windows.Forms.TextBox TbMatrixB;
        private System.Windows.Forms.Panel PnlResult;
        private System.Windows.Forms.TextBox TbResult;
        private System.Windows.Forms.Button BtAdd;
        private System.Windows.Forms.Button BtSubtract;
        private System.Windows.Forms.Button BtMultiply;
        private System.Windows.Forms.Button BtSolve;
        private System.Windows.Forms.Button BtInv;
    }
}


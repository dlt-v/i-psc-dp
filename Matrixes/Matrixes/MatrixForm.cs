using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrixes
{
    public partial class MatrixForm : Form
    {
        public MatrixForm()
        {
            InitializeComponent();
        }

        private void ScRight_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScLeft.SplitterDistance = ScRight.SplitterDistance;

        }

        private void ScLeft_SplitterMoved(object sender, SplitterEventArgs e)
        {
            ScRight.SplitterDistance = ScLeft.SplitterDistance;
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            Matrix matrixA = Matrix.Parse(TbMatrixA.Text);
            Matrix matrixB = Matrix.Parse(TbMatrixB.Text);
            TbResult.Text = (matrixA+matrixB).ToString();
        }

        private void BtSubtract_Click(object sender, EventArgs e)
        {
            Matrix matrixA = Matrix.Parse(TbMatrixA.Text);
            Matrix matrixB = Matrix.Parse(TbMatrixB.Text);
            TbResult.Text = (matrixA - matrixB).ToString();
        }

        private void BtMultiply_Click(object sender, EventArgs e)
        {
            Matrix matrixA = Matrix.Parse(TbMatrixA.Text);
            Matrix matrixB = Matrix.Parse(TbMatrixB.Text);
            TbResult.Text = (matrixA * matrixB).ToString();
        }

        private void BtSolve_Click(object sender, EventArgs e)
        {
            Matrix matrixA = Matrix.Parse(TbMatrixA.Text);
            Matrix matrixB = Matrix.Parse(TbMatrixB.Text);
            //public static Matrix solve(Matrix m, Matrix y)
            TbResult.Text = Matrix.Solve(matrixA,matrixB).ToString();
        }

        private void BtInv_Click(object sender, EventArgs e)
        {
            Matrix matrixA = Matrix.Parse(TbMatrixA.Text);
            TbResult.Text = Matrix.Inv(matrixA).ToString();
        }
    }
}

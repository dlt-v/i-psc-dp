using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Matrixes
{
    public class Matrix
    {
        private double[,] data;

        public Matrix (int RowCount, int ColCount) { data = new double[RowCount, ColCount]; }
        public int RowCount { get { return data.GetLength(0); } }
        public int ColCount { get { return data.GetLength(1); } }

        public double this[int r, int c] { get { return data[r, c]; } set { data[r, c] = value; } }
        
        public static Matrix operator +(Matrix a, Matrix b)
        {
            int RowCount = a.RowCount;
            int ColCount = a.ColCount;
            if (RowCount != b.RowCount||ColCount!=b.ColCount) { throw new ArgumentException("Matrixes have different sizes"); }
            Matrix matrix = new Matrix(RowCount, ColCount);
            for(int r = 0;r < RowCount; ++r)
            {
                for(int c = 0;c < ColCount; ++c)
                {
                    matrix[r, c] = a[r, c] + b[r, c];
                }
            }
            return matrix;
        }
        public static Matrix operator -(Matrix a, Matrix b)
        {
            int RowCount = a.RowCount;
            int ColCount = a.ColCount;
            if (RowCount != b.RowCount || ColCount != b.ColCount) { throw new ArgumentException("Matrixes have different sizes"); }
            Matrix matrix = new Matrix(RowCount, ColCount);
            for (int r = 0; r < RowCount; ++r)
            {
                for (int c = 0; c < ColCount; ++c)
                {
                    matrix[r, c] = a[r, c] - b[r, c];
                }
            }
            return matrix;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            int RowCount = a.RowCount;
            int ColCount = b.ColCount;
            int TopCount = a.ColCount;
            if (TopCount != b.RowCount) throw new ArgumentException("Incompatible matrix sizes");
            Matrix matrix = new Matrix(RowCount, ColCount);
            for (int r = 0; r <RowCount; ++r)
            {
                for (int c=0; c <ColCount; ++c)
                {
                    for (int t=0; t <TopCount; ++t)
                    {
                        matrix[r, c] += a[r, t] * b[t, c];
                    }
                }
            }
            return matrix;
        }
        public static Matrix Solve(Matrix m, Matrix y)
        {
            int RowCount = m.RowCount;
            if (RowCount != y.RowCount) throw new ArgumentException("Incompatible matrix sizes");
            int mColCount = m.ColCount;
            if (mColCount != RowCount) throw new ArgumentException("First parameter must be square matrix");
            int yColCount = y.ColCount;
            int ColCount = mColCount + yColCount;
            Matrix my = new Matrix(RowCount, ColCount);
            for (int r = 0; r < RowCount; ++r)
            {
                for(int c=0; c < mColCount; ++c) my[r,c] = m[r,c];
                for(int c=0; c < yColCount; ++c) my[r,c + mColCount] = y[r,c];
            }
            for (int d=0; d < RowCount; ++d)//iterujemy po przekątnej
            {
                //a += b-a <==> b += a-b
                int bestd = d;
                for(int r=d+1; r < RowCount; ++r) if (Math.Abs(my[bestd, d]) < Math.Abs(my[r, d])) bestd = r;
                if (bestd != d)
                {
                    for (int c = 0; c < ColCount; ++c)
                    {
                        double tmp = my[d, c];
                        my[d, c] = my[bestd, c];
                        my[bestd, c] = tmp;
                    }
                }
                //do zmiennej lokalnej wpisac wartos komorki z przekatnej
                double division = my[d, d];
                //kazda kolumne wiersza na przekatnej podzielic przez division
                for (int c = 0; c < ColCount; ++c) my[d,c] /= division;
                for (int r = 0; r < RowCount; ++r) //iterujemy po wierszach
                {
                    if (d==r) continue; //pomijamy reszte petli jezeli numer wiersza odpowiada numerowi przekatnej
                    //do zmiennej lokalnej wpisujemy wartosc z wiersza i przekatnej
                    double multiply = my[r, d];
                    //od kazdej komorki wiersza odjac odpowiedznia komorke z przekatnej pomnozonej przez multiply
                    for (int c = 0; c < ColCount; ++c) my[r, c] -= multiply * my[d,c];
                }
            }
            y = new Matrix(RowCount, yColCount);
            for (int r = 0; r < RowCount; ++r)
            {
                for (int c = 0; c < yColCount; ++c) y[r, c] = my[r, c + mColCount];
            }

            return y;
        }

        public static Matrix Inv (Matrix m) 
        {
            Matrix one = new Matrix(m.RowCount, m.ColCount);
            for (int r = 0; r < m.RowCount; ++r)
            {
                for(int c = 0; c < m.ColCount; ++c) one[r, c] = r == c? 1 : 0;
            }

            return Solve(m,one);
        }
        public static Matrix Parse(string text)
        {
            string s = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            string[] Rows = text.Replace(".",s).Replace(",",s).Split("\r\n\v\f".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            int RowCount = Rows.Length , ColCount = 0;
            Matrix matrix = null;
            for(int r=0; r< RowCount; ++r)
            {
                string[] Cols = Rows[r].Split("\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (r == 0) 
                { 
                   ColCount = Cols.Length;
                   matrix= new Matrix(RowCount, ColCount);
                }
                else if (ColCount != Cols.Length)
                {
                    throw new ArgumentException("Irregular matrix forbiden");
                }
                for (int c=0; c< Cols.Length; c++) 
                {
                    matrix[r,c]=double.Parse(Cols[c]);
                }
            }
            return matrix;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int r = 0; r < RowCount; ++r)
            {
                for (int c = 0; c < ColCount; ++c)
                {
                    if (c > 0) sb.Append('\t'); 
                    sb.Append(data[r, c]);
                }
                //sb.Append(Environment.NewLine);
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPrep
{
    public class ZeroMatrix
    {
        //Given an NxM matrix for every instance of a 0, replace the corresponding row and column with zeros
        public int[][] ZeroExplosion(int[][] matrix)
        {
            var zeroFirstCol = false;
            var zeroFirstRow = false;
            for (var i = 0; i < matrix.Length; i++)
            {
                for (var j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        if (i == 0)
                            zeroFirstRow = true;
                        if (j == 0)
                            zeroFirstCol = true;
                        //if we want to do this in place, we can use the first row/column to store which columns/rows we want to blow up with zeros
                        matrix[0][j] = 0;
                        matrix[i][0] = 0;
                    }
                }
            }
            for (var j = 0; j < matrix.Length; j++)
            {
                if(matrix[0][j] == 0)
                    ExplodeCol(matrix, j);
            }
            for (var i = 0; i < matrix.Length; i++)
            {
                if (matrix[i][0] == 0)
                    ExplodeRow(matrix, i);
            }
            if(zeroFirstRow)
                ExplodeRow(matrix, 0);
            if(zeroFirstCol)
                ExplodeCol(matrix, 0);
            return matrix;
        }

        public void ExplodeRow(int[][] matrix, int row)
        {
            for (var j=0; j < matrix.Length; j++)
            {
                matrix[row][j] = 0;
            } 
        }
        public void ExplodeCol(int[][] matrix, int col)
        {
            for (var i = 0; i < matrix.Length; i++)
            {
                matrix[i][col] = 0;
            }
        }
    }
}

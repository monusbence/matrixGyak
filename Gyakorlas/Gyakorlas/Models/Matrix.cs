using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDataModels.AbstractClass;
using WpfDataModels.Interface;

namespace Gyakorlas.Models
{
    internal class Matrix : AbsMatrix, IMatrixOperations
    {
        public void Add(AbsMatrix addMatrix)
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++) 
                {
                    this[rowIndex, columnIndex] += addMatrix[rowIndex, columnIndex];
                }
            }
        }

        public bool Equals(AbsMatrix other)
        {
            bool isEqual = true;
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    if (this[rowIndex, columnIndex] != other[rowIndex, columnIndex])
                    {
                        return false;
                    }
                }
            }
            return isEqual;

        }

        public void Fill(double value)
        {
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] = value;
                }
            }
        }

        public void FillRandomFloat(double start, double end)
        {
            Random rnd = new Random();
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] = (float)(rnd.NextDouble() * (end - start) + start);
                }
            }
        }

        public void FillRandomInt(int start, int end)
        {
            Random rnd = new Random();
            for (int rowIndex = 0; rowIndex < RowCount; rowIndex++)
            {
                for (int columnIndex = 0; columnIndex < ColumnCount; columnIndex++)
                {
                    this[rowIndex, columnIndex] = rnd.Next(start, end);
                }
            }

        }

        public void RotateToDown()
        {
            throw new NotImplementedException();
        }

        public void RotateToLeft()
        {
            throw new NotImplementedException();
        }

        public void RotateToTop()
        {
            throw new NotImplementedException();
        }

        public void RotatetToRight()
        {
            throw new NotImplementedException();
        }

        public void Sub(AbsMatrix subMatrix)
        {
            throw new NotImplementedException();
        }
    }
}

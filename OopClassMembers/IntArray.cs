using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopClassMembers
{
    internal class IntArray
    {
        private readonly int[] _array;

        public IntArray(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(
                    nameof(array),
                    "Cannot calculate min value of a null array.");
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(
                    "Cannot calculate min value of an empty array.",
                    nameof(array));
            }

            _array = array;
        }

        public int Min()
        {
            int min = _array[0];
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] < min)
                {
                    min = _array[i];
                }
            }

            return min;
        }
    }
}

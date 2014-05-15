using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColorSort
{
    class Sort
    {
        private int[] Merge(int[] A, int p, int q, int r)
        {
            int n1 = q - p + 1;
            int n2 = r - q;
            int?[] L = new int?[n1 + 1];
            int?[] R = new int?[n2 + 1];
            L[n1] = null; //sentinal value
            R[n2] = null;

            for (int i = 0; i < n1; i++)
                L[i] = A[p + i];

            for (int i = 0; i < n2; i++)
                R[i] = A[q + i + 1];

            int I = 0;
            int J = 0;
            bool ls = false; //left sentinal
            bool rs = false; //right sentinal
            for (int k = p; k <= r; k++)
            {

                if (ls && rs) return A;
                if (ls)
                {
                    A[k] = R[J].Value; //.Value ensures its not a null
                    J++;
                    if (R[J] == null)
                        rs = true;
                    continue;
                }
                if (rs)
                {
                    A[k] = L[I].Value;
                    I++;
                    if (L[I] == null)
                        ls = true;
                    continue;
                }

                if (L[I] <= R[J])
                {

                    A[k] = L[I].Value;
                    I++;
                    if (L[I] == null)
                        ls = true;
                }

                else
                {
                    if (rs)
                        continue;
                    A[k] = R[J].Value;

                    J++;
                    if (R[J] == null)
                        rs = true;

                }
            }
            return A;


        }
        public int[] mergeSort(int[] A, int p, int r)
        {
            if (p < r)
            {
                int q = (p + r) / 2;
                mergeSort(A, p, q);
                mergeSort(A, q + 1, r);
                return Merge(A, p, q, r);
            }
            return null;
        }

    }
}

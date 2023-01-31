using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Triple
{
    public class Triple<T> where T:IComparable<T>
    {
        public T A { get; set; }
        public T B { get; set; }
        public T C { get; set; }

        public Triple(T a, T b, T c)
        {
            A = a;
            B = b;
            C = c;
        }
        public override string ToString()
        {
            return $"{A}\r\n{B}\r\n{C}";
        }

        public T this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return A;
                    case 1: return B;
                    case 2: return C;
                    default:   throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0: A = value; break;
                    case 1: B = value; break;
                    case 2: C = value; break;
                    default: throw new IndexOutOfRangeException();

                }
            }
        }
        
        public void Sort()
        {
            if (A.CompareTo(B) > 0)
            {
                T temp = A;
                A = B;
                B = temp;
            }

            if (B.CompareTo(C) > 0)
            {
                T temp = B;
                B = C;
                C = temp;
            }

            if (A.CompareTo(B) > 0)
            {
                T temp = A;
                A = B;
                B = temp;
            }
        }
    }
}

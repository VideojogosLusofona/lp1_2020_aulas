using System;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T v0, v1, v2;

        public Guarda3()
        {
            v0 = default;
            v1 = default;
            v2 = default;
        }

        public T GetItem(int i)
        {
            switch (i)
            {
                case 0:
                    return v0;
                case 1:
                    return v1;
                case 2:
                    return v2;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    v0 = item;
                    break;
                case 1:
                    v1 = item;
                    break;
                case 2:
                    v2 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }

    }
}
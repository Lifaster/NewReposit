using System;

namespace FirstApp
{
    class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array;
        }
        public int this[int index]
        {
            get
            {
                return array[index];
            }

            private set
            {
                array[index] = value;
            }
        }

    }
    class Program
        {
            static void Main(string[] args)
            {
            }
        }
}
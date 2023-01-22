namespace Arrays
{

    //Домашка без екстра частини
    internal class Program
    {
        public static int[] SelectionSort()
        {
            int[] array = new int[] { 3, 9, 1, 7, 2, 6 };

            for (int i = 0; i < array.Length - 1; i++)
            {
                var smallObj = i;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallObj])
                        smallObj = j;
                }
                var temp = array[smallObj];
                array[smallObj] = array[i];
                array[i] = temp;
            }

            foreach (int i in array) 
            {
                Console.WriteLine(i);

            }
            return array;
        }

        public static int[] BubbleSort()
        {
            int[] array = new int[] { 4, 6, 1, 7, 3, 8 };

            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }

            foreach (int i in array)
            {
                Console.WriteLine(i);

            }
            return array;
        }

        public static int[] InsertionSort()
        {
            int[] array = new int[] { 10, 6, 4, 2, 7, 8 };


            for (int i = 1; i < array.Length; ++i)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
                      
            foreach (int i in array)
            {
                Console.WriteLine(i);

            }
            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("SelectionSort");
            SelectionSort();
            Console.WriteLine("BubbleSort");
            BubbleSort();
            Console.WriteLine("InsertionSort");
            InsertionSort();
        }
    }
}
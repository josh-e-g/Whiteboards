using System;

namespace ArraySort
{
    public class Class1
    {
        public static int[] Sort(int[] array)
        {
            int count;
            do
            {
                count = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int p = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = p;
                        count += 1;
                    }
                }
            } while (count > 0);

            return array;
        }
    }
}

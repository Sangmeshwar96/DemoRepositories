using System;

namespace ArryDemo
{
    class program
    {
        public static void Main(string[] args)
        {
            int[] my_array = new int[4];

            my_array[0] = 11;
            my_array[1] = 22;
            my_array[2] = 33;
            my_array[3] = 44;

            //for (int i = 0; i < my_array.Length; i++)
            //{
            //    Console.WriteLine(my_array[i]);
            //}

            foreach (int item in my_array)
            {
                Console.WriteLine(item);
            }


            ////Console.WriteLine(my_array[2]);


        }
    }
}
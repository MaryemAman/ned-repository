namespace Multi_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Decalre a 2D array with size 2,2
            int[,] array1 = new int[,] { 
                { 1, 2 }, 
                { 3, 4 } 
            };

            //Print out the members of array1
            //Console.WriteLine(array1[0, 0]);
            //Console.WriteLine(array1[0, 1]);
            //Console.WriteLine(array1[1, 0]);
            //Console.WriteLine(array1[1, 1]);



            //Print out the members of array1 by for loop
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(i); j++)
                {
                    Console.WriteLine(array1[i, j]);
                }
            }

            // Decalre a 2D array with size 4,4
            //array1 = new int[4, 4]
            //{
            //    {1, 2, 3, 4},
            //    {3, 4, 5, 6},
            //    {7, 8, 9, 10},
            //    {11, 12, 13, 14}
            //};

        }
    }
}

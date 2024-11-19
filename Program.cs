namespace ASSIGNMENT_3_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Change first set of 1s to 0.");
            Console.WriteLine("Original Array: 0, 2, 1, 1, 9, 1, 1 ");

            int[] resultArray = ConsecutiveOnes();

            Console.WriteLine("Modified array: ");
            Console.WriteLine(string.Join(", ", resultArray));
        }


        static int[] ConsecutiveOnes()
        {
            int[] ints = [ 0, 2, 1, 1, 9, 1, 1 ];

            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == 1 && ints[i + 1] == 1)
                {
                    ints[i] = 0;
                    ints[i + 1] = 0;
                    break;
                }
            }
        
            return ints;
        }
    }
}

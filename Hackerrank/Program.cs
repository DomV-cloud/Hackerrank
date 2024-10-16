using System.Threading.Channels;

namespace Hackerrank
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> matrix = new List<List<int>>()
            {
                new List<int> { 1, 1, 1, 0, 0, 0 },
                new List<int> { 0, 1, 0, 0, 0, 0 },
                new List<int> { 1, 1, 1, 0, 0, 0 },
                new List<int> { 0, 0, 2, 4, 4, 0 },
                new List<int> { 0, 0, 0, 2, 0, 0 },
                new List<int> { 0, 0, 1, 2, 4, 0 }
            };

            hourglassSum(matrix);
        }

        public static int hourglassSum(List<List<int>> arr)
        {
            List<int> row = [];
            int column = 0;
            int sum = 0;

            for (int i = 0; i < arr.Count; i++) // column 
            {
                row = arr[i];
                column = arr[i].First();

                for (int j = 0; j < 1; j++) // row
                {
                    Console.Write(row[j] + " ");
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}

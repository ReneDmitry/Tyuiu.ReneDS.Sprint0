namespace Tyuiu.ReneDS.Sprint0.Task6.V1.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            return total;
        }

        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            var index = 0;

            while(index < numbers.Length)
            {
                total = total - numbers[index];
                index++;
            }
            return total;
        }

        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            var index = 0;

            do
            {
                total = total *  numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return total;
        }
    }
}

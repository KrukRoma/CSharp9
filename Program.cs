namespace CSharp9
{
    public interface IOutput
    {
        void Show();
        void Show(string info);
    }

    public class Array : IOutput
    {
        private int[] array1;

        public Array(int[] array)
        {
            array1 = array;
        }

        public void Show()
        {
            Console.WriteLine("Array elements:");
            foreach (var item in array1)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.WriteLine(info);
            Show();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Array myArray = new Array(numbers);

            myArray.Show();

            myArray.Show("This is my array of numbers:");
        }
    }
}

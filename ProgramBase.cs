namespace LatihanOverloadingMethod
{
    internal class ProgramBase
    {
        public static void Main(string[] args)
        {
            Numbers number = new Numbers();

            Console.WriteLine("Minimum #1: {0}", number.FindMinimum(3, 1));
            Console.WriteLine("Minimum #2: {0}", number.FindMinimum(3, 4, 2));
            Console.WriteLine();
            Console.WriteLine("Maximum #1: {0}", number.FindMaximum(3, 1));
            Console.WriteLine("Maximum #2: {0}", number.FindMaximum(3, 2, 4));

            Console.ReadKey();
        }
    }
}
using System;

namespace CharPlay
{
    class Program
    {
        static void Main(string[] args)
        {
			string testString = " 0123456789 mark ";
			int i = testString.Length;
			int actualCharConvertedToInt;

			Console.WriteLine("---------------------------------------------------------");
			Console.WriteLine(testString);
			Console.WriteLine("---------------------------------------------------------");
			Console.WriteLine(i);
			Console.WriteLine("---------------------------------------------------------");
			for (int loop = 0; loop < i; loop++)
			{
				Console.Write(testString[loop]);
				Console.Write(" loop = ");
				Console.Write(loop);

				//Convert the char indexed by 'loop' to an int

				actualCharConvertedToInt = testString[loop];
				Console.Write(" actualCharConvertedToInt = \t");
				Console.Write(actualCharConvertedToInt);
				Console.Write(" -\t");
				//Console.Write(Char.GetNumericValue('m')); //returns -1
				Console.WriteLine(Char.GetNumericValue(testString[loop]));
			}
			Console.WriteLine("---------------------------------------------------------");
			Console.ReadKey();
		}
    }
}


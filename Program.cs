using System;

namespace Bminandi
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Add meg a magasságod (cm-ben):");
			double cm = Convert.ToDouble(Console.ReadLine());
			Console.Write("Add meg a testtömeged (kg-ban):");
			double kg = Convert.ToDouble(Console.ReadLine());
			double bmi = kg / ((cm / 100) * (cm / 100));
			if (bmi < 20)
			{
				Console.WriteLine("Alultáplált");
			}
			else if (19 < bmi && bmi < 25)
			{
				Console.WriteLine("Normális");
			}
			else if (24 < bmi && bmi < 30)
			{
				Console.WriteLine("Elhízott");
			}
			else {
				Console.WriteLine("Erősen elhízott");
			}
			Console.ReadKey();

		}
	}
}

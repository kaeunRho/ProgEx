using System;

namespace _04
{
	class Lab4
	{
		public static void Main (string[] args)
		{
			string num1 = Console.ReadLine ();
			string num2 = Console.ReadLine ();
			int Num1 = int.Parse(num1);
			int Num2 = int.Parse(num2);
			int sum =  Num1+Num2;
			Console.WriteLine ("First Num:{0}, Second Num:{1}, Sum:{2}",Num1,Num2,sum);
		}
	}
}

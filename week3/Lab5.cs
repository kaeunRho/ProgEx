using System;

namespace Lab5
{
	class Student
	{
		public string Name;
		public int Korean;
		public int English; 
		public int Mathmatics;
		public int Science;
		public Student(string _Name,int _Korean,int _English,int _Mathmatics, int _Science)
		{
		Name = _Name;
		Korean = _Korean;
		English = _English;
		Mathmatics = _Mathmatics;
		Science = _Science;
	    }
		public int Average()
	{
		return(Korean + English + Mathmatics + Science) / 4;
	}
	}
	class Average
	{
		public static void Main (string[] args)
		{
		Student S1 = new Student ("조영호", 10, 20, 30, 40);
			Console.WriteLine ("Name:{0},Average:{1}",S1.Name,S1.Average());
		}
	}
}

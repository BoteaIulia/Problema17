using System;

public static class Globals
{

	internal static void Main()
	{

		Console.Write("Determinati CMMDC si CMMMC a celor doua numere:");
		Console.Write("\n");

		int n;
		int m;
		int r;
		int P;
		Console.Write("Primul numar= ");
		n = Convert.ToInt32(Console.ReadLine());
		Console.Write("Al doilea  numar= ");
		m = Convert.ToInt32(Console.ReadLine()); ;
        P = n * m;


		while (m != 0)
		{


		    r = n % m;
			n = m;
			m = r;


		}
		Console.Write("CMMDC= ");
		Console.Write(n);
		const char V = '\n';
		Console.Write(V);
		Console.Write("CMMMC= ");
        int r1 = 'r';
        Console.Write(value: P / r1);


	}
}

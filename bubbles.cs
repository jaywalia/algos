using System;

public class Program
{
	// more of a ball sort 
	// true bubble sort shoudl find the largest item and then push it to top
	// and then find the next largest and so on.
	public static int[] BubbleSort(int[] a)
	{
		bool finishedSorting = false;
		//Print(a);
		while (!finishedSorting)
		{
			// before every loop we assume that we are done 
			// and no more sorting needs to be done
			bool stillSorting = false;
			for (int j = 0; j < a.Length - 1; j++)
			{
				Console.WriteLine($"{a[j]} and {a[j + 1]}");
				// if we swap an item, means we are still sorting
				if (a[j] > a[j + 1])
				{
					Console.WriteLine($"Swapping {a[j]} with {a[j + 1]}");
					//int t = a[j];
					//a[j] = a[j+1];
					//a[j+1] = t;
					// tuple swap
					(a[j + 1], a[j]) = (a[j], a[j + 1]);
					stillSorting = true;
				}
			}

			finishedSorting = !stillSorting;
			if (finishedSorting)
				Console.WriteLine("Yes! finished sorting");
			Print(a);
		}

		return a;
	}

	public static void Print(int[] a)
	{
		Console.Write("[");
		foreach (int i in a)
			Console.Write($"{i},");
		Console.Write("]");
		Console.WriteLine();
	}

	public static void Main()
	{
		int[] a = new int[]{2, 1, 3, 4, 7, 9, 3, 1};
		Print(a);
		int[] a_s = BubbleSort(a);
		Print(a_s);
	}
}

// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

using System;
					
public class Program
{
	public static int binarysearch(int[] arr1, int num)
	{
		int len = arr1.Length;
		int start = 0;
		int end = len - 1;
		while (start <= end)
		{
			int mid = (start + end) / 2;
			if (arr1[mid] == num)
				return mid;
			else if (num < arr1[mid])
				end = mid - 1;
			else
				start = mid + 1;

		}
		return -1;
	}
	public static void Main()
	{
		Console.WriteLine("Hello World");
		int[] arr = new int[] { 1, 3, 5, 8, 9, 10, 14, 16, 20 };
		int result = binarysearch(arr, 10);
		Console.WriteLine(result);
	}
}


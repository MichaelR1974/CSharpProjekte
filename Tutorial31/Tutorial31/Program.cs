

namespace Tutorial31
{
	class Programm
	{
		public static void Main(string[] args)
		{
			int newNumber = 5;
            int newNumber1 = 15;
            newNumber = MyFunktion(newNumber);
			Console.WriteLine(newNumber);

			newNumber1 = CrazyFunktion(newNumber1);
			Console.WriteLine(newNumber1);

			PrintSomethink();

			int[] arr1 = new int[] { 10, 20, 40 };
			int[] arr2 = new int[] { 15, 25, 45 }; ;

			PrintArray(arr1);
			PrintArray(arr2);
        }
			public static int MyFunktion(int number)
			{

			Console.WriteLine("this a funtion");
			int result = number * 10;

			return result;

			
			}

		public static int CrazyFunktion(int number)
		{
			return number * number;
		}

		public static void PrintSomethink()
		{

			Console.WriteLine("hi");
		}

		public static void PrintArray (int[] arr)
		{

			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("{0}, ", arr[i]);
			}
		}
	}
}
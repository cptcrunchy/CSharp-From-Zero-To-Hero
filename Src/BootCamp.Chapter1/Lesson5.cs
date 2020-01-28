using System;


namespace BootCamp.Chapter1
{
	static class Lesson5
	{
		internal static void Sort(int[] values)
		{
			if (values != null && values.Length > 0) Array.Sort(values);
		}
		internal static void Reverse(int[] values)
		{
			if (values != null && values.Length > 0) Array.Reverse(values);
		}

		internal static int[] RemoveLast(int[] values)
		{
			if (values != null && values.Length > 0)
			{
				int[] modifiedArray = new int[values.Length - 1];

				Array.Copy(values, modifiedArray, values.Length -1);

				return modifiedArray;
			}
			else
			{
				return values;
			}
		}
		internal static int[] InsertLast(int[] array, int number)
		{
			if (array != null && array.Length > 0)
			{

				int[] modifiedArray = new int[array.Length + 1];
				for (int i = 0; i < array.Length; i++)
				{
					modifiedArray[i] = array[i];
				}

				modifiedArray.SetValue(number, modifiedArray.Length - 1);
				return modifiedArray;
			}
			else
			{
				return new int[1] { number };
			}
		}

		internal static int[] RemoveFirst(int[] values)
		{
			if (values != null && values.Length > 0)
			{
				int[] modifiedArray = new int[values.Length - 1];

				Array.Copy(values, 1, modifiedArray, 0, values.Length - 1);

				return modifiedArray;
			}
			else
			{
				return values;
			}
		}
		internal static int[] InsertFirst(int[] array, int number)
		{

			if (array != null && array.Length > 0)
			{
				int[] modifiedArray = new int[array.Length + 1];
				modifiedArray.SetValue(number, 0);
				for (int i = 0; i < array.Length; i++)
				{
					modifiedArray[i + 1] = array[i];
				}
				return modifiedArray;
			}
			else
			{
				return new int[1] { number };
			}
		}

		internal static int[] RemoveAt(int[] array, int index)
		{
			bool HasInvalidArguments = array == null || index < 0 || index >= array.Length;
			
			if (HasInvalidArguments)
			{
				return array;			
			}
			else
			{
				var modifiedArray = new int[array.Length - 1];
				for (int i = 0; i < modifiedArray.Length; i++)
				{
					modifiedArray[i] = i < index ? array[i] : array[i + 1];
				}
				return modifiedArray;
			}
		}
		internal static int[] InsertAt(int[] array, int number, int index)
		{
			/// <returns>A new array with element inserted at a given index.
			/// If an array is empty or null, returns new array with number in it.</returns>

			if (index <= 0 || array.Length == 0)
			{
				if (index == 0)
				{
					return new int[1] { number };
				}
				else
				{
					return array;
				}
				
			}
			else
			{
				var modifiedArray = new int[array.Length + 1];
				for (int i = 0; i < array.Length; i++)
				{
					if (i == index)
					{
						modifiedArray[index] = number;
					}
					else
					{
						modifiedArray[i] = array[i];
					}

				}
				return modifiedArray;

			}
		}
	}
}

using System;


namespace BootCamp.Chapter1
{
    static class Lesson5
    {
        /// <summary>
        /// This helper method will take in an array of type int and return true if
        /// the array is not null and the array's length is greater than 0
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        internal static bool IsNotNullAndEmpty(int[] array)
        {
            return array != null && array.Length > 0;
        }

        internal static void Sort(int[] array)
        {
            if (IsNotNullAndEmpty(array)) Array.Sort(array);
        }
        
        internal static void Reverse(int[] array)
        {
            if (IsNotNullAndEmpty(array)) Array.Reverse(array);
        }

        internal static int[] RemoveLast(int[] array)
        {
            if (IsNotNullAndEmpty(array))
            {
                int[] modifiedArray = new int[array.Length - 1];

                Array.Copy(array, modifiedArray, array.Length - 1);

                return modifiedArray;
            }
            else
            {
                return array;
            }
        }
        
        internal static int[] InsertLast(int[] array, int number)
        {
            if (IsNotNullAndEmpty(array))
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

        internal static int[] RemoveFirst(int[] array)
        {
            if (IsNotNullAndEmpty(array))
            {
                int[] modifiedArray = new int[array.Length - 1];

                Array.Copy(array, 1, modifiedArray, 0, array.Length - 1);

                return modifiedArray;
            }
            else
            {
                return array;
            }
        }
        
        internal static int[] InsertFirst(int[] array, int number)
        {

            if (IsNotNullAndEmpty(array))
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

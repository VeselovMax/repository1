using System;

namespace Project1
{
    class OneDimensionalArray
    {
        private int[] array;

        public OneDimensionalArray(bool getFromUser, int length)
        {
            Create(getFromUser, length);
        }

        private int[] GetFromUser()
        {
            Console.WriteLine("Получение массива с клавиатуры, введите длину");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Вводите значения");
            for (int i = 0; i < array.Length; i++)
            {
                int value = int.Parse(Console.ReadLine());
                array[i] = value;
            }
            Console.WriteLine("Массив получен");
            return array;
        }

        private int[] GetRandom(int length)
        {
            Random random = new Random();
            int[] array = new int[length];
            for (int i = 0; i < array.Length; i++)
            {
                int value = random.Next(0, 10);
                array[i] = value;
            }
            return array;
        }

        public void Print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine("");
        }

        public void Create(bool getFromUser, int length)
        {
            if (getFromUser)
            {
                array = GetFromUser();
            }
            else
            {
                array = GetRandom(length);
            }
        }

        public decimal GetAverageValue()
        {
            decimal sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum / array.Length;
        }

        public void DeleteElementsBiggerThan100()
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 100 && array[i] >= -100)
                {
                    count += 1;
                }
            }
            int[] new_array = new int[count];
            int count2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 100 && array[i] >= -100)
                {
                    new_array[count2] = array[i];
                    count2++;
                }
            }
            array = new_array;
        }

        public void DeleteRepeating()
        {
            int count = 0;
            bool isUnique = true;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i > j && array[i] == array[j])
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    count++;
                }
                isUnique = true;
            }
            int[] new_array = new int[count];
            int count1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i > j && array[i] == array[j])
                    {
                        isUnique = false;
                    }
                }
                if (isUnique)
                {
                    new_array[count1] = array[i];
                    count1++;
                }
                isUnique = true;
            }
            array = new_array;
        }
    }
}
using System;

namespace Project1
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool getFromUser;
            bool remake;
            Console.WriteLine("Одномерный массив");
            Console.WriteLine("Ввести массив вручную?    yes/no");
            getFromUser = CheckFromUser();
            OneDimensionalArray OneDimArray = new OneDimensionalArray(getFromUser, 5);
            OneDimArray.Print();

            Console.Write("Среднее значение всех элементов массива: ");
            Console.WriteLine(OneDimArray.GetAverageValue());

            OneDimArray.DeleteElementsBiggerThan100();
            Console.WriteLine("Удалены элементы больше 100 по модулю");
            OneDimArray.Print();

            OneDimArray.DeleteRepeating();
            Console.WriteLine("Удалены повторяющиеся элементы");
            OneDimArray.Print();

            Console.WriteLine("Пересоздать массив?    yes/no");
            remake = CheckFromUser();
            if (remake)
            {
                Console.WriteLine("Ввести массив вручную?    yes/no");
                getFromUser = CheckFromUser();
                OneDimArray.Create(getFromUser, 5);
                Console.WriteLine("Массив пересоздан");
                OneDimArray.Print();
            }

            Console.WriteLine("\nДвумерный массив");
            Console.WriteLine("Ввести массив вручную?    yes/no");
            getFromUser = CheckFromUser();
            TwoDimensionalArray TwoDimArray = new TwoDimensionalArray(getFromUser, 5, 5);
            TwoDimArray.Print();

            Console.Write("Среднее значение всех элементов массива: ");
            Console.WriteLine(TwoDimArray.GetAverageValue());

            Console.WriteLine("Массив выведенный змейкой:");
            TwoDimArray.PrintAsSnake();

            Console.WriteLine("Пересоздать массив?    yes/no");
            remake = CheckFromUser();
            if (remake)
            {
                Console.WriteLine("Ввести массив вручную?    yes/no");
                getFromUser = CheckFromUser();
                TwoDimArray.Create(getFromUser, 5, 5);
                Console.WriteLine("Массив пересоздан");
                TwoDimArray.Print();
            }

            Console.WriteLine("\nСтупенчатый массив");
            Console.WriteLine("Ввести массив вручную?    yes/no");
            getFromUser = CheckFromUser();
            JaggedArray JagArray = new JaggedArray(getFromUser, 5);
            JagArray.Print();

            Console.Write("Среднее значение всех элементов массива: ");
            Console.WriteLine(JagArray.GetAverageValue());

            Console.Write("Средние значения всех элементов массивов: ");
            Console.WriteLine(JagArray.GetAverageInnerValues());

            Console.WriteLine("Изменены все четные по значению элементы массива на произведения их индексов");
            JagArray.ChangeEven();
            JagArray.Print();
            Console.WriteLine("Пересоздать массив?    yes/no");
            remake = CheckFromUser();
            if (remake)
            {
                Console.WriteLine("Ввести массив вручную?    yes/no");
                getFromUser = CheckFromUser();
                JagArray.Create(getFromUser, 5);
                Console.WriteLine("Массив пересоздан");
                JagArray.Print();
            }

            static bool CheckFromUser()
            {
                bool answer = false;
                bool incorrectAnswer = true;
                string input;
                while (incorrectAnswer)
                {
                    input = Console.ReadLine();
                    if (input == "yes")
                    {
                        answer = true;
                        incorrectAnswer = false;
                    }
                    else if (input == "no")
                    {
                        answer = false;
                        incorrectAnswer = false;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели некорректный ответ! Попробуйте снова.");
                    }
                }
                return answer;
            }
        }
    }
}

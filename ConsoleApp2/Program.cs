using System.Collections;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Създаване на празен ArrayList
            ArrayList products = new ArrayList();

            // 2. Добавяне на 4 начални продукта
            products.Add("Хляб");
            products.Add("Мляко");
            products.Add("Яйца");
            products.Add("Сирене");

            // 3. Въвеждане на нов продукт от клавиатурата
            Console.Write("Въведете нов продукт: ");
            string newProduct = Console.ReadLine();

            products.Add(newProduct);

            // 4. Проверка дали Мляко се съдържа в списъка
            if (products.Contains("Мляко"))
            {
                products.Remove("Мляко");

                Console.WriteLine(
                    "Продуктът 'Мляко' беше купен и премахнат от списъка."
                );
            }

            // 5. Вмъкване на Кафе на втора позиция (индекс 1)
            products.Insert(1, "Кафе");

            // 6. Извеждане на общия брой продукти
            Console.WriteLine("\nОбщ брой продукти: " + products.Count);

            // 7. Отпечатване на всички продукти с номерация
            Console.WriteLine("Останали продукти:");

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + products[i]);
            }
        }
        //програмни езици 
    }
}

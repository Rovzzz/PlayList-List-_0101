using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace List
{
    public class Program
    {
        void newPlayList ()
        {
        }

        static void Main(string[] args)
        {
            #region Номер1
            //List<string> people = new List<string>  ()
            //{
            //"Злобинов",
            //"Баашенков",
            //"Коротких",
            //"Корнилова"
            //};
            //people.Add("Смолин");
            //foreach (var item in people)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Номер2
            Console.WriteLine("Музыкальный плеер");
            Console.WriteLine("\nВыберите плейлист:");
            Console.WriteLine("\n1 - Рок\n2 - Шансон\n3 - Фолк");

            Dictionary<int, string> rock = new Dictionary<int, string> ()
            {
                {1, "Rusoka - Pirunkieli" },
                {2, "Judas Priest - Painkiller"},
                {3, "Therion - Summernight city"}
            };

            Dictionary<int, string> Shanson = new Dictionary<int, string>()
            {
                {1, "Михаил Круг - Кольщик" },
                {2, "Сергей Трофимов - Город Сочи"},
                {3, "Бутырка - Вторяки не чай"}
            };

            Dictionary<int, string> Folk = new Dictionary<int, string>()
            {
                {1, "Roki Vulovic - Smoluca" },
                {2, "Roki Vulovic - Panteri"},
                {3, "Baja Mali Knindza - Tata"}
            };

            for ( ; ; )
            {
                Console.Write("\nВведите номер альбома: ");
                int number = Convert.ToInt32(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("\nРок");
                        foreach (var item in rock)
                        {
                            Console.WriteLine($"\n {item}");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nШансон");
                        foreach (var item in Shanson)
                        {
                            Console.WriteLine($"\n {item}");
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nФолк");
                        foreach (var item in Folk)
                        {
                            Console.WriteLine($"\n {item}");
                        }
                        break;
                    default:
                        if (number > 3)
                        {
                            Console.WriteLine("\nВыберите альбом из существующих или создайте новый альбом!");
                        }
                        break;
                }
            }
            #endregion
            Console.ReadKey();

        }
    }
}

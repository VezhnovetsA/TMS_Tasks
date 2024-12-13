
namespace simu
{
    internal class Program
    {
        public static int CalculateMoney(int prod1, int prod2, int prod3, int prod4, int prod5, int usersMoney, int usersChoise)
        {
            switch (usersChoise)
            {
                case 1:
                    if (usersMoney >= prod1)
                    {
                        usersMoney -= prod1;
                    }
                    else
                    {
                        Console.WriteLine("\n ***** У вас недостаточно средств! *****");
                    }
                    break;

                case 2:
                    if (usersMoney >= prod2)
                    {
                        usersMoney -= prod2;
                    }
                    else
                    {
                        Console.WriteLine("\n ***** У вас недостаточно средств! *****");
                    }
                    break;

                case 3:
                    if (usersMoney >= prod3)
                    {
                        usersMoney -= prod3;
                    }
                    else
                    {
                        Console.WriteLine("\n ***** У вас недостаточно средств! *****");
                    }
                    break;

                case 4:
                    if (usersMoney >= prod4)
                    {
                        usersMoney -= prod4;
                    }
                    else
                    {
                        Console.WriteLine("\n ***** У вас недостаточно средств! *****");
                    }
                    break;

                case 5:
                    if (usersMoney >= prod5)
                    {
                        usersMoney -= prod5;
                    }
                    else
                    {
                        Console.WriteLine("\n ***** У вас недостаточно средств! *****");
                    }
                    break;

                default:
                    Console.WriteLine("Ошибка в функции CalculateMoney");
                    break;

            }
            return usersMoney;
        }


        public static bool WantsToStay(int userMoney)
        {
            Console.WriteLine($"\nНа вашем счету {userMoney} рублей. Желаете приобрести в данном отделе что-то еще?");
            Console.WriteLine("(Выберете 1 если желаете остаться, выберете другое числовое значение для выхода из отдела)\n");

            bool temp;
            int userChoise = Int32.Parse(Console.ReadLine());

            if (userChoise == 1)
            {
                temp = true;
            }

            else
            {
                temp = false;
            }

            return temp;
        }

        public static void Main(string[] args)
        {
            // Задание 4: Симулятор магазина Покупатель-продавец (для любителей финтеха =D)

            //Описание:
            //Создайте программу, где пользователь играет роль покупателя,
            //а программа выступает в роли продавца.В начале у пользователя есть определённая сумма денег.
            //Программа предлагает товары на продажу с случайно сгенерированными ценами.
            //Пользователь может покупать товары, пока у него есть деньги, или выйти из магазина.

            //Пример:

            //Добро пожаловать в магазин!У вас на счету: 500 монет.

            //Товары в наличии:
            //1.Яблоко - 50 монет
            //2.Хлеб - 30 монет
            //3.Сыр - 100 монет

            //Введите номер товара для покупки или "0" для выхода: 1
            //Вы купили Яблоко за 50 монет.Остаток: 450 монет.

            //Товары в наличии:
            // 1.Хлеб - 30 монет
            //2.Сыр - 100 монет

            int money = 30;
            bool exitShop = true;

            Console.WriteLine($"Вы в магазине. На вашем счету {money} рублей");

            while (exitShop)
            {
                Console.WriteLine("\nКакой отдел желаете посетить?");

                Console.WriteLine("1 - фрукты/овощи \n2 - хлебобулочные \n3 - мясомолочный");
                Console.WriteLine("(Выберете другое числовое значение для выхода из магазина)\n");
                int category = Int32.Parse(Console.ReadLine());

                switch (category)
                {
                    case 1:

                        bool exitCategory = true;

                        while (exitCategory)
                        {
                            Console.WriteLine("\nВы в отделе фруктов и овощей. Что желаете приобрести?");
                            Console.WriteLine("1 - Яблоки 1кг (3 руб.) \n2 - Груши 1кг (7 руб.) \n3 - Томаты 1кг (9 руб.) \n4 - Огурцы 1кг (8 руб.) \n5 - Морковь 1кг (2 руб.)");
                            Console.WriteLine("Какие товары желаете приобрести?\n");

                            int choise = Int32.Parse(Console.ReadLine());

                            money = CalculateMoney(3, 7, 9, 8, 2, money, choise);

                            exitCategory = WantsToStay(money);

                        }

                        break;

                        ////////////////////////////////



                    case 2:

                        exitCategory = true;

                        while (exitCategory)
                        {
                            Console.WriteLine("\nВы в хлебобулочном отделе. Что желаете приобрести?");
                            Console.WriteLine("1 - Хлеб (2 руб.) \n2 - Батон (1 руб.) \n3 - Пряники (5 руб.) \n4 - Сушки (4 руб.) \n5 - Лаваш (3 руб.)");
                            Console.WriteLine("\nКакие товары желаете приобрести?\n");

                            int choise = Int32.Parse(Console.ReadLine());

                            money = CalculateMoney(2, 1, 5, 4, 3, money, choise);

                            exitCategory = WantsToStay(money);
                        }    
                            
                        break;

                    case 3:

                        exitCategory = true;

                        while (exitCategory)
                        {
                            Console.WriteLine("\nВы в отделе мясных и молочных продуктов. Что желаете приобрести?");
                            Console.WriteLine("1 - Яйца (4 руб.) \n2 - Молоко (3 руб.) \n3 - Филе цыпленка (12 руб.) \n4 - Колбаса вареная (5 руб.)\n5 - Сардельки (7 руб.)");
                            Console.WriteLine("\nКакие товары желаете приобрести?\n");

                            int choise = Int32.Parse(Console.ReadLine());

                            money = CalculateMoney(4, 3, 12, 5, 7, money, choise);

                            exitCategory = WantsToStay(money);
                            
                        }

                        break;


                    default:

                        Console.WriteLine("\nДо свидания!");
                        exitShop = false;

                        break;
                }
            }

            Console.ReadKey();

        }
    }


}


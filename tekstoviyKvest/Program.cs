namespace tekstoviyKvest
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Напишите текстовую игру, где пользователь принимает решения, от которых зависит сюжет.

            //Пример:

            //Вы находитесь в лесу. Перед вами два пути: налево и направо.Введите ваш выбор
            //(налево / направо): направо
            //Вы встретили медведя и убежали. Конец игры.

            Console.WriteLine("Вы очутились в темном лесу. Ночь приближается, и вам нужно выбраться до наступления темноты.");
            Console.WriteLine("Цель - найти дорогу к дому, избегая опасностей\n");

            Console.WriteLine("Вы стоите на лесной тропинке. Перед вами развилка. Что вы сделаете? (Введите соответствующую цифру)\n");
            Console.WriteLine("1 - Повернуть налево \n2 - Повернуть направо\n3 - Пойти прямо\n");

            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice) 
            {
                case 1:
                    {
                        Console.WriteLine("\nВы идете налево и видите старый мост. Она кажется хрупким. Что вы сделаете?");
                        Console.WriteLine("1 - Перейти по мосту \n2 - Обойти мост по воде\n");

                        userChoice = int.Parse(Console.ReadLine());

                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nМост действительно оказался хрупким и обрушися под вашими ногами. Конец игры.");

                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nВы промокли до нитки, но находите новую тропинку, по которой вы добираетесь до дома.");

                        }

                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("\nВы выбираете путь направо и видите заброшенную хижину. Что вы сделаете?");
                        Console.WriteLine("1 - Зайти внутрь \n2 - Пройти мимо\n");

                        userChoice = int.Parse(Console.ReadLine());

                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nВы находите карту, которая указывает дорогу к выходу.");
                            
                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nВы проходите мимо и продолжаете путь, но впоследствие заблудились в лесу. Конец игры.");

                        }

                        break;
                    }

                case 3:
                    {
                        Console.WriteLine("\nВы идете прямо и наталкиваетесь на волка. Что вы сделаете?");
                        Console.WriteLine("1 - Попробовать убежать \n2 - Спокойно отступить\n");

                        userChoice = int.Parse(Console.ReadLine());

                        if (userChoice == 1)
                        {
                            Console.WriteLine("\nВолк догоняет вас. Конец игры");

                        }
                        else if (userChoice == 2)
                        {
                            Console.WriteLine("\nВолк не преследует вас, и вы находите тропинку, ведущую к выходу.");

                        }

                        break;
                    }
            }
            Console.ReadKey();

            }

        }
    }




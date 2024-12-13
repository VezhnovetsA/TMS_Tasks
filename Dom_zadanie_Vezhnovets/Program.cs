namespace Dom_zadanie_Vezhnovets
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Задание 1: Вывод ФИО и даты рождения  - базовое задание, без использовния библиотек
            //Описание:
            //Напишите программу, которая запрашивает у пользователя его ФИО и дату рождения, а затем выводит их на экран.

            //Пример:

            //Введите ваше ФИО: Иванов Иван Иванович  
            //Введите дату рождения (дд.мм.гггг): 15.03.1990
            //Ваши данные: Иванов Иван Иванович, дата рождения: 15.03.1990

            Console.WriteLine("Задание 1\n");

            Console.WriteLine("Введите ваше ФИО: ");
            string usersName = Console.ReadLine();

            Console.WriteLine("Введите вашу дату рождения: ");
            string usersDateOfBirth = Console.ReadLine();

            Console.WriteLine($"\nВаши данные:\nФИО: {usersName}\nДата рождения: {usersDateOfBirth}");
            Console.ReadKey();
        }

    }
}


using HTcinema;

var mov = new Movies();
var cash = new CashRegister();
var sess = new Session();




///////////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("Добро пожаловать в кинотеатр!");

bool exit = false;

while (!exit)
{
    Console.WriteLine("\n\tВыберете действие: ");

    Console.WriteLine("\t1 - Просмотреть список фильмов");
    Console.WriteLine("\t2 - Просмотреть доступные сеансы");
    Console.WriteLine("\t3 - Посмотреть список фильмов конкретного жанра");
    Console.WriteLine("\t4 - Купить билет");
    Console.WriteLine("\t5 - Добавить фильм");
    Console.WriteLine("\t6 - Удалить фильм");
    Console.WriteLine("\t7 - Посмотреть список купленных билетов");
    Console.WriteLine("\t\tДля завершения работы программы введите любое другое значение.\n");

    string operation = Console.ReadLine();

    switch (operation)
    {
        case "1":
            mov.ShowAllMovies();

            break;

        case "2":
            sess.ShowAllSessions();

            break;

        case "3":
            Console.WriteLine("Введите жанр: ");
            string specificGenre = Console.ReadLine();

            mov.ShowAllThatGenreMovies(specificGenre);

            break;

        case "4":

            Console.WriteLine("Введите название фильма: ");
            string boughtMovie = Console.ReadLine();

            Console.WriteLine();
            sess.ShowAllSessions();

            Console.WriteLine("\nВыберте время сеанса: ");
            string selectedSessionTime = Console.ReadLine();

            cash.BuyTicket(boughtMovie, selectedSessionTime, mov.GetMoviesDictionary(), sess);
            break;


        case "5":
            Console.WriteLine("Введите название фильма: ");
            string name = Console.ReadLine();

            Console.WriteLine("Введите жанр фильма: ");
            string genre = Console.ReadLine();

            mov.AddMovie(name, genre);

            break;

        case "6":
            Console.WriteLine("Введите название фильма: ");
            string deleteName = Console.ReadLine();

            mov.RemoveMovie(deleteName);

            break;

        case "7":
            cash.ShowPurchasedTickets();

            break;

        default:
            exit = true;

            break;
    }

}

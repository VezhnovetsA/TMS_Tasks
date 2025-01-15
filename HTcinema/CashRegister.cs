namespace HTcinema
{
    internal class CashRegister
    {
        private Dictionary<string, Dictionary<string, int>> tickets = new();


        public void BuyTicket(string movieName, string sessionTime, Dictionary<string, string> moviesDictionary, Session session)
        {
            if (moviesDictionary.ContainsKey(movieName) && session.CheckSessionTime(sessionTime))
            {

                if (!tickets.ContainsKey(movieName))
                {
                    tickets[movieName] = new Dictionary<string, int>();
                }

                if (tickets[movieName].ContainsKey(sessionTime))
                {
                    tickets[movieName][sessionTime]++;
                }
                else
                {
                    tickets[movieName][sessionTime] = 1;
                }

                Console.WriteLine($"Билет на фильм \"{movieName}\" на сеанс в {sessionTime} успешно куплен!");
            }

            else
            {
                Console.WriteLine($"Фильм \"{movieName}\" не найден в списке доступных фильмов или выбрано неверное время сеанса");
            }
        }


        public void ShowPurchasedTickets()
        {
            Console.WriteLine("Купленные билеты:");

            foreach (var movie in tickets)
            {
                foreach (var session in movie.Value)
                {
                    Console.WriteLine($"Фильм: {movie.Key}, Время сеанса: {session.Key}, Количество билетов: {session.Value}");
                }
            }
        }

    }
}


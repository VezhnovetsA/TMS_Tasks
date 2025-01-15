namespace HTcinema
{
    internal class Session
    {
        private List<string> sessionTimes = GenerateSessionTimes(new TimeSpan(10, 0, 0), new TimeSpan(22, 0, 0), TimeSpan.FromHours(2));

        //private Dictionary<string, string> movies = new Dictionary<string, string>() 
        private static List<string> GenerateSessionTimes(TimeSpan startTime, TimeSpan endTime, TimeSpan interval)
        {
            var sessionTimes = new List<string>();
            for (var time = startTime; time <= endTime; time += interval)
            {
                sessionTimes.Add(time.ToString(@"hh\:mm"));
            }
            return sessionTimes;
        }

        public void ShowAllSessions()
        {
            Console.WriteLine("Доступные сеансы:");

            foreach (string time in sessionTimes)
            {
                Console.WriteLine(time);
            }
        }

        public List<string> GetSessionTimes()
        {
            return sessionTimes;
        }

        public bool CheckSessionTime(string usersInputTime)
        {
            if (sessionTimes.Contains(usersInputTime))
            {
                return true;
            }
            else
            {  
                return false;
            }
        }

    }
}

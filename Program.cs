using System;

namespace ClubInterface
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Methods
        string Fullname();
    }

    class Program
    {
        class GameClub : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string GameName { get; set; }
            public string Type { get; set; }
            public int Players { get; set; }

            public GameClub()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                GameName = string.Empty;
                Type = string.Empty;
                Players = 0;
            }

            public GameClub(int id, string firstName, string latestName, string gameName, string type, int players)
            {
                Id = id;
                FirstName = firstName;
                LastName = latestName;
                GameName = gameName;
                Type = type;
                Players = players;
            }

            public string Fullname()
            {
                return FirstName + " " + LastName;
            }

            public void Display()
            {
                Console.WriteLine($"~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"Member ID: {Id}");
                Console.WriteLine($"Member Name: {Fullname()}");
                Console.WriteLine($"Playing: {GameName}");
                Console.WriteLine($"Game Type: {Type} game");
                Console.WriteLine($"Number of Players: {Players}");
            }
        
        }

        static void Main(string[] args)
        {
            GameClub gameOne = new GameClub();
            gameOne.Id= 1;
            gameOne.FirstName = "Jonny";
            gameOne.LastName = "Jones";
            gameOne.GameName = "Monopoly";
            gameOne.Type = "Board";
            gameOne.Players = 5;
            gameOne.Display();

            GameClub gameTwo = new GameClub(2, "Debbie", "Dresco", "Donkey Kong", "Video", 2);
            gameTwo.Display();

        }
    }
}
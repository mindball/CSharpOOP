
namespace PlayersAndMonsters.Core
{
    using Core.Contracts;
    using PlayersAndMonsters.IO.Contracts;

    class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IManagerController manager;

        public Engine(IReader reader, IWriter writer, IManagerController manager)
        {
            this.reader = reader;
            this.writer = writer;
            this.manager = manager;
        }

        public void Run()
        {
            while(true)
            {
                var line = this.reader.ReadLine();

                if (line.Equals("Exit"))
                {
                    break;
                }

                var commandParts = line.Split();
                var command = commandParts[0];

                string message = null;
                switch (command)
                    {
                        case "AddPlayer":
                            message = this.manager.AddPlayer(commandParts[1], commandParts[2]);
                            break;
                        case "AddCard":
                            message = this.manager.AddCard(commandParts[1], commandParts[2]);
                            break;
                        case "AddPlayerCard":
                            message = this.manager.AddPlayerCard(commandParts[1], commandParts[2]);
                            break;
                        case "Fight":
                            message = this.manager.Fight(commandParts[1], commandParts[2]);
                            break;
                    case "Report":
                        message = this.manager.Report();
                        break;
                    }

                this.writer.WriteLine(message);
                }



            }
    }
}

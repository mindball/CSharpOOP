using System;

namespace ExersiceEnumAndAttribute
{
    class StartUp
    {
        static void Main(string[] args)
        {

            //Problem 1, 2
            //string input = Console.ReadLine();
            //string[] inputArg = input.Split();
            //
            //switch (inputArg[1])
            //{
            //    case "Suits":
            //        CardSuits();
            //        break;
            //    case "Ranks":
            //        CardRank();
            //        break;
            //}

            ////Problem 3
            //string[] inputArg = new string[2];
            //for (int i = 0; i < inputArg.Length; i++)
            //{
            //    inputArg[i] = Console.ReadLine();
            //}

            //CardPower(inputArg);

            ////Problem 4
            //string[] inputArg = new string[4];
            //for (int i = 0; i < inputArg.Length; i++)
            //{
            //    inputArg[i] = Console.ReadLine();
            //}

            ////Problem 5
            //CompareCard(inputArg);

            ////Problem 6
            //string input = Console.ReadLine();
            //PrintAttributes(input);

            ////problem 7
            //PrintDeckOfCards();

            CardGame();

        }



        //Problem 1
        public static void CardSuits()
        {
            var cardSuitsCollection = Enum.GetValues(typeof(Suit));
            foreach (var suit in cardSuitsCollection)
            {
                Console.WriteLine($"Ordinal value: {(int)suit}; Name value: {suit}");
            }
        }

        //Problem 2
        public static void CardRank()
        {
            var RankCollection = Enum.GetValues(typeof(Rank));
            foreach (var rank in RankCollection)
            {
                Console.WriteLine($"Ordinal value: {(int)rank}; Name value: {rank}");
            }
        }

        //Problem 3,4
        public static void CardPower(string[] inputArg)
        {

            CardFactory card = new CardFactory();

            Console.WriteLine(card.CreateCard(inputArg[1], inputArg[0]));
        }

        //Problem 5
        public static void CompareCard(string[] inputArg)
        {
            Card cardOne = new CardFactory().CreateCard(inputArg[1], inputArg[0]);
            Card cardTwo = new CardFactory().CreateCard(inputArg[3], inputArg[2]);

            if (cardOne.CompareTo(cardTwo) < 0)
                Console.WriteLine(cardTwo);
            else
                Console.WriteLine(cardOne);

        }

        //Problem 6
        public static void PrintAttributes(string input)
        {
            if (input.Equals("Rank"))
                PrintAttributes(typeof(NewRank));
            else
                PrintAttributes(typeof(NewSuit));

        }

        //Problem 6
        private static void PrintAttributes(Type type)
        {
            var attributes = type.GetCustomAttributes(false);
            Console.WriteLine(attributes[0]);
        }

        //problem 7
        public static void PrintDeckOfCards()
        {
            var suits = Enum.GetValues(typeof(NewSuit));
            foreach (var suit in suits)
            {
                var ranks = Enum.GetValues(typeof(NewRank));
                foreach (var rank in ranks)
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }

        //problem 8

        public static void CardGame()
        {
            string nameOfFirstPlayer = Console.ReadLine();
            string nameOfSecondPlayer = Console.ReadLine();

            Player firstPlayer = new Player(nameOfFirstPlayer);
            Player secondPlayer = new Player(nameOfSecondPlayer);

            int cardCount = 1;

            while(cardCount <= 10)
            {
                string[] cardType = Console.ReadLine().Split();
                try
                {
                    CardFactory card = new CardFactory();
                    Card newCard = card.CreateCard(cardType[2], cardType[0]);

                    if(cardCount < 6)
                    {
                        firstPlayer.AddCard(newCard);
                    }
                    else
                    {
                        secondPlayer.AddCard(newCard);
                    }
                    
                }
                catch (Exception ex)
                {                    
                    Console.WriteLine(ex.Message);
                    continue;
                }

                cardCount++;
            }

            if(firstPlayer.WinningCard.CardPower > 
                secondPlayer.WinningCard.CardPower)
            {
                Console.WriteLine(firstPlayer);
            }
            else
            {
                Console.WriteLine(secondPlayer);
            }
            
        }
    }
}

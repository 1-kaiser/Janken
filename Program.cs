Random random = new Random();

String player;
String comp;
bool again = true;

    while (again)
    {

        player = "";
        comp = "";
        

        while (player == "rock" || player == "paper" || player == "scissor")
        {
            Console.Write("Rock | Paper | Scissor");
            player = Console.ReadLine();
            player = player.ToLower();

            Console.WriteLine(player);
        }

        switch (random.Next(1,4))
        {
            case 1:
            comp = "rock";
            break;

            case 2:
            comp = "paper";
            break;

            case 3:
            comp = "scissor";
            break;
        }

        Console.WriteLine("Player: " + player);
        Console.WriteLine("Computer: " + comp);

        switch (player)
        {
            
            case "rock":
                if (comp == "rock")
                {
                    Console.WriteLine("Draw");
                } else if (comp == "paper")
                {
                    Console.WriteLine("You Lose");
                } else {
                    Console.WriteLine("You Win");
                }
            break;

            case "paper":
                if (comp == "rock")
                {
                    Console.WriteLine("You Win");
                } else if (comp == "paper")
                {
                    Console.WriteLine("Draw");
                } else {
                    Console.WriteLine("You Lose");
                }
            break;

            case "scissor":
                if (comp == "rock")
                {
                    Console.WriteLine("You Lose");
                } else if (comp == "paper")
                {
                    Console.WriteLine("You Win");
                } else {
                    Console.WriteLine("Draw");
                }
            break;
        }

    }


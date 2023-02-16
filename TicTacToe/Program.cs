using BoardLogic;

Board game = new Board();

int userTurn = -1;
int computerTurn = -1;
Random random = new Random();


while (game.whoIsWinner() == 0)
{
    //Don't allow humans to choose occupied square
    while (userTurn == -1 || game.Grid[userTurn] != 0)
    {
        Console.WriteLine("Enter a number from 0-8: ");
        userTurn = int.Parse(Console.ReadLine());
        Console.WriteLine($"You chose {userTurn}");
    }
    game.Grid[userTurn] = 1;

    if (game.isBoardFull())

        break;

    //Dont allow computers to choose invalid square
    while (computerTurn == -1 || game.Grid[computerTurn] != 0)
    {
        computerTurn = random.Next(8);
        Console.WriteLine($"Computer chose {computerTurn}");
    }
    game.Grid[computerTurn] = 2;

    if (game.isBoardFull())

        break;

    printBoard();
    Console.WriteLine("-------------------------");

    //while is done
    Console.WriteLine($"The game is over. {game.whoIsWinner()} is the winner! :)");
}
Console.WriteLine($"Player {game.whoIsWinner()} won the game! :P");


printBoard();


void printBoard()
{
    for (int i = 0; i < 9; i++)
    {
        //Print X or O for each square
        //.: unoccupied
        //X: Player 1
        //O: Player 2

        if (game.Grid[i] == 0)
        {
            Console.Write(".");
        }
        if (game.Grid[i] == 1)
        {
            Console.Write("X");
        }
        if (game.Grid[i] == 2)
        {
            Console.Write("O");
        }

        //Print a new line every 3rd character
        if (i == 2 || i == 5 || i == 8)
        {
            Console.WriteLine();
        }
    }

}




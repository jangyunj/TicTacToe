namespace BoardLogic
{
    public class Board
    {
        public int[] Grid { get; set; }

        public Board()  //Constructor: object of class is created to initialize all class data members
        {
            //Define how big the array is
            Grid = new int[9];

            //Initialize the board by setting all squares to empty
            for (int i = 0; i < 9; i++)
            {
                Grid[i] = 0;
            }

        }

        public bool isBoardFull()
        {
            bool isFull = true;   //Assume board is full. If exception is found, change the value
            for (int i = 0; i < Grid.Length; i++)
            {
                if (Grid[i] == 0)
                {
                    isFull = false;
                }
            }
            return isFull;
        }


        public int whoIsWinner()
        {
            //Return 0 if nobody won. Return the player number if they won.

            //First Row:
            if (Grid[0] == Grid[1] && Grid[1] == Grid[2])
            {
                return Grid[0];
            }

            //Second Row:
            if (Grid[3] == Grid[4] && Grid[4] == Grid[5])
            {
                return Grid[3];
            }

            //Third Row:
            if (Grid[6] == Grid[7] && Grid[7] == Grid[8])
            {
                return Grid[6];
            }

            //First Column:
            if (Grid[0] == Grid[3] && Grid[3] == Grid[6])
            {
                return Grid[0];
            }

            //Second Column:
            if (Grid[1] == Grid[4] && Grid[4] == Grid[7])
            {
                return Grid[1];
            }

            //Third Column:
            if (Grid[2] == Grid[5] && Grid[5] == Grid[8])
            {
                return Grid[2];
            }

            //Diagonal L to R:
            if (Grid[0] == Grid[4] && Grid[4] == Grid[8])
            {
                return Grid[0];
            }

            //Diagonal R to L:
            if (Grid[2] == Grid[4] && Grid[4] == Grid[6])
            {
                return Grid[2];
            }
            return 0;
        }


    }
}

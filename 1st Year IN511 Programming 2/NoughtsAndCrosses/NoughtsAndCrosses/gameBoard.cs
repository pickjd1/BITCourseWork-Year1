using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NoughtsAndCrosses
{
    public class GameBoard
    {
        private const int NROWS = 3;
        private const int NCOLS = 3;
        private const int GAMESQUAREWIDTH = 100;
        private const int GAMESQUAREHEIGHT = 100;

        private GameSquare[,] gameSquares;
        private bool playerX;
    
        public GameBoard(Graphics graphics)
        {
            playerX = true;
            gameSquares = new GameSquare[NCOLS, NROWS];

            int squareLeft;
            int squareTop;
            int squareWidth;
            int squareHeight;

            for (int i = 0; i < NCOLS; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    squareLeft = i * GAMESQUAREWIDTH;
                    squareTop = j * GAMESQUAREHEIGHT;
                    squareWidth = GAMESQUAREWIDTH;
                    squareHeight = GAMESQUAREHEIGHT;

                    gameSquares[i, j] = new GameSquare(graphics, squareLeft, squareTop, squareWidth, squareHeight);
                }
                
            }
        }

        public void SetupNewGame()
        {
            for (int i = 0; i < NCOLS; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    gameSquares[i, j].SetUp();
                }
            }
            playerX = true;
        }

        public void PlayThisSquare(Point location)
        {
            for (int i = 0; i < NCOLS; i++)
            {
                for (int j = 0; j < NROWS; j++)
                {
                    if (gameSquares[i,j].FindActiveSquare(location))
                    {
                        gameSquares[i, j].Play(playerX);
                        playerX = !playerX;
                    }
                }
            }
        }
    }
}

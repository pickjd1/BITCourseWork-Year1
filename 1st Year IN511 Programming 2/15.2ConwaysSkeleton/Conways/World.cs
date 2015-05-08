using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conways
{
    public class World
    {
        private const int NCELLS = 50;
        private const int RANDFILL = 40;

        private Random random;
        private Grid grid;
        private Cell[,] worldCells;
            
        //constructor
        public World(Random random, Grid grid)
        {
            this.random = random;
            this.grid = grid;

            worldCells = new Cell[50, 50];
            // worldCells = new Cell[NCELLS, NCELLS];
 
            for (int i = 0; i < NCELLS; i++)
            {
                for (int j = 0; j < NCELLS; j++ )
                {
                    // fill the worldCells with cells
                }
            }

            //assign neighbours 
            int iLeft, iRight, jTop, jBottom;

            for (int i = 0; i < NCELLS; i++)
            {
                for (int j = 0; j < NCELLS; j++)
                {
                    if (i == 0)
                    {
                        iLeft = (NCELLS-1); 
                    }
                    else
                    {
                        iLeft = i - 1;
                    }

                    if (i == (NCELLS -1))
                    {
                        iRight = 0;
                    }
                    else
                    {
                        iRight = i + 1;
                    }

                    if (j == 0)
                    {
                        jTop = (NCELLS-1);
                    }
                    else
                    {
                        jTop = j - 1;
                    }

                    if (j == (NCELLS  - 1))
                    {
                        jBottom = 0;
                    }
                    else
                    {
                        jBottom = j + 1;
                    }

                    worldCells[i, j].Neighbour(worldCells[iLeft, jTop]);

                    worldCells[i, j].Neighbour(worldCells[iLeft, j]);

                    worldCells[i, j].Neighbour(worldCells[iLeft, jBottom]);

                    worldCells[i, j].Neighbour(worldCells[iRight, jTop]);

                    worldCells[i, j].Neighbour(worldCells[iRight, j]);

                    worldCells[i, j].Neighbour(worldCells[iRight, jBottom]);

                    worldCells[i, j].Neighbour(worldCells[i, jTop]);

                    worldCells[i, j].Neighbour(worldCells[i, jBottom]);
                }
            }
        }

        public void Clear()
        {
            for (int i = 0; i < NCELLS; i++ )
            {
                for (int j = 0; j < NCELLS; j++ )
                {
                    // set all cells to dead
                    // set all cells to be generation 0
                }
            }
        }

        public void Fill()
        {
            // set 40% of cells to be alive
        }

        public void Draw()
        {
            for (int i = 0; i < NCELLS; i++)
            {
                for (int j = 0; j < NCELLS; j++)
                {
                    if (worldCells[i,j].CurrState)
                    {
                        switch (worldCells[i, j].Generation)
                        {
                            case 0:
                                grid.SetCellColour(i, j, Color.Aqua);
                                break;
                            case 1:
                                grid.SetCellColour(i, j, Color.Aqua);
                                break;
                            case 2:
                                grid.SetCellColour(i, j, Color.Teal);
                                break;
                            case 3:
                                grid.SetCellColour(i, j, Color.Blue);
                                break;
                            case 4:
                                grid.SetCellColour(i, j, Color.Navy);
                                break;
                            default:
                                grid.SetCellColour(i, j, Color.Purple);
                                break;
                        }
                    }
                    else
                    {
                        grid.SetCellColour(i, j, Color.White);
                    }
                }
            }
        }

        public void ComputeNextWorldGeneration()
        {
            // tell each cell to calculate whether it will be alive in the next generation
            // tell each cell to update its state
        }
    }
}

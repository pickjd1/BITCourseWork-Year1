using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Conways
{
     public class Cell
    {
        //constants 
        //private int NEIGHBOURS = 8;
        
        //fields
        private bool currState;
        private bool nextState;
        private int nNeighbours;
        private Cell[] neighbours = new Cell[8];
        private int generation;

        public bool CurrState
        {
            get { return currState; }
            set { currState = value; }
        }
        
        public bool NextState
        {
            get { return nextState; }
            set { nextState = value; }
        }

        public int NNeighbours
        {
            get { return nNeighbours; }
            set { nNeighbours = value; }
        }

        public void Neighbour(Cell neighbour)
        {
                nNeighbours += 1;
                neighbours[nNeighbours] = neighbour;
        }

        public int Generation
        {
            get { return generation; }
            set { generation = value; }
        }

        public Cell()
        {
            this.currState = false;
            this.nextState = false;
            this.nNeighbours = -1;
            this.generation = 0;
        }

        public void ComputeNextCellGeneration()
        {
            // count number of live neighbours

            // implement the rules
        }

        public void UpdateNextCellGeneration()
        {
            // update currState from nextState;           
            // reset generation
        }
    }
}

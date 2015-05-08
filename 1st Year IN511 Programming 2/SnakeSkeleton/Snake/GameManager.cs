using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace SnakeGame
{
    public class GameManager
    {
        private Grid grid;
        private Random random;
        private Snake snake;
        private Frog frog;

        public GameManager(Grid grid, Random random)
        {
            this.grid = grid;
            this.random = random;
            snake = new Snake("snakeSkin.bmp", "snakeEyes.bmp", grid);
            frog = new Frog("frog.bmp", grid);
        }

        public void StartNewGame()
        {
            snake = null;
            frog = null;

            grid.Draw();

            snake = new Snake("snakeSkin.bmp", "snakeEyes.bmp", grid);
            frog = new Frog("frog.bmp", grid);
        }
        
        public ErrorMessage PlayGame()
        {
            if (!frog.Alive)
            {
                frog.Position = FindFreeCell();
                frog.Alive = true;
            }

            grid.Draw();
            frog.Draw();
            snake.Draw();
            
            snake.Move();

            if (snake.HitSelf())
            {
                return ErrorMessage.snakeHitSelf;
            }

            if (snake.HitWall())
            {
                return ErrorMessage.snakeHitWall;
            }

            if (snake.EatenFrog(frog.Position))
            {
                frog.Alive = false;
                snake.Grow();
                return ErrorMessage.snakeEatenFrog;
            }
            else
            {
                return ErrorMessage.noError;
            }
        }

        private Point FindFreeCell()
        {
            Point target = Point.Empty;

            while (target == Point.Empty)
            {
                int i = random.Next(30);
                int j = random.Next(30);

                if (grid.Rows[i].Cells[j].Value == grid.Blank)
                {
                    target = new Point(i, j);
                }
            }

            return target;
        }

        public void SetSnakeDirection(Direction direction)
        {
            snake.Direction = direction;
        }
  }
}

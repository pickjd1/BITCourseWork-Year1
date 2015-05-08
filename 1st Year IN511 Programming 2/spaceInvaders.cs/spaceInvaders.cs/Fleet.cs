using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spaceInvaders.cs
{
    public class GameManager
    {
        private BombFleet bombFleet;
        private MissileFleet missileFleet;
        private EnemyFleet enemyFleet;
        private MotherShip motherShip;
    
        public GameManager()
        {
            motherShip = new MotherShip(true, 8, new Point(10,100), "mothership (2).bmp", graphics);
        }
    }
}

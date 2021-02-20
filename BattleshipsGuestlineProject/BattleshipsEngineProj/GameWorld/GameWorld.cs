using BattleshipsEngineProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsEngineProj.GameWorld
{
    public class GameWorld : IGameWorld
    {

        /// <summary>
        /// CONSTRUCTOR for the GameWorld Class
        /// </summary>
        public GameWorld() 
        {
            // 
        }


        /// <summary>
        /// METHOD: InitialiseGame
        /// </summary>
        public void InitialiseGame()
        {
            /*  Initialise the game
            *   I.E. setup the player, boats and board 
            */
        }

        /// <summary>
        /// METHOD: InitialiseWorld
        /// </summary>
        public void InitialiseWorld()
        {
            /*  Initialise the world 
             *  Setup the board 
             */


            // Use 2 * (10*10)2D Arrays to create two tile grids. 1. For the player
            // to place their ships on
            // 2. For the player to visibly see where they have fired shots to, what was
            // a miss and what was a hit

            

        }

        private int[,] MakeGrid() 
        {

            return new int[1,1];
        }
    }
}

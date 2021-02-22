using BattleshipsEngineProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipsEngineProj.GameWorld.Grid;

namespace BattleshipsEngineProj.GameWorld
{
    public class GameWorld : IGameWorld
    {
        // VARIABLE, String array called _intToStringArr, will store the first 10 letters of the alphabet
        // (10x10 grid requires 10 alphabetic letters) 
        private String[] _intToStringArr;


        /*
         * 
         * TO REFACTOR: Make an IGrid and Grid class, each grid will have two ITile 2D
         * arrays inside, so upon making 1 blank ITile 2D array the Grid classes can take that 
         * and copy that as two blank 2D arrays -> reduces redundant number of method calls
         * to MakeGrid method
         */
        // VARIABLE of type ITile as a 2D array, this is the player 1s grid
        private ITile[,] _p1Grid;
        // VARIABLE of type ITile as a 2D array, this is player 2s (AI) grid 
        private ITile[,] _p2Grid;
        // VARIABLE fot type ITile as 2D array, this is player 1s shot grid
        private ITile[,] _p1ShotGrid;

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


            // SET _intToStringArr variable to the first 10 letters of the alphabet
            // could have done a single string and converted to char array in the method call
            // but went with this instead
            _intToStringArr = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };

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

        private ITile[,] MakeGrid() 
        {

            ITile[,] grid = new ITile[10, 10];

            // FOR LOOP for the X acis
            for (int x = 0; x < 10; x++)
            {
                // FOR LOOP for the Y axis 
                for (int y = 0; y < 10; y++)
                {
                    // INITIALISE a new tile at grid position X and Y, pass in 
                    // the string found at y - 1 in the in to string array and then the x value
                    grid[x, y] = new Tile(_intToStringArr[y - 1] + x);

                }
            }

            return grid;
        }
    }
}

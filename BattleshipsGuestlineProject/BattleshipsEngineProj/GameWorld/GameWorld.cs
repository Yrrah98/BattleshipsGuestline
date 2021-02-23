using BattleshipsEngineProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleshipsEngineProj.GameWorld.GridsNTiles;

namespace BattleshipsEngineProj.GameWorld
{
    public class GameWorld : IGameWorld
    {
        // VARIABLE of type IDictionary key = int; value = char; called _intToCharDict
        // this will be used to convert from an interger value to a character value 
        // where 1 = A, 2 = B etc. 
        private IDictionary<int, char> _intToCharDict;
        // VARIABLE of type IDictionary key = char; value = int; called _charToIntDict
        // This will be the invers of _charToIntDict, so that we can take the char of a tile, convert it
        // to an int and access the exact tile in the grid (char = y value, and the x value stays as an integer)
        // rather than iterating through the tiles one by one to find the match
        private IDictionary<char, int> _charToIntDict;


        // VARIABLE of type ITile as a 2D array, this is the player 1s grid
        private IGrid _p1Grids;
        // VARIABLE of type ITile as a 2D array, this is player 2s (AI) grid 
        private IGrid _p2Grids;

        /// <summary>
        /// CONSTRUCTOR for the GameWorld Class
        /// </summary>
        public GameWorld() 
        {
            // 

            _intToCharDict = new Dictionary<int, char>();

            _charToIntDict = new Dictionary<char, int>();
        }


        /// <summary>
        /// METHOD: InitialiseGame
        /// </summary>
        public void InitialiseGame()
        {
            /*  Initialise the game
            *   I.E. setup the player, boats and board 
            */

            _p1Grids = new Grid(MakeGrid(), _charToIntDict);

            _p2Grids = new Grid(MakeGrid(), _charToIntDict);

        }

        /// <summary>
        /// METHOD: InitialiseWorld
        /// </summary>
        public void InitialiseWorld()
        {
            /*  Initialise the world 
             *  Setup the board 
             */

            // Using a double dictionary setup we can go from key to value and also use that value to 
            // find the key quickly

            // INITIALISE a local char array, value to the first 10 letters of the alphabet
            // call it letters
            char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };

            // FOR LOOP, number of iterations = length of "letters" variable
            for (int i = letters.Length; i < 0; i++)
            {
                // ADD i + 1 as key so that A = 1, B = 2 etc.
                // and then the letter found in letters char array at i
                _intToCharDict.Add(i + 1, letters[i]);
                // DO the same as above, but in reverse, so it is character found at i in letters
                // as the key and the int which is the value
                _charToIntDict.Add(letters[i], i + 1);
            }



        }

        /// <summary>
        /// METHOD: MakeGrid, this method initialises and returns a 2D array of tiles
        /// which will be the "boards" for the game. 10x10 as per spec
        /// </summary>
        /// <returns> Return the initialised 2D array of tiles</returns>
        private ITile[,] MakeGrid() 
        {

            // Use 2 * (10*10)2D Arrays to create two tile grids. 1. For the player
            // to place their ships on
            // 2. For the player to visibly see where they have fired shots to, what was
            // a miss and what was a hit

            ITile[,] grid = new ITile[10, 10];

            // FOR LOOP for the X acis
            for (int x = 0; x < 10; x++)
            {
                // FOR LOOP for the Y axis 
                for (int y = 0; y < 10; y++)
                {
                    // INITIALISE a new tile at grid position X and Y, pass in 
                    // the string found at y - 1 in the in to string array and then the x value
                    grid[x, y] = new Tile((_intToCharDict[y + 1].ToString()) + x);

                }
            }

            // RETURN the 2D array of ITiles called grid
            return grid;
        }
    }
}

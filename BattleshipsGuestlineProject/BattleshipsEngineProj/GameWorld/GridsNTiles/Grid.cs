using BattleshipsEngineProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// AUTHOR: Harry Jones
/// DATE: 22/02/2021
/// VERSION: v0.1
/// PURPOSE: The grid class will be used to manage both of the players grids
/// </summary>
namespace BattleshipsEngineProj.GameWorld.GridsNTiles
{
    public class Grid : IGrid
    {
        // VARIABLE of type ITile as a 2D array called _playerShipGrid, will be the grid to keep track of 
        // the players own ships
        private ITile[,] _playerShipGrid;
        // VARIABLE of type ITile as a 2D array called _playerShotsGrid, will be the grid to keep track of
        // the players hits and misses
        private ITile[,] _playerShotsGrid;

        private IDictionary<char, int> _charToInt;

        /// <summary>
        /// CONSTRUCTOR for the Grid class
        /// </summary>
        /// <param name="tileArray"> Tile array which will be the basis of the two grids the player has </param>
        /// <param name="charToInt"> charToInt dictionary, used to find the integer in the 2D array from
        /// the character </param>
        public Grid(ITile[,] tileArray, IDictionary<char, int> charToInt) 
        {
            // SET the _playerShipGrid value to the value of Tile 2D array passed into
            // the constructor
            _playerShipGrid = tileArray;
            // SET the _playerShotsGrid value to the value of Tile 2D array passed into
            // the constructor
            _playerShotsGrid = tileArray;
            // SET the charToInt dictionary to the charToInt dictionary passed in to the constructor
            _charToInt = charToInt;
        }

        /// <summary>
        /// METHOD: ShotfiredAt
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool ShotFiredAt(String position) 
        {

            // INITIALISE a local char variable to store 
            // the first value of the string "position" passed in
            // as this will be the Alphabetical letter which is used for the Y axis
            char y = position.ToCharArray()[0];
            
            // Initialise a string called split, this will store the numeric value
            // after the alphabetical value in here
            string split = "";

            // FOR -> num. of iterations = length of position parameter as a char array
            // We'll start the for loop at one after the first character (the letter)
            for (int i = 1; i < position.ToCharArray().Length; i++) 
            {
                // ADD the character to the split string 
                split += position.ToCharArray()[i];

                // doing this ensures whether we have A1 or B10, we will
                // always get the both digits
            }

            // INITIALISE a local int variable to store 
            int x; 

            // CALL to TryParse [struct] method of int 
            // to see if the split string is an integer, if it is the value of
            // x is changed to the value, if not, it will remain as 0 (default) 
            int.TryParse(split, out x);

            // IF the value of x is 0 at this point, then we know 
            // something has gone wrong somewhere

            // TO CHANGE - Access tile at the position passed in
            // and call the ShootTile method on the tile
            // RETURN the result of the check
            _playerShipGrid[_charToInt[y], x].ShootTile();


            return false;
        }
    }
}

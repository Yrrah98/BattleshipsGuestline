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
namespace BattleshipsEngineProj.GameWorld.Grid
{
    public class Grid
    {
        // VARIABLE of type ITile as a 2D array called _playerShipGrid, will be the grid to keep track of 
        // the players own ships
        private ITile[,] _playerShipGrid;
        // VARIABLE of type ITile as a 2D array called _playerShotsGrid, will be the grid to keep track of
        // the players hits and misses
        private ITile[,] _playerShotsGrid;

        /// <summary>
        /// CONSTRUCTOR for the Grid class
        /// </summary>
        public Grid(ITile[,] tileArray) 
        {
            // SET the _playerShipGrid value to the value of Tile 2D array passed into
            // the constructor
            _playerShipGrid = tileArray;
            // SET the _playerShotsGrid value to the value of Tile 2D array passed into
            // the constructor
            _playerShotsGrid = tileArray;
        }

        /// <summary>
        /// METHOD: ShotfiredAt
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public bool ShotFiredAt(String position) 
        {

            // TO CHANGE - Access tile at the position passed in
            // and call the ShootTile method on the tile
            // RETURN the result of the check
            return false;
        }
    }
}

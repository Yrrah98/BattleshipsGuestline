using BattleshipsEngineProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// AUTHOR: Harry Jones
/// DATE: 21/02/2021
/// VERSION: v0.1
/// PURPOSE: This is a single tile on the board of the battleships game 
/// </summary>
namespace BattleshipsEngineProj.GameWorld.GridsNTiles
{
    public class Tile : ITile
    {

        /// <summary>
        /// TRUE = Shot at. FALSE = Not shot at.
        /// </summary>
        public bool FiredUpon { get; private set; }
        // VARIABLE of type IEntity called _battleShip, this will be the 
        // the battleship a player places in this tile
        private IEntity _battleShip;
        // VARIABLE readonly, type of String called ID. Will contain
        // the tiles position/ID e.g. "A5" or "C6" etc.
        // readonly as the data will not change
        public readonly String _ID;


        /// <summary>
        /// CONSTRUCTOR for Tile class, the tiles ID/Position is passed in as a String parameter
        /// </summary>
        /// <param name="ID">Position/ID of tile</param>
        public Tile(String ID) 
        {
            // INITIALISE
            FiredUpon = false;
            // SET the _ID variable of this class to the value of the ID
            // passed into the constructor, this allows the readonly variable 
            // to have its value set.
            _ID = ID;
        }


        /// <summary>
        /// METHOD: ShootTile, run query to see if player has hit or missed
        /// </summary>
        public void ShootTile()
        {
            

            // PSEUDO-CODE:
            // Whether it is a hit or miss, change the FiredUpon flag to true.
            FiredUpon = true;

            // IF there is a ship here, the player has hit 
            if (_battleShip != null)
            {
                // NOTIFY the player they have shot successfully
            }
            // ELSE if there is no ship, they have missed
            else 
            {
                // No hit, tell the player they have missed
            }


        }

        /// <summary>
        /// METHOD: PlaceShip, assosciates the ship passed in with this tile grid
        /// therefor a shot at this tile grid is a shot at the ship in it 
        /// </summary>
        /// <param name="entity">The ship being placed</param>
        public void PlaceShip(IEntity entity) 
        {
            // SET the _battleShip variable to the 
            _battleShip = entity;
        }
    }
}

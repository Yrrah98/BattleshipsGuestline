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
namespace BattleshipsEngineProj.GameWorld.Tile
{
    public class Tile : ITile
    {

        /// <summary>
        /// TRUE = Shot at. FALSE = Not shot at.
        /// </summary>
        public bool FiredUpon { get; private set; }

        private IEntity _battleShip;


        /// <summary>
        /// CONSTRUCTOR for Tile class
        /// </summary>
        public Tile() 
        {
            // INITIALISE
            FiredUpon = false;
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
            
            // THEN notify the player as such

            // ELSE if there is no ship then they player has missed, notify them of this
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

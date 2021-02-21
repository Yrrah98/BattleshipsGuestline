using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// AUTHOR: Harry Jones
/// DATE: 21/02/2021
/// VERSION: v0.1
/// PURPOSE: This is the interface for an ITile class, which will be the basis
/// of the "game world". Will say what ship it contains and whether it has been fired at or not
/// and whether it is occupied. 
/// </summary>
namespace BattleshipsEngineProj.Interfaces
{
    public interface ITile
    {
        /// <summary>
        /// PROPERTY which will setup a flag to say whether the 
        /// spot has been fired at or not TRUE = Fired at
        /// FALSE = No shots fired at this spot
        /// </summary>
        bool FiredUpon { get; }

        /// <summary>
        /// METHOD: ShootTile, this command will be called by a player
        /// and will "Shoot the tile" triggering a query to determine if the shot was 
        /// a hit or miss
        /// The player will be notified if they make a hit or not, this will also 
        /// trigger some kind of affect with visuals to show the spot 
        /// has been shot at and missed
        /// </summary>
        void ShootTile();

        /// <summary>
        /// METHOD: PlaceShip, this method will associate a ship with this tile.
        /// </summary>
        /// <param name="ship"></param>
        void PlaceShip(IEntity ship);
    }
}

using BattleshipsEngineProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Harry Jones
/// VERSION: v0.1
/// PURPOSE: This is the player class, this will contain accessors for the ships the player
/// has and the number of sunk ships
/// </summary>
namespace BattleshipsEngineProj
{
    public class Player : IPlayer
    {
        // VARIABLE a List of the Active ships which the player has which haven't been sunk
        private IList<IEntity> _activeShips;
        /// <summary>
        /// PROPERTY: ActiveShips
        /// </summary>
        public IList<IEntity> ActiveShips { get { return _activeShips; } }

        // VARIABLE to keep track of the number of ships which have been sunk
        private int _sunkShipsCount;
        /// <summary>
        /// PROPERTY: SunkShipsCount
        /// </summary>
        public int SunkShipsCount { get { return _sunkShipsCount; }}

        /// <summary>
        /// CONSTRUCTOR for the Player class
        /// </summary>
        public Player() 
        {
            // SET the value of ships to sink to the number of active ships
            // the player has
        }


        public bool HitOrMiss(int[,] gridPos) 
        {
            // TO CHANGE when more code is added
            return false;
        }
    }
}

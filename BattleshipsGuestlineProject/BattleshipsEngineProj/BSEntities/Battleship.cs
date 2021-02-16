using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Harry Jones
/// VERSION: v0.1
/// DATE: 15/02/2021
/// PURPOSE: This is the players battleship. 5 blocks in length and each player only has 1 
/// </summary>
namespace BattleshipsEngineProj.BSEntities
{
    public class Battleship : BSEntity
    {
        /// <summary>
        /// CONSTRUCTOR for Battleship class
        /// </summary>
        public Battleship() 
        {
            ShipLength = 5;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Harry Jones
/// DATE: 22/02/2021
/// VERSION: v0.1
/// PURPOSE: This will act as a container for each players grids
/// they will have a grid to place ships on and a grid to where 
/// hits and misses will appear
/// </summary>
namespace BattleshipsEngineProj.Interfaces
{
    public interface IGrid
    {
        /// <summary>
        /// METHOD: ShotFiredAt, will be a public method which the other player will call to 
        /// take a shot at this players grid
        /// </summary>
        /// <param name="position">the position the other player is shooting at</param>
        /// <returns> Returns hit or miss -> Hit = true; Miss = false </returns>
        bool ShotFiredAt(String position);

    }
}

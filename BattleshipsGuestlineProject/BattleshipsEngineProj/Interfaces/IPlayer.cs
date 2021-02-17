using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BattleshipsEngineProj.Interfaces
{
    public interface IPlayer
    {
        // PROPERTY: ActiveShips to access the active ships of the player
        IList<IEntity> ActiveShips { get; }
        // PROPERTY: SunkShips to access the number of inactive ships
        // IF 3 or equal to the number of the Active ships at the start of the game
        // then the player with these ships has lost
        int SunkShipsCount { get; }

        /// <summary>
        /// METHOD: Public method which a player will ask the other when they have fired a shot
        /// tells them whether they have hit or missed on the location which they will pass through 
        /// </summary>
        /// <param name="gridPos">Grid position they are firing at</param>
        /// <returns>Hit = true and Miss = false</returns>
        bool HitOrMiss(int[,] gridPos);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsEngineProj.Interfaces
{
    public interface IGameWorld
    {
        /// <summary>
        /// METHOD: InitialiseWorld, this method will set the world up ready
        /// for battleships to be placed, shots to be fired and ships to be sunk. 
        /// </summary>
        void InitialiseWorld();

        /// <summary>
        /// METHOD: InitialiseGame, this method will set the players up ready to play when
        /// they choose to start playing. 
        /// </summary>
        void InitialiseGame();
    }
}

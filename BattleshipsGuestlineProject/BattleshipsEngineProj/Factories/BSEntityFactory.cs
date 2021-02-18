using BattleshipsEngineProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Harry Jones
/// VERSION: v0.1
/// PURPOSE: This is a factory which will use the IEntityFactory interface,
/// class will be used to make entitis for the game
/// </summary>
namespace BattleshipsEngineProj.Factories
{
    public class BSEntityFactory : IEntityFactory
    {

        /// <summary>
        /// CONSTRUCTOR for BSEntityFactory
        /// </summary>
        public BSEntityFactory() 
        {
            // DO NOTHING
        }

        /// <summary>
        /// METHOD: CreateEntity, concrete implementation, simply returns a new type of T
        /// upon method call
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IEntity CreateEntity<T>() where T : IEntity, new()
        {
            return new T();
        }
    }
}

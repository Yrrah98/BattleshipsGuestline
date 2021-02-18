using BattleshipsEngineProj.BSEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Harry Jones
/// VERSION: v0.1
/// PURPOSE: This is the interface for the BattleShip Entity Factory, were the game to be expanded to involve other entities and offer
/// graphics/other entities, it would probably be better to include an abstract factory
/// </summary>
namespace BattleshipsEngineProj.Interfaces
{
    public interface IEntityFactory
    {
        /// <summary>
        /// METHOD: CreateEntity, method to create an entity of the desired type. Must be of type
        /// IEntity and also new. 
        /// </summary>
        /// <typeparam name="T"> Type of entity </typeparam>
        /// <returns> and entity of type IEntity</returns>
        IEntity CreateEntity<T>() where T : IEntity, new();

    }
}

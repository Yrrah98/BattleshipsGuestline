using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR: Harry Jones
/// VERSION: v0.1
/// DATE: 15/02/2021
/// PURPOSE: Provides the base interface for entities of the game, opting not to over
/// engineer this project, I will be going with an inheritance based structure rather than
/// say a component based structure. 
/// </summary>
namespace BattleshipsEngineProj.Interfaces
{
    /// <summary>
    /// ENUM: CardinalOrientation, can be returned as an int
    /// This gives north, east, south and west a numeric value which will alter the 
    /// the direction the battleships face. They can only face north, east, south and west. 
    /// </summary>
    public enum CardinalOrientation: int
    {
        North = 0,
        East = 90,
        South = 180,
        West = 270
    }
    /// <summary>
    /// Base interface for all Battleship game entities, though will be only 2 different types of entities. 
    /// </summary>
    public interface IEntity
    {
        // PROPERTY: _entityID, contains the entities ID and only allows it to 
        // be set once. 
        // Monogame Framework doesn't use .NET Framework 5.0 yet,
        // so I couldn't use C# 9.0 "init" property accessor
        String EntityID { get; set; }

        Vector2 Position { get; set; }

        CardinalOrientation Orientation { get; set; }
        /// <summary>
        /// METHOD: InitialiseEntity, a method which is used to pass initialisation data into the entity
        /// e.g. name and position
        /// </summary>
        /// <param name="id"> The ID of the entity</param>
        void InitialiseEntity(String id, int x, int y, CardinalOrientation orientation);
    }
}

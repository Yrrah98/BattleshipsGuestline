using BattleshipsEngineProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

/// <summary>
/// AUTHOR: Harry Jones
/// VERSION: v0.1
/// DATE: 15/02/2021
/// PURPOSE: Is the base of the entity hierarchy of the game.
/// </summary>
namespace BattleshipsEngineProj.BSEntities
{
    public class BSEntity : IEntity
    {
        // VARIABLE of type String, contains the entities ID, set to protected and called _entityID
        protected String _entityID;
        // PROPERTY of type String called EntityID for protected variable _entityID
        // only allow the value to be set if the ID of the entity is empty or null
        public String EntityID { get { return _entityID; } set { if (String.IsNullOrWhiteSpace(_entityID) || String.IsNullOrEmpty(_entityID)) _entityID = value; } }
        // VARIABLE of type Vector2 (from XNA Framework) call _position, used to store x and y co-ordinates.
        protected Vector2 _position;
        // PROPERTY of type Vector2 called Position for protected variable _position, only allow the value of the 
        // position to be set if it has not already been set. 
        public Vector2 Position { get { return _position; } set { if (_position == null) _position = value; } }
        // VAIRABLE of type CardinalOrientation called _orientation, stores the orientation of the vessel
        protected CardinalOrientation _orientation;
        // VARIABLE of type bool, allows a the orientation of the vessel to be set only once. 
        protected bool _orientationSet; 
        // PROPERTY of type CardinalOrientation called Orientation returns and sets _orientation. Only
        // set _orientation value if _orientationSet returns false;
        public CardinalOrientation Orientation
        {
            get { return _orientation; }
            set { if (_orientationSet == false) { _orientation = value; _orientationSet = true; } }
        }

        /// <summary>
        /// CONSTRUCTOR for Base battleship entity classes
        /// </summary>
        public BSEntity()
        {
            // INITIALISE to false, this will
            _orientationSet = false;
        }

        public void InitialiseEntity(String id, int x, int y, CardinalOrientation orientation) 
        {
            // SET the _entityID using the property EntityID
            EntityID = id;
            // Declare local variable of type vector pass in the x and y to the x and y of
            // the vector class
            var vector = new Vector2(x, y);
            // SET the position of the entity using the Position property. 
            Position = vector;
            // SET the orientation of the entity using the Orientation property
            Orientation = orientation;
        }
    }
}

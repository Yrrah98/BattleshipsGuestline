using BattleshipsEngineProj.BSEntities;
using BattleshipsEngineProj.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsEngineProj
{
    public class Class1
    {

        public Class1()
        {
            IEntity entity = new BSEntity();

            entity.EntityID = "DestroyerP1";

            entity.Orientation = CardinalOrientation.North;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipsEngineProj.Interfaces
{
    public interface IPlayer
    {
        IList<IEntity> ActiveShips { get; set; }

        IList<IEntity> SunkShips { get; set; }

    }
}

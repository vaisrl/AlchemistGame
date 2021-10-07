using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.PotBehaviours
{
    public interface IPotBehaviour
    {
        void Enter();
        void Exit();
        void Update();
    }
}

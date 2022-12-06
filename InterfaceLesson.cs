using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLesson
{
    class InterfaceLesson : IBreath, ISecondInterface
    {
        public void CanBreath()
        {
            throw new NotImplementedException();
        }

        public void CanWalk()
        {
            throw new NotImplementedException();
        }
    }

}

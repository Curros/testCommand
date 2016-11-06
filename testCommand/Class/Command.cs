using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCommand.Class
{
    abstract class ACommand
    {
        protected IReciever reciever_ = null;

        public ACommand(IReciever reciever)
        {
            reciever_ = reciever;
        }

        public abstract int Execute();
    }
}

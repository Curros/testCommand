using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCommand.Class
{
    class AddCommand : ACommand
    {
        public AddCommand(IReciever reciever)
            : base(reciever)
        {

        }
        public override int Execute()
        {
            reciever_.SetAction(ACTIO_LIST.ADD);
            //return reciever_.GetResult();
            return ((Calculator)reciever_).x + ((Calculator)reciever_).y;
        }
    }

    class SubtractCommand : ACommand
    {
        public SubtractCommand(IReciever reciever)
            : base(reciever)
        {

        }
        public override int Execute()
        {
            reciever_.SetAction(ACTIO_LIST.SUBTRACT);
            //return reciever_.GetResult();
            return ((Calculator)reciever_).x - ((Calculator)reciever_).y;
        }
    }

    class MultiplyCommand : ACommand
    {
        public MultiplyCommand(IReciever reciever)
            : base(reciever)
        {

        }
        public override int Execute()
        {
            reciever_.SetAction(ACTIO_LIST.MULTIPLY);
            //return reciever_.GetResult();
            return ((Calculator)reciever_).x * ((Calculator)reciever_).y;
        }
    }

    class DividerCommand : ACommand
    {
        public DividerCommand(IReciever reciever)
            : base(reciever)
        {

        }
        public override int Execute()
        {
            reciever_.SetAction(ACTIO_LIST.DIVIDE);
            //return reciever_.GetResult();
            return ((Calculator)reciever_).x / ((Calculator)reciever_).y;
        }
    }
}

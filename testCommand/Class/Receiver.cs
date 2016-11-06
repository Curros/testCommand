using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCommand.Class
{
    //This is a helper type created to decide inside reciever
    enum ACTIO_LIST
    {
        ADD,
        SUBTRACT,
        MULTIPLY,
        DIVIDE
    }

    //Interface
    interface IReciever
    {
        void SetAction(ACTIO_LIST action);
        int GetResult();
    }

    //Operations of the Actions
    class Calculator : IReciever
    {
        int x_;
        int y_;

        ACTIO_LIST currentAction;

        public Calculator(int x, int y)
        {
            x_ = x;
            y_ = y;
        }

        #region IReciever Members

        public void SetAction(ACTIO_LIST action)
        {
            currentAction = action;
        }

        public int GetResult()
        {
            int result;

            if (currentAction == ACTIO_LIST.ADD)
            {
                result = x_ + y_;

            }
            else if (currentAction == ACTIO_LIST.MULTIPLY)
            {
                result = x_ * y_;
            }
            else if (currentAction == ACTIO_LIST.SUBTRACT)
            {
                result = x_ - y_;
            }
            else {
                result = x_ / y_;
            }

            return result;
        }

        #endregion
    }

}

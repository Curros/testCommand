using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testCommand.Class
{
    //This is a helper type created to decide inside receiver
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
        private int x_;
        private int y_;

        public int x {
            get { return this.x_; }
            set { this.x_ = x; }
        }

        public int y
        {
            get { return this.y_; }
            set { this.y_ = y; }
        }

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
            int result = 0;

            //if (currentAction == ACTIO_LIST.ADD)
            //{
            //    result = x_ + y_;
            //}
            //else if (currentAction == ACTIO_LIST.SUBTRACT)
            //{
            //    result = x_ - y_;
            //} else if (currentAction == ACTIO_LIST.MULTIPLY)
            //{
            //    result = x_ * y_;
            //}
            //else {
            //    result = x_ / y_;
            //}

            return result;
        }

        #endregion
    }

}

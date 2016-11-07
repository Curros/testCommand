using System;
using System.Windows.Forms;
using testCommand.Class;

namespace testCommand.UC
{
    public partial class UserControl1 : UserControl, IMessageFilter
    {

        IReciever calculator = null;
        ACommand command = null;
        AddCommand addCmd = null;
        SubtractCommand subCmd = null;
        MultiplyCommand mulCmd = null;
        DividerCommand divCmd = null;

        enum WMMessages
        {
            //left mouse up
            WM_LBUTTONUP        = 0x0202,
            //left mouse down
            WM_LBUTTONDOWN      = 0x0201,
            //middle mouse up
            WM_MBUTTONUP        = 0x0208,
            //right mouse up
            WM_RBUTTONUP        = 0x0205,
            //right mouse Down
            WM_RBUTTONDOWN      = 0x0204,
            //Left mouse double Click
            WM_LBUTTONDBLCLK    = 0x0203

        }


        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Application.AddMessageFilter(this);

            calculator = new Calculator(20, 10);

            addCmd = new AddCommand(calculator);
            subCmd = new SubtractCommand(calculator);
            mulCmd = new MultiplyCommand(calculator);
            divCmd = new DividerCommand(calculator);
        }

        /// <summary>
        /// Gets the actions//messages performed in the control.
        /// This Filter is always runing, be carefull with any loops.
        /// </summary>
        /// <param name="m"></param>
        /// <returns>false</returns>
        /// <remarks>Check all the Message types http://www.pinvoke.net/default.aspx/Constants.WM </remarks>
        public bool PreFilterMessage(ref Message m)
        {
            Control sender = Control.FromHandle(m.HWnd);

            switch (m.Msg)
            {
                case (int)WMMessages.WM_LBUTTONDBLCLK:
                    //After double click, Up is executed.
                    lblEvent.Text = "Left Mouse Double Click";
                    break;
                case (int)WMMessages.WM_LBUTTONDOWN:
                    lblEvent.Text = "Left Mouse Down";
                    break;
                case (int)WMMessages.WM_RBUTTONDOWN:
                    lblEvent.Text = "Rigth Mouse Down";
                    break;
                case (int)WMMessages.WM_RBUTTONUP:
                    lblEvent.Text = "Rigth Mouse Up";
                    break;
                default:
                    //This is always runing, be carefull.
                    break;
            }

            return false; // true to discard the message
        }

        private void radioAdd_CheckedChanged(object sender, EventArgs e)
        {
            //dynamic controltype = this.groupBox1;
            //var events = Type.ReflectionOnlyGetType(controltype.AssemblyQualifiedName, false, true).GetEvents();

            if (radioAdd.Checked == true)
            {
                command = addCmd;
            }
            else if (radioSub.Checked == true)
            {
                command = subCmd;
            }
            else if (radioMultiply.Checked == true)
            {
                command = mulCmd;
            }
            else if (radioDiv.Checked)
            {
                command = divCmd;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Total: " + command.Execute().ToString();
        }
    }
}

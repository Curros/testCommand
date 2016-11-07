using System;
using System.Windows.Forms;
using testCommand.Class;

namespace testCommand.UC
{
    public partial class UserControl1 : UserControl, IMessageFilter
    {

        #region Properties
        IReciever calculator = null;
        ACommand command = null;
        AddCommand addCmd = null;
        SubtractCommand subCmd = null;
        MultiplyCommand mulCmd = null;
        DividerCommand divCmd = null;

        /// <summary>
        /// All the actions registered.
        /// </summary>
        enum WMMessages
        {
            //left mouse up
            WM_LBUTTONUP = 0x0202,
            //left mouse down
            WM_LBUTTONDOWN = 0x0201,
            //middle mouse up
            WM_MBUTTONUP = 0x0208,
            //right mouse up
            WM_RBUTTONUP = 0x0205,
            //right mouse Down
            WM_RBUTTONDOWN = 0x0204,
            //Left mouse double Click
            WM_LBUTTONDBLCLK = 0x0203,
            //Sent to a window when its frame must be painted.
            WM_PAINT = 0x0F,
            //Sent to the parent window of an owner-drawn button, combo box, list box,
            //or menu when a visual aspect of the button, combo box, list box, or menu has changed.
            WM_DRAWITEM = 0x02B
        } 
        #endregion

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Application.AddMessageFilter(this); //Function to check the events.

            calculator = new Calculator(20, 10);

            addCmd = new AddCommand(calculator);
            subCmd = new SubtractCommand(calculator);
            mulCmd = new MultiplyCommand(calculator);
            divCmd = new DividerCommand(calculator);
        }

        /// <summary>
        /// Gets the actions/messages performed in the control.
        /// This Filter is always running, be careful with any loops.
        /// </summary>
        /// <param name="m"></param>
        /// <returns>false</returns>
        /// <remarks>Check all the Message types http://www.pinvoke.net/default.aspx/Constants.WM </remarks>
        public bool PreFilterMessage(ref Message m)
        {
            Control sender = Control.FromHandle(m.HWnd);

            if (sender != null)
            {
                var controlName = (sender.GetType().GetProperty("Name") != null) ? sender.Name : null;

                switch (m.Msg)
                {
                    case (int)WMMessages.WM_LBUTTONDBLCLK:
                        //After double click, Up is executed.
                        lblEvent.Text = "Left Mouse Double Click";
                        break;
                    case (int)WMMessages.WM_LBUTTONDOWN:
                        lblEvent.Text = "Left Mouse Down";
                        break;
                    case (int)WMMessages.WM_LBUTTONUP:
                        //lblEvent.Text = "Left Mouse Down";

                        //Check the type of object that rise this event.
                        if (sender is RadioButton)
                            radioCheckedChanged(sender);
                        else if (sender is Button)
                            button1_Click(sender, new EventArgs());

                        break;
                    case (int)WMMessages.WM_RBUTTONDOWN:
                        lblEvent.Text = "Right Mouse Down";
                        break;
                    case (int)WMMessages.WM_RBUTTONUP:
                        lblEvent.Text = "Right Mouse Up";
                        break;
                    case (int)WMMessages.WM_DRAWITEM:
                        //This is always running, be careful.
                        break;
                    case (int)WMMessages.WM_PAINT:
                        //This is always running, be careful.
                        break;
                    default:
                        //This is always running, be careful.
                        break;
                } 
            }

            return false; // true to discard the message
        }

        /// <summary>
        /// Add different commands depending on the action to perform.
        /// </summary>
        /// <param name="sender"></param>
        private void radioCheckedChanged(object sender)
        {
            //dynamic controltype = this.groupBox1;
            //var events = Type.ReflectionOnlyGetType(controltype.AssemblyQualifiedName, false, true).GetEvents();

            if (radioAdd.Name == ((Control)sender).Name)
            {
                command = addCmd;
            }
            else if (radioSub.Name == ((Control)sender).Name)
            {
                command = subCmd;
            }
            else if (radioMultiply.Name == ((Control)sender).Name)
            {
                command = mulCmd;
            }
            else if (radioDiv.Name == ((Control)sender).Name)
            {
                command = divCmd;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Name == ((Control)sender).Name) {
                lblResult.Text = "Total: " + command.Execute().ToString();
            }
        }
    }
}

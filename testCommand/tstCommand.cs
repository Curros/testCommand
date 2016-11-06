using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testCommand.Class;
using System.IO;
using System.Reflection;

namespace testCommand
{
    public partial class tstCommand : Form, IMessageFilter
    {

        IReciever calculator = null;
        ACommand command = null;
        AddCommand addCmd = null;
        SubtractCommand subCmd = null;
        MultiplyCommand mulCmd = null;
        DividerCommand divCmd = null;

        public tstCommand()
        {
            InitializeComponent();
        }

        private void tstCommand_Load(object sender, EventArgs e)
        {
            Application.AddMessageFilter(this);

            calculator = new Calculator(20, 10);

            addCmd = new AddCommand(calculator);
            subCmd = new SubtractCommand(calculator);
            mulCmd = new MultiplyCommand(calculator);
            divCmd = new DividerCommand(calculator);
        }

        //Gets the actions in all the controls.
        public bool PreFilterMessage(ref Message m)
        {
            Control sender = Control.FromHandle(m.HWnd);

            //WM_LBUTTONDOWN  0x201
            if (m.Msg == 513) {
                var x = "nice! D";
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

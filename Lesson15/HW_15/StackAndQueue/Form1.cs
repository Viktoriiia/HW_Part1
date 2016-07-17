using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StackAndQueue
{
    public partial class Form1 : Form
    {
        private Stack<Object> stack = new Stack<object>();
        private int cInputNumberOfStackValue = 100;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void myAddValueButton_Click(object sender, EventArgs e)
        {
            //myInputValueTextBox.Text = cInputNumberOfStackValue;
            for(int i=0; i< cInputNumberOfStackValue; i++)
            {
                stack.Push(i);
            }
            
        }
    }
}

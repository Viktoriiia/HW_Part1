using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackAndQueue;

namespace HW_15
{
    public partial class CollectionTest : Form
    {
        private Stack<Object> stack = new Stack<object>();
        private Queue<Object> queue = new Queue<object>();
        private NewStack<Object> newDynamicStack = new NewStack<object>();
        private NewQueue<Object> newDynamicQueue = new NewQueue<object>();

        private int cNumberOfValue = 3;
        private int myNumberOfValue = 3;

        public CollectionTest()
        {
            InitializeComponent();
        }

        private void cAddValueButton_Click(object sender, EventArgs e)
        {
            cNumberOfValue = Convert.ToInt32(cInputValueTextBox.Text);
            if (choosingCProjectComboBox.Text == "C# Stack")
            {
                Stopwatch watchCStack = Stopwatch.StartNew();
                for (int i = 0; i < cNumberOfValue; i++)
                {
                    stack.Push(i);
                }
                watchCStack.Stop();
                updateCTimerLabelForAddingValue(watchCStack);
                redrawCStackPanel();
            }

            if (choosingCProjectComboBox.Text == "C# Queue")
            {
                Stopwatch watchCQueue = Stopwatch.StartNew();
                for (int i = 0; i < cNumberOfValue; i++)
                {
                    queue.Enqueue(i);
                }
                watchCQueue.Stop();
                updateCTimerLabelForAddingValue(watchCQueue);
                redrawCQueuePanel();
            }
        }

        private void cRemoveValueButton_Click(object sender, EventArgs e)
        {
            cNumberOfValue = Convert.ToInt32(cInputValueTextBox.Text);
            if (choosingCProjectComboBox.Text == "C# Stack")
            {
                if (stack.Count >= cNumberOfValue)
                {
                    Stopwatch watchCDeleteStack = Stopwatch.StartNew();
                    for (int i = 0; i < cNumberOfValue; i++)
                    {
                        stack.Pop();
                    }
                    watchCDeleteStack.Stop();
                    updateCTimerLabelForDelingtevalue(watchCDeleteStack);
                    redrawCStackPanel();
                }
                else
                {
                    MessageBox.Show("C Stack is empty,can't pop from empty stack", "Stack is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if (choosingCProjectComboBox.Text == "C# Queue")
            {
                if (queue.Count >= cNumberOfValue)
                {
                    Stopwatch watchCDeleteQueue = Stopwatch.StartNew();
                    for (int i = 0; i < cNumberOfValue; i++)
                    {
                        queue.Dequeue();
                    }
                    watchCDeleteQueue.Stop();
                    updateCTimerLabelForDelingtevalue(watchCDeleteQueue);
                    redrawCQueuePanel();
                }
                else
                {
                    MessageBox.Show("C# Queue is empty,can't pop from empty queue", "Stack is queue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void updateCTimerLabelForAddingValue(Stopwatch cWatch)
        {
            cOperationTimeLabelForAddingValue.Text = cWatch.Elapsed.ToString();
        }
        private void updateCTimerLabelForDelingtevalue(Stopwatch cWatch)
        {
            cOperationTimeLabelForDeletingValue.Text = cWatch.Elapsed.ToString();
        }

        private void redrawCStackPanel()
        {
            cOutPutValueRichTextBox.Text = "";
            foreach (Object value in stack.ToArray())
            {
                cOutPutValueRichTextBox.AppendText(value.ToString() + "\n");
            }
        }

        private void redrawCQueuePanel()
        {
            cOutPutValueRichTextBox.Text = "";
            foreach (Object value in queue.ToArray())
            {
                cOutPutValueRichTextBox.AppendText(value.ToString() + "\n");
            }
        }

        private void myAddValueButton_Click(object sender, EventArgs e)
        {
            myNumberOfValue = Convert.ToInt32(myInputValueTextBox.Text);
            if (choosingMyProjectComboBox.Text == "My Stack")
            {
                Stopwatch watchNewDynamicStack = Stopwatch.StartNew();
                for (int i = 0; i < myNumberOfValue; i++)
                {
                    newDynamicStack.Push(i);
                }
                watchNewDynamicStack.Stop();
                updateMyTimeLableForAddingValue(watchNewDynamicStack);
                redrawNewDynamicStack();
            }

            if (choosingMyProjectComboBox.Text == "My Queue")
            {
                Stopwatch watchNewDynamicQueue = Stopwatch.StartNew();
                for (int i = 0; i < myNumberOfValue; i++)
                {
                    newDynamicQueue.EnQueue(i);
                }
                watchNewDynamicQueue.Stop();
                updateMyTimeLableForAddingValue(watchNewDynamicQueue);
                redrawNewDynamicQueue();
            }
        }

        private void myRemoveValueButton_Click(object sender, EventArgs e)
        {
            myNumberOfValue = Convert.ToInt32(myInputValueTextBox.Text);
            if (choosingMyProjectComboBox.Text == "My Stack")
            {
                if (newDynamicStack.IsEmpty())
                {
                    MessageBox.Show("New Stack is empty,can't pop from empty stack", "Stack is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Stopwatch watchNewDeletedStack = Stopwatch.StartNew();
                    for (int i = 0; i < myNumberOfValue; i++)
                    {
                        newDynamicStack.Pop();
                    }
                    watchNewDeletedStack.Stop();
                    updateMyTimeLabeForDeletingValue(watchNewDeletedStack);
                    redrawNewDynamicStack();
                }
            }

            if (choosingMyProjectComboBox.Text == "My Queue")
            {
                if (newDynamicQueue.IsEmpty())
                {
                    MessageBox.Show("New Queue is empty,can't pop from empty queue", "Queue is empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Stopwatch watchNewDeleteQueue = Stopwatch.StartNew();
                    for (int i = 0; i < myNumberOfValue; i++)
                    {
                        newDynamicQueue.DeQueue();
                    }
                    watchNewDeleteQueue.Stop();
                    updateMyTimeLabeForDeletingValue(watchNewDeleteQueue);
                    redrawNewDynamicQueue();
                }
            }
        }

        private void updateMyTimeLableForAddingValue(Stopwatch myWatch)
        {
            myOperationTimeLabelForAddingValue.Text = myWatch.Elapsed.ToString();
        }
        private void updateMyTimeLabeForDeletingValue(Stopwatch myWatch)
        {
            myOperationTimeLabelForDeletingValue.Text = myWatch.Elapsed.ToString();
        }

        private void redrawNewDynamicStack()
        {
            myOutPutValueRichTextBox.Text = "";
            foreach (Object value in newDynamicStack.ToArray())
            {
                myOutPutValueRichTextBox.AppendText(value.ToString() + "\n");
            }
        }

        private void redrawNewDynamicQueue()
        {
            myOutPutValueRichTextBox.Text = "";
            foreach (Object value in newDynamicQueue.ToArray())
            {
                myOutPutValueRichTextBox.AppendText(value.ToString() + "\n");
            }
        }

        private void choosingMyProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            myProjectName.Text = choosingMyProjectComboBox.Text.ToString();
        }

        private void choosingCProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cProjectName.Text = choosingCProjectComboBox.Text;
        }

        private void myInputValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //myNumberOfValue = Convert.ToInt32(myInputValueTextBox.Text);
            }
        }

        private void cInputValueTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
            {
                e.Handled = true;
                //cNumberOfValue = Convert.ToInt32(cInputValueTextBox.Text);
            }
        }
    }
}

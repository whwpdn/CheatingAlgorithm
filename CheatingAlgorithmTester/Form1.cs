using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CheatingAlgorithm
{
    public partial class Form1 : Form
    {
        CheatingStack<int> testStack;
        CheatingQueue<int> testQueue;
        public Form1()
        {
            InitializeComponent();

            // test linkedlist
            /*
            CheatingLinkedList<int> aaa = new CheatingLinkedList<int>();
            aaa.PushBack(1);
            aaa.PushBack(2);
            aaa.PushBack(3);
            aaa.PushBack(4);

            int tmp = aaa.PopFront();
            label1.Text = tmp.ToString();
            tmp = aaa.PopFront();
            label1.Text = tmp.ToString();

            tmp = aaa.PopFront();
            label1.Text = tmp.ToString();
             * */
        }



        //stack test
        private void button3_Click(object sender, EventArgs e)
        {
            if (tbMax.Text.Equals("")) return;
            testStack = new CheatingStack<int>(Int32.Parse(tbMax.Text));
            this.btPop.Enabled = true;
            this.btPush.Enabled = true;

            UpdateStackList(this.listStack, testStack.Clone());
        }

        private void btPush_Click(object sender, EventArgs e)
        {
            testStack.Push(Int32.Parse(tbData.Text));
            UpdateStackList(this.listStack, testStack.Clone());
        }

        private void btPop_Click(object sender, EventArgs e)
        {
            this.lbPop.Text = testStack.Pop().ToString();
            UpdateStackList(this.listStack,testStack.Clone());
        }

        private void UpdateStackList(ListBox listbox ,int[] Items)
        {
            listbox.Items.Clear();
            if (Items == null) return;
            foreach (var item in Items)
            {
                listbox.Items.Add(item);
            }

        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.btPop.Enabled = false;
            this.btPush.Enabled = false;
        }

        private void btCreate2_Click(object sender, EventArgs e)
        {
            if (tbMax2.Text.Equals("")) return;
            testQueue = new CheatingQueue<int>(Int32.Parse(tbMax2.Text));
            this.btPop2.Enabled = true;
            this.btPush2.Enabled = true;

            UpdateStackList(this.listQueue, testQueue.Clone());
        }

        private void btPush2_Click(object sender, EventArgs e)
        {
            testQueue.Push(Int32.Parse(tbData2.Text));
            UpdateStackList(this.listQueue, testQueue.Clone());
        }

        private void btPop2_Click(object sender, EventArgs e)
        {
            this.lbPopdata2.Text = testQueue.Pop().ToString();
            UpdateStackList(this.listQueue, testQueue.Clone());
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            this.btPop2.Enabled = false;
            this.btPush2.Enabled = false;
        }

        // queue


    }
        
}

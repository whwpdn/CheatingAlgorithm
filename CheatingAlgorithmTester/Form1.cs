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

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbMax.Text.Equals("")) return;
            testStack = new CheatingStack<int>(Int32.Parse(tbMax.Text));
            this.btPop.Enabled = true;
            this.btPush.Enabled = true;
            
            UpdateStackList(testStack.Clone());
        }

        private void btPush_Click(object sender, EventArgs e)
        {
            testStack.Push(Int32.Parse(tbData.Text));
            UpdateStackList(testStack.Clone());
        }

        private void btPop_Click(object sender, EventArgs e)
        {
            this.lbPop.Text = testStack.Pop().ToString();
            UpdateStackList(testStack.Clone());
        }

        private void UpdateStackList(int[] Items)
        {
            listStack.Items.Clear();
            if (Items == null) return;
            foreach(var item in Items)
            {
                listStack.Items.Add(item);
            }
            
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.btPop.Enabled = false;
            this.btPush.Enabled = false;
            
        }
    }
}

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
        //CheatingAlgorithm testSorting;
        CheatingStack<int> testStack;
        CheatingQueue<int> testQueue;
        CheatingCircularQueue<int> testCircularQueue;
        int[] unsortedDatas;
        int[] sortedDatas;
        public Form1()
        {
            InitializeComponent();

          
        }
        private void InitData()
        {
            //testSorting = new CheatingAlgorithm();
            unsortedDatas = new int[6];
            for(int i=0 ; i<6;i++)
            {
                unsortedDatas[i] =Int32.Parse(((TextBox)this.Controls.Find("tbRawData"+i,true)[0]).Text);
            }

            sortedDatas = new int[6];
        }
        private void SetSortedData()
        {
            for (int i = 0; i < 6; i++)
            {
                ((TextBox)this.Controls.Find("tbSorted" + i, true)[0]).Text = sortedDatas[i].ToString();
            }
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


        // Queue
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

        // Circular queue
        private void btCreate3_Click(object sender, EventArgs e)
        {

            if (tbMax3.Text.Equals("")) return;
            testCircularQueue = new CheatingCircularQueue<int>(Int32.Parse(tbMax3.Text));
            this.btPop3.Enabled = true;
            this.btPush3.Enabled = true;

            UpdateStackList(this.listCircularQueue, testCircularQueue.Clone());
        }

        private void btPush3_Click(object sender, EventArgs e)
        {
            testCircularQueue.Push(Int32.Parse(tbData3.Text));
            UpdateStackList(this.listCircularQueue, testCircularQueue.Clone());
        }

        private void btPop3_Click(object sender, EventArgs e)
        {
            this.lbPopData3.Text = testCircularQueue.Pop().ToString();
            UpdateStackList(this.listCircularQueue, testCircularQueue.Clone());
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            this.btPop3.Enabled = false;
            this.btPush3.Enabled = false;
        }


        /// <summary>
        /// insertion sort test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btInsertion_Click(object sender, EventArgs e)
        {

            //sortedDatas = testSorting.InsertionSort(unsortedDatas);
            sortedDatas = unsortedDatas.InsertionSort();
            SetSortedData();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                ((TextBox)this.Controls.Find("tbSorted" + i, true)[0]).Text = 0.ToString();
            }
        }

        private void btSelection_Click(object sender, EventArgs e)
        {
            sortedDatas = unsortedDatas.SelectionSort();
            SetSortedData();
        }

     


    }
        
}

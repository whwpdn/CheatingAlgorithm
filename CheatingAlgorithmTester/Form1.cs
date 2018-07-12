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
using System.Diagnostics;

namespace CheatingAlgorithm
{
    delegate int[] AlgDelegate();
    enum AlgorithmType
    {
        Selection =0,
        Insertion ,
        Bubble,
        Merge,
    }
    delegate void AlgTestDelegate();
    public partial class Form1 : Form
    {
        //CheatingAlgorithm testSorting;
        CheatingStack<int> testStack;
        CheatingQueue<int> testQueue;
        CheatingCircularQueue<int> testCircularQueue;
        CheatingBinaryTree<int> testBinaryTree;
        int[] TempDatas;
        int[] unsortedDatas;
        int[] sortedDatas;
        int OutIdx;
        int InIdx;
        int TempValue;
        int Count =0;
        AlgTestDelegate algTestDele;
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
            TempDatas = (int[])unsortedDatas.Clone();
            InitAlgTypeCombobox();
            
        }

        private void InitAlgTypeCombobox()
        {
            foreach(string algtype in Enum.GetNames(typeof(AlgorithmType)))
            {
                this.cbAlg.Items.Add(algtype);
            }
            this.cbAlg.SelectedIndex = 0;
        }
        private void SetInitialValue(AlgorithmType type)
        {
            TempDatas = (int[])unsortedDatas.Clone();
            switch(type)
            {
                case AlgorithmType.Insertion:
                    OutIdx =1;
                    InIdx = OutIdx;
                    TempValue = TempDatas[OutIdx];
                    Count = 0;
                    algTestDele = new AlgTestDelegate(InsertionSortTest);
                    break;
                case AlgorithmType.Selection:
                    OutIdx = 0;
                    InIdx = OutIdx + 1;
                    TempValue = OutIdx;
                    Count = 0;
                    algTestDele = new AlgTestDelegate(SelectionSortTest);
                    break;
                case AlgorithmType.Bubble:
                     OutIdx = 1;
                    InIdx = 0;
                    Count = 0;
                    algTestDele = new AlgTestDelegate(BubbleSortTest);
                    break;

            }
        }
        private void SetSortedData(int [] data)
        {
            for (int i = 0; i < 6; i++)
            {
                ((TextBox)this.Controls.Find("tbSorted" + i, true)[0]).Text = data[i].ToString();
            }
        }

        private void SetSortedDataColor(int index1, int index2)
        {
            for (int i = 0; i < 6; i++)
            {
                ((TextBox)this.Controls.Find("tbSorted" + i, true)[0]).BackColor = Color.White;
            }
            ((TextBox)this.Controls.Find("tbSorted" + index1, true)[0]).BackColor = Color.Red;
            ((TextBox)this.Controls.Find("tbSorted" + index2, true)[0]).BackColor = Color.Yellow;
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

        private void Sorting(string name , AlgDelegate dele)
        {
            Stopwatch swtime = new Stopwatch();
            swtime.Start();

            //sortedDatas = unsortedDatas.InsertionSort();
            sortedDatas = dele();

            swtime.Stop();
            Log(String.Format("{0} Sorting Elapsed Time: {1}", name, swtime.Elapsed));
            SetSortedData(this.sortedDatas);
        }

        // binary tree
        //private void btCreate4_Click(object sender, EventArgs e)
        //{
        //    testBinaryTree
        //}
        private void btPush4_Click(object sender, EventArgs e)
        {
            testBinaryTree.Insert(Int32.Parse(tbData4.Text));
            tbData4.Text = "";
            tbData4.Focus();
            //UpdateStackList(this.listBinTree, testBinaryTree.Clone());
        }
        private void tabPage6_Enter(object sender, EventArgs e)
        {
            if(testBinaryTree ==null)
            {
                testBinaryTree = new CheatingBinaryTree<int>();
            }
                //this.btPop4.Enabled = false;
                //this.btPush4.Enabled = false;
                this.btCreate4.Enabled = false;
            
        }

        private void btPreorder_Click(object sender, EventArgs e)
        {
            testBinaryTree.Preorder(testBinaryTree.GetRootNode());
        }
        private void btPostorder_Click(object sender, EventArgs e)
        {
            testBinaryTree.Postorder(testBinaryTree.GetRootNode());
        }

        private void btInorder_Click(object sender, EventArgs e)
        {
            testBinaryTree.Inorder(testBinaryTree.GetRootNode());
        }



        /// <summary>
        /// insertion sort test
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btInsertion_Click(object sender, EventArgs e)
        {
            AlgDelegate algDelegate = new AlgDelegate(unsortedDatas.InsertionSort);
            Sorting("insertion", algDelegate);
        }
        
        private void btSelection_Click(object sender, EventArgs e)
        {
            AlgDelegate algDelegate = new AlgDelegate(unsortedDatas.SelectionSort);
            Sorting("Selection", algDelegate);
        }
        private void btBubble_Click(object sender, EventArgs e)
        {
            AlgDelegate algDelegate = new AlgDelegate(unsortedDatas.BubbleSort);
            Sorting("bubble", algDelegate);
        }
        private void btMerge_Click(object sender, EventArgs e)
        {
            AlgDelegate algDelegate = new AlgDelegate(unsortedDatas.MergeSort);
            Sorting("Merge", algDelegate);
        }
        private void btQuick_Click(object sender, EventArgs e)
        {
            AlgDelegate algDelegate = new AlgDelegate(unsortedDatas.QuickSort);
            Sorting("Quick", algDelegate);
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
            SetInitialValue((AlgorithmType)(this.cbAlg.SelectedIndex));
        }

        private void tbRawData0_TextChanged(object sender, EventArgs e)
        {
            for(int i=0; i<6 ;i++)
            {
                unsortedDatas[i] = Int32.Parse(((TextBox)this.Controls.Find("tbRawData" + i, true)[0]).Text);
            }
            
            
        }

        private void btNext_Click(object sender, EventArgs e)
        {


            algTestDele();
            
        }

        private void btEnd_Click(object sender, EventArgs e)
        {

        }

        private void cbAlg_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInitialValue( (AlgorithmType)((ComboBox)sender).SelectedIndex ) ;
            TempDatas = (int[])unsortedDatas.Clone();
        }
        /// <summary>
        /// 
        /// </summary>
        private void BubbleSortTest()
        {
            int size = TempDatas.Length;
            if(OutIdx < size)
            {   

                TempDatas = TempDatas.BubbleSortTest(ref OutIdx, ref InIdx);
                SetSortedDataColor(InIdx, ++InIdx);
                SetSortedData(TempDatas);
                this.lbCount.Text = (++Count).ToString();
            }
            else
            {
                Log("Done");
                return;
            }

            if(InIdx >=(size - OutIdx))
            {
                OutIdx++;
                InIdx =0;
            }    
        }
        /// <summary>
        /// 
        /// </summary>
        private void SelectionSortTest()
        {
            if (OutIdx < TempDatas.Length && InIdx < TempDatas.Length)
            {
                TempDatas = TempDatas.SelectionSortTest(ref OutIdx, ref InIdx, ref TempValue);
                SetSortedData(TempDatas);
                SetSortedDataColor(OutIdx, InIdx++);
                this.lbCount.Text = (++Count).ToString();    

                if (InIdx >= TempDatas.Length)
                {
                    TempValue = ++OutIdx;
                    InIdx = OutIdx + 1;
                }
            }
            else
            {

                Log("Done");
                return;
            }
            
        }
        /// <summary>
        /// 
        /// </summary>
        private void InsertionSortTest()
        {
            if (OutIdx < TempDatas.Length && InIdx >0)
            {
                TempDatas = TempDatas.InsertionSortTest(TempValue, ref InIdx);
                SetSortedData(TempDatas);
                SetSortedDataColor(OutIdx, --InIdx);
                
                this.lbCount.Text = (++Count).ToString();
                if (InIdx == 0)
                {   
                    OutIdx++;

                    if (OutIdx < TempDatas.Length)
                    {
                        InIdx = OutIdx;
                        TempValue = TempDatas[OutIdx];
                    }
                }   
            }
            else
            {
                Log("Done");
                return;
            }
        }
        private void Log(string msg , string para1)
        {
            Log(string.Format(msg + para1));
        }
        private void Log(string msg)
        {
            this.listLog.Items.Add(msg);
        }

       
        
       
      
        
    }
}

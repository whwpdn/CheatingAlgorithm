namespace CheatingAlgorithm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbPop = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.listStack = new System.Windows.Forms.ListBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.btPop = new System.Windows.Forms.Button();
            this.btPush = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbPopdata2 = new System.Windows.Forms.Label();
            this.btCreate2 = new System.Windows.Forms.Button();
            this.tbMax2 = new System.Windows.Forms.TextBox();
            this.listQueue = new System.Windows.Forms.ListBox();
            this.tbData2 = new System.Windows.Forms.TextBox();
            this.btPop2 = new System.Windows.Forms.Button();
            this.btPush2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbPopData3 = new System.Windows.Forms.Label();
            this.btCreate3 = new System.Windows.Forms.Button();
            this.tbMax3 = new System.Windows.Forms.TextBox();
            this.listCircularQueue = new System.Windows.Forms.ListBox();
            this.tbData3 = new System.Windows.Forms.TextBox();
            this.btPop3 = new System.Windows.Forms.Button();
            this.btPush3 = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btBubble = new System.Windows.Forms.Button();
            this.btSelection = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.tbSorted5 = new System.Windows.Forms.TextBox();
            this.tbSorted4 = new System.Windows.Forms.TextBox();
            this.tbSorted3 = new System.Windows.Forms.TextBox();
            this.tbSorted2 = new System.Windows.Forms.TextBox();
            this.tbSorted1 = new System.Windows.Forms.TextBox();
            this.tbSorted0 = new System.Windows.Forms.TextBox();
            this.tbRawData5 = new System.Windows.Forms.TextBox();
            this.tbRawData4 = new System.Windows.Forms.TextBox();
            this.tbRawData3 = new System.Windows.Forms.TextBox();
            this.tbRawData2 = new System.Windows.Forms.TextBox();
            this.tbRawData1 = new System.Windows.Forms.TextBox();
            this.tbRawData0 = new System.Windows.Forms.TextBox();
            this.listLog = new System.Windows.Forms.ListBox();
            this.btInsertion = new System.Windows.Forms.Button();
            this.btMerge = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(625, 473);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(617, 447);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LinkedList";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbPop);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.tbMax);
            this.tabPage2.Controls.Add(this.listStack);
            this.tabPage2.Controls.Add(this.tbData);
            this.tabPage2.Controls.Add(this.btPop);
            this.tabPage2.Controls.Add(this.btPush);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(617, 447);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stack";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            // 
            // lbPop
            // 
            this.lbPop.AutoSize = true;
            this.lbPop.Location = new System.Drawing.Point(158, 289);
            this.lbPop.Name = "lbPop";
            this.lbPop.Size = new System.Drawing.Size(54, 12);
            this.lbPop.TabIndex = 6;
            this.lbPop.Text = "pop data";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(160, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "create";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbMax
            // 
            this.tbMax.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbMax.Location = new System.Drawing.Point(30, 75);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(100, 21);
            this.tbMax.TabIndex = 4;
            // 
            // listStack
            // 
            this.listStack.FormattingEnabled = true;
            this.listStack.ItemHeight = 12;
            this.listStack.Location = new System.Drawing.Point(274, 47);
            this.listStack.Name = "listStack";
            this.listStack.Size = new System.Drawing.Size(227, 280);
            this.listStack.TabIndex = 3;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(30, 230);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(100, 21);
            this.tbData.TabIndex = 2;
            // 
            // btPop
            // 
            this.btPop.Location = new System.Drawing.Point(55, 284);
            this.btPop.Name = "btPop";
            this.btPop.Size = new System.Drawing.Size(75, 23);
            this.btPop.TabIndex = 1;
            this.btPop.Text = "pop";
            this.btPop.UseVisualStyleBackColor = true;
            this.btPop.Click += new System.EventHandler(this.btPop_Click);
            // 
            // btPush
            // 
            this.btPush.Location = new System.Drawing.Point(160, 216);
            this.btPush.Name = "btPush";
            this.btPush.Size = new System.Drawing.Size(75, 23);
            this.btPush.TabIndex = 0;
            this.btPush.Text = "push";
            this.btPush.UseVisualStyleBackColor = true;
            this.btPush.Click += new System.EventHandler(this.btPush_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbPopdata2);
            this.tabPage3.Controls.Add(this.btCreate2);
            this.tabPage3.Controls.Add(this.tbMax2);
            this.tabPage3.Controls.Add(this.listQueue);
            this.tabPage3.Controls.Add(this.tbData2);
            this.tabPage3.Controls.Add(this.btPop2);
            this.tabPage3.Controls.Add(this.btPush2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(617, 447);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Queue";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // lbPopdata2
            // 
            this.lbPopdata2.AutoSize = true;
            this.lbPopdata2.Location = new System.Drawing.Point(191, 294);
            this.lbPopdata2.Name = "lbPopdata2";
            this.lbPopdata2.Size = new System.Drawing.Size(54, 12);
            this.lbPopdata2.TabIndex = 13;
            this.lbPopdata2.Text = "pop data";
            // 
            // btCreate2
            // 
            this.btCreate2.Location = new System.Drawing.Point(193, 80);
            this.btCreate2.Name = "btCreate2";
            this.btCreate2.Size = new System.Drawing.Size(75, 23);
            this.btCreate2.TabIndex = 12;
            this.btCreate2.Text = "create";
            this.btCreate2.UseVisualStyleBackColor = true;
            this.btCreate2.Click += new System.EventHandler(this.btCreate2_Click);
            // 
            // tbMax2
            // 
            this.tbMax2.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbMax2.Location = new System.Drawing.Point(63, 80);
            this.tbMax2.Name = "tbMax2";
            this.tbMax2.Size = new System.Drawing.Size(100, 21);
            this.tbMax2.TabIndex = 11;
            // 
            // listQueue
            // 
            this.listQueue.FormattingEnabled = true;
            this.listQueue.ItemHeight = 12;
            this.listQueue.Location = new System.Drawing.Point(307, 52);
            this.listQueue.Name = "listQueue";
            this.listQueue.Size = new System.Drawing.Size(227, 280);
            this.listQueue.TabIndex = 10;
            // 
            // tbData2
            // 
            this.tbData2.Location = new System.Drawing.Point(63, 235);
            this.tbData2.Name = "tbData2";
            this.tbData2.Size = new System.Drawing.Size(100, 21);
            this.tbData2.TabIndex = 9;
            // 
            // btPop2
            // 
            this.btPop2.Location = new System.Drawing.Point(88, 289);
            this.btPop2.Name = "btPop2";
            this.btPop2.Size = new System.Drawing.Size(75, 23);
            this.btPop2.TabIndex = 8;
            this.btPop2.Text = "pop";
            this.btPop2.UseVisualStyleBackColor = true;
            this.btPop2.Click += new System.EventHandler(this.btPop2_Click);
            // 
            // btPush2
            // 
            this.btPush2.Location = new System.Drawing.Point(193, 221);
            this.btPush2.Name = "btPush2";
            this.btPush2.Size = new System.Drawing.Size(75, 23);
            this.btPush2.TabIndex = 7;
            this.btPush2.Text = "push";
            this.btPush2.UseVisualStyleBackColor = true;
            this.btPush2.Click += new System.EventHandler(this.btPush2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbPopData3);
            this.tabPage4.Controls.Add(this.btCreate3);
            this.tabPage4.Controls.Add(this.tbMax3);
            this.tabPage4.Controls.Add(this.listCircularQueue);
            this.tabPage4.Controls.Add(this.tbData3);
            this.tabPage4.Controls.Add(this.btPop3);
            this.tabPage4.Controls.Add(this.btPush3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(617, 447);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "circularQueue";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // lbPopData3
            // 
            this.lbPopData3.AutoSize = true;
            this.lbPopData3.Location = new System.Drawing.Point(201, 325);
            this.lbPopData3.Name = "lbPopData3";
            this.lbPopData3.Size = new System.Drawing.Size(54, 12);
            this.lbPopData3.TabIndex = 20;
            this.lbPopData3.Text = "pop data";
            // 
            // btCreate3
            // 
            this.btCreate3.Location = new System.Drawing.Point(203, 111);
            this.btCreate3.Name = "btCreate3";
            this.btCreate3.Size = new System.Drawing.Size(75, 23);
            this.btCreate3.TabIndex = 19;
            this.btCreate3.Text = "create";
            this.btCreate3.UseVisualStyleBackColor = true;
            this.btCreate3.Click += new System.EventHandler(this.btCreate3_Click);
            // 
            // tbMax3
            // 
            this.tbMax3.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tbMax3.Location = new System.Drawing.Point(73, 111);
            this.tbMax3.Name = "tbMax3";
            this.tbMax3.Size = new System.Drawing.Size(100, 21);
            this.tbMax3.TabIndex = 18;
            // 
            // listCircularQueue
            // 
            this.listCircularQueue.FormattingEnabled = true;
            this.listCircularQueue.ItemHeight = 12;
            this.listCircularQueue.Location = new System.Drawing.Point(317, 83);
            this.listCircularQueue.Name = "listCircularQueue";
            this.listCircularQueue.Size = new System.Drawing.Size(227, 280);
            this.listCircularQueue.TabIndex = 17;
            // 
            // tbData3
            // 
            this.tbData3.Location = new System.Drawing.Point(73, 266);
            this.tbData3.Name = "tbData3";
            this.tbData3.Size = new System.Drawing.Size(100, 21);
            this.tbData3.TabIndex = 16;
            // 
            // btPop3
            // 
            this.btPop3.Location = new System.Drawing.Point(98, 320);
            this.btPop3.Name = "btPop3";
            this.btPop3.Size = new System.Drawing.Size(75, 23);
            this.btPop3.TabIndex = 15;
            this.btPop3.Text = "pop";
            this.btPop3.UseVisualStyleBackColor = true;
            this.btPop3.Click += new System.EventHandler(this.btPop3_Click);
            // 
            // btPush3
            // 
            this.btPush3.Location = new System.Drawing.Point(203, 252);
            this.btPush3.Name = "btPush3";
            this.btPush3.Size = new System.Drawing.Size(75, 23);
            this.btPush3.TabIndex = 14;
            this.btPush3.Text = "push";
            this.btPush3.UseVisualStyleBackColor = true;
            this.btPush3.Click += new System.EventHandler(this.btPush3_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btMerge);
            this.tabPage5.Controls.Add(this.btBubble);
            this.tabPage5.Controls.Add(this.btSelection);
            this.tabPage5.Controls.Add(this.btReset);
            this.tabPage5.Controls.Add(this.tbSorted5);
            this.tabPage5.Controls.Add(this.tbSorted4);
            this.tabPage5.Controls.Add(this.tbSorted3);
            this.tabPage5.Controls.Add(this.tbSorted2);
            this.tabPage5.Controls.Add(this.tbSorted1);
            this.tabPage5.Controls.Add(this.tbSorted0);
            this.tabPage5.Controls.Add(this.tbRawData5);
            this.tabPage5.Controls.Add(this.tbRawData4);
            this.tabPage5.Controls.Add(this.tbRawData3);
            this.tabPage5.Controls.Add(this.tbRawData2);
            this.tabPage5.Controls.Add(this.tbRawData1);
            this.tabPage5.Controls.Add(this.tbRawData0);
            this.tabPage5.Controls.Add(this.listLog);
            this.tabPage5.Controls.Add(this.btInsertion);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(617, 447);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "sorting";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btBubble
            // 
            this.btBubble.Location = new System.Drawing.Point(179, 112);
            this.btBubble.Name = "btBubble";
            this.btBubble.Size = new System.Drawing.Size(75, 23);
            this.btBubble.TabIndex = 11;
            this.btBubble.Text = "bubble";
            this.btBubble.UseVisualStyleBackColor = true;
            this.btBubble.Click += new System.EventHandler(this.btBubble_Click);
            // 
            // btSelection
            // 
            this.btSelection.Location = new System.Drawing.Point(98, 112);
            this.btSelection.Name = "btSelection";
            this.btSelection.Size = new System.Drawing.Size(75, 23);
            this.btSelection.TabIndex = 10;
            this.btSelection.Text = "selection";
            this.btSelection.UseVisualStyleBackColor = true;
            this.btSelection.Click += new System.EventHandler(this.btSelection_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(459, 56);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // tbSorted5
            // 
            this.tbSorted5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSorted5.Location = new System.Drawing.Point(302, 56);
            this.tbSorted5.Name = "tbSorted5";
            this.tbSorted5.Size = new System.Drawing.Size(51, 26);
            this.tbSorted5.TabIndex = 3;
            this.tbSorted5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSorted4
            // 
            this.tbSorted4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSorted4.Location = new System.Drawing.Point(245, 56);
            this.tbSorted4.Name = "tbSorted4";
            this.tbSorted4.Size = new System.Drawing.Size(51, 26);
            this.tbSorted4.TabIndex = 4;
            this.tbSorted4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSorted3
            // 
            this.tbSorted3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSorted3.Location = new System.Drawing.Point(188, 56);
            this.tbSorted3.Name = "tbSorted3";
            this.tbSorted3.Size = new System.Drawing.Size(51, 26);
            this.tbSorted3.TabIndex = 5;
            this.tbSorted3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSorted2
            // 
            this.tbSorted2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSorted2.Location = new System.Drawing.Point(131, 56);
            this.tbSorted2.Name = "tbSorted2";
            this.tbSorted2.Size = new System.Drawing.Size(51, 26);
            this.tbSorted2.TabIndex = 6;
            this.tbSorted2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSorted1
            // 
            this.tbSorted1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSorted1.Location = new System.Drawing.Point(74, 56);
            this.tbSorted1.Name = "tbSorted1";
            this.tbSorted1.Size = new System.Drawing.Size(51, 26);
            this.tbSorted1.TabIndex = 7;
            this.tbSorted1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbSorted0
            // 
            this.tbSorted0.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbSorted0.Location = new System.Drawing.Point(17, 56);
            this.tbSorted0.Name = "tbSorted0";
            this.tbSorted0.Size = new System.Drawing.Size(51, 26);
            this.tbSorted0.TabIndex = 8;
            this.tbSorted0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbRawData5
            // 
            this.tbRawData5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRawData5.Location = new System.Drawing.Point(302, 23);
            this.tbRawData5.Name = "tbRawData5";
            this.tbRawData5.Size = new System.Drawing.Size(51, 26);
            this.tbRawData5.TabIndex = 2;
            this.tbRawData5.Text = "8";
            this.tbRawData5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRawData5.TextChanged += new System.EventHandler(this.tbRawData0_TextChanged);
            // 
            // tbRawData4
            // 
            this.tbRawData4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRawData4.Location = new System.Drawing.Point(245, 23);
            this.tbRawData4.Name = "tbRawData4";
            this.tbRawData4.Size = new System.Drawing.Size(51, 26);
            this.tbRawData4.TabIndex = 2;
            this.tbRawData4.Text = "2";
            this.tbRawData4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRawData4.TextChanged += new System.EventHandler(this.tbRawData0_TextChanged);
            // 
            // tbRawData3
            // 
            this.tbRawData3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRawData3.Location = new System.Drawing.Point(188, 23);
            this.tbRawData3.Name = "tbRawData3";
            this.tbRawData3.Size = new System.Drawing.Size(51, 26);
            this.tbRawData3.TabIndex = 2;
            this.tbRawData3.Text = "13";
            this.tbRawData3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRawData3.TextChanged += new System.EventHandler(this.tbRawData0_TextChanged);
            // 
            // tbRawData2
            // 
            this.tbRawData2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRawData2.Location = new System.Drawing.Point(131, 23);
            this.tbRawData2.Name = "tbRawData2";
            this.tbRawData2.Size = new System.Drawing.Size(51, 26);
            this.tbRawData2.TabIndex = 2;
            this.tbRawData2.Text = "3";
            this.tbRawData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRawData2.TextChanged += new System.EventHandler(this.tbRawData0_TextChanged);
            // 
            // tbRawData1
            // 
            this.tbRawData1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRawData1.Location = new System.Drawing.Point(74, 23);
            this.tbRawData1.Name = "tbRawData1";
            this.tbRawData1.Size = new System.Drawing.Size(51, 26);
            this.tbRawData1.TabIndex = 2;
            this.tbRawData1.Text = "7";
            this.tbRawData1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRawData1.TextChanged += new System.EventHandler(this.tbRawData0_TextChanged);
            // 
            // tbRawData0
            // 
            this.tbRawData0.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbRawData0.Location = new System.Drawing.Point(17, 23);
            this.tbRawData0.Name = "tbRawData0";
            this.tbRawData0.Size = new System.Drawing.Size(51, 26);
            this.tbRawData0.TabIndex = 2;
            this.tbRawData0.Text = "10";
            this.tbRawData0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbRawData0.TextChanged += new System.EventHandler(this.tbRawData0_TextChanged);
            // 
            // listLog
            // 
            this.listLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listLog.FormattingEnabled = true;
            this.listLog.ItemHeight = 12;
            this.listLog.Location = new System.Drawing.Point(3, 356);
            this.listLog.Name = "listLog";
            this.listLog.Size = new System.Drawing.Size(611, 88);
            this.listLog.TabIndex = 1;
            // 
            // btInsertion
            // 
            this.btInsertion.Location = new System.Drawing.Point(17, 112);
            this.btInsertion.Name = "btInsertion";
            this.btInsertion.Size = new System.Drawing.Size(75, 23);
            this.btInsertion.TabIndex = 0;
            this.btInsertion.Text = "insertion";
            this.btInsertion.UseVisualStyleBackColor = true;
            this.btInsertion.Click += new System.EventHandler(this.btInsertion_Click);
            // 
            // btMerge
            // 
            this.btMerge.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btMerge.Location = new System.Drawing.Point(260, 112);
            this.btMerge.Name = "btMerge";
            this.btMerge.Size = new System.Drawing.Size(75, 23);
            this.btMerge.TabIndex = 11;
            this.btMerge.Text = "merge";
            this.btMerge.UseVisualStyleBackColor = true;
            this.btMerge.Click += new System.EventHandler(this.btMerge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 473);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.ListBox listStack;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.Button btPop;
        private System.Windows.Forms.Button btPush;
        private System.Windows.Forms.Label lbPop;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lbPopdata2;
        private System.Windows.Forms.Button btCreate2;
        private System.Windows.Forms.TextBox tbMax2;
        private System.Windows.Forms.ListBox listQueue;
        private System.Windows.Forms.TextBox tbData2;
        private System.Windows.Forms.Button btPop2;
        private System.Windows.Forms.Button btPush2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lbPopData3;
        private System.Windows.Forms.Button btCreate3;
        private System.Windows.Forms.TextBox tbMax3;
        private System.Windows.Forms.ListBox listCircularQueue;
        private System.Windows.Forms.TextBox tbData3;
        private System.Windows.Forms.Button btPop3;
        private System.Windows.Forms.Button btPush3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Button btInsertion;
        private System.Windows.Forms.TextBox tbSorted5;
        private System.Windows.Forms.TextBox tbSorted4;
        private System.Windows.Forms.TextBox tbSorted3;
        private System.Windows.Forms.TextBox tbSorted2;
        private System.Windows.Forms.TextBox tbSorted1;
        private System.Windows.Forms.TextBox tbSorted0;
        private System.Windows.Forms.TextBox tbRawData5;
        private System.Windows.Forms.TextBox tbRawData4;
        private System.Windows.Forms.TextBox tbRawData3;
        private System.Windows.Forms.TextBox tbRawData2;
        private System.Windows.Forms.TextBox tbRawData1;
        private System.Windows.Forms.TextBox tbRawData0;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btSelection;
        private System.Windows.Forms.Button btBubble;
        private System.Windows.Forms.Button btMerge;

    }
}


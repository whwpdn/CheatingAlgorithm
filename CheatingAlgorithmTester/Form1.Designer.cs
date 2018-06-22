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
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 473);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
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

    }
}


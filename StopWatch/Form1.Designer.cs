namespace StopWatch
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btRecord = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labeldotSecond = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRecord
            // 
            this.btRecord.Location = new System.Drawing.Point(74, 231);
            this.btRecord.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btRecord.Name = "btRecord";
            this.btRecord.Size = new System.Drawing.Size(103, 43);
            this.btRecord.TabIndex = 0;
            this.btRecord.Text = "초기화";
            this.btRecord.UseVisualStyleBackColor = true;
            this.btRecord.Click += new System.EventHandler(this.btRecord_Click);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(218, 231);
            this.btStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(103, 43);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "시작";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Location = new System.Drawing.Point(129, 53);
            this.labelMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(34, 28);
            this.labelMin.TabIndex = 2;
            this.labelMin.Text = "00";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.Location = new System.Drawing.Point(187, 53);
            this.labelSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(34, 28);
            this.labelSecond.TabIndex = 3;
            this.labelSecond.Text = "00";
            // 
            // labeldotSecond
            // 
            this.labeldotSecond.AutoSize = true;
            this.labeldotSecond.Location = new System.Drawing.Point(229, 53);
            this.labeldotSecond.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldotSecond.Name = "labeldotSecond";
            this.labeldotSecond.Size = new System.Drawing.Size(34, 28);
            this.labeldotSecond.TabIndex = 4;
            this.labeldotSecond.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = ".";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(94, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 138);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(6, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(197, 84);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 300);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labeldotSecond);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.btRecord);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRecord;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labeldotSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}


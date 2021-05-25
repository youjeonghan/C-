
namespace Panel
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
            this.btn1 = new System.Windows.Forms.RadioButton();
            this.btn2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.other = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.AutoSize = true;
            this.btn1.Location = new System.Drawing.Point(46, 30);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(45, 16);
            this.btn1.TabIndex = 0;
            this.btn1.TabStop = true;
            this.btn1.Text = "Red";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.AutoSize = true;
            this.btn2.Location = new System.Drawing.Point(46, 87);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 16);
            this.btn2.TabIndex = 1;
            this.btn2.TabStop = true;
            this.btn2.Text = "Black";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.other);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Location = new System.Drawing.Point(99, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 135);
            this.panel1.TabIndex = 4;
            // 
            // other
            // 
            this.other.Location = new System.Drawing.Point(143, 132);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(100, 21);
            this.other.TabIndex = 4;
            this.other.Tag = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn3
            // 
            this.btn3.AutoSize = true;
            this.btn3.Location = new System.Drawing.Point(46, 134);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(51, 16);
            this.btn3.TabIndex = 5;
            this.btn3.TabStop = true;
            this.btn3.Text = "other";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton btn1;
        private System.Windows.Forms.RadioButton btn2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox other;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton btn3;
    }
}


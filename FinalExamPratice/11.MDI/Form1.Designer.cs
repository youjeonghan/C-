
namespace _11.MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.한국ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.미국ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.일본ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.정령ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pythonToolStripMenuItem,
            this.정령ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pythonToolStripMenuItem
            // 
            this.pythonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.한국ToolStripMenuItem,
            this.미국ToolStripMenuItem,
            this.일본ToolStripMenuItem});
            this.pythonToolStripMenuItem.Name = "pythonToolStripMenuItem";
            this.pythonToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.pythonToolStripMenuItem.Text = "언어";
            // 
            // 한국ToolStripMenuItem
            // 
            this.한국ToolStripMenuItem.Name = "한국ToolStripMenuItem";
            this.한국ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.한국ToolStripMenuItem.Text = "한국";
            this.한국ToolStripMenuItem.Click += new System.EventHandler(this.한국ToolStripMenuItem_Click);
            // 
            // 미국ToolStripMenuItem
            // 
            this.미국ToolStripMenuItem.Name = "미국ToolStripMenuItem";
            this.미국ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.미국ToolStripMenuItem.Text = "미국";
            // 
            // 일본ToolStripMenuItem
            // 
            this.일본ToolStripMenuItem.Name = "일본ToolStripMenuItem";
            this.일본ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.일본ToolStripMenuItem.Text = "일본";
            // 
            // 정령ToolStripMenuItem
            // 
            this.정령ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.arrangeToolStripMenuItem});
            this.정령ToolStripMenuItem.Name = "정령ToolStripMenuItem";
            this.정령ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.정령ToolStripMenuItem.Text = "정렬";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cascadeToolStripMenuItem.Text = "cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.verticalToolStripMenuItem.Text = "vertical";
            this.verticalToolStripMenuItem.Click += new System.EventHandler(this.verticalToolStripMenuItem_Click);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.horizontalToolStripMenuItem.Text = "horizontal";
            this.horizontalToolStripMenuItem.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // arrangeToolStripMenuItem
            // 
            this.arrangeToolStripMenuItem.Name = "arrangeToolStripMenuItem";
            this.arrangeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arrangeToolStripMenuItem.Text = "arrange";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pythonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 한국ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 미국ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 일본ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 정령ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


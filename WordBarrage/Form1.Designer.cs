namespace WordBarrage
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyinonMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.随机顺序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.暂停ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.方向ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.向上滚动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.向下滚动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增大字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.减小字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.红色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.蓝色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放速度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.减小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.蓝紫色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.royalBlueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyinonMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifyinonMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "单词弹幕";
            this.notifyIcon1.Visible = true;
            // 
            // notifyinonMenu
            // 
            this.notifyinonMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出ToolStripMenuItem,
            this.随机顺序ToolStripMenuItem,
            this.暂停ToolStripMenuItem,
            this.方向ToolStripMenuItem,
            this.字体ToolStripMenuItem,
            this.播放速度ToolStripMenuItem});
            this.notifyinonMenu.Name = "notifyinonMenu";
            this.notifyinonMenu.Size = new System.Drawing.Size(181, 158);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 随机顺序ToolStripMenuItem
            // 
            this.随机顺序ToolStripMenuItem.Name = "随机顺序ToolStripMenuItem";
            this.随机顺序ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.随机顺序ToolStripMenuItem.Text = "随机顺序";
            this.随机顺序ToolStripMenuItem.Click += new System.EventHandler(this.随机顺序ToolStripMenuItem_Click);
            // 
            // 暂停ToolStripMenuItem
            // 
            this.暂停ToolStripMenuItem.CheckOnClick = true;
            this.暂停ToolStripMenuItem.Name = "暂停ToolStripMenuItem";
            this.暂停ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.暂停ToolStripMenuItem.Text = "暂停";
            this.暂停ToolStripMenuItem.Click += new System.EventHandler(this.暂停ToolStripMenuItem_Click);
            // 
            // 方向ToolStripMenuItem
            // 
            this.方向ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.向上滚动ToolStripMenuItem,
            this.向下滚动ToolStripMenuItem});
            this.方向ToolStripMenuItem.Name = "方向ToolStripMenuItem";
            this.方向ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.方向ToolStripMenuItem.Text = "方向";
            // 
            // 向上滚动ToolStripMenuItem
            // 
            this.向上滚动ToolStripMenuItem.Name = "向上滚动ToolStripMenuItem";
            this.向上滚动ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.向上滚动ToolStripMenuItem.Text = "向上滚动";
            this.向上滚动ToolStripMenuItem.Click += new System.EventHandler(this.向上滚动ToolStripMenuItem_Click);
            // 
            // 向下滚动ToolStripMenuItem
            // 
            this.向下滚动ToolStripMenuItem.Name = "向下滚动ToolStripMenuItem";
            this.向下滚动ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.向下滚动ToolStripMenuItem.Text = "向下滚动";
            this.向下滚动ToolStripMenuItem.Click += new System.EventHandler(this.向下滚动ToolStripMenuItem_Click);
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增大字体ToolStripMenuItem,
            this.减小字体ToolStripMenuItem,
            this.字体颜色ToolStripMenuItem});
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.字体ToolStripMenuItem.Text = "字体";
            // 
            // 增大字体ToolStripMenuItem
            // 
            this.增大字体ToolStripMenuItem.Name = "增大字体ToolStripMenuItem";
            this.增大字体ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.增大字体ToolStripMenuItem.Text = "增大字体";
            this.增大字体ToolStripMenuItem.Click += new System.EventHandler(this.增大字体ToolStripMenuItem_Click);
            // 
            // 减小字体ToolStripMenuItem
            // 
            this.减小字体ToolStripMenuItem.Name = "减小字体ToolStripMenuItem";
            this.减小字体ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.减小字体ToolStripMenuItem.Text = "减小字体";
            this.减小字体ToolStripMenuItem.Click += new System.EventHandler(this.减小字体ToolStripMenuItem_Click);
            // 
            // 字体颜色ToolStripMenuItem
            // 
            this.字体颜色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.红色ToolStripMenuItem,
            this.蓝色ToolStripMenuItem,
            this.黑色ToolStripMenuItem,
            this.蓝紫色ToolStripMenuItem,
            this.royalBlueToolStripMenuItem});
            this.字体颜色ToolStripMenuItem.Name = "字体颜色ToolStripMenuItem";
            this.字体颜色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.字体颜色ToolStripMenuItem.Text = "字体颜色";
            // 
            // 红色ToolStripMenuItem
            // 
            this.红色ToolStripMenuItem.Name = "红色ToolStripMenuItem";
            this.红色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.红色ToolStripMenuItem.Text = "红色";
            this.红色ToolStripMenuItem.Click += new System.EventHandler(this.红色ToolStripMenuItem_Click);
            // 
            // 蓝色ToolStripMenuItem
            // 
            this.蓝色ToolStripMenuItem.Name = "蓝色ToolStripMenuItem";
            this.蓝色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.蓝色ToolStripMenuItem.Text = "蓝色";
            this.蓝色ToolStripMenuItem.Click += new System.EventHandler(this.蓝色ToolStripMenuItem_Click);
            // 
            // 黑色ToolStripMenuItem
            // 
            this.黑色ToolStripMenuItem.Name = "黑色ToolStripMenuItem";
            this.黑色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.黑色ToolStripMenuItem.Text = "黑色";
            this.黑色ToolStripMenuItem.Click += new System.EventHandler(this.黑色ToolStripMenuItem_Click);
            // 
            // 播放速度ToolStripMenuItem
            // 
            this.播放速度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem,
            this.减小ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.播放速度ToolStripMenuItem.Name = "播放速度ToolStripMenuItem";
            this.播放速度ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.播放速度ToolStripMenuItem.Text = "播放速度";
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.增加ToolStripMenuItem.Text = "1";
            this.增加ToolStripMenuItem.Click += new System.EventHandler(this.增加ToolStripMenuItem_Click);
            // 
            // 减小ToolStripMenuItem
            // 
            this.减小ToolStripMenuItem.Name = "减小ToolStripMenuItem";
            this.减小ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.减小ToolStripMenuItem.Text = "2";
            this.减小ToolStripMenuItem.Click += new System.EventHandler(this.减小ToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "3";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // 蓝紫色ToolStripMenuItem
            // 
            this.蓝紫色ToolStripMenuItem.Name = "蓝紫色ToolStripMenuItem";
            this.蓝紫色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.蓝紫色ToolStripMenuItem.Text = "蓝紫色";
            this.蓝紫色ToolStripMenuItem.Click += new System.EventHandler(this.蓝紫色ToolStripMenuItem_Click);
            // 
            // royalBlueToolStripMenuItem
            // 
            this.royalBlueToolStripMenuItem.Name = "royalBlueToolStripMenuItem";
            this.royalBlueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.royalBlueToolStripMenuItem.Text = "RoyalBlue";
            this.royalBlueToolStripMenuItem.Click += new System.EventHandler(this.RoyalBlueToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.notifyinonMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip notifyinonMenu;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem 随机顺序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 暂停ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 方向ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向上滚动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 向下滚动ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增大字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 减小字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 红色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 蓝色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放速度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 减小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 蓝紫色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem royalBlueToolStripMenuItem;
    }
}


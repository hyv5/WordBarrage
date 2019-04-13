using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordBarrage
{
    public partial class Form1 : Form
    {
        List<Label> wordLabels;
        Label initLabel;
        int wordindex = 0;
        List<String> wordlist = new List<string>();
        int fontSize = 12;
        Color color = Color.Red;
        int speed = 1;
        int direction =-1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Rectangle rec = Screen.GetWorkingArea(this);
            this.Height = rec.Height;
            this.Width = rec.Width / 6;
            this.Location = new Point(rec.Width-Width,0);
            this.BackColor = Color.White;
            this.TransparencyKey = Color.White;
            this.Opacity = 1;
            wordLabels = new List<Label>();
            Assembly myAssem = Assembly.GetEntryAssembly();
            Stream stream = myAssem.GetManifestResourceStream("WordBarrage.words.txt");
            System.IO.StreamReader sr = new System.IO.StreamReader(stream);
            while (!sr.EndOfStream) {
                wordlist.Add(sr.ReadLine());
            }
            initLabel = CreateWord("初始化完毕，运行开始");

        }
        
        private Label CreateWord(String word) {
            Label test = new Label();
            if (direction == -1)
            {
                test.Location = new Point(0, Height+ fontSize);
            }
            else {
                test.Location = new Point(0, -fontSize);
            }
            test.Text = word;
            test.Width = Width-1;
            test.Visible = true;
            test.ForeColor = color;
            test.BackColor = Color.White;
            test.Font = new Font("宋体", fontSize, FontStyle.Bold);
            Controls.Add(test);
            wordLabels.Add(test);
            return test;
        }
    

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
            Application.Exit();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int lastY = this.Height;
            var size = wordLabels.Count;
            for (var i = 0; i < size; i++) {
                Label label = wordLabels[i];
                Point point = label.Location;
                point.Y = point.Y + direction * speed;
                if (point.Y < -5* fontSize || point.Y > Height + 5* fontSize)
                {
                    label.Visible = false;
                    wordLabels.Remove(label);
                    size--;
                    Controls.Remove(label);
                }
                else
                {
                    lastY = point.Y;
                    label.Location = point;
                }
            }
            if (direction==-1&&(this.Height - lastY > fontSize)) {
                if (wordindex == wordlist.Count) {
                    wordindex = 0;
                }
                String word = wordlist[wordindex++];
                CreateWord(word);
            }else
            if (direction == 1 && (lastY > fontSize))
            {
                if (wordindex == wordlist.Count)
                {
                    wordindex = 0;
                }
                String word = wordlist[wordindex++];
                CreateWord(word);
            }
        }

        private void 随机顺序ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            Random random = new Random();
            wordlist.Sort((e1, e2) => random.Next(-1,2));
            timer.Start();
        }

        private void 暂停ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var check = (sender as ToolStripMenuItem).Checked;
            if (check)
            {
                timer.Stop();
            }
            else {
                timer.Start();
            }
        }

        private void 向上滚动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            wordindex = 0;
            wordLabels = new List<Label>();
            direction = -1;
        }

        private void 向下滚动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            wordindex = 0;
            wordLabels = new List<Label>();
            direction = 1;
        }

        private void 增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed = 1;
        }

        private void 减小ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            speed = 2;
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            speed = 3;
        }

        private void 增大字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontSize++;
        }

        private void 减小字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontSize--;
        }

        private void 红色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Red;
        }

        private void 蓝色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Blue;
        }

        private void 黑色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.Black;
            
        }

        private void 蓝紫色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.BlueViolet;
            
        }

        private void RoyalBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            color = Color.RoyalBlue;
        }
    }
}

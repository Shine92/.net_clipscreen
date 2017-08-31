using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test0831_clip {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private string lastString = "";  //儲值
        private void button1_Click(object sender, EventArgs e) {
            //測試用            
        }

        private void timer1_Tick(object sender, EventArgs e) {
            string s = Clipboard.GetText();  //取得剪貼簿的文字
            if (s != lastString) {  //如果新值不等於就值
                textBox1.Text += s + System.Environment.NewLine;
                lastString = s; //新值儲值
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            timer1.Enabled = (checkBox1.Checked) ? true : false; //方法2
            //if (checkBox1.Checked) {
            //    timer1.Enabled = true;
            //}else {
            //    timer1.Enabled = false;
            //}
        }
    }
}

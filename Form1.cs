using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobile
{
    public partial class Form1 : Form
    {
        int ml_seconds_to_press = 500;
        DateTime last_press;
        string last_pressed = "";
        int last_char_from_sequence = 0;
        suggestor st = new suggestor();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Actions(object sender, EventArgs e)
        {
            if (sender == btn_0)
            {
                tb_WriteHere.Text += " ";
            }
            else if (sender == btn_1   || sender == btn_2 
                    || sender == btn_3 || sender == btn_4 
                    || sender == btn_5 || sender == btn_6 
                    || sender == btn_7 || sender == btn_8 
                    || sender == btn_9)
            {
                var sndr = (sender as Button);
                WriteTextWithButton(sndr);
                SearchWords();
            }
            else if (sender == btn_Add)
            {
                var idx = tb_WriteHere.Text.LastIndexOf(" ");
                idx = (idx == -1 ? 0 : idx + 1);

                var word = tb_WriteHere.Text.Substring(idx);

                if(word.Length > 0)
                    st.Add(word);
            }
            else if (sender == btn_Erase)
            {
                if (tb_WriteHere.SelectedText.Length > 0)
                    tb_WriteHere.Text = tb_WriteHere.Text.Replace(tb_WriteHere.SelectedText, "");
                else if (tb_WriteHere.Text.Length > 0)
                    tb_WriteHere.Text = tb_WriteHere.Text.Remove(tb_WriteHere.Text.Length - 1);
            }
            else if (sender == btn_up)
            {
                var ss = tb_WriteHere.SelectionStart;
                var line = tb_WriteHere.GetLineFromCharIndex(ss);
                if (line > 0)
                    tb_WriteHere.SelectionStart = ss - tb_WriteHere.Lines[line].Count();
            }
            else if (sender == btn_down)
            {
                var ss = tb_WriteHere.SelectionStart;
                var line = tb_WriteHere.GetLineFromCharIndex(ss);
                if (line < tb_WriteHere.Lines.Count())
                    tb_WriteHere.SelectionStart = ss - tb_WriteHere.Lines[line].Count();
            }
            else if (sender == btn_left)
            {
                if(tb_WriteHere.SelectionStart > 0)
                    tb_WriteHere.SelectionStart--;
            }
            else if (sender == btn_right)
            {
                if (tb_WriteHere.SelectionStart < tb_WriteHere.Text.Length)
                    tb_WriteHere.SelectionStart++;
            }
            else if (sender == btn_sharp)
            {
                tb_WriteHere.Text += "#";
            }
            else if (sender == btn_star)
            {
                tb_WriteHere.Text += "*";
            }
            else if (sender == btn_fw || sender == btn_sw || sender == btn_tw)
            {
                var idx = tb_WriteHere.Text.LastIndexOf(" ");
                idx = (idx == -1 ? 0 : idx + 1);

                var words = tb_WriteHere.Text.Substring(0, idx);

                tb_WriteHere.Text = words + (sender as Button).Text;
            }
        }

        private void SearchWords()
        {
            Thread th = new Thread(Thrd);
            th.Start();
        }

        void Thrd()
        {
            lock (st)
            {
                int idx = 0;
                string word = "";
                MethodInvoker inv = delegate
                {
                    idx = tb_WriteHere.Text.LastIndexOf(" ");
                    idx = (idx == -1 ? 0 : idx + 1);
                    word = tb_WriteHere.Text.Substring(idx);
                };
                this.Invoke(inv);

                string[] res = st.search(word.ToLower());

                inv = delegate
                {
                    btn_fw.Text = res[0].ToUpper();
                    btn_sw.Text = res[1].ToUpper();
                    btn_tw.Text = res[2].ToUpper();
                };
                this.Invoke(inv);
            }
        }

        private void WriteTextWithButton(Button sndr)
        {
            if ((DateTime.Now - last_press).TotalMilliseconds < ml_seconds_to_press
                &&
                last_pressed == sndr.Name)
            {
                tb_WriteHere.Text = tb_WriteHere.Text.Remove(tb_WriteHere.Text.Length - 1);

                string result = Regex.Replace(sndr.Text, @"\r\n?|\n", "");

                if (last_char_from_sequence > result.Length - 1)
                    last_char_from_sequence = 0;

                tb_WriteHere.Text += result[last_char_from_sequence].ToString();

                last_char_from_sequence++;
                last_pressed = sndr.Name;
                last_press = DateTime.Now;
            }
            else
            {
                last_char_from_sequence = 0;

                tb_WriteHere.Text += sndr.Text[last_char_from_sequence].ToString();
                last_char_from_sequence++;
                last_pressed = sndr.Name;
                last_press = DateTime.Now;
            }
        }

        private void Form1_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0)
            {
                btn_Actions(btn_0, null);
            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                btn_Actions(btn_1, null);
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                btn_Actions(btn_2, null);
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                btn_Actions(btn_3, null);
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                btn_Actions(btn_4, null);
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                btn_Actions(btn_5, null);
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                btn_Actions(btn_6, null);
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                btn_Actions(btn_7, null);
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                btn_Actions(btn_8, null);
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                btn_Actions(btn_9, null);
            }
        }
    }
}

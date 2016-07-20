using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckedListBox
{
    public partial class Form1 : Form
    {
        static bool isStarted;
        public Form1()
        {
            InitializeComponent();
            String[] myCheckList1 = new String[] { "bit 1", "bit 2", "bit 3" };
            checkedListBox1.Items.AddRange(myCheckList1); // add list to checkedListBox1
            checkedListBox1.CheckOnClick = true; // one click
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isStarted)
            {
                btnStart.Text = "STOP";
                isStarted = true;
                timer1.Start();
            }
            else
            {
                btnStart.Text = "START";
                isStarted = false;
                timer1.Stop();
                foreach (Int32 i in checkedListBox1.CheckedIndices)
                {
                    checkedListBox1.SetItemChecked(i, false);
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkedListBox1.SetItemChecked(0, true);
            }
            else
            {
                checkedListBox1.SetItemChecked(0, false);
            }
            if (checkBox2.Checked)
            {
                checkedListBox1.SetItemChecked(1, true);
            }
            else
            {
                checkedListBox1.SetItemChecked(1, false);
            }
            if (checkBox3.Checked)
            {
                checkedListBox1.SetItemChecked(2, true);
            }
            else
            {
                checkedListBox1.SetItemChecked(2, false);
            }
        }
    }
}

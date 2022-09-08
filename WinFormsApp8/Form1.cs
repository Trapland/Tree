using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add((treeView1.Nodes.Count + 1).ToString() + ". " + textBox1.Text);
            treeView1.Nodes.Add((treeView1.Nodes.Count + 1).ToString() + ". " + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                if (treeView1.Nodes[i].Text == comboBox1.SelectedItem.ToString())
                {
                    comboBox2.Items.Add((treeView1.Nodes.Count).ToString() + "." + (treeView1.Nodes[i].Nodes.Count + 1).ToString() + ". " + textBox2.Text);
                    treeView1.Nodes[i].Nodes.Add((treeView1.Nodes.Count).ToString() + "." + (treeView1.Nodes[i].Nodes.Count + 1).ToString() + ". " + textBox2.Text);
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < treeView1.Nodes.Count; i++)
            {
                if (treeView1.Nodes[i].Text == comboBox1.SelectedItem.ToString())
                {
                    for (int j = 0; j < treeView1.Nodes[i].Nodes.Count; j++)
                    {
                        if (treeView1.Nodes[i].Nodes[j].Text == comboBox2.SelectedItem.ToString())
                        {
                            treeView1.Nodes[i].Nodes[j].Nodes.Add((treeView1.Nodes.Count).ToString() + "." + (treeView1.Nodes[i].Nodes.Count).ToString() + "." + (treeView1.Nodes[i].Nodes[j].Nodes.Count + 1).ToString() + ". " + textBox3.Text);
                            break;
                        }
                    }
                    break;
                }
            }
        }
    }
}

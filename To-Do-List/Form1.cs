using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void AddTask()
        {
            if (TxtTaskName.Text == "")
            {
                chkListTask.Items.Add(TxtTaskName.Text = "Task"); 
            }

            else
            {
                chkListTask.Items.Add(TxtTaskName.Text);
            }
            TxtTaskName.Clear();
        }
        private void ReseteTask()
        {
            lblComleted.Text = "0";
            lblPanding.Text = "0";
            chkListTask.Items.Clear();

        }
        private void CompletedTask()
        {
           
       
            short completed = 0;
            short pending = 0;

            // المرور على كل العناصر في CheckedListBox
            for (int i = 0; i < chkListTask.Items.Count; i++)
            {
                if (chkListTask.GetItemChecked(i))
                {
                    completed++; // المهمة منجزة
                }
                else
                {
                    pending++;   // المهمة معلقة
                }
            } 

            lblComleted.Text = completed.ToString();
            lblPanding.Text = pending.ToString();
        }
        private void RemoveTasks()
        {
            if (chkListTask.SelectedIndex != -1)
            {
                chkListTask.Items.RemoveAt(chkListTask.SelectedIndex);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

       

        

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            AddTask();
            CompletedTask();
        }

        private void btnRemoveTask_Click(object sender, EventArgs e)
        {
            RemoveTasks();
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            ReseteTask();
           
        }

        private void chkListTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompletedTask();
        }
    }
}

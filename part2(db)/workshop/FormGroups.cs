using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class FormGroups : Form
    {
        public FormGroups()
        {
            InitializeComponent();
        }

        private void FormGroups_Load(object sender, EventArgs e)
        {
            buttonList_Click(sender, e);
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DB dB = new DB();
            listBox1.Items.AddRange(dB.Groups.ToArray());
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormGroupView formGroupView = new FormGroupView();
            if (formGroupView.ShowDialog() == DialogResult.OK)
            {
                Group group = new Group();
                group.Groupname = formGroupView.textBox2.Text;
                DB db = new DB();
                db.Groups.Add(group);
                db.SaveChanges();
                buttonList_Click(sender, e);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
                FormGroupView formGroupView = new FormGroupView();
                Group group = listBox1.SelectedItem as Group;
                formGroupView.textBox1.Text = group.GroupId.ToString();
                formGroupView.textBox2.Text = group.Groupname;
                if (formGroupView.ShowDialog() == DialogResult.OK)
                {
                    DB db = new DB();
                    group = db.Groups.Find(group.GroupId);
                    db.Groups.Remove(group);
                    db.SaveChanges();
                    buttonList_Click(sender, e);
                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                FormGroupView formGroupView = new FormGroupView();
                Group group = listBox1.SelectedItem as Group;
                formGroupView.textBox1.Text = group.GroupId.ToString();
                formGroupView.textBox2.Text = group.Groupname;
                if (formGroupView.ShowDialog() == DialogResult.OK)
                {
                    DB db = new DB();
                    group = db.Groups.Find(group.GroupId);
                    group.Groupname = formGroupView.textBox2.Text;
                    db.SaveChanges();
                    buttonList_Click(sender, e);
                }
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                FormGroupView formGroupView = new FormGroupView();
                Group group = listBox1.SelectedItem as Group;
                formGroupView.textBox1.Text = group.GroupId.ToString();
                formGroupView.textBox2.Text = group.Groupname;
                if (formGroupView.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }
    }
}

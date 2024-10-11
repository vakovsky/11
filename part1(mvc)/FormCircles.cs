using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCircles : Form
    {
        public FormCircles()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            FormCircleView formCircleView = new FormCircleView();
            formCircleView.ShowDialog();
            circle.R = int.Parse(formCircleView.textBoxR.Text);
            listBox1.Items.Add(circle);
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;
                Circle circle = listBox1.Items[index] as Circle;
                FormCircleView formCircleView = new FormCircleView();
                formCircleView.textBoxR.Text = circle.R.ToString();
                formCircleView.textBoxArea.Text = circle.Area.ToString();
                formCircleView.ShowDialog();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;
                Circle circle = listBox1.Items[index] as Circle;
                FormCircleView formCircleView = new FormCircleView();
                formCircleView.textBoxR.Text = circle.R.ToString();
                formCircleView.textBoxArea.Text = circle.Area.ToString();
                if (formCircleView.ShowDialog() == DialogResult.OK)
                {
                    circle.R = int.Parse(formCircleView.textBoxR.Text);
                    listBox1.Items[index] = circle;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                int index = listBox1.SelectedIndex;
                Circle circle = listBox1.Items[index] as Circle;
                FormCircleView formCircleView = new FormCircleView();
                formCircleView.textBoxR.Text = circle.R.ToString();
                formCircleView.textBoxArea.Text = circle.Area.ToString();
                formCircleView.ShowDialog();
                listBox1.Items.RemoveAt(index);
            }
        }
    }
}

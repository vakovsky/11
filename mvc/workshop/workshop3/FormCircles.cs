using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClassLibrary1;

using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class FormCircles : Form
    {
        public FormCircles()
        {
            InitializeComponent();
        }

        private void FormCircles_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCircleView formCircleView = new FormCircleView();
            formCircleView.Text = formCircleView.Text + "(Create)";
            if (formCircleView.ShowDialog() == DialogResult.OK)
            {
                Circle circle = new Circle();
                circle.R = int.Parse(formCircleView.textBox1.Text);
                listBox1.Items.Add(circle);
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                Circle circle = listBox1.Items[index] as Circle;
                FormCircleView formCircleView = new FormCircleView();
                formCircleView.Text = formCircleView.Text + "(Read)";
                formCircleView.textBox1.Text = circle.R.ToString();
                if (formCircleView.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                Circle circle = listBox1.Items[index] as Circle;
                FormCircleView formCircleView = new FormCircleView();
                formCircleView.Text = formCircleView.Text + "(Update)";
                formCircleView.textBox1.Text = circle.R.ToString();
                if (formCircleView.ShowDialog() == DialogResult.OK)
                {
                    circle.R = int.Parse(formCircleView.textBox1.Text);
                    listBox1.Items[index] = circle;
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                Circle circle = listBox1.Items[index] as Circle;
                FormCircleView formCircleView = new FormCircleView();
                formCircleView.Text = formCircleView.Text + "(Delete)";
                formCircleView.textBox1.Text = circle.R.ToString();
                if (formCircleView.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(index);
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Circle
            {
                Id = 1,
                R = 10,
            };
            Circle circle = new Circle { Id = 1, R = 10 };
            List<Circle> circles = new List<Circle>
            {
                new Circle
                {
                    Id = 1,
                    R = 10,
                },
                new Circle
                {
                    Id = 2,
                    R = 23,
                },
            };
            Circle[] circles2 = new[]
            {
                new Circle
                {
                    Id = 3,
                    R = 50,
                },
                new Circle
                {
                    Id = 4,
                    R = 83,
                },
            };
            listBox1.Items.AddRange(circles.ToArray());
            listBox1.Items.AddRange(circles2);
        }

        private void buttonSaveJSON_Click(object sender, EventArgs e)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(listBox1.Items, options);
            File.WriteAllText("json.txt", json);
        }

        private void buttonLoadJSON_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText("json.txt");
            Circle[] circles = JsonSerializer.Deserialize(json, typeof(Circle[])) as Circle[];
            listBox1.Items.AddRange(circles.ToArray());
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Circle[]));
            StreamWriter streamWriter = new StreamWriter("xml.xml");
            Circle[] circles = listBox1.Items.Cast<Circle>().ToArray();
            xmlSerializer.Serialize(streamWriter, c);
            streamWriter.Close();
        }

        private void buttonLoadXML_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Circle[]));
            StreamReader streamReader = new StreamReader("test.txt");
            Circle[] circles = xmlSerializer.Deserialize(streamReader) as Circle[];
            listBox1.Items.AddRange(circles.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("test.txt", "Hello");
        }
    }
}

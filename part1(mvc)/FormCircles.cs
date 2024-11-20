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

using System.Text.Json;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class FormCircles : System.Windows.Forms.Form
    {
        public FormCircles()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle();
            FormCircleView formCircleView = new FormCircleView();
            if (formCircleView.ShowDialog() == DialogResult.OK)
            {
                circle.R = int.Parse(formCircleView.textBoxR.Text);
                listBox1.Items.Add(circle);
            }
            else
            {

            }
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
                if (listBox1.Items[index] is Circle)
                {
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
                if (formCircleView.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.RemoveAt(index);
                }
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            buttonRead_Click(sender, e);
        }
        //Export as JSON
        private void buttonSaveJSON_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "circles.json";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(listBox1.Items, options);
                File.WriteAllText(saveFileDialog1.FileName, json);
            }
        }
        //Import as JSON
        private void buttonLoadJSON_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.FileName = "circles.json";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string json = File.ReadAllText(openFileDialog1.FileName);
                Circle[] circles = JsonSerializer.Deserialize(json, typeof(Circle[])) as Circle[];
                listBox1.Items.AddRange(circles);
            }
        }
        //Export as XML
        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Circle[]));
            StreamWriter streamWriter = new StreamWriter("circles.xml");
            Circle[] circles = listBox1.Items.Cast<Circle>().ToArray();
            xmlSerializer.Serialize(streamWriter, circles);
            streamWriter.Close();
        }
        //Import as XML
        private void buttonLoadXML_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Circle[]));
            StreamReader streamReader = new StreamReader("circles.xml");
            Circle[] circles = xmlSerializer.Deserialize(streamReader) as Circle[];
            listBox1.Items.AddRange(circles);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle { R = 15 };
            List<Circle> circlesList = new List<Circle>
            {
                new Circle
                {
                    R = 10,
                },
                new Circle
                {
                    R = 23,
                },
                circle
            };
            Circle[] circlesArray = new[]
            {
                new Circle
                {
                      R = 50,
                },
                new Circle
                {
                    R = 83,
                },
            };
            listBox1.Items.AddRange(circlesList.ToArray());
            listBox1.Items.AddRange(circlesArray);
            listBox1.Items.Add(new Circle { R = 34 });
        }
    }
}

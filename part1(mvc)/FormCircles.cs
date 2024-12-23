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

using System.Data.OleDb;
using System.Data.SqlClient;

using System.Data.Entity;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp5
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
                formCircleView.textBoxPerimeter.Text = circle.Perimeter.ToString();
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
                    formCircleView.textBoxPerimeter.Text = circle.Perimeter.ToString();
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
                formCircleView.textBoxPerimeter.Text = circle.Perimeter.ToString();
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

        private void buttonSaveJSON_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "circles.json";
            saveFileDialog1.DefaultExt = "json";
            saveFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(listBox1.Items, options);
                File.WriteAllText(saveFileDialog1.FileName, json);
            }
        }

        private void buttonLoadJSON_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.FileName = "circles.json";
            openFileDialog1.DefaultExt = "json";
            openFileDialog1.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string json = File.ReadAllText(openFileDialog1.FileName);
                Circle[] circles = JsonSerializer.Deserialize(json, typeof(Circle[])) as Circle[];
                listBox1.Items.AddRange(circles);
            }
        }

        private void buttonSaveXML_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "circles.xml";
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Circle[]));
                StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName);
                Circle[] circles = listBox1.Items.Cast<Circle>().ToArray();
                xmlSerializer.Serialize(streamWriter, circles);
                streamWriter.Close();
            }
        }

        private void buttonLoadXML_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.FileName = "circles.xml";
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Circle[]));
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                Circle[] circles = xmlSerializer.Deserialize(streamReader) as Circle[];
                listBox1.Items.AddRange(circles);
            }
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

        private void buttonSaveAccessDB_Click(object sender, EventArgs e)
        {
            OleDbConnection oleDbConnection = new OleDbConnection();
            oleDbConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Student\source\repos\SolutionPSD\DatabasePSD.accdb";
            oleDbConnection.Open();
            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.Connection = oleDbConnection;
            foreach (Circle circle in listBox1.Items.Cast<Circle>())
            {
                oleDbCommand.CommandText = string.Format(
                    "INSERT INTO Circles ([R])" +
                    "VALUES('{0}')",
                    circle.R
                    );
                oleDbCommand.ExecuteNonQuery();
            }
            oleDbConnection.Close();
        }

        private void buttonLoadAccessDB_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            OleDbConnection oleDbConnection = new OleDbConnection();
            oleDbConnection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Student\source\repos\SolutionPSD\DatabasePSD.accdb";
            oleDbConnection.Open();
            OleDbCommand oleDbCommand = new OleDbCommand();
            oleDbCommand.Connection = oleDbConnection;
            oleDbCommand.CommandText = string.Format(
                "SELECT * FROM Circles;"
                );
            OleDbDataReader oleDbDataReader = oleDbCommand.ExecuteReader();
            while (oleDbDataReader.Read())
            {
                Circle circle = new Circle();
                circle.R = Convert.ToInt32(oleDbDataReader["R"]);
                circle.ID = Convert.ToInt32(oleDbDataReader["ID"]);
                listBox1.Items.Add(circle);
            }
            oleDbDataReader.Close();
            oleDbConnection.Close();
        }

        private void buttonSaveMSSQLDB_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User3\Desktop\Solution13\Solution13\DatabasePSD.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            foreach (Circle circle in listBox1.Items.Cast<Circle>())
            {
                sqlCommand.CommandText = string.Format(
                    "INSERT INTO Circles ([R])" +
                    "VALUES('{0}')",
                    circle.R
                    );
                sqlCommand.ExecuteNonQuery();
            }
            sqlConnection.Close();
        }

        private void buttonLoadMSSQLDB_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User3\Desktop\Solution13\Solution13\DatabasePSD.mdf;Integrated Security=True;Connect Timeout=30";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = string.Format(
                "SELECT * FROM Circles;"
                );
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Circle circle = new Circle();
                circle.ID = Convert.ToInt32(sqlDataReader["ID"]);
                circle.R = Convert.ToInt32(sqlDataReader["R"]);
                listBox1.Items.Add(circle);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
        }

        private void buttonLoadCSV_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.FileName = "circles.csv";
            openFileDialog1.DefaultExt = "csv";
            openFileDialog1.Filter = "Character-separated values files (*.csv)|*.csv|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                foreach (string line in lines)
                {
                    string[] fields = line.Split(':');
                    Circle circle = new Circle
                    {
                        ID = Convert.ToInt32(fields[0]),
                        R = Convert.ToInt32(fields[1]),
                    };
                    listBox1.Items.Add(circle);
                }
            }
        }

        private void buttonSaveCSV_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Application.StartupPath;
            saveFileDialog1.FileName = "circles.csv";
            saveFileDialog1.DefaultExt = "csv";
            saveFileDialog1.Filter = "Character-separated values files (*.csv)|*.csv|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<string> lines = new List<string>();
                foreach (Circle circle in listBox1.Items.Cast<Circle>())
                {
                    lines.Add(string.Format("{0}:{1}", circle.ID, circle.R));
                }
                File.WriteAllLines(saveFileDialog1.FileName, lines);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void buttonLoadMSSQLDBContext_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (DataBaseContext db = new DataBaseContext())
            {
                List<Circle> circles = (
                    from c in db.Circles
                    orderby c.ID
                    select c
                ).ToList();
                listBox1.Items.AddRange(circles.ToArray());
            }
        }

        private void buttonSaveMSSQLDBContext_Click(object sender, EventArgs e)
        {
            using (DataBaseContext db = new DataBaseContext())
            {
                foreach (var circle in listBox1.Items.Cast<Circle>())
                {
                    db.Circles.Add(circle);
                }
                db.SaveChanges();
            }
        }

        public class DataBaseContext : DbContext
        {
            public DataBaseContext() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User3\Desktop\Solution13\Solution13\DatabasePSD.mdf;Integrated Security=True;Connect Timeout=30") { }
            public DbSet<Circle> Circles { get; set; }
        }

    }
}

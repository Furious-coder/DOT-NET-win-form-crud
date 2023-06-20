using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using System.Xml.Linq;

namespace library
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = new MySqlConnection("SERVER=127.0.0.1;DATABASE=library;UID=root;PASSWORD=1234;");
        



        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            // conn.Open();
            //  try
            //  {
            //MySqlDataAdapter da = new MySqlDataAdapter("insert into info(Name,ID,Book)values('" + n.Text + "'," + i.Text + ",'" + b.Text + "')", conn);
            //DataSet ds = new DataSet();
            //da.Fill(ds);

            //String query = "insert into info(Name,ID,Book)values(@val1,@val2,@val3)";
            //MySqlCommand command = new MySqlCommand(query, conn);
            //command.Parameters.AddWithValue("@val1", n.Text);
            // command.Parameters.AddWithValue("@val2", int.Parse(i.Text));
            // command.Parameters.AddWithValue("@val3", b.Text);
            // command.ExecuteNonQuery();
            // n.Text = "";
            // i.Text = "";
            // b.Text = "";


            // }
            // catch (Exception ex)
            // {
            //      MessageBox.Show("Please enter a valid input");
            // }

            //conn.Close();

            

        }

        private void view_Click(object sender, EventArgs e)
        {

            click();
        }

        void click()
        {
            //conn.Open();

            //string query = "SELECT * FROM info";

            //MySqlCommand command = new MySqlCommand(query, conn);
            //
            //MySqlDataReader reader = command.ExecuteReader();

            //DataTable dataTable = new DataTable();
            //dataTable.Load(reader);

            //grid.DataSource = dataTable;
            //conn.Close();
            List<Entry> entries = GetEntries();

            string name = n.Text;
            string id = i.Text;
            string book = b.Text;

           // Entry newEntry = new Entry { name = name, id =id, book=book};

           // entries.Add(newEntry);
            grid.DataSource = entries;

        
            i.Text = string.Empty;
            b.Text = string.Empty;
            n.Text = string.Empty;
        }


        private void delete_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string query = "delete from info where ID=@value";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@value", i.Text);
                command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid input");
            }
            n.Text = "";
            i.Text = "";
            b.Text = "";
            conn.Close();
            click();
        }

        private void update_Click(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                string query = "update info set Name=@val1, Book=@val2 where ID=@id";
                MySqlCommand command = new MySqlCommand(query, conn);
                command.Parameters.AddWithValue("@val1", n.Text);
                command.Parameters.AddWithValue("@val2", b.Text);
                command.Parameters.AddWithValue("@id", int.Parse(i.Text));
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid input");
            }
            n.Text = "";
            i.Text = "";
            b.Text = "";
            conn.Close();
            click();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string query = "delete from info";
            MySqlCommand command = new MySqlCommand( query, conn);
            command.ExecuteNonQuery();
            conn.Close();
            click();
        }
        public class Entry
        {
            public string id { get; set; }
            public string name { get; set; }
            public string book { get; set; }
        }
        private List<Entry>  GetEntries()
        {
           List<Entry> entries = new List<Entry>();
//entries.Add(new Entry { id = i.Text });
           // entries.Add(new Entry {  name = n.Text });
           // entries.Add(new Entry { book = b.Text });
           // return entries;
//


            Entry entry = new Entry();
            entry.id = i.Text;
            entry.book = b.Text;
            entry.name = n.Text;
            entries.Add(entry);
            return entries;
          

        }

    }
}

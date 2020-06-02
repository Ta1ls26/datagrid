using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace gr
{
    public partial class Form1 : Form
    {
        public string CmdText = "SELECT * FROM [Customers]";
        public string ConnString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\acer\\source\\repos\\gr\\databd.mdb";
        public Form1()
        {
            InitializeComponent();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, @"Customers");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


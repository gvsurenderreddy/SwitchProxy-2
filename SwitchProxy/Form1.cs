using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchProxy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable proxyTable = createProxyTable();
            dataGridViewProxy.DataSource = proxyTable;
        }


        private DataTable createProxyTable()
        {
            DataTable proxyTable = new DataTable();
            proxyTable.Columns.Add("Active", typeof(bool));
            proxyTable.Columns.Add("Name", typeof(string));
            proxyTable.Columns.Add("Address", typeof(string));
            proxyTable.Columns.Add("Port", typeof(string));
            proxyTable.Columns.Add("Ignore local settings", typeof(bool));
            return proxyTable;
        }

    }
}

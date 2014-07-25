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
        private static int numberOfColumns = 5;
        private const String COLUMN_ACTIVE = "Active";
        private const String COLUMN_NAME = "Name";
        private const String COLUMN_ADDRESS = "Address";
        private const String COLUMN_PORT = "Port";
        private const String COLUMN_IGNORE_LOCAL_SETTINGS = "Ignore local settings";
        
        public Form1()
        {
            InitializeComponent();
            DataTable proxyTable = createProxyTable();
            dataGridViewProxy.DataSource = proxyTable;

            // Set rightmost column to fill -> prevents space
            dataGridViewProxy.Columns[numberOfColumns-1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private DataTable createProxyTable()
        {
            DataTable proxyTable = new DataTable();
            proxyTable.Columns.Add(COLUMN_ACTIVE, typeof(bool));
            proxyTable.Columns.Add(COLUMN_NAME, typeof(string));
            proxyTable.Columns.Add(COLUMN_ADDRESS, typeof(string));
            proxyTable.Columns.Add(COLUMN_PORT, typeof(string));
            proxyTable.Columns.Add(COLUMN_IGNORE_LOCAL_SETTINGS, typeof(bool));

            return proxyTable;
        }

    }
}

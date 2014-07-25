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
        private const String COLUMN_ACTIVE = "Active";
        private const String COLUMN_NAME = "Name";
        private const String COLUMN_ADDRESS = "Address";
        private const String COLUMN_PORT = "Port";
        private const String COLUMN_IGNORE_LOCAL_SETTINGS = "Ignore local settings";

        private static int numberOfColumns = 5;
        private static DataTable proxyTable;



        public Form1()
        {
            InitializeComponent();
            initializeDataGridView();
            addEmptyRowToDatatable();
            refreshDataGridView();
        }

        private void initializeDataGridView()
        {
            proxyTable = createProxyTable();
            refreshDataGridView();

            // Set rightmost column to fill -> prevents space
            dataGridViewProxy.Columns[COLUMN_IGNORE_LOCAL_SETTINGS].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProxy.Columns[COLUMN_ACTIVE].ReadOnly = true;
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

        private void addEmptyRowToDatatable()
        {
            DataRow row = proxyTable.NewRow();
            proxyTable.Rows.Add(row);
        }

        private void refreshDataGridView()
        {
            dataGridViewProxy.DataSource = proxyTable;
        }

        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            addEmptyRowToDatatable();
            refreshDataGridView();
        }

        private void buttonDeleteRows_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProxy.SelectedRows)
            {
                proxyTable.Rows.RemoveAt(row.Index);
            }
            refreshDataGridView();

        }

        private void buttonSetActive_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewProxy.Rows)
            {
                proxyTable.Rows[row.Index][COLUMN_ACTIVE] = false;
            }

            foreach (DataGridViewRow row in dataGridViewProxy.SelectedRows)
            {
                proxyTable.Rows[row.Index][COLUMN_ACTIVE] = true;
            }
            refreshDataGridView();
        }

    }
}

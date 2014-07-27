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
        // COLUMN NAMES        
        private const String COLUMN_ACTIVE = "Active";
        private const String COLUMN_NAME = "Name";
        private const String COLUMN_PROXY_ENABLED = "Proxy enabled";
        private const String COLUMN_ADDRESS = "Address";
        private const String COLUMN_PORT = "Port";
        private const String COLUMN_IGNORE_LOCAL_SETTINGS = "Ignore local settings";

        private static DataTable proxyTable;
        private const String tableName = "Proxy table";

        /// <summary>
        /// Program flow
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            initializeDataGridView();
            addEmptyRowToDatatable();
            refreshDataGridView();
        }

        /// <summary>
        /// Initializes the GridView by creating an empty DataTable, setting properties of certain columns
        /// and setting the DataTable to the GridView
        /// </summary>
        private void initializeDataGridView()
        {
            proxyTable = createProxyTable();
            refreshDataGridView();

            // Set rightmost column to fill -> prevents space
            dataGridViewProxy.Columns[COLUMN_IGNORE_LOCAL_SETTINGS].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewProxy.Columns[COLUMN_ACTIVE].ReadOnly = true;
        }

        /// <summary>
        /// Creates the empty DataTable
        /// </summary>
        /// <returns>An empty proxy DataTable</returns>
        private DataTable createProxyTable()
        {
            DataTable proxyTable = new DataTable();
            proxyTable.TableName = tableName;
            proxyTable.Columns.Add(COLUMN_ACTIVE, typeof(bool));
            proxyTable.Columns.Add(COLUMN_NAME, typeof(string));
            proxyTable.Columns.Add(COLUMN_PROXY_ENABLED, typeof(bool));
            proxyTable.Columns.Add(COLUMN_ADDRESS, typeof(string));
            proxyTable.Columns.Add(COLUMN_PORT, typeof(string));
            proxyTable.Columns.Add(COLUMN_IGNORE_LOCAL_SETTINGS, typeof(bool));

            return proxyTable;
        }

        /// <summary>
        /// Adds an empty row to the DataTable. Does not refresh the GridView display
        /// </summary>
        private void addEmptyRowToDatatable()
        {
            DataRow row = proxyTable.NewRow();

            // Initialize values
            row[COLUMN_ACTIVE] = false;
            row[COLUMN_NAME] = "";
            row[COLUMN_PROXY_ENABLED] = false;
            row[COLUMN_ADDRESS] = "";
            row[COLUMN_PORT] = "";
            row[COLUMN_IGNORE_LOCAL_SETTINGS] = false;

            proxyTable.Rows.Add(row);
        }

        /// <summary>
        /// Refreshes the GridView by assigning the current DataTable to it. Sets the StatusStrip
        /// to success afterwards
        /// </summary>
        private void refreshDataGridView()
        {
            dataGridViewProxy.DataSource = proxyTable;
            setStatusStripSuccessful();
        }

        /// <summary>
        /// Adds an empty row to the DataTable and refreshes the GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddRow_Click(object sender, EventArgs e)
        {
            addEmptyRowToDatatable();
            refreshDataGridView();
        }

        /// <summary>
        /// Deletes selected row from the proxy DataTable and refreshes the GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteRows_Click(object sender, EventArgs e)
        {
            int numberOfSelectedRows = dataGridViewProxy.SelectedRows.Count;
            foreach (DataGridViewRow row in dataGridViewProxy.SelectedRows)
            {
                proxyTable.Rows.RemoveAt(row.Index);
            }
            refreshDataGridView();
        }

        /// <summary>
        /// Sets the active flag only at selected lines of the GridView by updating the proxy DataTable and refreshing
        /// the GridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetActive_Click(object sender, EventArgs e)
        {
            // No row selected
            if (dataGridViewProxy.SelectedRows.Count == 0)
            {
                setStatusStrip(Color.Yellow, "Please select 1 row");
                return;
            }

            // More than one row selected
            if (dataGridViewProxy.SelectedRows.Count > 1)
            {
                setStatusStrip(Color.Yellow, "Please select 1 row");
                return;
            }

            foreach (DataGridViewRow row in dataGridViewProxy.Rows)
            {
                proxyTable.Rows[row.Index][COLUMN_ACTIVE] = false;
            }

            foreach (DataGridViewRow row in dataGridViewProxy.SelectedRows)
            {
                proxyTable.Rows[row.Index][COLUMN_ACTIVE] = true;
                updateProxySettings(proxyTable.Rows[row.Index]);
            }

            refreshDataGridView();
        }

        /// <summary>
        /// Updates the system proxy settings according to an entry in the DataTable by calling ProxyAccess
        /// </summary>
        /// <param name="dataRow">DataRow representing the selected DataGridViewRow</param>
        private void updateProxySettings(DataRow dataRow)
        {
            bool proxyEnabled = (bool)dataRow[COLUMN_PROXY_ENABLED];
            ProxyAccess.setProxy(proxyEnabled);

            String ip;
            String port;

            if (dataRow[COLUMN_ADDRESS] == DBNull.Value)
            {
                ip = "";
            }
            else
            {
                ip = (String)dataRow[COLUMN_ADDRESS];
            }

            if (dataRow[COLUMN_PORT] == DBNull.Value)
            {
                port = "";
            }
            else
            {
                port = (String)dataRow[COLUMN_PORT];
            }

            String ipAndPort;

            if (ip == "" || port == "")
            {
                ipAndPort = "";
            }
            else
            {
                ipAndPort = ip + ":" + port;
            }
            ProxyAccess.setIpAndPort(ipAndPort);

            bool ignoreLocalSettings = (bool)dataRow[COLUMN_IGNORE_LOCAL_SETTINGS];
            ProxyAccess.setIgnoreLocalSettings(ignoreLocalSettings);
        }

        /// <summary>
        /// Sets the content of the StatusStrip
        /// </summary>
        /// <param name="color">Color of color field</param>
        /// <param name="message">Message to display</param>
        private void setStatusStrip(Color color, String message)
        {
            toolStripStatusLabelColor.BackColor = color;
            toolStripStatusLabelMessage.Text = message;
        }

        /// <summary>
        /// Sets the StatusStrip to LightGreen and empty caption
        /// </summary>
        private void setStatusStripSuccessful()
        {
            setStatusStrip(Color.Green, "");
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            FileAccess.saveConfig(proxyTable);
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            proxyTable = FileAccess.loadConfig();
            refreshDataGridView();
        }

    }
}

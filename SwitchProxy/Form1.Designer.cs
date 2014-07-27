namespace SwitchProxy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewProxy = new System.Windows.Forms.DataGridView();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.buttonDeleteRows = new System.Windows.Forms.Button();
            this.buttonSetActive = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelColor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxy)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewProxy
            // 
            this.dataGridViewProxy.AllowUserToAddRows = false;
            this.dataGridViewProxy.AllowUserToDeleteRows = false;
            this.dataGridViewProxy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProxy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProxy.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewProxy.Name = "dataGridViewProxy";
            this.dataGridViewProxy.Size = new System.Drawing.Size(655, 220);
            this.dataGridViewProxy.TabIndex = 0;
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRow.Location = new System.Drawing.Point(592, 238);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRow.TabIndex = 1;
            this.buttonAddRow.Text = "+";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // buttonDeleteRows
            // 
            this.buttonDeleteRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteRows.Location = new System.Drawing.Point(511, 238);
            this.buttonDeleteRows.Name = "buttonDeleteRows";
            this.buttonDeleteRows.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRows.TabIndex = 2;
            this.buttonDeleteRows.Text = "-";
            this.buttonDeleteRows.UseVisualStyleBackColor = true;
            this.buttonDeleteRows.Click += new System.EventHandler(this.buttonDeleteRows_Click);
            // 
            // buttonSetActive
            // 
            this.buttonSetActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSetActive.Location = new System.Drawing.Point(430, 238);
            this.buttonSetActive.Name = "buttonSetActive";
            this.buttonSetActive.Size = new System.Drawing.Size(75, 23);
            this.buttonSetActive.TabIndex = 3;
            this.buttonSetActive.Text = "Set active";
            this.buttonSetActive.UseVisualStyleBackColor = true;
            this.buttonSetActive.Click += new System.EventHandler(this.buttonSetActive_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelColor,
            this.toolStripStatusLabelMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 272);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(679, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelColor
            // 
            this.toolStripStatusLabelColor.Name = "toolStripStatusLabelColor";
            this.toolStripStatusLabelColor.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabelColor.Text = "   ";
            // 
            // toolStripStatusLabelMessage
            // 
            this.toolStripStatusLabelMessage.Name = "toolStripStatusLabelMessage";
            this.toolStripStatusLabelMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Save config";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Load config";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 294);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonSetActive);
            this.Controls.Add(this.buttonDeleteRows);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.dataGridViewProxy);
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Text = "SwitchProxy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxy)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProxy;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.Button buttonDeleteRows;
        private System.Windows.Forms.Button buttonSetActive;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelColor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMessage;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
    }
}


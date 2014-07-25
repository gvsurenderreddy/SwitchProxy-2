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
            this.dataGridViewProxy = new System.Windows.Forms.DataGridView();
            this.buttonAddRow = new System.Windows.Forms.Button();
            this.buttonDeleteRows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxy)).BeginInit();
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
            this.dataGridViewProxy.Size = new System.Drawing.Size(546, 151);
            this.dataGridViewProxy.TabIndex = 0;
            // 
            // buttonAddRow
            // 
            this.buttonAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRow.Location = new System.Drawing.Point(483, 176);
            this.buttonAddRow.Name = "buttonAddRow";
            this.buttonAddRow.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRow.TabIndex = 1;
            this.buttonAddRow.Text = "+";
            this.buttonAddRow.UseVisualStyleBackColor = true;
            this.buttonAddRow.Click += new System.EventHandler(this.buttonAddRow_Click);
            // 
            // buttonDeleteRows
            // 
            this.buttonDeleteRows.Location = new System.Drawing.Point(402, 176);
            this.buttonDeleteRows.Name = "buttonDeleteRows";
            this.buttonDeleteRows.Size = new System.Drawing.Size(75, 23);
            this.buttonDeleteRows.TabIndex = 2;
            this.buttonDeleteRows.Text = "-";
            this.buttonDeleteRows.UseVisualStyleBackColor = true;
            this.buttonDeleteRows.Click += new System.EventHandler(this.buttonDeleteRows_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 211);
            this.Controls.Add(this.buttonDeleteRows);
            this.Controls.Add(this.buttonAddRow);
            this.Controls.Add(this.dataGridViewProxy);
            this.Name = "Form1";
            this.Text = "SwitchProxy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProxy;
        private System.Windows.Forms.Button buttonAddRow;
        private System.Windows.Forms.Button buttonDeleteRows;
    }
}


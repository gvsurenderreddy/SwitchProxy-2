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
            this.dataGridViewProxy.Size = new System.Drawing.Size(546, 190);
            this.dataGridViewProxy.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 211);
            this.Controls.Add(this.dataGridViewProxy);
            this.Name = "Form1";
            this.Text = "SwitchProxy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProxy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProxy;
    }
}


namespace vRAIPRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvStaticIPv4 = new System.Windows.Forms.DataGridView();
            this.cbNetProfile = new System.Windows.Forms.ComboBox();
            this.cbNetRange = new System.Windows.Forms.ComboBox();
            this.lbNetProfile = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbIPAddress = new System.Windows.Forms.Label();
            this.lbHostname = new System.Windows.Forms.Label();
            this.tbHostname = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vraDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaticIPv4)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vraDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStaticIPv4
            // 
            this.dgvStaticIPv4.AllowUserToAddRows = false;
            this.dgvStaticIPv4.AllowUserToDeleteRows = false;
            this.dgvStaticIPv4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaticIPv4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaticIPv4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStaticIPv4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaticIPv4.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvStaticIPv4.Location = new System.Drawing.Point(33, 84);
            this.dgvStaticIPv4.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStaticIPv4.Name = "dgvStaticIPv4";
            this.dgvStaticIPv4.ReadOnly = true;
            this.dgvStaticIPv4.RowHeadersVisible = false;
            this.dgvStaticIPv4.RowHeadersWidth = 51;
            this.dgvStaticIPv4.RowTemplate.Height = 24;
            this.dgvStaticIPv4.Size = new System.Drawing.Size(539, 249);
            this.dgvStaticIPv4.TabIndex = 0;
            // 
            // cbNetProfile
            // 
            this.cbNetProfile.FormattingEnabled = true;
            this.cbNetProfile.Location = new System.Drawing.Point(33, 30);
            this.cbNetProfile.Margin = new System.Windows.Forms.Padding(2);
            this.cbNetProfile.Name = "cbNetProfile";
            this.cbNetProfile.Size = new System.Drawing.Size(240, 21);
            this.cbNetProfile.TabIndex = 1;
            this.cbNetProfile.Tag = "Network Profile";
            this.cbNetProfile.SelectedIndexChanged += new System.EventHandler(this.CbNetProfile_SelectedIndexChanged);
            // 
            // cbNetRange
            // 
            this.cbNetRange.FormattingEnabled = true;
            this.cbNetRange.Location = new System.Drawing.Point(282, 30);
            this.cbNetRange.Margin = new System.Windows.Forms.Padding(2);
            this.cbNetRange.Name = "cbNetRange";
            this.cbNetRange.Size = new System.Drawing.Size(280, 21);
            this.cbNetRange.TabIndex = 2;
            this.cbNetRange.SelectedIndexChanged += new System.EventHandler(this.CbNetRange_SelectedIndexChanged);
            // 
            // lbNetProfile
            // 
            this.lbNetProfile.AutoSize = true;
            this.lbNetProfile.Location = new System.Drawing.Point(31, 14);
            this.lbNetProfile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNetProfile.Name = "lbNetProfile";
            this.lbNetProfile.Size = new System.Drawing.Size(79, 13);
            this.lbNetProfile.TabIndex = 3;
            this.lbNetProfile.Text = "Network Profile";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Network Range";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbIPAddress.Location = new System.Drawing.Point(142, 358);
            this.tbIPAddress.Margin = new System.Windows.Forms.Padding(2);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(131, 20);
            this.tbIPAddress.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(282, 359);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add IP";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // lbIPAddress
            // 
            this.lbIPAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbIPAddress.AutoSize = true;
            this.lbIPAddress.Location = new System.Drawing.Point(142, 380);
            this.lbIPAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIPAddress.Name = "lbIPAddress";
            this.lbIPAddress.Size = new System.Drawing.Size(58, 13);
            this.lbIPAddress.TabIndex = 7;
            this.lbIPAddress.Text = "IP Address";
            // 
            // lbHostname
            // 
            this.lbHostname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbHostname.AutoSize = true;
            this.lbHostname.Location = new System.Drawing.Point(33, 382);
            this.lbHostname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHostname.Name = "lbHostname";
            this.lbHostname.Size = new System.Drawing.Size(55, 13);
            this.lbHostname.TabIndex = 9;
            this.lbHostname.Text = "Hostname";
            // 
            // tbHostname
            // 
            this.tbHostname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbHostname.Location = new System.Drawing.Point(33, 358);
            this.tbHostname.Margin = new System.Windows.Forms.Padding(2);
            this.tbHostname.Name = "tbHostname";
            this.tbHostname.Size = new System.Drawing.Size(105, 20);
            this.tbHostname.TabIndex = 8;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 48);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(610, 409);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lbHostname);
            this.Controls.Add(this.tbHostname);
            this.Controls.Add(this.lbIPAddress);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNetProfile);
            this.Controls.Add(this.cbNetRange);
            this.Controls.Add(this.cbNetProfile);
            this.Controls.Add(this.dgvStaticIPv4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "vRA IP Address Reservation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaticIPv4)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vraDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaticIPv4;
        private System.Windows.Forms.BindingSource vraDataSetBindingSource;
        private System.Windows.Forms.ComboBox cbNetProfile;
        private System.Windows.Forms.ComboBox cbNetRange;
        private System.Windows.Forms.Label lbNetProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbIPAddress;
        private System.Windows.Forms.Label lbHostname;
        private System.Windows.Forms.TextBox tbHostname;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


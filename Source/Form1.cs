using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace vRAIPRes
{
    public partial class Form1 : Form
    {
        DataPull dPull = new DataPull();
        DataPush dp = new DataPush();
        public Form1()
        {
            InitializeComponent();

            try
            {
                if(dPull.IsServerConnected())
                { 
                    Dictionary<string, string> NP = dPull.GetNP();

                    cbNetProfile.DataSource = new BindingSource(NP, null);
                    cbNetProfile.DisplayMember = "Key";
                    cbNetProfile.ValueMember = "Value";
                }
                else
                {
                    string connError = @"
Please check connection string in the config file
The current connection is:" +   $" \r\n{Properties.Settings.Default.vra_prodConnectionString}";
                    MessageBox.Show(connError);
                    Environment.Exit(0);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void CbNetProfile_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                Dictionary<string, string> NR = dPull.GetNR(((KeyValuePair<string, string>)cbNetProfile.SelectedItem).Value);
                cbNetRange.DataSource = new BindingSource(NR, null);
                cbNetRange.DisplayMember = "Key";
                cbNetRange.ValueMember = "Value";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CbNetRange_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RefreshDT();
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            var results = "0";
            try
            {
                if (!dPull.IpExists(tbIPAddress.Text))
                {
                    var npID = ((KeyValuePair<string, string>)cbNetProfile.SelectedItem).Value;
                    var nrID = ((KeyValuePair<string, string>)cbNetRange.SelectedItem).Value;
                    var ipSortValue = dPull.GetIPSortValue(npID, nrID);

                    results = dp.AddIP(tbIPAddress.Text, npID, nrID, ipSortValue, tbHostname.Text);
                }
                else
                {
                    results = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            RefreshDT();
            if (results == "1")
            {
                MessageBox.Show($"Added IP Address and Hostname: {tbIPAddress.Text},{tbHostname.Text}");
                tbIPAddress.Text = "";
                tbHostname.Text = "";
            }
            else
            {
                MessageBox.Show($"Failed to add IP Address and Hostname: {tbIPAddress.Text},{tbHostname.Text}");
                tbIPAddress.Text = "";
                tbHostname.Text = "";
            }
        }

        private void RefreshDT()
        {
            try
            {
                DataTable dt = dPull.GetDT(((KeyValuePair<string, string>)cbNetProfile.SelectedItem).Value,
                    ((KeyValuePair<string, string>)cbNetRange.SelectedItem).Value);
                dgvStaticIPv4.DataSource = new BindingSource(dt, null);
                dgvStaticIPv4.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                dgvStaticIPv4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvStaticIPv4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dgvStaticIPv4.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vRAIPResAbout a = new vRAIPResAbout();
            a.Show();
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

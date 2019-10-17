using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace vRAIPRes
{
    class DataPush
    {
        public string AddIP(string ipAddress, string npID, string nrID, Int64 ipSort, string hName = null)
        {
            string results = "";
            if (!IsIPv4(ipAddress) && IsPingable(ipAddress) && HasName(ipAddress))
            {
                return "0";
            }

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.vra_prodConnectionString))
            {
                try
                {
                    string qString = @" 
INSERT INTO [StaticIPv4Address]
(ID, 
 StaticIPv4NetworkProfileID, 
 StaticIPv4RangeID,
 Hostname, 
 IPv4Address,
 IPSortValue,
 StaticIPv4AddressState, 
 CreatedDate,
 LastModifiedDate)
 VALUES 
 (@ID, 
  @StaticIPv4NetworkProfileID, 
  @StaticIPv4RangeID,
  @Hostname, 
  @IPv4Address,
  @IPSortValue,
  @StaticIPv4AddressState,  
  GETUTCDATE(),
  GETUTCDATE()
  );
";

                    using (SqlCommand cmd = new SqlCommand(qString, connection))
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = Guid.NewGuid();
                        cmd.Parameters.Add("@StaticIPv4NetworkProfileID", SqlDbType.UniqueIdentifier).Value =
                            new Guid(npID);
                        cmd.Parameters.Add("@StaticIPv4RangeID", SqlDbType.UniqueIdentifier).Value = new Guid(nrID);
                        cmd.Parameters.Add("@Hostname", SqlDbType.NVarChar).Value = hName;
                        cmd.Parameters.Add("@IPv4Address", SqlDbType.NVarChar).Value = ipAddress;
                        cmd.Parameters.Add("@IPSortValue", SqlDbType.BigInt).Value = ipSort;
                        cmd.Parameters.Add("@StaticIPv4AddressState", SqlDbType.Int).Value = 0;


                        connection.Open();
                        results = cmd.ExecuteNonQuery().ToString();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }

            return results;
        }

        private bool IsIPv4(string ipAddress)
        {
            return Regex.IsMatch(ipAddress, @"^\d{1,3}(\.\d{1,3}){3}$") &&
                   ipAddress.Split('.').SingleOrDefault(s => int.Parse(s) > 255) == null;
        }

        private bool IsPingable(string ipAddress)
        {
            bool rslt = false;
            try
            {
                Ping pingSender = new Ping();
                PingOptions options = new PingOptions();
                string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 120;
                PingReply reply = pingSender.Send(ipAddress, timeout, buffer, options);
                if (reply.Status == IPStatus.Success)
                {
                    rslt = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

            return rslt;
        }

        private bool HasName(string ipAddress)
        {
            bool rslt = false;

            try
            {
                IPHostEntry host = Dns.GetHostEntry(ipAddress);
                if (host.HostName != null)
                {
                    rslt = true;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

            return rslt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace vRAIPRes
{
    class DataPull
    {

        public Dictionary<string, string> GetNP()
        {
            Dictionary<string, string> NP = new Dictionary<string, string>();
            string qString = "Select StaticIPv4NetworkProfileName,ID from StaticIPv4NetworkProfile";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.vra_prodConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(qString, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var colone = reader[0].ToString();
                            var coltwo = reader[1].ToString();
                            NP.Add(colone, coltwo);
                        }

                        reader.Close();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }

            return NP;
        }

        public Dictionary<string, string> GetNR(string npID)
        {
            Dictionary<string, string> NR = new Dictionary<string, string>();
            string qString = $"Select StaticIPv4RangeName,ID from StaticIPv4Range where StaticIPv4NetworkProfileID = '{npID}'";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.vra_prodConnectionString))
            {
                try
                {
                    using (SqlCommand command = new SqlCommand(qString, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            var colone = reader[0].ToString();
                            var coltwo = reader[1].ToString();
                            NR.Add(colone, coltwo);
                        }

                        reader.Close();
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }

            return NR;
        }

        public DataTable GetDT(string npID, string nrID)
        {
            DataTable DT = new DataTable();
            string qString = $"select Hostname,IPv4Address,StaticIPv4AddressState from StaticIPv4Address where StaticIPv4NetworkProfileID = '{npID}' and StaticIPv4RangeID ='{nrID}' order by IPSortValue desc";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.vra_prodConnectionString))
            {
                try
                {


                    connection.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(qString, connection))
                    {
                        dataAdapter.Fill(DT);
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }

            return DT;
        }

        public Int64 GetIPSortValue(string npID, string nrID)
        {
            Int64 sortValue = 0;
            string qString = $"select Max(IPSortValue) from StaticIPv4Address where StaticIPv4NetworkProfileID = '{npID}' and StaticIPv4RangeID ='{nrID}'";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.vra_prodConnectionString))
            {
                try
                {

                    using (SqlCommand cmd = new SqlCommand(qString, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            sortValue = Convert.ToInt64(reader[0].ToString());
                            sortValue++;

                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }

            return sortValue;
        }

        public bool IpExists(string ipAddress)
        {
            bool rslt = false;

            string qString = $"select Count(IPv4Address) from StaticIPv4Address where  IPv4Address = '{ipAddress}'";
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.vra_prodConnectionString))
            {
                try
                {

                    using (SqlCommand cmd = new SqlCommand(qString, connection))
                    {
                        connection.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (Convert.ToInt32(reader[0].ToString()) >= 1)
                            {
                                rslt = true;
                            }


                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    throw;
                }
            }
            return rslt;
        }
        public bool IsServerConnected()
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.vra_prodConnectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}

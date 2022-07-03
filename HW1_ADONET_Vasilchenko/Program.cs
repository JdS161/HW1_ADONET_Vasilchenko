using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Console;

namespace HW1_ADONET_Vasilchenko
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connstr = "Data Source=DDUBL220689B80\\SQLEXPRESS; DataBase=FIRMA; Trusted_Connection=True";
            SqlConnection conn = new SqlConnection(connstr);
            conn.Open();
            string sqlCmd = "";
            SqlCommand cmd;
            SqlDataReader dr;

            WriteLine("Available options:");
            WriteLine("1. Employee LastName sorting;\n2. Employee age sorting;\n3. Customer LastName sorting");
            Write("\nYour option:");
            int option = Convert.ToInt32(ReadLine());

            switch (option)
            {
                case 1:
                    sqlCmd = "SELECT * FROM [CompanyDB].[dbo].[Employee] ORDER BY LastName";
                    cmd = new SqlCommand(sqlCmd, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var out1 = dr[0];
                        var out2 = dr[1];
                        var out3 = dr[2];
                        var out4 = dr[3];
                        WriteLine($"{out1}\t{out2}\t{out3}\t{out4}");
                    }
                    dr.Close();
                    break;
                case 2:
                    sqlCmd = "SELECT * FROM [CompanyDB].[dbo].[Employee] ORDER BY BirthDate";
                    cmd = new SqlCommand(sqlCmd, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var out1 = dr[0];
                        var out2 = dr[1];
                        var out3 = dr[2];
                        var out4 = dr[3];
                        WriteLine($"{out1}\t{out2}\t{out3}\t{out4}");
                    }
                    dr.Close();
                    break;
                case 3:
                    sqlCmd = "SELECT * FROM [CompanyDB].[dbo].[Customers] ORDER BY LastName";
                    cmd = new SqlCommand(sqlCmd, conn);
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        var out1 = dr[0];
                        var out2 = dr[1];
                        var out3 = dr[2];
                        var out4 = dr[3];
                        WriteLine($"{out1}\t{out2}\t{out3}\t{out4}");
                    }
                    dr.Close();
                    break;                    

                default:
                    break;
            }            
            

            conn.Close();
            ReadLine();

        }
    }
}

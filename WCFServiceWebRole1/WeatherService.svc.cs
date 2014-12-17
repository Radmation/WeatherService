using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFServiceWebRole1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : WeatherServiceInterface
    {
        public string GetWeather()
        {
            try
            {
            SqlConnection conn = new SqlConnection("Data Source=134.39.173.35;Initial Catalog=contributions;User id=demoGuest;Password=sp0kan3");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader myReader;
            cmd.CommandText = "SELECT Sunrise, Sunset, AvgHi, AvgLo FROM [WeatherDB2012].[dbo].[Spokane2012] WHERE Month=DATEPART(m,SYSDATETIME()) and Day = DATEPART(d,SYSDATETIME())";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            myReader = cmd.ExecuteReader();
            myReader.Read();
            if (myReader.HasRows)
            {
                string myString = "Sunrise: " + myReader["Sunrise"].ToString();
                myString += " Sunset: " + myReader["Sunset"].ToString();
                myString += " AvgHi: " + myReader["AvgHi"].ToString();
                myString += " AvgLo: " + myReader["AvgLo"].ToString();
                return myString;
            }
            else
                return "ERROR";
            }

            catch (Exception ex)
            {
                return "Error";
            }
        }

        public string GetSunrise()
        {
            try
            {
            SqlConnection conn = new SqlConnection("Data Source=134.39.173.35;Initial Catalog=contributions;User id=demoGuest;Password=sp0kan3");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader myReader;
            cmd.CommandText = "SELECT Sunrise, Sunset, AvgHi, AvgLo FROM [WeatherDB2012].[dbo].[Spokane2012] WHERE Month=DATEPART(m,SYSDATETIME()) and Day = DATEPART(d,SYSDATETIME())";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            myReader = cmd.ExecuteReader();
            myReader.Read();
            if (myReader.HasRows)
            {
                string myString = "Sunrise: " + myReader["Sunrise"].ToString();
                return myString;
            }
            else
                return "ERROR";
            }

            catch (Exception ex)
            {
                return "Error";
            }
        }

        public string GetSunset()
        {
            try
            {
            SqlConnection conn = new SqlConnection("Data Source=134.39.173.35;Initial Catalog=contributions;User id=demoGuest;Password=sp0kan3");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader myReader;
            cmd.CommandText = "SELECT Sunrise, Sunset, AvgHi, AvgLo FROM [WeatherDB2012].[dbo].[Spokane2012] WHERE Month=DATEPART(m,SYSDATETIME()) and Day = DATEPART(d,SYSDATETIME())";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            myReader = cmd.ExecuteReader();
            myReader.Read();
            if (myReader.HasRows)
            {
                string myString = "Sunset: " + myReader["Sunset"].ToString();
                return myString;
            }
            else
                return "ERROR";
            }

            catch (Exception ex)
            {
                return "Error";
            }
        }
        
        public string GetAvgHi()
        {
            try
            {
            SqlConnection conn = new SqlConnection("Data Source=134.39.173.35;Initial Catalog=contributions;User id=demoGuest;Password=sp0kan3");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader myReader;
            cmd.CommandText = "SELECT Sunrise, Sunset, AvgHi, AvgLo FROM [WeatherDB2012].[dbo].[Spokane2012] WHERE Month=DATEPART(m,SYSDATETIME()) and Day = DATEPART(d,SYSDATETIME())";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            myReader = cmd.ExecuteReader();
            myReader.Read();
            if (myReader.HasRows)
            {
                string myString = "AvgHi: " + myReader["AvgHi"].ToString();
                return myString;
            }
            else
                return "ERROR";
            }

            catch (Exception ex)
            {
                return "Error";
            }
        }

        public string GetAvgLo()
        {
            try
            {
            SqlConnection conn = new SqlConnection("Data Source=134.39.173.35;Initial Catalog=contributions;User id=demoGuest;Password=sp0kan3");

            SqlCommand cmd = new SqlCommand();
            SqlDataReader myReader;
            cmd.CommandText = "SELECT Sunrise, Sunset, AvgHi, AvgLo FROM [WeatherDB2012].[dbo].[Spokane2012] WHERE Month=DATEPART(m,SYSDATETIME()) and Day = DATEPART(d,SYSDATETIME())";
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = conn;
            conn.Open();
            myReader = cmd.ExecuteReader();
            myReader.Read();
            if (myReader.HasRows)
            {
                string myString = "AvgLo: " + myReader["AvgLo"].ToString();
                return myString;
            }
            else
                return "ERROR";
            }

            catch (Exception ex)
            {
                return "Error";
            }
        }
        

    }
}

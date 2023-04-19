using System;
using System.Data;
using System.Data.SqlClient;

namespace CommonLibrary._01_CSharpBasics
{
    public class Program2
    {
       public static void AdoCLass()
        {
            try
            {
                string ConnectionString = @"data source=EVS01LAP4176; database=BookDB; integrated security=SSPI";
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    //Create the SqlDataAdapter instance by specifying the command text and connection object
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Book; select * from Author; select * from Category", connection);

                    //Creating DataSet Object
                    DataSet dataSet = new DataSet();

                    //Filling the DataSet using the Fill Method of SqlDataAdapter object
                    //Here, we have not specified the data table name and the data table will be created at index position 0
                    dataAdapter.Fill(dataSet);
                    dataSet.Tables[0].TableName = "Book";
                    dataSet.Tables[1].TableName = "Author";
                    dataSet.Tables[2].TableName = "Category";


                    //Iterating through the DataSet 
                    //First fetch the Datatable from the dataset and then fetch the rows using the Rows property of Datatable
                    Console.WriteLine("Book Table");
                   foreach (DataRow row in dataSet.Tables[0].Rows)
                    {
                        //Accessing the Data using the string column name as key
                        Console.WriteLine(row["Id"] + ",  " + row["BookName"]+ ", "+row["Price"]+ ", "+row["IssueDate"]);

                        //Accessing the Data using the integer index position as key
                        //Console.WriteLine(row["Id"] + ",  " + row["Name"] + ",  " + row["Mobile"]);
                    }    
                    Console.WriteLine("Author Table");
                   foreach (DataRow row in dataSet.Tables[1].Rows)
                    {
                        //Accessing the Data using the string column name as key
                        Console.WriteLine(row["Id"] + ",  " + row["AuthorName"]+ ", "+row["CreatedOn"]);

                        //Accessing the Data using the integer index position as key
                        //Console.WriteLine(row["Id"] + ",  " + row["Name"] + ",  " + row["Mobile"]);
                    }    
                    Console.WriteLine("Category Table");
                   foreach (DataRow row in dataSet.Tables[2].Rows)
                    {
                        //Accessing the Data using the string column name as key
                        Console.WriteLine(row["Id"] + ",  " + row["CategoryName"]+ ", "+row["CreatedOn"]);

                        //Accessing the Data using the integer index position as key
                        //Console.WriteLine(row["Id"] + ",  " + row["Name"] + ",  " + row["Mobile"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Occurred: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
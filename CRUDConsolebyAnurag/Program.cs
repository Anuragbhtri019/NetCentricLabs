using System;
using Microsoft.Data.SqlClient;


class Program
{
    // Update with your connection details
    private static readonly string connectionString =
        "Server=(localdb)\\MSSQLLocalDB;Database=CRUDConsole;TrustServerCertificate=True;";

    static void Main(string[] args)
    {
        Console.WriteLine("=== CRUD Console Application ===");

        while (true)
        {
            Console.WriteLine("\n=== CRUD Operations Menu for Product  ===");
            Console.WriteLine("1. Insert Data");
            Console.WriteLine("2. Read Data");
            Console.WriteLine("3. Update Data");
            Console.WriteLine("4. Delete Data");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    InsertData();
                    break;
                case "2":
                    ReadData();
                    break;
                case "3":
                    UpdateData();
                    break;
                case "4":
                    DeleteData();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    // INSERT
    static void InsertData()
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        Console.Write("Enter Name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Enter Price: ");
        decimal price = decimal.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter Quantity: ");
        int qty = int.Parse(Console.ReadLine() ?? "0");

        

        string query = "INSERT INTO Products (Name, Price, Quantity) VALUES (@Name, @Price, @Quantity)";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Price", price);
        cmd.Parameters.AddWithValue("@Quantity", qty);

        cmd.ExecuteNonQuery();
        Console.WriteLine("Inserted successfully!");
    }

    // READ
    static void ReadData()
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query = "SELECT ProductId, Name, Price, Quantity FROM Products";
        SqlCommand cmd = new SqlCommand(query, conn);
        SqlDataReader reader = cmd.ExecuteReader();

        Console.WriteLine("\n=== Products Table ===");
        Console.WriteLine("ID\tName\t\t\tPrice\t\tQuantity");
        Console.WriteLine("--------------------------------------");

        while (reader.Read())
        {
            Console.WriteLine($"{reader["ProductId"]}\t{reader["Name"]}\t\t\t{reader["Price"]}\t\t{reader["Quantity"]}");
        }
    }

    // UPDATE
    static void UpdateData()
    {
        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();
        Console.Write("Enter Product ID to update: ");
        int id = int.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Name: ");
        string name = Console.ReadLine() ?? "";
        Console.Write("Enter new Price: ");
        decimal price = decimal.Parse(Console.ReadLine() ?? "0");
        Console.Write("Enter new Quantity: ");
        int qty = int.Parse(Console.ReadLine() ?? "0");

       

        string query = "UPDATE Products SET Name=@Name, Price=@Price, Quantity=@Quantity WHERE ProductId=@Id";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Name", name);
        cmd.Parameters.AddWithValue("@Price", price);
        cmd.Parameters.AddWithValue("@Quantity", qty);
        cmd.Parameters.AddWithValue("@Id", id);

        int rows = cmd.ExecuteNonQuery();
        Console.WriteLine(rows > 0 ? "Updated successfully!" : "No record found.");
    }

    // DELETE
    static void DeleteData()
    {
        Console.Write("Enter Product ID to delete: ");
        int id = int.Parse(Console.ReadLine() ?? "0");

        using SqlConnection conn = new SqlConnection(connectionString);
        conn.Open();

        string query = "DELETE FROM Products WHERE ProductId=@Id";
        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);

        int rowsAffected = cmd.ExecuteNonQuery();
        Console.WriteLine(rowsAffected > 0 ? "Deleted successfully!" : "No record found with that ID.");
    }
}

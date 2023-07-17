using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");

        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])

                };
                products.Add(product);
            }

            reader.Close();
            _connection.Close();
            return products;


        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();
        } public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        } public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Delete from Products where Id=@id", _connection);
          
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

    }
}


/*    public DataTable GetAll2()
    {
        // PROFESYONEL PROJELERDE DATATABLE KULLANILMASINDAN KACINILIYOR sebebi:Büyük boyutlu oldugu için bilgi fazlalığı 


        // initial catalog hangi data base i secmek istiyosak yazılır
        // integrated security windowsdan onay alma gibi bişe araştır!!
        // Başındaki @ herşeyi string olarak algıla demek

        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog =ETrade;integrated security=true");
        if (connection.State == ConnectionState.Closed)
        {
            connection.Open();
        }
        SqlCommand command = new SqlCommand("Select * from Products",connection);

        SqlDataReader reader = command.ExecuteReader();

        DataTable dataTable = new DataTable();
        dataTable.Load(reader);
        reader.Close();
        connection.Close();
        return dataTable;

        /* sistem şöyle işliyo sqlconnection u önce belirliyoruz neresi oldugnu
        sonra eğer sql connection kapalıysa acıyoruz (state = durum)
        sql command komutları alıyor ve bağlantıya gönderiyo
        en son komutları okuyucak bi reader lazım
        readerla işin bitince operasyonu execute ediyosun işin bitince işlemleri kapatıyosun */

// connection -> connection state -> command -> reader ->execute 









//uzaktaki bir sql bağlantısı için integrated security false, userid,password girmen lazım
// SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog =ETrade;integrated security=false;uid=mete;password=12345");


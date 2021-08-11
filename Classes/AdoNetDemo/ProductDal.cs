using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace AdoNetDemo
{
    public class ProductDal
    {
        readonly SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB; initial catalog=Etrade;integrated security=true");

        private void ConnectionMethod()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public List<Product> GetAll()
        {

            ConnectionMethod();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    Fiyat = Convert.ToDecimal(reader["Fiyat"]),
                    Stok = Convert.ToInt32(reader["Stok"])
                };
                products.Add(product);
            }
            reader.Close();
            _connection.Close();
            return products;
        }



        //public DataTable GetAll2()
        //{
        //    ConnectionMethod();

        //    SqlCommand command = new SqlCommand("Select * from Products", _connection);

        //    SqlDataReader reader = command.ExecuteReader();

        //    DataTable dataTable = new DataTable();
        //    dataTable.Load(reader);
        //    reader.Close();
        //    _connection.Close();
        //    return dataTable;
        //}

        public void Add(Product product)
        {
            ConnectionMethod();
            SqlCommand command = new SqlCommand("Insert into Products values(@UrunAdi,@Fiyat,@Stok)", _connection);
            command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@Fiyat", product.Fiyat);
            command.Parameters.AddWithValue("@Stok", product.Stok);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Product product)
        {
            ConnectionMethod();
            SqlCommand command = new SqlCommand("Update Products set UrunAdi=@UrunAdi, Fiyat=@Fiyat, Stok=@Stok where Id=@Id", _connection);
            command.Parameters.AddWithValue("@UrunAdi", product.UrunAdi);
            command.Parameters.AddWithValue("@Fiyat", product.Fiyat);
            command.Parameters.AddWithValue("@Stok", product.Stok);
            command.Parameters.AddWithValue("@Id", product.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Delete(int id)
        {
            ConnectionMethod();
            SqlCommand command = new SqlCommand("Delete from Products where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }


    }
}

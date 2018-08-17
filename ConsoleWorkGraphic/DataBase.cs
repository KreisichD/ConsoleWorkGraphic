using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;


namespace ConsoleWorkGraphic
{
    class DataBase
    {
        private MySqlConnection dataBase;

        DataBase(String connection)
        {
            dataBase = new MySqlConnection(connection);
        }
    }
}

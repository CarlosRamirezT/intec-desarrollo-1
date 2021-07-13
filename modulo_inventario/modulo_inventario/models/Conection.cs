using System;
using Npgsql;


namespace modulo_inventario.models
{
    public abstract class Conection
    {
        // cadena con el datasource, puerto, usuario, password, base de datos y tabla para conectarse a la base de datos
        private static readonly string CONNECTION_STRING = "Host=localhost;Username=postgres;Password=cadara;Database=dev1_final";
        // query a ejecutar en la base de datos, cada metodo debera modificarlo
        protected string _query;
        // variable para almacenar la referencia en memoria a la conexion establecido con la base de datos
        // se debe reiniciar en el constructor de cada clase que implemente esta clase abstracta

        public static NpgsqlConnection get_connection()
        {
            NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        //protected NpgsqlCommand _command;

        // metodos que se deben implementar en cada clase de tipo dao que implemente esta

        // este metodo inserta registros a la base de datos
        public abstract int Create();
        // este metodo actualizar registros a la base de datos
        public abstract void Write();
        // este metodo borrar registros de la base de datos
        public abstract void Unlink();
        // este metodo recupera registros especificos de la base de datos
        // y devuelve un DataGrid conteniendo todos los campos y registros
    }
}

using System;
using Npgsql;

namespace modulo_inventario.models
{
    abstract class Conection
    {
        // cadena con el datasource, puerto, usuario, password, base de datos y tabla para conectarse a la base de datos
        protected readonly string CONNECTION_STRING = "Host=localhost;Username=cadara;Password=cadara;Database=desarrollo-1-final";
        // query a ejecutar en la base de datos, cada metodo debera modificarlo
        protected string _query;
        // variable para almacenar la referencia en memoria a la conexion establecido con la base de datos
        // se debe reiniciar en el constructor de cada clase que implemente esta clase abstracta
        protected Conection _connection;
        // variable que representa el comando a ejecutar variendose de la coneccion y el query
        protected NpgsqlCommand _command;

        // metodos que se deben implementar en cada clase de tipo dao que implemente esta

        // este metodo inserta registros a la base de datos
        public abstract void Create();
        // este metodo actualizar registros a la base de datos
        public abstract void Write();
        // este metodo borrar registros de la base de datos
        public abstract void Unlink();
        // este metodo recupera registros especificos de la base de datos
        // y devuelve un DataGrid conteniendo todos los campos y registros
        public abstract Conection[] Search(string domain);
        // este metodo recupera todos los registros de la tabla de la base de datos
        // y devuelve un DataGrid conteniendo todos los campos y registros
        public abstract Conection Browse(int Id);
        public abstract Conection[] Browse();
    }
}

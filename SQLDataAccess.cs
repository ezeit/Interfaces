public class SQLDataAccess : IDataAccess{

    private SQLConnection = new SQLConnection(); //Dummy code

    public List<String> ObtenerDatos(){
        return SQLConnection.GetListStrings(); //ME CONECTO A LA BASE DE DATOS Y TRAIGO UNA LISTA DE STRINGS
    }

}
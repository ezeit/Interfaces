public MockDataAccess : IDataAccess {

    public List<String> ObtenerDatos(){
        return new List<String>(){
            "String mock 1",
            "String mock 2",
            "ESTE STRING ME INTERESA"
        };
    }
}
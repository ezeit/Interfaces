public class MAIN {

    public void run(IDataAccess da){
        Console.Log(da.ObtenerDatos());
    }
}

  //EJEMPLO DE LLAMADA EN PRODUCCION: Trae los datos desde una base de datos
  var main = new MAIN();
  main.run(new SQLDataAccess());

//EJEMPLO DE LLAMADA EN TEST UNITARIOS: Trae los datos desde un mock, por que no nos interesa probar la conexion a la db, sino que nos importa lo que devuelve
  var main = new MAIN();
  main.run(new MockDataAccess());
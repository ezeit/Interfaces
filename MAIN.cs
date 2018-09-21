//EJEMPLO DE LLAMADA EN PRODUCCION: Trae los datos desde una base de datos
var main = new DatoBusiness(new SQLDataAccess());
var result = main.ObtenerDatos();

//EJEMPLO DE LLAMADA EN TEST UNITARIOS: Trae los datos desde un mock, 
//por que no nos interesa probar la conexion a la db, sino que nos importa lo que devuelve
var main = new DatoBusiness(new MockDataAccess());
var result = main.ObtenerDatos();
assert.isTrue(result.contains("ESTE STRING ME INTERESA"));

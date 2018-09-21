public class DatoBusiness {
    IDataAccess _da;

    public DatoBusiness(IDataAccess da){
        this._da = da || Throw ex;
    }

    public List<string> ObtenerStrings (){
        return this._da.ObtenerDatos();
    }
}
using System.Web.Services;


namespace ServicioWeb
{
    /// <summary>
    /// Summary description for ServicioClientes
    /// </summary>
    [WebService(Namespace = "http://localhost/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ServicioClientes : System.Web.Services.WebService
    {
        #region Metodos para el tratamiento de la Tabla Cliente
        [WebMethod(Description = "Inserta un nuevo registro", MessageName = "NuevoClienteSimple")]
        public int          NuevoClienteSimple(string nombre, string telefono)
        {
            Cliente cli = new Cliente();
            int res = cli.InsertarRegistro(nombre, telefono);
            return res;
        }

        [WebMethod(Description = "Regresa una lista de registros en Formato JSON", MessageName = "ListadoClientesJSON")]
        public string    ListadoClientesJSON()
        {
            Cliente cli = new Cliente();
            return (cli.strListadoJSON());
            
        }

        [WebMethod(Description = "Regresa una lista de registros en Format XML", MessageName = "ListadoClientesXML")]
        public Cliente[] ListadoClientesXML()
        {
            
            Cliente cli = new Cliente();
            return (cli.strListadoXML());
        }
        #endregion

    }
}

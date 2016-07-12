using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
[ServiceContract]
public interface IVehiculoService
{

    [OperationContract]
    string GetPosicion();
    [OperationContract]
    string PostConfiguracion(int n, int m);
    [OperationContract]
    VehiculoRespuesta PostValidarComando(string comando, int n, int m, string posicion);
        
	// TODO: agregue aquí sus operaciones de servicio
}

[DataContract]
public class VehiculoRespuesta
{
    [DataMember]
    public string Posicion { get; set; }
    [DataMember]
    public string Mensaje { get; set; }
}
public class VehiculoAccion
{
    [DataMember]
    public string Posicion { get; set; }
    [DataMember]
    public string Mensaje { get; set; }
    [DataMember]
    public int Df { get; set; }
    [DataMember]
    public int Dc { get; set; }
    [DataMember]
    public bool Estado { get; set; }
}

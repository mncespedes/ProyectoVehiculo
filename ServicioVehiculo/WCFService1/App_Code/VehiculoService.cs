using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
public class VehiculoService : IVehiculoService
{
    public string GetPosicion()
    {
        //leer archivo
        string line;
        StreamReader stream = new StreamReader(@"C:\Users\neyder\Desktop\posicion.txt");
        do
        {
            line = stream.ReadLine();            
        } while (line == "");
        stream.Close();
        return line;
    }
    //Método que configura el tamaño de la matriz
    public string PostConfiguracion(int n, int m)
    {
        if (n > 0 && m > 0)
        {
            return "Ok";
        }
        return "Error al configurar la matriz";
    }
    //Método que Valida el comando y hace el llamado al método de desplazar
    public VehiculoRespuesta PostValidarComando(string comando, int n, int m, string posicion)
    {
        VehiculoRespuesta modelRespuesta = new VehiculoRespuesta();
        string posiconFinal = "";
        string mensaje = "";

        Regex regex = new Regex(@"^([1-9]+[0-9]*,[NSEO];)*[1-9][0-9]*,[NSEO]$");
        if (regex.IsMatch(comando))
        {
            char delimitaP = ',';
            char delimita = ';';
            String[] desplazamientos;
            String[] posisionActual = posicion.Split(delimitaP);
            int df = Convert.ToInt32(posisionActual[0]);
            int dc = Convert.ToInt32(posisionActual[1]);
            
            if (comando.Length > 4)
            {
                desplazamientos = comando.Split(delimita);
                foreach (var desplazamiento in desplazamientos)
                {
                    VehiculoAccion accion = new VehiculoAccion();
                        accion = desplazar(desplazamiento, df, dc, n, m);
                    df = accion.Df;
                    dc = accion.Dc;
                    mensaje = accion.Mensaje;

                    if (accion.Estado == false)
                      break;
                }
            }
            else
            {
                VehiculoAccion accion = new VehiculoAccion();
                accion = desplazar(comando, df, dc, n, m);
                df = accion.Df;
                dc = accion.Dc;
                mensaje = accion.Mensaje;
            }
            posiconFinal = df + "," + dc;
        }
        else
        {
            modelRespuesta.Mensaje = "Error en formato de comando";
            modelRespuesta.Posicion = "0,0";
            return modelRespuesta;
        }
        StreamWriter escrito = new StreamWriter(@"C:\Users\neyder\Desktop\posicion.txt");
        //Escribir en el archivo
        escrito.WriteLine(posiconFinal);
        //Cerrar el archivo
        escrito.Close();
        modelRespuesta.Posicion = posiconFinal;
        modelRespuesta.Mensaje = mensaje;
        return modelRespuesta;
    }
    //Método que realiza el desplazamiento de la matriz 
    private VehiculoAccion desplazar(dynamic desplazamiento, int desFila, int desCol, int n, int m)
    {
        char delimitaD = ',';
        int df = desFila;
        int dc = desCol;
        VehiculoAccion modelRespuesta = new VehiculoAccion();
        String[] desp = desplazamiento.Split(delimitaD);
        if (desp[1] == "N")
        {
            df = df + Convert.ToInt32(desp[0]);
            if (df > n)
            {
                modelRespuesta.Mensaje = "Se ha detenido el avance por salir de los límites";
                modelRespuesta.Posicion = df + "," + dc;
                modelRespuesta.Estado = false;
                return modelRespuesta;
            }
        }
        else if (desp[1] == "E")
        {
            dc = dc + Convert.ToInt32(desp[0]);
            if (dc > n)
            {
                modelRespuesta.Mensaje = "Se ha detenido el avance por salir de los límites";
                modelRespuesta.Posicion = df + "," + dc;
                modelRespuesta.Estado = false;
                return modelRespuesta;
            }
        }
        else if (desp[1] == "O")
        {
            dc = dc - Convert.ToInt32(desp[0]);
            if (dc < 0)
            {
                dc = dc + 1;
                modelRespuesta.Mensaje = "Se ha detenido el avance por salir de los límites";
                modelRespuesta.Posicion = df + "," + dc;
                modelRespuesta.Estado = false;
                return modelRespuesta;
            }
        }
        else if (desp[1] == "S")
        {
            df = df - Convert.ToInt32(desp[0]);
            if (df < 0)
            {
                df = df + 1;
                modelRespuesta.Mensaje = "Se ha detenido el avance por salir de los límites";
                modelRespuesta.Posicion = df + "," + dc;
                modelRespuesta.Estado = false;
                return modelRespuesta;
            }
        }
        modelRespuesta.Mensaje = "Se realizó satisfactoriamente";
        modelRespuesta.Posicion = df + "," + dc;
        modelRespuesta.Df = df;
        modelRespuesta.Dc = dc;
        modelRespuesta.Estado = true;
        return modelRespuesta;
    }
}

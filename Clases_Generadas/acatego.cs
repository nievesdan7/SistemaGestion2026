using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class acatego {

		#region Campos
            private string _cacdcodcat;
            private string _cacdnomcat;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public string cacdcodcat
            { 
                get{ return this._cacdcodcat;}
                set{ this._cacdcodcat = value;}
            } 
		    public string cacdnomcat
            { 
                get{ return this._cacdnomcat;}
                set{ this._cacdnomcat = value;}
            } 
        #endregion

        #region Constructor
            public acatego()
            { 
		        this._cacdcodcat = "";
		        this._cacdnomcat = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "cacdcodcat," +
                                     "cacdnomcat " + 
                             "from acatego " +
                             "";

                this.Conexion.PrepararComando(sql);


                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._cacdcodcat=ResultadoConsulta.GetString(0);
                    this._cacdnomcat=ResultadoConsulta.GetString(1);
                    this.Conexion.Desconectar();

                    return true;
                }
                else
                {
                    this.Conexion.Desconectar();
                    return false;
                }
            }
            public bool VerificarExistencia()
            { 
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "cacdcodcat," +
                                     "cacdnomcat " + 
                             "from acatego " +
                             "";
 
                this.Conexion.PrepararComando(sql); 


                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.HasRows)
                {
                this.Conexion.Desconectar();

                    return true;
                }
                else 
                { 

                this.Conexion.Desconectar();
                    return false;
                } 
            } 
            public bool Grabar()
            { 
                if (this.VerificarExistencia())
                {
                    return false;
                }
                else 
                { 
                    this.Conexion.Conectar();
			        string sql = "insert into acatego (" +
                                                       "cacdcodcat," +
                                                       "cacdnomcat" +
                                                       ") " +
	                             "values (" + 
                                          "@cacdcodcat," +
                                          "@cacdnomcat" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroCadena("@cacdcodcat",this._cacdcodcat);
                    this.Conexion.AsignarParametroCadena("@cacdnomcat",this._cacdnomcat);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                } 
            } 
            public bool Modificar()
            { 
                if (!this.VerificarExistencia())
                {
                    return false;
                }
                else 
                { 
                    this.Conexion.Conectar();
			        string sql = "update acatego set " +
                                                     "cacdcodcat = @cacdcodcat, " +
                                                     "cacdnomcat = @cacdnomcat" +
                                 " ";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroCadena("@cacdcodcat",this._cacdcodcat);
                    this.Conexion.AsignarParametroCadena("@cacdnomcat",this._cacdnomcat);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<acatego> Lista(string where)
            { 
                List<acatego> ListaResultado = new List<acatego>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "cacdcodcat," +
                                     "cacdnomcat " + 
                             "from acatego " ;
 
                if (where.Replace(" ", "") != "")
                {
                    sql+= "where " + where;
                }

 
                this.Conexion.PrepararComando(sql); 
                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta!=null)
                {
                    while (ResultadoConsulta.Read())
                    {
                          acatego Auxiliar = new acatego();
                          Auxiliar.cacdcodcat = ResultadoConsulta.GetString(0);
                          Auxiliar.cacdnomcat = ResultadoConsulta.GetString(1);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}


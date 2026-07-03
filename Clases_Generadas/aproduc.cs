using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aproduc {

		#region Campos
            private decimal _caproducpreprod;
            private decimal _caproduccosprod;
            private string _caproducnomprod;
            private string _caproducstkprod;
            private string _caproductalprod;
            private string _paproduccodprod;
            private string _caproductipprod;
            private string _caproduccolprod;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public decimal caproducpreprod
            { 
                get{ return this._caproducpreprod;}
                set{ this._caproducpreprod = value;}
            } 
		    public decimal caproduccosprod
            { 
                get{ return this._caproduccosprod;}
                set{ this._caproduccosprod = value;}
            } 
		    public string caproducnomprod
            { 
                get{ return this._caproducnomprod;}
                set{ this._caproducnomprod = value;}
            } 
		    public string caproducstkprod
            { 
                get{ return this._caproducstkprod;}
                set{ this._caproducstkprod = value;}
            } 
		    public string caproductalprod
            { 
                get{ return this._caproductalprod;}
                set{ this._caproductalprod = value;}
            } 
		    public string paproduccodprod
            { 
                get{ return this._paproduccodprod;}
                set{ this._paproduccodprod = value;}
            } 
		    public string caproductipprod
            { 
                get{ return this._caproductipprod;}
                set{ this._caproductipprod = value;}
            } 
		    public string caproduccolprod
            { 
                get{ return this._caproduccolprod;}
                set{ this._caproduccolprod = value;}
            } 
        #endregion

        #region Constructor
            public aproduc()
            { 
		        this._caproducpreprod = 0;
		        this._caproduccosprod = 0;
		        this._caproducnomprod = "";
		        this._caproducstkprod = "";
		        this._caproductalprod = "";
		        this._paproduccodprod = "";
		        this._caproductipprod = "";
		        this._caproduccolprod = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "caproducpreprod," +
                                     "caproduccosprod," +
                                     "caproducnomprod," +
                                     "caproducstkprod," +
                                     "caproductalprod," +
                                     "paproduccodprod," +
                                     "caproductipprod," +
                                     "caproduccolprod " + 
                             "from aproduc " +
                             "where "+
                                    "paproduccodprod = @paproduccodprod";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@paproduccodprod",this._paproduccodprod);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._caproducpreprod=ResultadoConsulta.GetDecimal(0);
                    this._caproduccosprod=ResultadoConsulta.GetDecimal(1);
                    this._caproducnomprod=ResultadoConsulta.GetString(2);
                    this._caproducstkprod=ResultadoConsulta.GetString(3);
                    this._caproductalprod=ResultadoConsulta.GetString(4);
                    this._paproduccodprod=ResultadoConsulta.GetString(5);
                    this._caproductipprod=ResultadoConsulta.GetString(6);
                    this._caproduccolprod=ResultadoConsulta.GetString(7);
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
                                     "caproducpreprod," +
                                     "caproduccosprod," +
                                     "caproducnomprod," +
                                     "caproducstkprod," +
                                     "caproductalprod," +
                                     "paproduccodprod," +
                                     "caproductipprod," +
                                     "caproduccolprod " + 
                             "from aproduc " +
                             "where " +
                                    "paproduccodprod = @paproduccodprod";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@paproduccodprod",this._paproduccodprod);

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
			        string sql = "insert into aproduc (" +
                                                       "caproducpreprod," +
                                                       "caproduccosprod," +
                                                       "caproducnomprod," +
                                                       "caproducstkprod," +
                                                       "caproductalprod," +
                                                       "paproduccodprod," +
                                                       "caproductipprod," +
                                                       "caproduccolprod" +
                                                       ") " +
	                             "values (" + 
                                          "@caproducpreprod," +
                                          "@caproduccosprod," +
                                          "@caproducnomprod," +
                                          "@caproducstkprod," +
                                          "@caproductalprod," +
                                          "@paproduccodprod," +
                                          "@caproductipprod," +
                                          "@caproduccolprod" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroDecimal("@caproducpreprod",this._caproducpreprod);
                    this.Conexion.AsignarParametroDecimal("@caproduccosprod",this._caproduccosprod);
                    this.Conexion.AsignarParametroCadena("@caproducnomprod",this._caproducnomprod);
                    this.Conexion.AsignarParametroCadena("@caproducstkprod",this._caproducstkprod);
                    this.Conexion.AsignarParametroCadena("@caproductalprod",this._caproductalprod);
                    this.Conexion.AsignarParametroCadena("@paproduccodprod",this._paproduccodprod);
                    this.Conexion.AsignarParametroCadena("@caproductipprod",this._caproductipprod);
                    this.Conexion.AsignarParametroCadena("@caproduccolprod",this._caproduccolprod);

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
			        string sql = "update aproduc set " +
                                                     "caproducpreprod = @caproducpreprod, " +
                                                     "caproduccosprod = @caproduccosprod, " +
                                                     "caproducnomprod = @caproducnomprod, " +
                                                     "caproducstkprod = @caproducstkprod, " +
                                                     "caproductalprod = @caproductalprod, " +
                                                     "caproductipprod = @caproductipprod, " +
                                                     "caproduccolprod = @caproduccolprod" +
                                 " where " +
                                        "paproduccodprod = @paproduccodprod";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroDecimal("@caproducpreprod",this._caproducpreprod);
                    this.Conexion.AsignarParametroDecimal("@caproduccosprod",this._caproduccosprod);
                    this.Conexion.AsignarParametroCadena("@caproducnomprod",this._caproducnomprod);
                    this.Conexion.AsignarParametroCadena("@caproducstkprod",this._caproducstkprod);
                    this.Conexion.AsignarParametroCadena("@caproductalprod",this._caproductalprod);
                    this.Conexion.AsignarParametroCadena("@paproduccodprod",this._paproduccodprod);
                    this.Conexion.AsignarParametroCadena("@caproductipprod",this._caproductipprod);
                    this.Conexion.AsignarParametroCadena("@caproduccolprod",this._caproduccolprod);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aproduc> Lista(string where)
            { 
                List<aproduc> ListaResultado = new List<aproduc>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "caproducpreprod," +
                                     "caproduccosprod," +
                                     "caproducnomprod," +
                                     "caproducstkprod," +
                                     "caproductalprod," +
                                     "paproduccodprod," +
                                     "caproductipprod," +
                                     "caproduccolprod " + 
                             "from aproduc " ;
 
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
                          aproduc Auxiliar = new aproduc();
                          Auxiliar.caproducpreprod = ResultadoConsulta.GetDecimal(0);
                          Auxiliar.caproduccosprod = ResultadoConsulta.GetDecimal(1);
                          Auxiliar.caproducnomprod = ResultadoConsulta.GetString(2);
                          Auxiliar.caproducstkprod = ResultadoConsulta.GetString(3);
                          Auxiliar.caproductalprod = ResultadoConsulta.GetString(4);
                          Auxiliar.paproduccodprod = ResultadoConsulta.GetString(5);
                          Auxiliar.caproductipprod = ResultadoConsulta.GetString(6);
                          Auxiliar.caproduccolprod = ResultadoConsulta.GetString(7);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}


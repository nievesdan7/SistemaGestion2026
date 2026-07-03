using System;
using System.Collections.Generic;
using System.Text;
//Libreria para acceso a datos
using System.Data.Common; 
//Libreria para acceso a Capa de Acceso a Datos
using CapaAD;

namespace CapaRN
{
	public class aperson {

		#region Campos
            private DateTime _capsfec;
            private bool _capssexper;
            private bool _capsestper;
            private string _capsapepat;
            private string _capsnomper;
            private string _capsnumcel;
            private string _capscorele;
            private string _capsdirper;
            private string _papscodeper;
            private string _capsfotper;
            private string _capsnumcid;
            private string _capsapemat;
            //Instancia para conexion a PostgreSQL 8.2
            private CLConexionPGSQL Conexion;
		#endregion 

		#region Propiedades
		    public DateTime capsfec
            { 
                get{ return this._capsfec;}
                set{ this._capsfec = value;}
            } 
		    public bool capssexper
            { 
                get{ return this._capssexper;}
                set{ this._capssexper = value;}
            } 
		    public bool capsestper
            { 
                get{ return this._capsestper;}
                set{ this._capsestper = value;}
            } 
		    public string capsapepat
            { 
                get{ return this._capsapepat;}
                set{ this._capsapepat = value;}
            } 
		    public string capsnomper
            { 
                get{ return this._capsnomper;}
                set{ this._capsnomper = value;}
            } 
		    public string capsnumcel
            { 
                get{ return this._capsnumcel;}
                set{ this._capsnumcel = value;}
            } 
		    public string capscorele
            { 
                get{ return this._capscorele;}
                set{ this._capscorele = value;}
            } 
		    public string capsdirper
            { 
                get{ return this._capsdirper;}
                set{ this._capsdirper = value;}
            } 
		    public string papscodeper
            { 
                get{ return this._papscodeper;}
                set{ this._papscodeper = value;}
            } 
		    public string capsfotper
            { 
                get{ return this._capsfotper;}
                set{ this._capsfotper = value;}
            } 
		    public string capsnumcid
            { 
                get{ return this._capsnumcid;}
                set{ this._capsnumcid = value;}
            } 
		    public string capsapemat
            { 
                get{ return this._capsapemat;}
                set{ this._capsapemat = value;}
            } 
        #endregion

        #region Constructor
            public aperson()
            { 
		        this._capsfec = DateTime.Now;
		        this._capssexper = true;
		        this._capsestper = true;
		        this._capsapepat = "";
		        this._capsnomper = "";
		        this._capsnumcel = "";
		        this._capscorele = "";
		        this._capsdirper = "";
		        this._papscodeper = "";
		        this._capsfotper = "";
		        this._capsnumcid = "";
		        this._capsapemat = "";
                this.Conexion = new CLConexionPGSQL();            } 
        #endregion

        #region Metodos
            public bool ObtenerDatos() 
            { 
                this.Conexion.Conectar();
			    string sql = "select " +
                                     "capsfec," +
                                     "capssexper," +
                                     "capsestper," +
                                     "capsapepat," +
                                     "capsnomper," +
                                     "capsnumcel," +
                                     "capscorele," +
                                     "capsdirper," +
                                     "papscodeper," +
                                     "capsfotper," +
                                     "capsnumcid," +
                                     "capsapemat " + 
                             "from aperson " +
                             "where "+
                                    "papscodeper = @papscodeper";

                this.Conexion.PrepararComando(sql);

                this.Conexion.AsignarParametroCadena("@papscodeper",this._papscodeper);

                DbDataReader ResultadoConsulta = Conexion.EjecutarConsulta();

                if (ResultadoConsulta.Read())
                {
                    this._capsfec=ResultadoConsulta.GetDateTime(0);
                    this._capssexper=ResultadoConsulta.GetBoolean(1);
                    this._capsestper=ResultadoConsulta.GetBoolean(2);
                    this._capsapepat=ResultadoConsulta.GetString(3);
                    this._capsnomper=ResultadoConsulta.GetString(4);
                    this._capsnumcel=ResultadoConsulta.GetString(5);
                    this._capscorele=ResultadoConsulta.GetString(6);
                    this._capsdirper=ResultadoConsulta.GetString(7);
                    this._papscodeper=ResultadoConsulta.GetString(8);
                    this._capsfotper=ResultadoConsulta.GetString(9);
                    this._capsnumcid=ResultadoConsulta.GetString(10);
                    this._capsapemat=ResultadoConsulta.GetString(11);
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
                                     "capsfec," +
                                     "capssexper," +
                                     "capsestper," +
                                     "capsapepat," +
                                     "capsnomper," +
                                     "capsnumcel," +
                                     "capscorele," +
                                     "capsdirper," +
                                     "papscodeper," +
                                     "capsfotper," +
                                     "capsnumcid," +
                                     "capsapemat " + 
                             "from aperson " +
                             "where " +
                                    "papscodeper = @papscodeper";
 
                this.Conexion.PrepararComando(sql); 

                this.Conexion.AsignarParametroCadena("@papscodeper",this._papscodeper);

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
			        string sql = "insert into aperson (" +
                                                       "capsfec," +
                                                       "capssexper," +
                                                       "capsestper," +
                                                       "capsapepat," +
                                                       "capsnomper," +
                                                       "capsnumcel," +
                                                       "capscorele," +
                                                       "capsdirper," +
                                                       "papscodeper," +
                                                       "capsfotper," +
                                                       "capsnumcid," +
                                                       "capsapemat" +
                                                       ") " +
	                             "values (" + 
                                          "@capsfec," +
                                          "@capssexper," +
                                          "@capsestper," +
                                          "@capsapepat," +
                                          "@capsnomper," +
                                          "@capsnumcel," +
                                          "@capscorele," +
                                          "@capsdirper," +
                                          "@papscodeper," +
                                          "@capsfotper," +
                                          "@capsnumcid," +
                                          "@capsapemat" +
                                                       ")";

                    this.Conexion.PrepararComando(sql);

                    this.Conexion.AsignarParametroFecha("@capsfec",this._capsfec);
                    this.Conexion.AsignarParametroLogico("@capssexper",this._capssexper);
                    this.Conexion.AsignarParametroLogico("@capsestper",this._capsestper);
                    this.Conexion.AsignarParametroCadena("@capsapepat",this._capsapepat);
                    this.Conexion.AsignarParametroCadena("@capsnomper",this._capsnomper);
                    this.Conexion.AsignarParametroCadena("@capsnumcel",this._capsnumcel);
                    this.Conexion.AsignarParametroCadena("@capscorele",this._capscorele);
                    this.Conexion.AsignarParametroCadena("@capsdirper",this._capsdirper);
                    this.Conexion.AsignarParametroCadena("@papscodeper",this._papscodeper);
                    this.Conexion.AsignarParametroCadena("@capsfotper",this._capsfotper);
                    this.Conexion.AsignarParametroCadena("@capsnumcid",this._capsnumcid);
                    this.Conexion.AsignarParametroCadena("@capsapemat",this._capsapemat);

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
			        string sql = "update aperson set " +
                                                     "capsfec = @capsfec, " +
                                                     "capssexper = @capssexper, " +
                                                     "capsestper = @capsestper, " +
                                                     "capsapepat = @capsapepat, " +
                                                     "capsnomper = @capsnomper, " +
                                                     "capsnumcel = @capsnumcel, " +
                                                     "capscorele = @capscorele, " +
                                                     "capsdirper = @capsdirper, " +
                                                     "capsfotper = @capsfotper, " +
                                                     "capsnumcid = @capsnumcid, " +
                                                     "capsapemat = @capsapemat" +
                                 " where " +
                                        "papscodeper = @papscodeper";
 
                this.Conexion.PrepararComando(sql); 

                    this.Conexion.AsignarParametroFecha("@capsfec",this._capsfec);
                    this.Conexion.AsignarParametroLogico("@capssexper",this._capssexper);
                    this.Conexion.AsignarParametroLogico("@capsestper",this._capsestper);
                    this.Conexion.AsignarParametroCadena("@capsapepat",this._capsapepat);
                    this.Conexion.AsignarParametroCadena("@capsnomper",this._capsnomper);
                    this.Conexion.AsignarParametroCadena("@capsnumcel",this._capsnumcel);
                    this.Conexion.AsignarParametroCadena("@capscorele",this._capscorele);
                    this.Conexion.AsignarParametroCadena("@capsdirper",this._capsdirper);
                    this.Conexion.AsignarParametroCadena("@papscodeper",this._papscodeper);
                    this.Conexion.AsignarParametroCadena("@capsfotper",this._capsfotper);
                    this.Conexion.AsignarParametroCadena("@capsnumcid",this._capsnumcid);
                    this.Conexion.AsignarParametroCadena("@capsapemat",this._capsapemat);

                    this.Conexion.EjecutarTransaccion();
                    this.Conexion.Desconectar();

                    return true;
                }
            }
            public List<aperson> Lista(string where)
            { 
                List<aperson> ListaResultado = new List<aperson>();
                this.Conexion.Conectar(); 
			    string sql = "select " + 
                                     "capsfec," +
                                     "capssexper," +
                                     "capsestper," +
                                     "capsapepat," +
                                     "capsnomper," +
                                     "capsnumcel," +
                                     "capscorele," +
                                     "capsdirper," +
                                     "papscodeper," +
                                     "capsfotper," +
                                     "capsnumcid," +
                                     "capsapemat " + 
                             "from aperson " ;
 
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
                          aperson Auxiliar = new aperson();
                          Auxiliar.capsfec = ResultadoConsulta.GetDateTime(0);
                          Auxiliar.capssexper = ResultadoConsulta.GetBoolean(1);
                          Auxiliar.capsestper = ResultadoConsulta.GetBoolean(2);
                          Auxiliar.capsapepat = ResultadoConsulta.GetString(3);
                          Auxiliar.capsnomper = ResultadoConsulta.GetString(4);
                          Auxiliar.capsnumcel = ResultadoConsulta.GetString(5);
                          Auxiliar.capscorele = ResultadoConsulta.GetString(6);
                          Auxiliar.capsdirper = ResultadoConsulta.GetString(7);
                          Auxiliar.papscodeper = ResultadoConsulta.GetString(8);
                          Auxiliar.capsfotper = ResultadoConsulta.GetString(9);
                          Auxiliar.capsnumcid = ResultadoConsulta.GetString(10);
                          Auxiliar.capsapemat = ResultadoConsulta.GetString(11);
                          ListaResultado.Add(Auxiliar);
                    }

                }
                this.Conexion.Desconectar();
                return ListaResultado;
            } 
        #endregion 

	}
}


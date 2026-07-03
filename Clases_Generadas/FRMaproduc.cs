using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaRN;
namespace 
    {
        public partial class FRMaproduc : DevComponents.DotNetBar.Office2007Form
        {
            public FRMaproduc()
            {
                InitializeComponent();
            }

		#region Variables
            public aproduc _aproduc = new aproduc();
            public string Cod_aproduc_Mod = ""; 
            public Boolean Modificar = false;
            xnumcor Correlativo = new xnumcor();
        #endregion

        #region Metodos

            public void Limpiar_Casillas()
            { 
                   Modificar = false;
                   BTNGuardar.Text = "Guardar"; 
                   NUDcaproducpreprod.Value = 0; 
                   NUDcaproduccosprod.Value = 0; 
                   TXTcaproducnomprod.Text = ""; 
                   TXTcaproducstkprod.Text = ""; 
                   TXTcaproductalprod.Text = ""; 
                   TXTcaproductipprod.Text = ""; 
                   TXTcaproduccolprod.Text = ""; 
             } 

            public Boolean Verificar_Integridad()
            { 
                   Boolean ban = true;
                   return ban; 
             } 

            public void JalarDatosSeleccion()
            { 
                   BTNGuardar.Text = "Modificar"; 
                   NUDcaproducpreprod.Value = _aproduc.caproducpreprod; 
                   NUDcaproduccosprod.Value = _aproduc.caproduccosprod; 
                   TXTcaproducnomprod.Text = _aproduc.caproducnomprod; 
                   TXTcaproducstkprod.Text = _aproduc.caproducstkprod; 
                   TXTcaproductalprod.Text = _aproduc.caproductalprod; 
                   _aproduc.paproduccodprod = this.Cod_aproduc_Mod;
                   _aproduc.ObtenerDatos();
                   TXTcaproductipprod.Text = _aproduc.caproductipprod; 
                   TXTcaproduccolprod.Text = _aproduc.caproduccolprod; 
             } 

            private string CompletarDigitos(string Numero, int NumeroDigitos)
            { 
                   string aux = Numero.ToString();
                   string aux2 = aux;
                   if (aux.Length > NumeroDigitos)
                   {
                       return aux.Substring(0, NumeroDigitos);
                   }
                   else
                   {
                      for (int i = 1; i <= (NumeroDigitos - aux.Length); i++)
                       {
                           aux2 = "0" + aux2;
                       }
                       return aux2;
                   }
             } 

        #endregion 

        #region Eventos

            private void BTNGuardar_Click(object sender, EventArgs e)
            { 
                   if (Verificar_Integridad())
                   {
                       _aproduc.caproducpreprod= NUDcaproducpreprod.Value; 
                       _aproduc.caproduccosprod= NUDcaproduccosprod.Value; 
                       _aproduc.caproducnomprod= TXTcaproducnomprod.Text; 
                       _aproduc.caproducstkprod= TXTcaproducstkprod.Text; 
                       _aproduc.caproductalprod= TXTcaproductalprod.Text; 
                       _aproduc.caproductipprod= TXTcaproductipprod.Text; 
                       _aproduc.caproduccolprod= TXTcaproduccolprod.Text; 

                        if (!Modificar)
                        {
                            Correlativo.pxnctipcor = "aproduc-";
                            Correlativo.ObtenerSiguiente();
                            _aproduc.paproduccodprod = "aproduc-" + CompletarDigitos(Correlativo.cxncnumcor.ToString(), 12);
                        }
                        if (Modificar)
                        {
                            _aproduc.Modificar();
                            MessageBox.Show("aproduc Modificado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else if (_aproduc.Grabar())
                        {
                            MessageBox.Show("aproduc Guardado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                   }
             } 

            private void FRMaproduc_Load(object sender, EventArgs e)
            {
                if (Modificar)
                {
                    BTNGuardar.Text = "Modificar";
                    JalarDatosSeleccion();
                    this.Text = "Modificar aproduc";
                    this.BTNGuardar.Text = "Modificar";
                }
                else
                {
                    _aproduc = new aproduc();
                    this.Text = "Registrar aproduc";
                    this.BTNGuardar.Text = "Registrar";
                    Limpiar_Casillas();
                }
            } 


            private void BTNCancelar_Click(object sender, EventArgs e)
            {
                this.Close();
            } 


            private void BTNLimpiarCasillas_Click(object sender, EventArgs e)
            {
                Limpiar_Casillas();
                if (Modificar)
                {
                    BTNGuardar.Text = "Modificar";
                }
            } 


        #endregion 

	}
}


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
        public partial class FRMaperson : DevComponents.DotNetBar.Office2007Form
        {
            public FRMaperson()
            {
                InitializeComponent();
            }

		#region Variables
            public aperson _aperson = new aperson();
            public string Cod_aperson_Mod = ""; 
            public Boolean Modificar = false;
            xnumcor Correlativo = new xnumcor();
        #endregion

        #region Metodos

            public void Limpiar_Casillas()
            { 
                   Modificar = false;
                   BTNGuardar.Text = "Guardar"; 
                   DTPcapsfec.Value = DateTime.Now; 
                   SWCcapssexper.Value = true; 
                   SWCcapsestper.Value = true; 
                   TXTcapsapepat.Text = ""; 
                   TXTcapsnomper.Text = ""; 
                   TXTcapsnumcel.Text = ""; 
                   TXTcapscorele.Text = ""; 
                   TXTcapsdirper.Text = ""; 
                   TXTcapsfotper.Text = ""; 
                   TXTcapsnumcid.Text = ""; 
                   TXTcapsapemat.Text = ""; 
             } 

            public Boolean Verificar_Integridad()
            { 
                   Boolean ban = true;
                   return ban; 
             } 

            public void JalarDatosSeleccion()
            { 
                   BTNGuardar.Text = "Modificar"; 
                   DTPcapsfec.Value = _aperson.capsfec; 
                   SWCcapssexper.Value = _aperson.capssexper; 
                   SWCcapsestper.Value = _aperson.capsestper; 
                   TXTcapsapepat.Text = _aperson.capsapepat; 
                   TXTcapsnomper.Text = _aperson.capsnomper; 
                   TXTcapsnumcel.Text = _aperson.capsnumcel; 
                   TXTcapscorele.Text = _aperson.capscorele; 
                   TXTcapsdirper.Text = _aperson.capsdirper; 
                   _aperson.papscodeper = this.Cod_aperson_Mod;
                   _aperson.ObtenerDatos();
                   TXTcapsfotper.Text = _aperson.capsfotper; 
                   TXTcapsnumcid.Text = _aperson.capsnumcid; 
                   TXTcapsapemat.Text = _aperson.capsapemat; 
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
                       _aperson.capsfec= DTPcapsfec.Value; 
                       _aperson.capssexper= SWCcapssexper.Value; 
                       _aperson.capsestper= SWCcapsestper.Value; 
                       _aperson.capsapepat= TXTcapsapepat.Text; 
                       _aperson.capsnomper= TXTcapsnomper.Text; 
                       _aperson.capsnumcel= TXTcapsnumcel.Text; 
                       _aperson.capscorele= TXTcapscorele.Text; 
                       _aperson.capsdirper= TXTcapsdirper.Text; 
                       _aperson.capsfotper= TXTcapsfotper.Text; 
                       _aperson.capsnumcid= TXTcapsnumcid.Text; 
                       _aperson.capsapemat= TXTcapsapemat.Text; 

                        if (!Modificar)
                        {
                            Correlativo.pxnctipcor = "aperson-";
                            Correlativo.ObtenerSiguiente();
                            _aperson.papscodeper = "aperson-" + CompletarDigitos(Correlativo.cxncnumcor.ToString(), 12);
                        }
                        if (Modificar)
                        {
                            _aperson.Modificar();
                            MessageBox.Show("aperson Modificado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else if (_aperson.Grabar())
                        {
                            MessageBox.Show("aperson Guardado correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                   }
             } 

            private void FRMaperson_Load(object sender, EventArgs e)
            {
                if (Modificar)
                {
                    BTNGuardar.Text = "Modificar";
                    JalarDatosSeleccion();
                    this.Text = "Modificar aperson";
                    this.BTNGuardar.Text = "Modificar";
                }
                else
                {
                    _aperson = new aperson();
                    this.Text = "Registrar aperson";
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


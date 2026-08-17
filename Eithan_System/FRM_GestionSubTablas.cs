using CapaRN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eithan_System
{
    public partial class FRM_GestionSubTablas : DevComponents.DotNetBar.Office2007Form
    {
        #region Variables
        
        public String nombreTabla = "";
        private xnumcor correlativo = new xnumcor();
        private acatego tabla = new acatego();
        public String codTabMod = "";

        public bool modificar = false;
        public bool actualizar = false;
        #endregion

        #region Constructor
        public FRM_GestionSubTablas()
        {
            InitializeComponent();

        }
        #endregion

        #region Metodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (TXT_Nombre.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el nombre de " + this.nombreTabla, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_Nombre.Focus();
                respuesta = false;
            }

            return respuesta;
        }

        #endregion

        #region Eventos
        private void FRM_GestionSubTablas_Load(object sender, EventArgs e)
        {
            TXT_Nombre.Text = this.nombreTabla;
            GPPanelPrincipal.Text = "Agregar " + this.nombreTabla;

        }
        private void BTNCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BTNAgregar_Click(object sender, EventArgs e)
        {
            if (VerificarIntegridad())
            {
                tabla = new acatego();

                
                    correlativo.pxnctipcor = "acatego";

                if (correlativo.ObtenerSiguiente())
                {

                    tabla.cacdcodcat = "CAT-" + correlativo.cxncnumcor.ToString("D3");
                }
               

                tabla.cacdnomcat = TXT_Nombre.Text.Trim();

                   if (tabla.Grabar2())
                    {
                        MessageBox.Show("Categoría guardada correctamente!!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.actualizar = true;
                        this.Close();
                    }             
            }
        }
        #endregion
    }
}

using AForge.Video.DirectShow;
using CapaRN;
using Eithan_System.Properties;
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
    public partial class FRMUsuarioRegistrar : DevComponents.DotNetBar.Office2007Form
    {

        #region Variables
        private aususis usuario = new aususis();
        private xnumcor correlativo = new xnumcor();
        public bool modificar = false;
        public String codUsuMod = "";
        public bool actualizar = false;



        #endregion

        #region Constructor
        public FRMUsuarioRegistrar()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private bool VerificarIntegridad()
        {
            bool respuesta = true;

            if (TXT_LoginUsuario.Text.Replace(" ", "") == "")
            {
                MessageBox.Show("Introduzca el login del usuario", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_LoginUsuario.Focus();
                respuesta = false;
            }
           
             
            return respuesta;
        }
        private void LimpiarCasillas()
        {
            SWB_Estado.Value = true;
            TXT_CI.Text = "";
            TXT_Nombres.Text = "Nombre Completo";
            TXT_LoginUsuario.Text = "";
            TXT_LoginUsuario.Focus();

        }

        private void JalarDatos()
        {
            usuario.pauscodusu = this.codUsuMod;
            usuario.ObtenerDatos();

            SWB_Estado.Value = usuario.causestusu;
            TXT_CI.Text = "";
            TXT_Nombres.Text = "";
            TXT_LoginUsuario = usuario.causnomlog;

        }
        #endregion
        private void TXT_Nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTN_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRMUsuarioRegistrar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar el formulario?",
                               "Pregunta",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question,
                               MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                e.Cancel = true;
            }
            
        }

        private void TXT_CI_Enter(object sender, EventArgs e)
        {

        }

        private void FRMUsuarioRegistrar_Load(object sender, EventArgs e)
        {
           
            if (this.modificar)
            {
                JalarDatos();
                BTN_Grabar.Text = "&Modificar";
                this.Text = "Modificar Usuario";
                GP_Panel_Usuario.Text = "Modificar Usuario";
                TXT_CI.Focus();
            }
            else
            {
                LimpiarCasillas();
                BTN_Grabar.Text = "&Guardar";
                this.Text = "Registrar Usuario";
                GP_Panel_Usuario.Text = "Registrar Usuario";
                TXT_CI.Focus();
            }
        }

        private void TXT_LoginUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            bool tecla_valida = false;
            //Identificar si es una tecla válida
            if ((e.KeyCode >= Keys.NumPad0) && (e.KeyCode <= Keys.NumPad9))
                tecla_valida = true;
            else if ((e.KeyCode >= Keys.D0) && (e.KeyCode <= Keys.D9) && !e.Shift)
                tecla_valida = true;
            else if ((e.KeyCode == Keys.Subtract) ||
                (e.KeyCode == Keys.Back) ||
                (e.KeyCode == Keys.Delete) ||
                (e.KeyCode == Keys.Left) ||
                (e.KeyCode == Keys.Right) ||
                ((e.KeyCode == Keys.OemMinus) && !e.Shift))
                tecla_valida = true;
            if (!tecla_valida)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}

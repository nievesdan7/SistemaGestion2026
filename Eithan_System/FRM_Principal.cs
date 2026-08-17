
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
    public partial class FRM_Principal : DevComponents.DotNetBar.Office2007Form
    {

        public aususis usuario = new aususis();
        public aperson persona = new aperson();
        #region Constructor
        public FRM_Principal()
        {
            InitializeComponent();
        }
        #endregion

        #region Metodos

        private void Estado_1() {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRM_Fondo1 a = new FRM_Fondo1();
            a.MdiParent = this;
            a.Show();
            BTNActualizarPassword.Enabled = false;
            BTNCerrarSesion.Enabled = false;
            RTB_Administracion.Enabled = false;
            RBPAdministracion.Enabled = false;
            BTNLogin.Enabled = true;
            BTN_LoginHuella.Enabled = true;
        }

        private void Estado_2()
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRM_Fondo2 a = new FRM_Fondo2();
            a.MdiParent = this;
            a.persona = this.persona;
            a.usuario = this.usuario;
            a.Show();
            BTNActualizarPassword.Enabled = true;
            BTNCerrarSesion.Enabled = true;
            RTB_Administracion.Enabled = true;
            RBPAdministracion.Enabled = true;
            BTNLogin.Enabled = false;
            BTN_LoginHuella.Enabled = false;
        }

        #endregion

        #region Eventos
        private void FRM_Principal_Load(object sender, EventArgs e)
        {
            FRM_Splash banner = new FRM_Splash();
            banner.ShowDialog();
            this.Opacity = 1;
            Estado_1();
        }

        private void BTN_Personas_Click(object sender, EventArgs e)
        {
            foreach ( Form s in this.MdiChildren )
            {
                s.Close();
            }
            FRM_Persona_Lista a = new FRM_Persona_Lista();
            a.MdiParent = this;
            a.Show();
        }

        private void BTN_Usuarios_Click(object sender, EventArgs e)
        {
            foreach (Form s in this.MdiChildren)
            {
                s.Close();
            }
            FRMUsuarioLista a = new FRMUsuarioLista();
            a.MdiParent = this;
            a.Show();
        }

        private void BTNLogin_Click(object sender, EventArgs e)
        {
            FRM_IniciarSesion a = new FRM_IniciarSesion();
            a.ShowDialog();
            if (a.actualizar_password) {
                FRM_Modificar_Password b = new FRM_Modificar_Password();
                b.usuario = a.usuario;
                b.persona = a.persona;
                b.ShowDialog();
            }
            if (a.login_exitoso) {
                MessageBox.Show("Bienvenido al sistema "+a.persona.capsnomper,"Validacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            if (a.login_exitoso)
            {
                this.persona = a.persona;
                this.usuario = a.usuario;
                Estado_2();
            }
        }

        private void BTN_LoginHuella_Click(object sender, EventArgs e)
        {
            FRM_Iniciar_Sesion_Huella a = new FRM_Iniciar_Sesion_Huella();
            a.ShowDialog();
            if(a.login_exitoso) {
                
                this.persona = a.persona;
                this.usuario = a.usuario;
                Estado_2();
            }
        }
        #endregion

        private void BTNCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                                "Cerrar Sesión",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Estado_1();
            }
        }
    }
}

namespace Eithan_System
{
    partial class FRM_GestionSubTablas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GPPanelPrincipal = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.TXT_Nombre = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.BTNCancelar = new DevComponents.DotNetBar.ButtonX();
            this.BTNAgregar = new DevComponents.DotNetBar.ButtonX();
            this.GPPanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GPPanelPrincipal
            // 
            this.GPPanelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.GPPanelPrincipal.CanvasColor = System.Drawing.SystemColors.Control;
            this.GPPanelPrincipal.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.GPPanelPrincipal.Controls.Add(this.TXT_Nombre);
            this.GPPanelPrincipal.Controls.Add(this.BTNCancelar);
            this.GPPanelPrincipal.Controls.Add(this.BTNAgregar);
            this.GPPanelPrincipal.DisabledBackColor = System.Drawing.Color.Empty;
            this.GPPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GPPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.GPPanelPrincipal.Name = "GPPanelPrincipal";
            this.GPPanelPrincipal.Size = new System.Drawing.Size(255, 119);
            // 
            // 
            // 
            this.GPPanelPrincipal.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.GPPanelPrincipal.Style.BackColorGradientAngle = 90;
            this.GPPanelPrincipal.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.GPPanelPrincipal.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelPrincipal.Style.BorderBottomWidth = 1;
            this.GPPanelPrincipal.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.GPPanelPrincipal.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelPrincipal.Style.BorderLeftWidth = 1;
            this.GPPanelPrincipal.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelPrincipal.Style.BorderRightWidth = 1;
            this.GPPanelPrincipal.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.GPPanelPrincipal.Style.BorderTopWidth = 1;
            this.GPPanelPrincipal.Style.CornerDiameter = 4;
            this.GPPanelPrincipal.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.GPPanelPrincipal.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.GPPanelPrincipal.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.GPPanelPrincipal.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.GPPanelPrincipal.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.GPPanelPrincipal.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GPPanelPrincipal.TabIndex = 2;
            this.GPPanelPrincipal.Text = "Tabla";
            // 
            // TXT_Nombre
            // 
            // 
            // 
            // 
            this.TXT_Nombre.Border.Class = "TextBoxBorder";
            this.TXT_Nombre.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Nombre.Location = new System.Drawing.Point(9, 18);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.PreventEnterBeep = true;
            this.TXT_Nombre.Size = new System.Drawing.Size(233, 23);
            this.TXT_Nombre.TabIndex = 15;
            this.TXT_Nombre.WatermarkText = "Introduzca el nombre";
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTNCancelar.Image = global::Eithan_System.Properties.Resources.ic_salir_app1;
            this.BTNCancelar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNCancelar.Location = new System.Drawing.Point(124, 47);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(118, 39);
            this.BTNCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNCancelar.TabIndex = 3;
            this.BTNCancelar.Text = "&Cancelar";
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // BTNAgregar
            // 
            this.BTNAgregar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTNAgregar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTNAgregar.Image = global::Eithan_System.Properties.Resources.ic_agregar;
            this.BTNAgregar.ImageFixedSize = new System.Drawing.Size(30, 30);
            this.BTNAgregar.Location = new System.Drawing.Point(9, 47);
            this.BTNAgregar.Name = "BTNAgregar";
            this.BTNAgregar.Size = new System.Drawing.Size(109, 39);
            this.BTNAgregar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTNAgregar.TabIndex = 2;
            this.BTNAgregar.Text = "&Agregar";
            this.BTNAgregar.Click += new System.EventHandler(this.BTNAgregar_Click);
            // 
            // FRM_GestionSubTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 119);
            this.Controls.Add(this.GPPanelPrincipal);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_GestionSubTablas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_GestionSubTablas";
            this.Load += new System.EventHandler(this.FRM_GestionSubTablas_Load);
            this.GPPanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel GPPanelPrincipal;
        private DevComponents.DotNetBar.ButtonX BTNCancelar;
        private DevComponents.DotNetBar.ButtonX BTNAgregar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Nombre;
    }
}
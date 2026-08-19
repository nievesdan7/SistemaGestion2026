namespace Eithan_System
{
    partial class FRM_Producto_Lista
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.EPN_Opciones = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTN_Reporte = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Modificar = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Registrar = new DevComponents.DotNetBar.ButtonX();
            this.DTG_Lista = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn();
            this.Column11 = new DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn();
            this.Column12 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.Column13 = new DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn();
            this.EPN_Filtrar = new DevComponents.DotNetBar.ExpandablePanel();
            this.BTN_Okey = new DevComponents.DotNetBar.ButtonX();
            this.BTN_AgregarProducto = new DevComponents.DotNetBar.ButtonX();
            this.BTN_Buscar = new DevComponents.DotNetBar.ButtonX();
            this.TXT_Filtrar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IIN_Filas = new DevComponents.Editors.IntegerInput();
            this.EPN_Opciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Lista)).BeginInit();
            this.EPN_Filtrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).BeginInit();
            this.SuspendLayout();
            // 
            // EPN_Opciones
            // 
            this.EPN_Opciones.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPN_Opciones.CollapseDirection = DevComponents.DotNetBar.eCollapseDirection.RightToLeft;
            this.EPN_Opciones.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPN_Opciones.Controls.Add(this.BTN_Reporte);
            this.EPN_Opciones.Controls.Add(this.BTN_Modificar);
            this.EPN_Opciones.Controls.Add(this.BTN_Registrar);
            this.EPN_Opciones.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPN_Opciones.Dock = System.Windows.Forms.DockStyle.Left;
            this.EPN_Opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPN_Opciones.HideControlsWhenCollapsed = true;
            this.EPN_Opciones.Location = new System.Drawing.Point(0, 0);
            this.EPN_Opciones.Name = "EPN_Opciones";
            this.EPN_Opciones.Size = new System.Drawing.Size(72, 407);
            this.EPN_Opciones.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Opciones.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Opciones.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPN_Opciones.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPN_Opciones.Style.GradientAngle = 90;
            this.EPN_Opciones.TabIndex = 17;
            this.EPN_Opciones.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Opciones.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Opciones.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPN_Opciones.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPN_Opciones.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPN_Opciones.TitleStyle.GradientAngle = 90;
            this.EPN_Opciones.TitleStyleMouseDown.BackColor1.Color = System.Drawing.Color.Transparent;
            this.EPN_Opciones.TitleText = "Opciones";
            // 
            // BTN_Reporte
            // 
            this.BTN_Reporte.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Reporte.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Reporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Reporte.Image = global::Eithan_System.Properties.Resources.icons8_producto_48__3_;
            this.BTN_Reporte.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Reporte.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Reporte.Location = new System.Drawing.Point(0, 186);
            this.BTN_Reporte.Name = "BTN_Reporte";
            this.BTN_Reporte.Size = new System.Drawing.Size(72, 81);
            this.BTN_Reporte.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Reporte.TabIndex = 6;
            this.BTN_Reporte.Text = "Reporte";
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Modificar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Modificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Modificar.Image = global::Eithan_System.Properties.Resources.icons8_producto_48__2_;
            this.BTN_Modificar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Modificar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Modificar.Location = new System.Drawing.Point(0, 106);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(72, 80);
            this.BTN_Modificar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Modificar.TabIndex = 5;
            this.BTN_Modificar.Text = "Modificar ";
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Registrar
            // 
            this.BTN_Registrar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Registrar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Registrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.BTN_Registrar.Image = global::Eithan_System.Properties.Resources.icons8_producto_48__1_;
            this.BTN_Registrar.ImageFixedSize = new System.Drawing.Size(60, 60);
            this.BTN_Registrar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Registrar.Location = new System.Drawing.Point(0, 26);
            this.BTN_Registrar.Name = "BTN_Registrar";
            this.BTN_Registrar.Size = new System.Drawing.Size(72, 80);
            this.BTN_Registrar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Registrar.TabIndex = 4;
            this.BTN_Registrar.Text = "Registrar ";
            this.BTN_Registrar.Click += new System.EventHandler(this.BTN_Registrar_Click);
            // 
            // DTG_Lista
            // 
            this.DTG_Lista.AllowUserToAddRows = false;
            this.DTG_Lista.AllowUserToDeleteRows = false;
            this.DTG_Lista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTG_Lista.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_Lista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DTG_Lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTG_Lista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DTG_Lista.DefaultCellStyle = dataGridViewCellStyle5;
            this.DTG_Lista.EnableHeadersVisualStyles = false;
            this.DTG_Lista.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(157)))));
            this.DTG_Lista.Location = new System.Drawing.Point(72, 93);
            this.DTG_Lista.MultiSelect = false;
            this.DTG_Lista.Name = "DTG_Lista";
            this.DTG_Lista.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DTG_Lista.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DTG_Lista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTG_Lista.Size = new System.Drawing.Size(822, 314);
            this.DTG_Lista.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Codigo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.Checked = true;
            this.Column2.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.Column2.CheckValue = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.FillWeight = 84.72402F;
            this.Column2.HeaderText = "Estado";
            this.Column2.MinimumWidth = 60;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 60;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.FillWeight = 137.6461F;
            this.Column3.HeaderText = "Nombre";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.FillWeight = 152.7503F;
            this.Column4.HeaderText = "Categoria";
            this.Column4.MinimumWidth = 120;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column5.FillWeight = 137.9986F;
            this.Column5.HeaderText = "Modelo";
            this.Column5.MinimumWidth = 120;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.Format = "d";
            dataGridViewCellStyle3.NullValue = null;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.FillWeight = 83.67951F;
            this.Column7.HeaderText = "Marca";
            this.Column7.MinimumWidth = 80;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column8.FillWeight = 60.70373F;
            this.Column8.HeaderText = "Material";
            this.Column8.MinimumWidth = 60;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 83;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column9.FillWeight = 80.55662F;
            this.Column9.HeaderText = "Color";
            this.Column9.MinimumWidth = 80;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            // 
            // 
            // 
            this.Column10.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Column10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column10.FillWeight = 97.67016F;
            this.Column10.HeaderText = "Stock";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 68;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            // 
            // 
            // 
            this.Column11.BackgroundStyle.Class = "DataGridViewNumericBorder";
            this.Column11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column11.FillWeight = 92.44769F;
            this.Column11.HeaderText = "Precio Venta";
            this.Column11.Increment = 1D;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 105;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            // 
            // 
            // 
            this.Column12.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.Column12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column12.FillWeight = 87.89562F;
            this.Column12.HeaderText = "Fecha Creacion";
            this.Column12.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Column12.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column12.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.Column12.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column12.MonthCalendar.DisplayMonth = new System.DateTime(2026, 8, 1, 0, 0, 0, 0);
            this.Column12.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.Column12.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 121;
            // 
            // Column13
            // 
            this.Column13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            // 
            // 
            // 
            this.Column13.BackgroundStyle.Class = "DataGridViewDateTimeBorder";
            this.Column13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column13.FillWeight = 83.92788F;
            this.Column13.HeaderText = "Fecha Modificacion";
            this.Column13.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            // 
            // 
            // 
            // 
            // 
            // 
            this.Column13.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column13.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            // 
            // 
            // 
            this.Column13.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column13.MonthCalendar.DisplayMonth = new System.DateTime(2026, 8, 1, 0, 0, 0, 0);
            this.Column13.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            // 
            // 
            // 
            this.Column13.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 141;
            // 
            // EPN_Filtrar
            // 
            this.EPN_Filtrar.CanvasColor = System.Drawing.SystemColors.Control;
            this.EPN_Filtrar.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.EPN_Filtrar.Controls.Add(this.BTN_Okey);
            this.EPN_Filtrar.Controls.Add(this.BTN_AgregarProducto);
            this.EPN_Filtrar.Controls.Add(this.BTN_Buscar);
            this.EPN_Filtrar.Controls.Add(this.TXT_Filtrar);
            this.EPN_Filtrar.Controls.Add(this.IIN_Filas);
            this.EPN_Filtrar.DisabledBackColor = System.Drawing.Color.Empty;
            this.EPN_Filtrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.EPN_Filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EPN_Filtrar.HideControlsWhenCollapsed = true;
            this.EPN_Filtrar.Location = new System.Drawing.Point(72, 0);
            this.EPN_Filtrar.Name = "EPN_Filtrar";
            this.EPN_Filtrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EPN_Filtrar.Size = new System.Drawing.Size(822, 93);
            this.EPN_Filtrar.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Filtrar.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Filtrar.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.EPN_Filtrar.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.EPN_Filtrar.Style.GradientAngle = 90;
            this.EPN_Filtrar.TabIndex = 29;
            this.EPN_Filtrar.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
            this.EPN_Filtrar.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.EPN_Filtrar.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.EPN_Filtrar.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.EPN_Filtrar.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.EPN_Filtrar.TitleStyle.GradientAngle = 90;
            this.EPN_Filtrar.TitleStyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EPN_Filtrar.TitleText = "Filtrar";
            // 
            // BTN_Okey
            // 
            this.BTN_Okey.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Okey.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Okey.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_Okey.Image = global::Eithan_System.Properties.Resources.ico_okey2;
            this.BTN_Okey.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Okey.Location = new System.Drawing.Point(319, 50);
            this.BTN_Okey.Name = "BTN_Okey";
            this.BTN_Okey.Size = new System.Drawing.Size(25, 23);
            this.BTN_Okey.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Okey.TabIndex = 17;
            // 
            // BTN_AgregarProducto
            // 
            this.BTN_AgregarProducto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_AgregarProducto.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_AgregarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BTN_AgregarProducto.Image = global::Eithan_System.Properties.Resources.ic_agregar;
            this.BTN_AgregarProducto.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_AgregarProducto.Location = new System.Drawing.Point(288, 50);
            this.BTN_AgregarProducto.Name = "BTN_AgregarProducto";
            this.BTN_AgregarProducto.Size = new System.Drawing.Size(25, 23);
            this.BTN_AgregarProducto.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_AgregarProducto.TabIndex = 16;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTN_Buscar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTN_Buscar.Image = global::Eithan_System.Properties.Resources.icons8_búsqueda_96;
            this.BTN_Buscar.ImageFixedSize = new System.Drawing.Size(20, 20);
            this.BTN_Buscar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
            this.BTN_Buscar.Location = new System.Drawing.Point(257, 50);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(25, 23);
            this.BTN_Buscar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTN_Buscar.TabIndex = 6;
            // 
            // TXT_Filtrar
            // 
            this.TXT_Filtrar.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TXT_Filtrar.Border.Class = "TextBoxBorder";
            this.TXT_Filtrar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TXT_Filtrar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TXT_Filtrar.DisabledBackColor = System.Drawing.Color.White;
            this.TXT_Filtrar.ForeColor = System.Drawing.Color.Black;
            this.TXT_Filtrar.Location = new System.Drawing.Point(92, 50);
            this.TXT_Filtrar.Name = "TXT_Filtrar";
            this.TXT_Filtrar.PreventEnterBeep = true;
            this.TXT_Filtrar.Size = new System.Drawing.Size(159, 23);
            this.TXT_Filtrar.TabIndex = 5;
            this.TXT_Filtrar.WatermarkText = "Datos a Buscar...";
            // 
            // IIN_Filas
            // 
            // 
            // 
            // 
            this.IIN_Filas.BackgroundStyle.Class = "DateTimeInputBackground";
            this.IIN_Filas.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IIN_Filas.ButtonFreeText.Shortcut = DevComponents.DotNetBar.eShortcut.F2;
            this.IIN_Filas.Increment = 10;
            this.IIN_Filas.Location = new System.Drawing.Point(6, 50);
            this.IIN_Filas.MaxValue = 1000;
            this.IIN_Filas.MinValue = 0;
            this.IIN_Filas.Name = "IIN_Filas";
            this.IIN_Filas.ShowUpDown = true;
            this.IIN_Filas.Size = new System.Drawing.Size(80, 23);
            this.IIN_Filas.TabIndex = 4;
            this.IIN_Filas.Value = 50;
            // 
            // FRM_Producto_Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 407);
            this.ControlBox = false;
            this.Controls.Add(this.DTG_Lista);
            this.Controls.Add(this.EPN_Filtrar);
            this.Controls.Add(this.EPN_Opciones);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRM_Producto_Lista";
            this.Text = "FRM_Producto_Lista";
            this.Load += new System.EventHandler(this.FRM_Producto_Lista_Load);
            this.EPN_Opciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTG_Lista)).EndInit();
            this.EPN_Filtrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IIN_Filas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevComponents.DotNetBar.ExpandablePanel EPN_Opciones;
        private DevComponents.DotNetBar.ButtonX BTN_Reporte;
        private DevComponents.DotNetBar.ButtonX BTN_Modificar;
        private DevComponents.DotNetBar.ButtonX BTN_Registrar;
        private DevComponents.DotNetBar.Controls.DataGridViewX DTG_Lista;
        private DevComponents.DotNetBar.ExpandablePanel EPN_Filtrar;
        private DevComponents.DotNetBar.ButtonX BTN_Okey;
        private DevComponents.DotNetBar.ButtonX BTN_AgregarProducto;
        private DevComponents.DotNetBar.ButtonX BTN_Buscar;
        private DevComponents.DotNetBar.Controls.TextBoxX TXT_Filtrar;
        private DevComponents.Editors.IntegerInput IIN_Filas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private DevComponents.DotNetBar.Controls.DataGridViewCheckBoxXColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private DevComponents.DotNetBar.Controls.DataGridViewIntegerInputColumn Column10;
        private DevComponents.DotNetBar.Controls.DataGridViewDoubleInputColumn Column11;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn Column12;
        private DevComponents.DotNetBar.Controls.DataGridViewDateTimeInputColumn Column13;
    }
}
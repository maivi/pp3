<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProducto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProducto))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupClientes = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtStockInicial = New System.Windows.Forms.TextBox()
        Me.cboGenero = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPreVenta = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPreCompra = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTalle = New System.Windows.Forms.TextBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupOpciones = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.panelProducto = New System.Windows.Forms.Panel()
        Me.panelProveedor = New System.Windows.Forms.Panel()
        Me.dgvProveedor = New System.Windows.Forms.DataGridView()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.panelCategoria = New System.Windows.Forms.Panel()
        Me.dgvTipo = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bsProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsCategoria = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProveedor = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ZapateriaDataSet1 = New Zapateria.zapateriaDataSet()
        Me.GroupClientes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupOpciones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelProducto.SuspendLayout()
        Me.panelProveedor.SuspendLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCategoria.SuspendLayout()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZapateriaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupClientes
        '
        Me.GroupClientes.BackColor = System.Drawing.Color.Transparent
        Me.GroupClientes.Controls.Add(Me.Label13)
        Me.GroupClientes.Controls.Add(Me.txtStockInicial)
        Me.GroupClientes.Controls.Add(Me.cboGenero)
        Me.GroupClientes.Controls.Add(Me.Label12)
        Me.GroupClientes.Controls.Add(Me.txtPreVenta)
        Me.GroupClientes.Controls.Add(Me.txtTipo)
        Me.GroupClientes.Controls.Add(Me.Label8)
        Me.GroupClientes.Controls.Add(Me.txtPreCompra)
        Me.GroupClientes.Controls.Add(Me.Label2)
        Me.GroupClientes.Controls.Add(Me.txtProveedor)
        Me.GroupClientes.Controls.Add(Me.Label5)
        Me.GroupClientes.Controls.Add(Me.txtTalle)
        Me.GroupClientes.Controls.Add(Me.lblTipo)
        Me.GroupClientes.Controls.Add(Me.Label6)
        Me.GroupClientes.Controls.Add(Me.txtNombre)
        Me.GroupClientes.Controls.Add(Me.Label4)
        Me.GroupClientes.Controls.Add(Me.Label1)
        Me.GroupClientes.Controls.Add(Me.txtCodigo)
        Me.GroupClientes.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupClientes.Location = New System.Drawing.Point(4, 7)
        Me.GroupClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupClientes.Name = "GroupClientes"
        Me.GroupClientes.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupClientes.Size = New System.Drawing.Size(567, 386)
        Me.GroupClientes.TabIndex = 7
        Me.GroupClientes.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 254)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(174, 23)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Precio Compra: $"
        '
        'txtStockInicial
        '
        Me.txtStockInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStockInicial.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStockInicial.Location = New System.Drawing.Point(191, 304)
        Me.txtStockInicial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtStockInicial.MaxLength = 12
        Me.txtStockInicial.Name = "txtStockInicial"
        Me.txtStockInicial.Size = New System.Drawing.Size(82, 32)
        Me.txtStockInicial.TabIndex = 24
        '
        'cboGenero
        '
        Me.cboGenero.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cboGenero.FormattingEnabled = True
        Me.cboGenero.Items.AddRange(New Object() {"Hombre", "Mujer", "Niño"})
        Me.cboGenero.Location = New System.Drawing.Point(364, 44)
        Me.cboGenero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboGenero.Name = "cboGenero"
        Me.cboGenero.Size = New System.Drawing.Size(148, 32)
        Me.cboGenero.TabIndex = 23
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(272, 48)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(85, 23)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Genero:"
        '
        'txtPreVenta
        '
        Me.txtPreVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPreVenta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreVenta.Location = New System.Drawing.Point(445, 250)
        Me.txtPreVenta.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPreVenta.MaxLength = 12
        Me.txtPreVenta.Name = "txtPreVenta"
        Me.txtPreVenta.Size = New System.Drawing.Size(94, 32)
        Me.txtPreVenta.TabIndex = 21
        '
        'txtTipo
        '
        Me.txtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTipo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipo.Location = New System.Drawing.Point(313, 149)
        Me.txtTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTipo.MaxLength = 12
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(199, 32)
        Me.txtTipo.TabIndex = 20
        Me.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(284, 254)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 23)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Precio Venta: $"
        '
        'txtPreCompra
        '
        Me.txtPreCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPreCompra.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreCompra.Location = New System.Drawing.Point(191, 250)
        Me.txtPreCompra.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPreCompra.MaxLength = 12
        Me.txtPreCompra.Name = "txtPreCompra"
        Me.txtPreCompra.Size = New System.Drawing.Size(82, 32)
        Me.txtPreCompra.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 153)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Talle:"
        '
        'txtProveedor
        '
        Me.txtProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProveedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedor.Location = New System.Drawing.Point(133, 198)
        Me.txtProveedor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProveedor.MaxLength = 12
        Me.txtProveedor.Name = "txtProveedor"
        Me.txtProveedor.ReadOnly = True
        Me.txtProveedor.Size = New System.Drawing.Size(379, 32)
        Me.txtProveedor.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 306)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Stock Inicial:"
        '
        'txtTalle
        '
        Me.txtTalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTalle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTalle.Location = New System.Drawing.Point(133, 149)
        Me.txtTalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTalle.MaxLength = 12
        Me.txtTalle.Name = "txtTalle"
        Me.txtTalle.Size = New System.Drawing.Size(93, 32)
        Me.txtTalle.TabIndex = 2
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.Location = New System.Drawing.Point(245, 153)
        Me.lblTipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(59, 23)
        Me.lblTipo.TabIndex = 15
        Me.lblTipo.Text = "Tipo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 201)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Proveedor:"
        '
        'txtNombre
        '
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(132, 98)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.MaxLength = 35
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(381, 32)
        Me.txtNombre.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Marca:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Codigo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(132, 46)
        Me.txtCodigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCodigo.MaxLength = 25
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(106, 32)
        Me.txtCodigo.TabIndex = 0
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Teal
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(145, 66)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(135, 38)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Teal
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnActualizar.FlatAppearance.BorderSize = 0
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(145, 66)
        Me.btnActualizar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(135, 38)
        Me.btnActualizar.TabIndex = 10
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Teal
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.FlatAppearance.BorderSize = 0
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(8, 66)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(135, 38)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(13, 14)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1454, 62)
        Me.Panel2.TabIndex = 229
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(408, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(205, 36)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PRODUCTOS"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Teal
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(8, 108)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(135, 38)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'GroupOpciones
        '
        Me.GroupOpciones.BackColor = System.Drawing.Color.Transparent
        Me.GroupOpciones.Controls.Add(Me.btnSalir)
        Me.GroupOpciones.Controls.Add(Me.btnLimpiar)
        Me.GroupOpciones.Controls.Add(Me.btnEliminar)
        Me.GroupOpciones.Controls.Add(Me.btnActualizar)
        Me.GroupOpciones.Controls.Add(Me.btnGuardar)
        Me.GroupOpciones.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupOpciones.Location = New System.Drawing.Point(579, 289)
        Me.GroupOpciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupOpciones.Name = "GroupOpciones"
        Me.GroupOpciones.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupOpciones.Size = New System.Drawing.Size(291, 151)
        Me.GroupOpciones.TabIndex = 55
        Me.GroupOpciones.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Teal
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalir.FlatAppearance.BorderSize = 0
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(145, 108)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(135, 38)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupOpciones)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GroupClientes)
        Me.Panel1.Location = New System.Drawing.Point(13, 89)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(877, 446)
        Me.Panel1.TabIndex = 231
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(579, 7)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(291, 233)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Minion Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 7)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(180, 33)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Nombre/Codigo"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(201, 5)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(392, 34)
        Me.TextBox1.TabIndex = 1
        '
        'dgvProducto
        '
        Me.dgvProducto.AllowUserToAddRows = False
        Me.dgvProducto.AllowUserToDeleteRows = False
        Me.dgvProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducto.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvProducto.Location = New System.Drawing.Point(24, 57)
        Me.dgvProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProducto.MultiSelect = False
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = True
        Me.dgvProducto.RowTemplate.Height = 24
        Me.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducto.Size = New System.Drawing.Size(545, 400)
        Me.dgvProducto.TabIndex = 2
        '
        'panelProducto
        '
        Me.panelProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelProducto.Controls.Add(Me.dgvProducto)
        Me.panelProducto.Controls.Add(Me.TextBox1)
        Me.panelProducto.Controls.Add(Me.Label9)
        Me.panelProducto.Location = New System.Drawing.Point(896, 89)
        Me.panelProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelProducto.Name = "panelProducto"
        Me.panelProducto.Size = New System.Drawing.Size(572, 459)
        Me.panelProducto.TabIndex = 237
        '
        'panelProveedor
        '
        Me.panelProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelProveedor.Controls.Add(Me.dgvProveedor)
        Me.panelProveedor.Controls.Add(Me.TextBox4)
        Me.panelProveedor.Controls.Add(Me.Label10)
        Me.panelProveedor.Location = New System.Drawing.Point(896, 89)
        Me.panelProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelProveedor.Name = "panelProveedor"
        Me.panelProveedor.Size = New System.Drawing.Size(572, 459)
        Me.panelProveedor.TabIndex = 240
        '
        'dgvProveedor
        '
        Me.dgvProveedor.AllowUserToAddRows = False
        Me.dgvProveedor.AllowUserToDeleteRows = False
        Me.dgvProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProveedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProveedor.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProveedor.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvProveedor.Location = New System.Drawing.Point(3, 57)
        Me.dgvProveedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProveedor.MultiSelect = False
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        Me.dgvProveedor.RowTemplate.Height = 24
        Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedor.Size = New System.Drawing.Size(565, 400)
        Me.dgvProveedor.TabIndex = 2
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(232, 5)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(321, 34)
        Me.TextBox4.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Minion Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 33)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Proveedor/CUIT"
        '
        'panelCategoria
        '
        Me.panelCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelCategoria.Controls.Add(Me.dgvTipo)
        Me.panelCategoria.Controls.Add(Me.TextBox5)
        Me.panelCategoria.Controls.Add(Me.Label11)
        Me.panelCategoria.Location = New System.Drawing.Point(896, 89)
        Me.panelCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.panelCategoria.Name = "panelCategoria"
        Me.panelCategoria.Size = New System.Drawing.Size(571, 459)
        Me.panelCategoria.TabIndex = 238
        '
        'dgvTipo
        '
        Me.dgvTipo.AllowUserToAddRows = False
        Me.dgvTipo.AllowUserToDeleteRows = False
        Me.dgvTipo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvTipo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTipo.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvTipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTipo.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTipo.GridColor = System.Drawing.Color.ForestGreen
        Me.dgvTipo.Location = New System.Drawing.Point(1, 57)
        Me.dgvTipo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvTipo.MultiSelect = False
        Me.dgvTipo.Name = "dgvTipo"
        Me.dgvTipo.ReadOnly = True
        Me.dgvTipo.RowTemplate.Height = 24
        Me.dgvTipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTipo.Size = New System.Drawing.Size(567, 400)
        Me.dgvTipo.TabIndex = 2
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(128, 7)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(303, 34)
        Me.TextBox5.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Minion Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 33)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Categoria:"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ZapateriaDataSet1
        '
        Me.ZapateriaDataSet1.DataSetName = "zapateriaDataSet"
        Me.ZapateriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1480, 598)
        Me.Controls.Add(Me.panelProveedor)
        Me.Controls.Add(Me.panelCategoria)
        Me.Controls.Add(Me.panelProducto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupClientes.ResumeLayout(False)
        Me.GroupClientes.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupOpciones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelProducto.ResumeLayout(False)
        Me.panelProducto.PerformLayout()
        Me.panelProveedor.ResumeLayout(False)
        Me.panelProveedor.PerformLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCategoria.ResumeLayout(False)
        Me.panelCategoria.PerformLayout()
        CType(Me.dgvTipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZapateriaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupClientes As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPreCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTalle As System.Windows.Forms.TextBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents GroupOpciones As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtPreVenta As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents panelProducto As System.Windows.Forms.Panel
    Friend WithEvents panelProveedor As System.Windows.Forms.Panel
    Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents panelCategoria As System.Windows.Forms.Panel
    Friend WithEvents dgvTipo As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents bsProductos As System.Windows.Forms.BindingSource
    Friend WithEvents bsCategoria As System.Windows.Forms.BindingSource
    Friend WithEvents bsProveedor As System.Windows.Forms.BindingSource
    Friend WithEvents cboGenero As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtStockInicial As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ZapateriaDataSet1 As Zapateria.zapateriaDataSet
End Class

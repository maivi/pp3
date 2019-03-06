<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVenta
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTalleProducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lvlTotalProducto = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtTotalProducto = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.txtPrecioProducto = New System.Windows.Forms.TextBox()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.txtDocumentoCliente = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LblArticulos = New System.Windows.Forms.Label()
        Me.txtArticulos = New System.Windows.Forms.TextBox()
        Me.btnBorrarProducto = New System.Windows.Forms.Button()
        Me.chBoxDescuento = New System.Windows.Forms.CheckBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.txtDescuento = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvVenta = New System.Windows.Forms.DataGridView()
        Me.cbxFormaPago = New System.Windows.Forms.ComboBox()
        Me.TipopagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ZapateriaDataSet1 = New Zapateria.zapateriaDataSet1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.TextBox()
        Me.txtTotalVenta = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCambioPago = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.ComboBox()
        Me.txtCantidadProductos = New System.Windows.Forms.TextBox()
        Me.cmbCANTIDADProductos = New System.Windows.Forms.ComboBox()
        Me.panProducto = New System.Windows.Forms.Panel()
        Me.txtFiltroCodigo = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.txtFiltroTalle = New System.Windows.Forms.TextBox()
        Me.txtFiltroProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.bsProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.TipopagoTableAdapter = New Zapateria.zapateriaDataSet1TableAdapters.tipopagoTableAdapter()
        Me.lblIdProducto = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCantidadProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipopagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ZapateriaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panProducto.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblFecha)
        Me.Panel2.Controls.Add(Me.lblCajero)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(11, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1896, 51)
        Me.Panel2.TabIndex = 228
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(1475, 16)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(90, 24)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Label17"
        '
        'lblCajero
        '
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajero.Location = New System.Drawing.Point(1123, 18)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.Size = New System.Drawing.Size(167, 23)
        Me.lblCajero.TabIndex = 9
        Me.lblCajero.Text = "aca nombre cajero"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1039, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 21)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Cajero:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(592, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(279, 36)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "REALIZAR VENTA"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSize = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(12, 69)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1037, 889)
        Me.Panel1.TabIndex = 227
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lblIdProducto)
        Me.Panel5.Controls.Add(Me.txtStock)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.txtCodigoProducto)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.txtTalleProducto)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lvlTotalProducto)
        Me.Panel5.Controls.Add(Me.txtNombreProducto)
        Me.Panel5.Controls.Add(Me.txtCantidad)
        Me.Panel5.Controls.Add(Me.txtTotalProducto)
        Me.Panel5.Controls.Add(Me.lblCantidad)
        Me.Panel5.Controls.Add(Me.lblProducto)
        Me.Panel5.Controls.Add(Me.btnAgregarProducto)
        Me.Panel5.Controls.Add(Me.txtPrecioProducto)
        Me.Panel5.Controls.Add(Me.lblPrecio)
        Me.Panel5.Location = New System.Drawing.Point(4, 145)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1023, 135)
        Me.Panel5.TabIndex = 226
        '
        'txtStock
        '
        Me.txtStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStock.Enabled = False
        Me.txtStock.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStock.Location = New System.Drawing.Point(734, 48)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(124, 32)
        Me.txtStock.TabIndex = 201
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(655, 50)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 24)
        Me.Label15.TabIndex = 200
        Me.Label15.Text = "Stock:"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProducto.Enabled = False
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(95, 48)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(124, 32)
        Me.txtCodigoProducto.TabIndex = 199
        Me.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(3, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 24)
        Me.Label11.TabIndex = 198
        Me.Label11.Text = "Codigo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(421, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(231, 34)
        Me.Label9.TabIndex = 197
        Me.Label9.Text = "Datos Producto"
        '
        'txtTalleProducto
        '
        Me.txtTalleProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTalleProducto.Enabled = False
        Me.txtTalleProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTalleProducto.Location = New System.Drawing.Point(74, 97)
        Me.txtTalleProducto.Name = "txtTalleProducto"
        Me.txtTalleProducto.Size = New System.Drawing.Size(70, 32)
        Me.txtTalleProducto.TabIndex = 196
        Me.txtTalleProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(3, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 24)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "Talle:"
        '
        'lvlTotalProducto
        '
        Me.lvlTotalProducto.AutoSize = True
        Me.lvlTotalProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlTotalProducto.ForeColor = System.Drawing.Color.Black
        Me.lvlTotalProducto.Location = New System.Drawing.Point(637, 102)
        Me.lvlTotalProducto.Name = "lvlTotalProducto"
        Me.lvlTotalProducto.Size = New System.Drawing.Size(86, 24)
        Me.lvlTotalProducto.TabIndex = 194
        Me.lvlTotalProducto.Text = "Total: $"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreProducto.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNombreProducto.Enabled = False
        Me.txtNombreProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(363, 48)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(272, 32)
        Me.txtNombreProducto.TabIndex = 192
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(553, 96)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(54, 32)
        Me.txtCantidad.TabIndex = 191
        '
        'txtTotalProducto
        '
        Me.txtTotalProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalProducto.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTotalProducto.Enabled = False
        Me.txtTotalProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalProducto.Location = New System.Drawing.Point(728, 96)
        Me.txtTotalProducto.Name = "txtTotalProducto"
        Me.txtTotalProducto.Size = New System.Drawing.Size(115, 32)
        Me.txtTotalProducto.TabIndex = 190
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Black
        Me.lblCantidad.Location = New System.Drawing.Point(442, 102)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(107, 24)
        Me.lblCantidad.TabIndex = 187
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.Black
        Me.lblProducto.Location = New System.Drawing.Point(249, 50)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(108, 24)
        Me.lblProducto.TabIndex = 186
        Me.lblProducto.Text = "Producto:"
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.Teal
        Me.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnAgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarProducto.Location = New System.Drawing.Point(857, 94)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAgregarProducto.Size = New System.Drawing.Size(134, 32)
        Me.btnAgregarProducto.TabIndex = 185
        Me.btnAgregarProducto.Text = "AGREGAR"
        Me.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAgregarProducto.UseVisualStyleBackColor = False
        '
        'txtPrecioProducto
        '
        Me.txtPrecioProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioProducto.Cursor = System.Windows.Forms.Cursors.No
        Me.txtPrecioProducto.Enabled = False
        Me.txtPrecioProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioProducto.Location = New System.Drawing.Point(304, 97)
        Me.txtPrecioProducto.Name = "txtPrecioProducto"
        Me.txtPrecioProducto.Size = New System.Drawing.Size(100, 32)
        Me.txtPrecioProducto.TabIndex = 189
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.Black
        Me.lblPrecio.Location = New System.Drawing.Point(199, 102)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(99, 24)
        Me.lblPrecio.TabIndex = 188
        Me.lblPrecio.Text = "Precio: $"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.btnClientes)
        Me.Panel4.Controls.Add(Me.lbltelefono)
        Me.Panel4.Controls.Add(Me.txtNombreCliente)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtDireccionCliente)
        Me.Panel4.Controls.Add(Me.txtDocumentoCliente)
        Me.Panel4.Controls.Add(Me.lblNombre)
        Me.Panel4.Controls.Add(Me.lblDocumento)
        Me.Panel4.Controls.Add(Me.txtTelefonoCliente)
        Me.Panel4.Location = New System.Drawing.Point(3, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1024, 121)
        Me.Panel4.TabIndex = 225
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(426, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(203, 34)
        Me.Label10.TabIndex = 198
        Me.Label10.Text = "Datos Cliente"
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.Color.Teal
        Me.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClientes.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.Color.Black
        Me.btnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClientes.Location = New System.Drawing.Point(858, 47)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(117, 32)
        Me.btnClientes.TabIndex = 184
        Me.btnClientes.Text = "BUSCAR"
        Me.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.ForeColor = System.Drawing.Color.Black
        Me.lbltelefono.Location = New System.Drawing.Point(459, 87)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(104, 24)
        Me.lbltelefono.TabIndex = 190
        Me.lbltelefono.Text = "Telefono:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCliente.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNombreCliente.Enabled = False
        Me.txtNombreCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(122, 47)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(319, 32)
        Me.txtNombreCliente.TabIndex = 188
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Dirección:"
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccionCliente.Cursor = System.Windows.Forms.Cursors.No
        Me.txtDireccionCliente.Enabled = False
        Me.txtDireccionCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionCliente.Location = New System.Drawing.Point(122, 85)
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(319, 32)
        Me.txtDireccionCliente.TabIndex = 189
        '
        'txtDocumentoCliente
        '
        Me.txtDocumentoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocumentoCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDocumentoCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentoCliente.Location = New System.Drawing.Point(604, 47)
        Me.txtDocumentoCliente.MaxLength = 12
        Me.txtDocumentoCliente.Name = "txtDocumentoCliente"
        Me.txtDocumentoCliente.Size = New System.Drawing.Size(247, 32)
        Me.txtDocumentoCliente.TabIndex = 183
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(4, 49)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(97, 24)
        Me.lblNombre.TabIndex = 186
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.Black
        Me.lblDocumento.Location = New System.Drawing.Point(459, 49)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(132, 24)
        Me.lblDocumento.TabIndex = 185
        Me.lblDocumento.Text = "Documento:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonoCliente.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTelefonoCliente.Enabled = False
        Me.txtTelefonoCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(604, 85)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(247, 32)
        Me.txtTelefonoCliente.TabIndex = 191
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.Controls.Add(Me.LblArticulos)
        Me.Panel3.Controls.Add(Me.txtArticulos)
        Me.Panel3.Controls.Add(Me.btnBorrarProducto)
        Me.Panel3.Controls.Add(Me.chBoxDescuento)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.txtDescuento)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.dgvVenta)
        Me.Panel3.Controls.Add(Me.cbxFormaPago)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.btnCancelar)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtPago)
        Me.Panel3.Controls.Add(Me.txtTotalVenta)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtCambioPago)
        Me.Panel3.Location = New System.Drawing.Point(4, 286)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1023, 593)
        Me.Panel3.TabIndex = 224
        '
        'LblArticulos
        '
        Me.LblArticulos.AutoSize = True
        Me.LblArticulos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblArticulos.ForeColor = System.Drawing.Color.Black
        Me.LblArticulos.Location = New System.Drawing.Point(755, 312)
        Me.LblArticulos.Name = "LblArticulos"
        Me.LblArticulos.Size = New System.Drawing.Size(116, 21)
        Me.LblArticulos.TabIndex = 234
        Me.LblArticulos.Text = "ARTÍCULOS:"
        '
        'txtArticulos
        '
        Me.txtArticulos.BackColor = System.Drawing.SystemColors.Info
        Me.txtArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArticulos.Cursor = System.Windows.Forms.Cursors.No
        Me.txtArticulos.Enabled = False
        Me.txtArticulos.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulos.Location = New System.Drawing.Point(885, 302)
        Me.txtArticulos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtArticulos.Name = "txtArticulos"
        Me.txtArticulos.Size = New System.Drawing.Size(135, 36)
        Me.txtArticulos.TabIndex = 233
        '
        'btnBorrarProducto
        '
        Me.btnBorrarProducto.BackColor = System.Drawing.Color.Teal
        Me.btnBorrarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnBorrarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBorrarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBorrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarProducto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarProducto.ForeColor = System.Drawing.Color.Black
        Me.btnBorrarProducto.Location = New System.Drawing.Point(786, 6)
        Me.btnBorrarProducto.Name = "btnBorrarProducto"
        Me.btnBorrarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnBorrarProducto.Size = New System.Drawing.Size(154, 69)
        Me.btnBorrarProducto.TabIndex = 232
        Me.btnBorrarProducto.Text = "BORRAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "PRODUCTO"
        Me.btnBorrarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBorrarProducto.UseVisualStyleBackColor = False
        '
        'chBoxDescuento
        '
        Me.chBoxDescuento.AutoSize = True
        Me.chBoxDescuento.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chBoxDescuento.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBoxDescuento.Location = New System.Drawing.Point(942, 208)
        Me.chBoxDescuento.Name = "chBoxDescuento"
        Me.chBoxDescuento.Size = New System.Drawing.Size(18, 17)
        Me.chBoxDescuento.TabIndex = 231
        Me.chBoxDescuento.UseVisualStyleBackColor = True
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(891, 195)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(29, 32)
        Me.TextBox4.TabIndex = 230
        Me.TextBox4.Text = "%"
        '
        'txtDescuento
        '
        Me.txtDescuento.Enabled = False
        Me.txtDescuento.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuento.Location = New System.Drawing.Point(849, 195)
        Me.txtDescuento.Mask = "99"
        Me.txtDescuento.Name = "txtDescuento"
        Me.txtDescuento.Size = New System.Drawing.Size(36, 32)
        Me.txtDescuento.TabIndex = 200
        Me.txtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(720, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 24)
        Me.Label12.TabIndex = 229
        Me.Label12.Text = "Descuento:"
        '
        'dgvVenta
        '
        Me.dgvVenta.AllowUserToAddRows = False
        Me.dgvVenta.AllowUserToDeleteRows = False
        Me.dgvVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.txtCodigo, Me.txtProducto, Me.txtTalle, Me.txtPrecio, Me.txtCantidadProd, Me.txtTotalProd})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVenta.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVenta.Location = New System.Drawing.Point(6, 6)
        Me.dgvVenta.MultiSelect = False
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.ReadOnly = True
        Me.dgvVenta.RowTemplate.Height = 24
        Me.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVenta.Size = New System.Drawing.Size(696, 584)
        Me.dgvVenta.TabIndex = 228
        '
        'cbxFormaPago
        '
        Me.cbxFormaPago.DataSource = Me.TipopagoBindingSource
        Me.cbxFormaPago.DisplayMember = "Nombre"
        Me.cbxFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxFormaPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFormaPago.FormattingEnabled = True
        Me.cbxFormaPago.Location = New System.Drawing.Point(838, 265)
        Me.cbxFormaPago.Name = "cbxFormaPago"
        Me.cbxFormaPago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxFormaPago.Size = New System.Drawing.Size(182, 32)
        Me.cbxFormaPago.TabIndex = 227
        Me.cbxFormaPago.ValueMember = "Nombre"
        '
        'TipopagoBindingSource
        '
        Me.TipopagoBindingSource.DataMember = "tipopago"
        Me.TipopagoBindingSource.DataSource = Me.ZapateriaDataSet1
        '
        'ZapateriaDataSet1
        '
        Me.ZapateriaDataSet1.DataSetName = "zapateriaDataSet1"
        Me.ZapateriaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(730, 251)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 46)
        Me.Label6.TabIndex = 226
        Me.Label6.Text = "Forma " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Pago:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(808, 358)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(15, 32)
        Me.TextBox3.TabIndex = 225
        Me.TextBox3.Text = "$"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(849, 143)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(15, 32)
        Me.TextBox2.TabIndex = 224
        Me.TextBox2.Text = "$"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Teal
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown
        Me.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Black
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(868, 431)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(135, 69)
        Me.btnCancelar.TabIndex = 216
        Me.btnCancelar.Text = "CANCELAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "VENTA"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Teal
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(715, 431)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(135, 69)
        Me.btnGuardar.TabIndex = 215
        Me.btnGuardar.Text = "IMPRIMIR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FACTURA"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(849, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(15, 32)
        Me.TextBox1.TabIndex = 223
        Me.TextBox1.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(730, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 46)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(734, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 46)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cambio:"
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.White
        Me.txtPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.ForeColor = System.Drawing.Color.Black
        Me.txtPago.Location = New System.Drawing.Point(871, 85)
        Me.txtPago.MaxLength = 14
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(103, 32)
        Me.txtPago.TabIndex = 217
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Enabled = False
        Me.txtTotalVenta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenta.Location = New System.Drawing.Point(838, 358)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(102, 32)
        Me.txtTotalVenta.TabIndex = 218
        Me.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(730, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 46)
        Me.Label2.TabIndex = 221
        Me.Label2.Text = "Dinero " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CLiente:"
        '
        'txtCambioPago
        '
        Me.txtCambioPago.Enabled = False
        Me.txtCambioPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambioPago.Location = New System.Drawing.Point(871, 142)
        Me.txtCambioPago.MaxLength = 12
        Me.txtCambioPago.Name = "txtCambioPago"
        Me.txtCambioPago.Size = New System.Drawing.Size(103, 32)
        Me.txtCambioPago.TabIndex = 219
        '
        'txtDate
        '
        Me.txtDate.FormattingEnabled = True
        Me.txtDate.Location = New System.Drawing.Point(308, 339)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(101, 24)
        Me.txtDate.TabIndex = 224
        '
        'txtCantidadProductos
        '
        Me.txtCantidadProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadProductos.Cursor = System.Windows.Forms.Cursors.No
        Me.txtCantidadProductos.Enabled = False
        Me.txtCantidadProductos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadProductos.Location = New System.Drawing.Point(427, 339)
        Me.txtCantidadProductos.Name = "txtCantidadProductos"
        Me.txtCantidadProductos.Size = New System.Drawing.Size(62, 27)
        Me.txtCantidadProductos.TabIndex = 226
        '
        'cmbCANTIDADProductos
        '
        Me.cmbCANTIDADProductos.FormattingEnabled = True
        Me.cmbCANTIDADProductos.Location = New System.Drawing.Point(495, 339)
        Me.cmbCANTIDADProductos.Name = "cmbCANTIDADProductos"
        Me.cmbCANTIDADProductos.Size = New System.Drawing.Size(29, 24)
        Me.cmbCANTIDADProductos.TabIndex = 225
        '
        'panProducto
        '
        Me.panProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panProducto.Controls.Add(Me.txtFiltroCodigo)
        Me.panProducto.Controls.Add(Me.Label14)
        Me.panProducto.Controls.Add(Me.Label13)
        Me.panProducto.Controls.Add(Me.dgvProducto)
        Me.panProducto.Controls.Add(Me.txtFiltroTalle)
        Me.panProducto.Controls.Add(Me.txtFiltroProducto)
        Me.panProducto.Controls.Add(Me.Label8)
        Me.panProducto.Controls.Add(Me.Nombre)
        Me.panProducto.Location = New System.Drawing.Point(1055, 70)
        Me.panProducto.Name = "panProducto"
        Me.panProducto.Size = New System.Drawing.Size(852, 623)
        Me.panProducto.TabIndex = 229
        '
        'txtFiltroCodigo
        '
        Me.txtFiltroCodigo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroCodigo.Location = New System.Drawing.Point(105, 66)
        Me.txtFiltroCodigo.Name = "txtFiltroCodigo"
        Me.txtFiltroCodigo.Size = New System.Drawing.Size(157, 32)
        Me.txtFiltroCodigo.TabIndex = 200
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(86, 24)
        Me.Label14.TabIndex = 199
        Me.Label14.Text = "Codigo:"
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(188, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(156, 34)
        Me.Label13.TabIndex = 198
        Me.Label13.Text = "Productos"
        '
        'dgvProducto
        '
        Me.dgvProducto.AllowUserToAddRows = False
        Me.dgvProducto.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducto.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvProducto.Location = New System.Drawing.Point(3, 131)
        Me.dgvProducto.MultiSelect = False
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = True
        Me.dgvProducto.RowTemplate.Height = 24
        Me.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducto.Size = New System.Drawing.Size(846, 474)
        Me.dgvProducto.TabIndex = 4
        '
        'txtFiltroTalle
        '
        Me.txtFiltroTalle.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroTalle.Location = New System.Drawing.Point(771, 66)
        Me.txtFiltroTalle.Name = "txtFiltroTalle"
        Me.txtFiltroTalle.Size = New System.Drawing.Size(86, 32)
        Me.txtFiltroTalle.TabIndex = 3
        '
        'txtFiltroProducto
        '
        Me.txtFiltroProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltroProducto.Location = New System.Drawing.Point(414, 66)
        Me.txtFiltroProducto.Name = "txtFiltroProducto"
        Me.txtFiltroProducto.Size = New System.Drawing.Size(268, 32)
        Me.txtFiltroProducto.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(700, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 24)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Talle:"
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(300, 69)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(108, 24)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Producto:"
        '
        'TipopagoTableAdapter
        '
        Me.TipopagoTableAdapter.ClearBeforeFill = True
        '
        'lblIdProducto
        '
        Me.lblIdProducto.AutoSize = True
        Me.lblIdProducto.Location = New System.Drawing.Point(885, 50)
        Me.lblIdProducto.Name = "lblIdProducto"
        Me.lblIdProducto.Size = New System.Drawing.Size(19, 17)
        Me.lblIdProducto.TabIndex = 202
        Me.lblIdProducto.Text = "id"
        Me.lblIdProducto.Visible = False
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'txtCodigo
        '
        Me.txtCodigo.HeaderText = "Codigo"
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.ReadOnly = True
        Me.txtCodigo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtProducto
        '
        Me.txtProducto.HeaderText = "Producto"
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.ReadOnly = True
        Me.txtProducto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtTalle
        '
        Me.txtTalle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.txtTalle.HeaderText = "Talle"
        Me.txtTalle.Name = "txtTalle"
        Me.txtTalle.ReadOnly = True
        Me.txtTalle.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.txtTalle.Width = 81
        '
        'txtPrecio
        '
        Me.txtPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.txtPrecio.HeaderText = "Precio Unitario $"
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.txtPrecio.Width = 161
        '
        'txtCantidadProd
        '
        Me.txtCantidadProd.HeaderText = "Cantidad"
        Me.txtCantidadProd.Name = "txtCantidadProd"
        Me.txtCantidadProd.ReadOnly = True
        Me.txtCantidadProd.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txtTotalProd
        '
        Me.txtTotalProd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.txtTotalProd.HeaderText = "Total $"
        Me.txtTotalProd.Name = "txtTotalProd"
        Me.txtTotalProd.ReadOnly = True
        Me.txtTotalProd.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.txtTotalProd.Width = 94
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1914, 1045)
        Me.Controls.Add(Me.panProducto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtCantidadProductos)
        Me.Controls.Add(Me.cmbCANTIDADProductos)
        Me.Name = "frmVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipopagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ZapateriaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panProducto.ResumeLayout(False)
        Me.panProducto.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lvlTotalProducto As System.Windows.Forms.Label
    Friend WithEvents txtNombreProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents btnAgregarProducto As System.Windows.Forms.Button
    Friend WithEvents txtPrecioProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblPrecio As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnClientes As System.Windows.Forms.Button
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumentoCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoCliente As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtCambioPago As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPago As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDate As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidadProductos As System.Windows.Forms.TextBox
    Friend WithEvents cmbCANTIDADProductos As System.Windows.Forms.ComboBox
    Friend WithEvents cbxFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvVenta As System.Windows.Forms.DataGridView
    Friend WithEvents panProducto As System.Windows.Forms.Panel
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltroTalle As System.Windows.Forms.TextBox
    Friend WithEvents txtFiltroProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents bsProductos As System.Windows.Forms.BindingSource
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTalleProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDescuento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtFiltroCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents chBoxDescuento As System.Windows.Forms.CheckBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblCajero As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnBorrarProducto As System.Windows.Forms.Button
    Friend WithEvents LblArticulos As System.Windows.Forms.Label
    Friend WithEvents txtArticulos As System.Windows.Forms.TextBox
    Friend WithEvents ZapateriaDataSet1 As Zapateria.zapateriaDataSet1
    Friend WithEvents TipopagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipopagoTableAdapter As Zapateria.zapateriaDataSet1TableAdapters.tipopagoTableAdapter
    Friend WithEvents lblIdProducto As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCantidadProd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotalProd As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

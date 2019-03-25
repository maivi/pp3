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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblCajero = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
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
        Me.lbltelefono = New System.Windows.Forms.Label()
        Me.txtNombreCliente = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccionCliente = New System.Windows.Forms.TextBox()
        Me.txtDocumentoCliente = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.txtTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtCajaAhorro = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvVenta = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtProducto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtCantidadProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTotalProd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbxFormaPago = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dgvProducto = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.dgvCliente = New System.Windows.Forms.DataGridView()
        Me.bsCliente = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProductos = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panProducto.SuspendLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCliente, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel2.Controls.Add(Me.lblID)
        Me.Panel2.Controls.Add(Me.lblCajero)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(8, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1254, 42)
        Me.Panel2.TabIndex = 228
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(698, 4)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 10
        Me.lblID.Visible = False
        '
        'lblCajero
        '
        Me.lblCajero.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCajero.AutoSize = True
        Me.lblCajero.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajero.ForeColor = System.Drawing.Color.Snow
        Me.lblCajero.Location = New System.Drawing.Point(909, 10)
        Me.lblCajero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCajero.Name = "lblCajero"
        Me.lblCajero.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblCajero.Size = New System.Drawing.Size(72, 23)
        Me.lblCajero.TabIndex = 9
        Me.lblCajero.Text = "Usuario"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Snow
        Me.Label16.Location = New System.Drawing.Point(814, 6)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(100, 29)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Cajero:"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(360, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(223, 29)
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
        Me.Panel1.Location = New System.Drawing.Point(9, 56)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(778, 507)
        Me.Panel1.TabIndex = 227
        '
        'Panel5
        '
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
        Me.Panel5.Location = New System.Drawing.Point(3, 118)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(767, 110)
        Me.Panel5.TabIndex = 226
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoProducto.Enabled = False
        Me.txtCodigoProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoProducto.Location = New System.Drawing.Point(71, 39)
        Me.txtCodigoProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(94, 27)
        Me.txtCodigoProducto.TabIndex = 199
        Me.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(2, 41)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 19)
        Me.Label11.TabIndex = 198
        Me.Label11.Text = "Codigo:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(316, 0)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 27)
        Me.Label9.TabIndex = 197
        Me.Label9.Text = "Datos Producto"
        '
        'txtTalleProducto
        '
        Me.txtTalleProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTalleProducto.Enabled = False
        Me.txtTalleProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTalleProducto.Location = New System.Drawing.Point(71, 79)
        Me.txtTalleProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTalleProducto.Name = "txtTalleProducto"
        Me.txtTalleProducto.Size = New System.Drawing.Size(53, 27)
        Me.txtTalleProducto.TabIndex = 196
        Me.txtTalleProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(2, 83)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 19)
        Me.Label7.TabIndex = 195
        Me.Label7.Text = "Talle:"
        '
        'lvlTotalProducto
        '
        Me.lvlTotalProducto.AutoSize = True
        Me.lvlTotalProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvlTotalProducto.ForeColor = System.Drawing.Color.Black
        Me.lvlTotalProducto.Location = New System.Drawing.Point(478, 83)
        Me.lvlTotalProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lvlTotalProducto.Name = "lvlTotalProducto"
        Me.lvlTotalProducto.Size = New System.Drawing.Size(73, 19)
        Me.lvlTotalProducto.TabIndex = 194
        Me.lvlTotalProducto.Text = "Total: $"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreProducto.Cursor = System.Windows.Forms.Cursors.No
        Me.txtNombreProducto.Enabled = False
        Me.txtNombreProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProducto.Location = New System.Drawing.Point(272, 39)
        Me.txtNombreProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(204, 27)
        Me.txtNombreProducto.TabIndex = 192
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(420, 78)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(42, 27)
        Me.txtCantidad.TabIndex = 191
        '
        'txtTotalProducto
        '
        Me.txtTotalProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalProducto.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTotalProducto.Enabled = False
        Me.txtTotalProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalProducto.Location = New System.Drawing.Point(551, 78)
        Me.txtTotalProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalProducto.Name = "txtTotalProducto"
        Me.txtTotalProducto.Size = New System.Drawing.Size(93, 27)
        Me.txtTotalProducto.TabIndex = 190
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.ForeColor = System.Drawing.Color.Black
        Me.lblCantidad.Location = New System.Drawing.Point(332, 83)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(88, 19)
        Me.lblCantidad.TabIndex = 187
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProducto.ForeColor = System.Drawing.Color.Black
        Me.lblProducto.Location = New System.Drawing.Point(187, 41)
        Me.lblProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(88, 19)
        Me.lblProducto.TabIndex = 186
        Me.lblProducto.Text = "Producto:"
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.BackColor = System.Drawing.Color.Teal
        Me.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarProducto.Enabled = False
        Me.btnAgregarProducto.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnAgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.ForeColor = System.Drawing.Color.Black
        Me.btnAgregarProducto.Location = New System.Drawing.Point(654, 78)
        Me.btnAgregarProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnAgregarProducto.Size = New System.Drawing.Size(100, 27)
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
        Me.txtPrecioProducto.Location = New System.Drawing.Point(242, 79)
        Me.txtPrecioProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrecioProducto.Name = "txtPrecioProducto"
        Me.txtPrecioProducto.Size = New System.Drawing.Size(76, 27)
        Me.txtPrecioProducto.TabIndex = 189
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.Color.Black
        Me.lblPrecio.Location = New System.Drawing.Point(161, 83)
        Me.lblPrecio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(81, 19)
        Me.lblPrecio.TabIndex = 188
        Me.lblPrecio.Text = "Precio: $"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Controls.Add(Me.lbltelefono)
        Me.Panel4.Controls.Add(Me.txtNombreCliente)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.txtDireccionCliente)
        Me.Panel4.Controls.Add(Me.txtDocumentoCliente)
        Me.Panel4.Controls.Add(Me.lblNombre)
        Me.Panel4.Controls.Add(Me.lblDocumento)
        Me.Panel4.Controls.Add(Me.txtTelefonoCliente)
        Me.Panel4.Location = New System.Drawing.Point(2, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(768, 98)
        Me.Panel4.TabIndex = 225
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 0)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 27)
        Me.Label10.TabIndex = 198
        Me.Label10.Text = "Datos Cliente"
        '
        'lbltelefono
        '
        Me.lbltelefono.AutoSize = True
        Me.lbltelefono.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltelefono.ForeColor = System.Drawing.Color.Black
        Me.lbltelefono.Location = New System.Drawing.Point(344, 71)
        Me.lbltelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltelefono.Name = "lbltelefono"
        Me.lbltelefono.Size = New System.Drawing.Size(87, 19)
        Me.lbltelefono.TabIndex = 190
        Me.lbltelefono.Text = "Telefono:"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreCliente.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtNombreCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCliente.Location = New System.Drawing.Point(97, 38)
        Me.txtNombreCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(235, 27)
        Me.txtNombreCliente.TabIndex = 188
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 71)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 19)
        Me.Label5.TabIndex = 187
        Me.Label5.Text = "Dirección:"
        '
        'txtDireccionCliente
        '
        Me.txtDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccionCliente.Cursor = System.Windows.Forms.Cursors.No
        Me.txtDireccionCliente.Enabled = False
        Me.txtDireccionCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionCliente.Location = New System.Drawing.Point(97, 69)
        Me.txtDireccionCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDireccionCliente.Name = "txtDireccionCliente"
        Me.txtDireccionCliente.Size = New System.Drawing.Size(235, 27)
        Me.txtDireccionCliente.TabIndex = 189
        '
        'txtDocumentoCliente
        '
        Me.txtDocumentoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocumentoCliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtDocumentoCliente.Enabled = False
        Me.txtDocumentoCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentoCliente.Location = New System.Drawing.Point(453, 38)
        Me.txtDocumentoCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDocumentoCliente.MaxLength = 12
        Me.txtDocumentoCliente.Name = "txtDocumentoCliente"
        Me.txtDocumentoCliente.Size = New System.Drawing.Size(302, 27)
        Me.txtDocumentoCliente.TabIndex = 183
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(3, 40)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(79, 19)
        Me.lblNombre.TabIndex = 186
        Me.lblNombre.Text = "Nombre:"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.ForeColor = System.Drawing.Color.Black
        Me.lblDocumento.Location = New System.Drawing.Point(344, 40)
        Me.lblDocumento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(107, 19)
        Me.lblDocumento.TabIndex = 185
        Me.lblDocumento.Text = "Documento:"
        '
        'txtTelefonoCliente
        '
        Me.txtTelefonoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonoCliente.Cursor = System.Windows.Forms.Cursors.No
        Me.txtTelefonoCliente.Enabled = False
        Me.txtTelefonoCliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoCliente.Location = New System.Drawing.Point(453, 69)
        Me.txtTelefonoCliente.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTelefonoCliente.Name = "txtTelefonoCliente"
        Me.txtTelefonoCliente.Size = New System.Drawing.Size(302, 27)
        Me.txtTelefonoCliente.TabIndex = 191
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtCajaAhorro)
        Me.Panel3.Controls.Add(Me.TextBox4)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.dgvVenta)
        Me.Panel3.Controls.Add(Me.cbxFormaPago)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Controls.Add(Me.btnGuardar)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtPago)
        Me.Panel3.Controls.Add(Me.txtTotalVenta)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtCambioPago)
        Me.Panel3.Location = New System.Drawing.Point(3, 232)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(767, 269)
        Me.Panel3.TabIndex = 224
        '
        'txtCajaAhorro
        '
        Me.txtCajaAhorro.BackColor = System.Drawing.Color.White
        Me.txtCajaAhorro.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajaAhorro.ForeColor = System.Drawing.Color.Black
        Me.txtCajaAhorro.Location = New System.Drawing.Point(661, 112)
        Me.txtCajaAhorro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCajaAhorro.MaxLength = 14
        Me.txtCajaAhorro.Name = "txtCajaAhorro"
        Me.txtCajaAhorro.Size = New System.Drawing.Size(101, 27)
        Me.txtCajaAhorro.TabIndex = 231
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(645, 112)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(12, 27)
        Me.TextBox4.TabIndex = 230
        Me.TextBox4.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(542, 105)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 36)
        Me.Label12.TabIndex = 229
        Me.Label12.Text = "Dinero " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Caja Ahorro:"
        '
        'dgvVenta
        '
        Me.dgvVenta.AllowUserToAddRows = False
        Me.dgvVenta.AllowUserToDeleteRows = False
        Me.dgvVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txtCodigo, Me.txtProducto, Me.txtTalle, Me.txtPrecio, Me.txtCantidadProd, Me.txtTotalProd})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvVenta.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvVenta.Location = New System.Drawing.Point(4, 5)
        Me.dgvVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvVenta.MultiSelect = False
        Me.dgvVenta.Name = "dgvVenta"
        Me.dgvVenta.ReadOnly = True
        Me.dgvVenta.RowTemplate.Height = 24
        Me.dgvVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVenta.Size = New System.Drawing.Size(522, 262)
        Me.dgvVenta.TabIndex = 228
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
        Me.txtTalle.Width = 70
        '
        'txtPrecio
        '
        Me.txtPrecio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.txtPrecio.HeaderText = "Precio Unitario $"
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.txtPrecio.Width = 133
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
        Me.txtTotalProd.Width = 78
        '
        'cbxFormaPago
        '
        Me.cbxFormaPago.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cbxFormaPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxFormaPago.FormattingEnabled = True
        Me.cbxFormaPago.Items.AddRange(New Object() {"Contado", "Cuenta Corriente"})
        Me.cbxFormaPago.Location = New System.Drawing.Point(643, 26)
        Me.cbxFormaPago.Margin = New System.Windows.Forms.Padding(2)
        Me.cbxFormaPago.Name = "cbxFormaPago"
        Me.cbxFormaPago.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxFormaPago.Size = New System.Drawing.Size(119, 27)
        Me.cbxFormaPago.TabIndex = 227
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(542, 17)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 36)
        Me.Label6.TabIndex = 226
        Me.Label6.Text = "Forma " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Pago:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(644, 201)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(12, 27)
        Me.TextBox3.TabIndex = 225
        Me.TextBox3.Text = "$"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(645, 68)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(12, 27)
        Me.TextBox2.TabIndex = 224
        Me.TextBox2.Text = "$"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Teal
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.Black
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGuardar.Location = New System.Drawing.Point(531, 241)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(231, 25)
        Me.btnGuardar.TabIndex = 215
        Me.btnGuardar.Text = "REGISTRAR VENTA"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(645, 155)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(12, 27)
        Me.TextBox1.TabIndex = 223
        Me.TextBox1.Text = "$"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(541, 193)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 36)
        Me.Label4.TabIndex = 220
        Me.Label4.Text = "Total" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Venta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(540, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 36)
        Me.Label1.TabIndex = 222
        Me.Label1.Text = "Total " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cambio:"
        '
        'txtPago
        '
        Me.txtPago.BackColor = System.Drawing.Color.White
        Me.txtPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPago.ForeColor = System.Drawing.Color.Black
        Me.txtPago.Location = New System.Drawing.Point(661, 67)
        Me.txtPago.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPago.MaxLength = 14
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(101, 27)
        Me.txtPago.TabIndex = 217
        '
        'txtTotalVenta
        '
        Me.txtTotalVenta.Enabled = False
        Me.txtTotalVenta.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalVenta.Location = New System.Drawing.Point(661, 200)
        Me.txtTotalVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTotalVenta.Name = "txtTotalVenta"
        Me.txtTotalVenta.Size = New System.Drawing.Size(101, 27)
        Me.txtTotalVenta.TabIndex = 218
        Me.txtTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(542, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 36)
        Me.Label2.TabIndex = 221
        Me.Label2.Text = "Dinero " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cliente:"
        '
        'txtCambioPago
        '
        Me.txtCambioPago.Enabled = False
        Me.txtCambioPago.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambioPago.Location = New System.Drawing.Point(661, 155)
        Me.txtCambioPago.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCambioPago.MaxLength = 12
        Me.txtCambioPago.Name = "txtCambioPago"
        Me.txtCambioPago.Size = New System.Drawing.Size(101, 27)
        Me.txtCambioPago.TabIndex = 219
        '
        'txtDate
        '
        Me.txtDate.FormattingEnabled = True
        Me.txtDate.Location = New System.Drawing.Point(231, 275)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(77, 21)
        Me.txtDate.TabIndex = 224
        '
        'txtCantidadProductos
        '
        Me.txtCantidadProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadProductos.Cursor = System.Windows.Forms.Cursors.No
        Me.txtCantidadProductos.Enabled = False
        Me.txtCantidadProductos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadProductos.Location = New System.Drawing.Point(320, 275)
        Me.txtCantidadProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadProductos.Name = "txtCantidadProductos"
        Me.txtCantidadProductos.Size = New System.Drawing.Size(47, 23)
        Me.txtCantidadProductos.TabIndex = 226
        '
        'cmbCANTIDADProductos
        '
        Me.cmbCANTIDADProductos.FormattingEnabled = True
        Me.cmbCANTIDADProductos.Location = New System.Drawing.Point(371, 275)
        Me.cmbCANTIDADProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbCANTIDADProductos.Name = "cmbCANTIDADProductos"
        Me.cmbCANTIDADProductos.Size = New System.Drawing.Size(23, 21)
        Me.cmbCANTIDADProductos.TabIndex = 225
        '
        'panProducto
        '
        Me.panProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panProducto.Controls.Add(Me.Label13)
        Me.panProducto.Controls.Add(Me.dgvProducto)
        Me.panProducto.Controls.Add(Me.TextBox5)
        Me.panProducto.Controls.Add(Me.Nombre)
        Me.panProducto.Controls.Add(Me.dgvCliente)
        Me.panProducto.Location = New System.Drawing.Point(791, 57)
        Me.panProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.panProducto.Name = "panProducto"
        Me.panProducto.Size = New System.Drawing.Size(471, 506)
        Me.panProducto.TabIndex = 229
        '
        'Label13
        '
        Me.Label13.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(141, 13)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(124, 27)
        Me.Label13.TabIndex = 198
        Me.Label13.Text = "Productos"
        '
        'dgvProducto
        '
        Me.dgvProducto.AllowUserToAddRows = False
        Me.dgvProducto.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvProducto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvProducto.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvProducto.Location = New System.Drawing.Point(2, 107)
        Me.dgvProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProducto.MultiSelect = False
        Me.dgvProducto.Name = "dgvProducto"
        Me.dgvProducto.ReadOnly = True
        Me.dgvProducto.RowTemplate.Height = 24
        Me.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProducto.Size = New System.Drawing.Size(466, 384)
        Me.dgvProducto.TabIndex = 4
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(178, 65)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(286, 27)
        Me.TextBox5.TabIndex = 2
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(12, 69)
        Me.Nombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(149, 19)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Producto o Talle:"
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AllowUserToDeleteRows = False
        Me.dgvCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 10.8!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle12
        Me.dgvCliente.Location = New System.Drawing.Point(3, 54)
        Me.dgvCliente.MultiSelect = False
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(465, 447)
        Me.dgvCliente.TabIndex = 201
        Me.dgvCliente.Visible = False
        '
        'frmVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 584)
        Me.Controls.Add(Me.panProducto)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtCantidadProductos)
        Me.Controls.Add(Me.cmbCANTIDADProductos)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
        Me.panProducto.ResumeLayout(False)
        Me.panProducto.PerformLayout()
        CType(Me.dgvProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCliente, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lbltelefono As System.Windows.Forms.Label
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDocumentoCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoCliente As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.ComboBox
    Friend WithEvents txtCantidadProductos As System.Windows.Forms.TextBox
    Friend WithEvents cmbCANTIDADProductos As System.Windows.Forms.ComboBox
    Friend WithEvents panProducto As System.Windows.Forms.Panel
    Friend WithEvents dgvProducto As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Nombre As System.Windows.Forms.Label
    Friend WithEvents bsProductos As System.Windows.Forms.BindingSource
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTalleProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblCajero As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvVenta As System.Windows.Forms.DataGridView
    Friend WithEvents txtCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtProducto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTalle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtCantidadProd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTotalProd As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cbxFormaPago As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPago As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalVenta As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCambioPago As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCajaAhorro As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents bsCliente As System.Windows.Forms.BindingSource
    Friend WithEvents lblID As System.Windows.Forms.Label
End Class

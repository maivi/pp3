<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProveedor
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupClientes = New System.Windows.Forms.GroupBox()
        Me.txtCUIT = New System.Windows.Forms.MaskedTextBox()
        Me.txtNombreProveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPaginaWeb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefonoProveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccionProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.panelProveedor = New System.Windows.Forms.Panel()
        Me.dgvProveedor = New System.Windows.Forms.DataGridView()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgbProveedor = New System.Windows.Forms.DataGridView()
        Me.bsProveedor = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupClientes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.panelProveedor.SuspendLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgbProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.Zapateria.My.Resources.Resources.Proveedores
        Me.PictureBox1.Location = New System.Drawing.Point(359, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 235
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(10, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1078, 51)
        Me.Panel2.TabIndex = 236
        '
        'Label6
        '
        Me.Label6.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(314, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(193, 29)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "PROVEEDORES"
        '
        'GroupClientes
        '
        Me.GroupClientes.BackColor = System.Drawing.Color.Transparent
        Me.GroupClientes.Controls.Add(Me.txtCUIT)
        Me.GroupClientes.Controls.Add(Me.txtNombreProveedor)
        Me.GroupClientes.Controls.Add(Me.Label5)
        Me.GroupClientes.Controls.Add(Me.txtPaginaWeb)
        Me.GroupClientes.Controls.Add(Me.Label4)
        Me.GroupClientes.Controls.Add(Me.txtTelefonoProveedor)
        Me.GroupClientes.Controls.Add(Me.Label3)
        Me.GroupClientes.Controls.Add(Me.txtDireccionProveedor)
        Me.GroupClientes.Controls.Add(Me.Label2)
        Me.GroupClientes.Controls.Add(Me.Label1)
        Me.GroupClientes.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupClientes.Location = New System.Drawing.Point(3, 3)
        Me.GroupClientes.Name = "GroupClientes"
        Me.GroupClientes.Size = New System.Drawing.Size(338, 257)
        Me.GroupClientes.TabIndex = 233
        Me.GroupClientes.TabStop = False
        '
        'txtCUIT
        '
        Me.txtCUIT.BeepOnError = True
        Me.txtCUIT.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCUIT.Location = New System.Drawing.Point(103, 26)
        Me.txtCUIT.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCUIT.Mask = "00-00000000-0"
        Me.txtCUIT.Name = "txtCUIT"
        Me.txtCUIT.Size = New System.Drawing.Size(164, 27)
        Me.txtCUIT.TabIndex = 1
        Me.txtCUIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtNombreProveedor
        '
        Me.txtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombreProveedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreProveedor.Location = New System.Drawing.Point(103, 68)
        Me.txtNombreProveedor.MaxLength = 25
        Me.txtNombreProveedor.Name = "txtNombreProveedor"
        Me.txtNombreProveedor.Size = New System.Drawing.Size(217, 27)
        Me.txtNombreProveedor.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(184, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pagina WEB o E-Mail:"
        '
        'txtPaginaWeb
        '
        Me.txtPaginaWeb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaginaWeb.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaginaWeb.Location = New System.Drawing.Point(17, 216)
        Me.txtPaginaWeb.MaxLength = 150
        Me.txtPaginaWeb.Name = "txtPaginaWeb"
        Me.txtPaginaWeb.Size = New System.Drawing.Size(303, 27)
        Me.txtPaginaWeb.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Telefono:"
        '
        'txtTelefonoProveedor
        '
        Me.txtTelefonoProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefonoProveedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoProveedor.Location = New System.Drawing.Point(103, 155)
        Me.txtTelefonoProveedor.MaxLength = 12
        Me.txtTelefonoProveedor.Name = "txtTelefonoProveedor"
        Me.txtTelefonoProveedor.Size = New System.Drawing.Size(217, 27)
        Me.txtTelefonoProveedor.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Dirección:"
        '
        'txtDireccionProveedor
        '
        Me.txtDireccionProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccionProveedor.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionProveedor.Location = New System.Drawing.Point(103, 113)
        Me.txtDireccionProveedor.MaxLength = 45
        Me.txtDireccionProveedor.Name = "txtDireccionProveedor"
        Me.txtDireccionProveedor.Size = New System.Drawing.Size(217, 27)
        Me.txtDireccionProveedor.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CUIT:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.GroupClientes)
        Me.Panel1.Location = New System.Drawing.Point(10, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(529, 371)
        Me.Panel1.TabIndex = 238
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(306, 264)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 102)
        Me.GroupBox1.TabIndex = 239
        Me.GroupBox1.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.Teal
        Me.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(111, 60)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(101, 31)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.Teal
        Me.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLimpiar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(6, 60)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(101, 31)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Teal
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEliminar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(6, 23)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(101, 31)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.Teal
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGuardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnGuardar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Location = New System.Drawing.Point(111, 23)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(101, 31)
        Me.btnGuardar.TabIndex = 5
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.Teal
        Me.btnActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnActualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnActualizar.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualizar.Location = New System.Drawing.Point(110, 23)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(101, 31)
        Me.btnActualizar.TabIndex = 6
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = False
        '
        'panelProveedor
        '
        Me.panelProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panelProveedor.Controls.Add(Me.dgvProveedor)
        Me.panelProveedor.Controls.Add(Me.txtFiltro)
        Me.panelProveedor.Controls.Add(Me.Label7)
        Me.panelProveedor.Location = New System.Drawing.Point(544, 67)
        Me.panelProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelProveedor.Name = "panelProveedor"
        Me.panelProveedor.Size = New System.Drawing.Size(543, 373)
        Me.panelProveedor.TabIndex = 239
        '
        'dgvProveedor
        '
        Me.dgvProveedor.AllowUserToAddRows = False
        Me.dgvProveedor.AllowUserToDeleteRows = False
        Me.dgvProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProveedor.Location = New System.Drawing.Point(0, 48)
        Me.dgvProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvProveedor.MultiSelect = False
        Me.dgvProveedor.Name = "dgvProveedor"
        Me.dgvProveedor.ReadOnly = True
        Me.dgvProveedor.RowTemplate.Height = 24
        Me.dgvProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProveedor.Size = New System.Drawing.Size(538, 325)
        Me.dgvProveedor.TabIndex = 2
        '
        'txtFiltro
        '
        Me.txtFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiltro.Location = New System.Drawing.Point(174, 4)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(356, 28)
        Me.txtFiltro.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Minion Pro", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(2, 6)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 26)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Proveedor/CUIT"
        '
        'dgbProveedor
        '
        Me.dgbProveedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgbProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgbProveedor.Location = New System.Drawing.Point(3, 56)
        Me.dgbProveedor.Name = "dgbProveedor"
        Me.dgbProveedor.RowTemplate.Height = 24
        Me.dgbProveedor.Size = New System.Drawing.Size(718, 400)
        Me.dgbProveedor.TabIndex = 2
        '
        'frmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 478)
        Me.Controls.Add(Me.panelProveedor)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmProveedor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupClientes.ResumeLayout(False)
        Me.GroupClientes.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.panelProveedor.ResumeLayout(False)
        Me.panelProveedor.PerformLayout()
        CType(Me.dgvProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgbProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupClientes As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombreProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPaginaWeb As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelefonoProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDireccionProveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnActualizar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents panelProveedor As System.Windows.Forms.Panel
    Friend WithEvents dgvProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents txtFiltro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCUIT As System.Windows.Forms.MaskedTextBox
    Friend WithEvents dgbProveedor As System.Windows.Forms.DataGridView
    Friend WithEvents bsProveedor As System.Windows.Forms.BindingSource
End Class

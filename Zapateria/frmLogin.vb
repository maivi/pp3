Imports MySql.Data.MySqlClient

Public Class frmLogin

    Public con As New MySqlConnection("server=localhost;user id=root;password=1234;persistsecurityinfo=True;database=agenda")
    Public dr As MySqlDataReader
    Public cmd As MySqlCommand

    Private Sub btnAcceder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceder.Click
        validar()
    End Sub
    Private Sub Login_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        frmPresentacion.Close()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub txtPass_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtContraseña.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(13) Then
            validar()
        End If
    End Sub
    Private Sub btnSalir2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Login_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtContraseña.Clear()
        txtUsuario.Clear()
    End Sub

    Private Sub validar()
        If txtUsuario.Text = "" And txtContraseña.Text = "" Then
            MsgBox("Los Campos no pueden estar Vacios", vbInformation, "Sistema!")
            txtUsuario.Select()
        ElseIf (txtUsuario.Text = "" Or txtContraseña.Text = "") Then
            MsgBox("Debe Lenar todos los campos", vbInformation, "Sistema!")
        ElseIf (txtUsuario.Text <> "" And txtContraseña.Text <> "") <> (txtUsuario.Text = "" And txtContraseña.Text = "") Then

            con.Open()
            Dim sql = "SELECT * FROM usuarios WHERE usuario = '" & txtUsuario.Text & "' AND pass= '" & txtContraseña.Text & "'"
            Dim cmd = New MySqlCommand(sql, con)
            Dim dr As MySqlDataReader = cmd.ExecuteReader
            Try
                If dr.Read = False Then
                    MsgBox("No REGISTRADO", vbCritical, "Invalid Login")
                Else
                    frmMenu.Show()
                    Me.Hide()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            con.Close()

        End If
    End Sub
End Class
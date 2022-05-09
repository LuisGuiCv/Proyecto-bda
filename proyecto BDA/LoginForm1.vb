Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'Código del Login'
        If UsernameTextBox.Text = "Luis" And PasswordTextBox.Text = "Cruz" Then 'Condicional de aceptación'
            My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
            Me.Close()
            Menú.Show()

            'Condicionales de negación'
        ElseIf UsernameTextBox.Text = "" Then 'Usuario en Blanco'
            MsgBox("por favor inserte el nombre de Usuario", MsgBoxStyle.Information)
            My.Computer.Audio.Play(My.Resources.KH_Unavailable, AudioPlayMode.Background)
        ElseIf PasswordTextBox.Text = "" Then 'Contraseña en blanco'
            MsgBox("por favor inserte la contraseña", MsgBoxStyle.Information)
            My.Computer.Audio.Play(My.Resources.KH_Unavailable, AudioPlayMode.Background)

        ElseIf PasswordTextBox.Text IsNot "Cruz" Then 'Contraseña incorrecta'
            MsgBox("Contraseña incorrecta", MsgBoxStyle.Critical)
            My.Computer.Audio.Play(My.Resources.KH_Unavailable, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        My.Computer.Audio.Play(My.Resources.KH_Close_Menu, AudioPlayMode.Background) 'Sonidos'
        End
    End Sub
End Class

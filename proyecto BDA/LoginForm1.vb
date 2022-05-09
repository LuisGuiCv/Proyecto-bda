Public Class LoginForm1

    ' TODO: inserte el c�digo para realizar autenticaci�n personalizada usando el nombre de usuario y la contrase�a proporcionada 
    ' (Consulte https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuaci�n: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementaci�n de IPrincipal utilizada para realizar la autenticaci�n. 
    ' Posteriormente, My.User devolver� la informaci�n de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        'C�digo del Login'
        If UsernameTextBox.Text = "Luis" And PasswordTextBox.Text = "Cruz" Then 'Condicional de aceptaci�n'
            My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
            Me.Close()
            Men�.Show()

            'Condicionales de negaci�n'
        ElseIf UsernameTextBox.Text = "" Then 'Usuario en Blanco'
            MsgBox("por favor inserte el nombre de Usuario", MsgBoxStyle.Information)
            My.Computer.Audio.Play(My.Resources.KH_Unavailable, AudioPlayMode.Background)
        ElseIf PasswordTextBox.Text = "" Then 'Contrase�a en blanco'
            MsgBox("por favor inserte la contrase�a", MsgBoxStyle.Information)
            My.Computer.Audio.Play(My.Resources.KH_Unavailable, AudioPlayMode.Background)

        ElseIf PasswordTextBox.Text IsNot "Cruz" Then 'Contrase�a incorrecta'
            MsgBox("Contrase�a incorrecta", MsgBoxStyle.Critical)
            My.Computer.Audio.Play(My.Resources.KH_Unavailable, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        My.Computer.Audio.Play(My.Resources.KH_Close_Menu, AudioPlayMode.Background) 'Sonidos'
        End
    End Sub
End Class

Public NotInheritable Class SplashScreen1

    'TODO: Este formulario se puede establecer fácilmente como pantalla de presentación para la aplicación desde la pestaña "Aplicación"
    '  del Diseñador de proyectos ("Propiedades" bajo el menú "Proyecto").


    Private Sub SplashScreen1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Timer1.Start() 'Inicia Timer de 3 segundos de duración'

    End Sub

    Private Sub ApplicationTitle_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Copyright_Click(sender As Object, e As EventArgs) Handles Copyright.Click
    End Sub
    Private Sub Version_Click(sender As Object, e As EventArgs) Handles Version.Click
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop() 'al terminar el conteo, se cierra la pantalla de splah screen y se abre el Form de Login'
        Me.Hide()
        LoginForm1.Show()
    End Sub
End Class

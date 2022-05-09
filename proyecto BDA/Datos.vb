Public Class Datos
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Regresa al menú'
        My.Computer.Audio.Play(My.Resources.KH_Close_Menu, AudioPlayMode.Background)
        Me.Hide()
        Menú.Show()
    End Sub
End Class
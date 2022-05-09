Public Class Menú
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Abre formulario CATÄLOGO'
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        Me.Hide()
        catalogo.Show()


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Abre formulario Vistas'
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        Me.Hide()
        vistas.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Abre Formulario Productos'
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        Me.Hide()
        tablas.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click 'Abre Formulario Conócenos'
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        Me.Hide()
        Datos.Show()
    End Sub



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click 'Termina el programa'
        My.Computer.Audio.Play(My.Resources.KH_Close_Menu, AudioPlayMode.Background)
        End
    End Sub

End Class

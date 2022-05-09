Imports System.Data 'importar librerías sql'
Imports System.Data.SqlClient
Public Class catalogo
    Dim cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True")
    'conexión a la base de datos'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Regresa al Menú'
        My.Computer.Audio.Play(My.Resources.KH_Close_Menu, AudioPlayMode.Background)
        Me.Hide()
        Menú.Show()
    End Sub
    'Al cambiar el nombre del juego en el Combobox, aparecerán los datos del producto seleccionado'
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'datos se usa para poder usar sentencias de SQL Server'
        Dim datos As New SqlDataAdapter("select Género,plataformas,Precio_unitario from producto where Nombre='" & Me.ComboBox1.Text & "'", cone)
        Dim ds As New DataSet() 'se hace un nuevo dataset'
        datos.Fill(ds, "producto") 'se ejecuta la consulta de la tabla producto'
        Me.genero.Text = ds.Tables("producto").Rows(0).Item(0) 'el valor de la fila y columna seleccionada se coloca en el TextBox correspondiente'
        Me.plataformas.Text = ds.Tables("producto").Rows(0).Item(1)
        Me.precio.Text = ds.Tables("producto").Rows(0).Item(2)
        If ComboBox1.Text = "Kingdom Hearts 3" Then 'Estas condicionales se utilizan para cuando se seleccione un producto del catálogo se muestre la imagen
            'del producto'
            PictureBox1.Image = My.Resources.kh3
        End If
        If ComboBox1.Text = "Crash Team Racing" Then
            PictureBox1.Image = My.Resources.CTR
        End If
        If ComboBox1.Text = "Assassins Creed II" Then
            PictureBox1.Image = My.Resources.Ezio
        End If
        If ComboBox1.Text = "South Park, The Stick of Truth" Then
            PictureBox1.Image = My.Resources.south_park
        End If
        If ComboBox1.Text = "Final Fantasy 7 REMAKE" Then
            PictureBox1.Image = My.Resources.ff7
        End If
        If ComboBox1.Text = "Star Wars Jedi The Fallen Order" Then
            PictureBox1.Image = My.Resources.star_wars
        End If
        If ComboBox1.Text = "Spider-Man" Then
            PictureBox1.Image = My.Resources.spiderman
        End If
        If ComboBox1.Text = "Dragon Ball Z Kakarot" Then
            PictureBox1.Image = My.Resources.dbz
        End If
        If ComboBox1.Text = "God Of War" Then
            PictureBox1.Image = My.Resources.Gow
        End If
        If ComboBox1.Text = "Resident Evil 2" Then
            PictureBox1.Image = My.Resources.re2
        End If
        If ComboBox1.Text = "Super Smash Bros Ultimate" Then
            PictureBox1.Image = My.Resources.smash
        End If
        If ComboBox1.Text = "The Last of Us" Then
            PictureBox1.Image = My.Resources.tlou
        End If
        If ComboBox1.Text = "Xbox-One" Then
            PictureBox1.Image = My.Resources.xbox
        End If
        If ComboBox1.Text = "PS4" Then
            PictureBox1.Image = My.Resources.ps4
        End If
        If ComboBox1.Text = "Nintendo Switch" Then
            PictureBox1.Image = My.Resources.switch
        End If
        If ComboBox1.Text = "Mando Xbox" Then
            PictureBox1.Image = My.Resources.controlxbox
        End If
        If ComboBox1.Text = "Dualshock 4" Then
            PictureBox1.Image = My.Resources.dualshock4
        End If
        If ComboBox1.Text = "Joy-Cons" Then
            PictureBox1.Image = My.Resources.joycons
        End If
    End Sub
End Class
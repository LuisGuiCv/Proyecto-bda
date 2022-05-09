Imports System.Data.SqlClient 'Importar librerías SQL'
Imports System.Data


Public Class Desarrollador
    Dim cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True") 'conexión con la base de datos'
    Private Sub Desarrollador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet5.Desarrolladores' Puede moverla o quitarla según sea necesario.
        Me.DesarrolladoresTableAdapter.Fill(Me.Tienda_juegosDataSet5.Desarrolladores)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Insertar.Click 'Botón Insertar'
        My.Computer.Audio.Play(My.Resources.KH_Save_Sound, AudioPlayMode.Background)
        Using cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True")
            Dim insertar As New SqlCommand("ins_des", cone)
            insertar.CommandType = CommandType.StoredProcedure
            insertar.Parameters.AddWithValue("@id_desarrollador", TextBox1.Text)
            insertar.Parameters.AddWithValue("@Nombre_desarrollador", TextBox2.Text)
            Try
                cone.Open()
                insertar.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cone.Dispose()
                insertar.Dispose()
                MsgBox("Desarrollador Registrado Correctamente", vbInformation, "Sistema")
            End Try
            TextBox1.Text = ""
            TextBox2.Text = ""
            Me.DesarrolladoresTableAdapter.Fill(Me.Tienda_juegosDataSet5.Desarrolladores)
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click 'Botón modificar'
        My.Computer.Audio.Play(My.Resources.KH_Save_Sound, AudioPlayMode.Background)
        Using cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True")
            Dim modificar As New SqlCommand("mod_des", cone)
            modificar.CommandType = CommandType.StoredProcedure
            modificar.Parameters.AddWithValue("@id_desarrollador", TextBox1.Text)
            modificar.Parameters.AddWithValue("@Nombre_desarrollador", TextBox2.Text)
            Try
                cone.Open()
                modificar.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cone.Dispose()
                modificar.Dispose()
                MsgBox("Desarrollador Modificado Correctamente", vbInformation, "Sistema")
            End Try
            TextBox1.Text = ""
            TextBox2.Text = ""
            Me.DesarrolladoresTableAdapter.Fill(Me.Tienda_juegosDataSet5.Desarrolladores)
        End Using
    End Sub

    'Coloca los registros de las celdas seleccionadas en los textbox correspondientes'
    Private Sub DesarrolladoresDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DesarrolladoresDataGridView.CellContentClick
        My.Computer.Audio.Play(My.Resources.KH_Menu_Select, AudioPlayMode.Background)
        Using cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True")
            Try
                TextBox1.Text = DesarrolladoresDataGridView.SelectedCells.Item(0).Value
                TextBox2.Text = DesarrolladoresDataGridView.SelectedCells.Item(1).Value
            Catch ex As Exception

            End Try
        End Using
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Botón eliminar'
        My.Computer.Audio.Play(My.Resources.KH_Save_Sound, AudioPlayMode.Background)
        Using cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True")
            Dim eliminar As New SqlCommand("elim_des", cone)
            eliminar.CommandType = CommandType.StoredProcedure
            eliminar.Parameters.AddWithValue("@id_desarrollador", TextBox1.Text)
            Try
                cone.Open()
                eliminar.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cone.Dispose()
                eliminar.Dispose()
                MsgBox("Desarrollador Eliminado Correctamente", vbInformation, "Sistema")
            End Try
            TextBox1.Text = ""
            TextBox2.Text = ""
            Me.DesarrolladoresTableAdapter.Fill(Me.Tienda_juegosDataSet5.Desarrolladores)
        End Using
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click 'Regresar al Menú'
        My.Computer.Audio.Play(My.Resources.KH_Close_Menu, AudioPlayMode.Background)
        Me.Close()
    End Sub

    Private Sub DesarrolladoresDataGridView_CellStateChanged(sender As Object, e As DataGridViewCellStateChangedEventArgs) Handles DesarrolladoresDataGridView.CellStateChanged
        My.Computer.Audio.Play(My.Resources.KH_Menu_Select, AudioPlayMode.Background)
    End Sub
End Class
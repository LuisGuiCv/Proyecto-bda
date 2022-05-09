Imports System.Data.SqlClient 'Importar librerías SQL'
Imports System.Data
Public Class tablas

    Dim cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet4.productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter2.Fill(Me.Tienda_juegosDataSet4.productos) 'Carga los datos en la tabla'
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click 'Volver al menú.'
        My.Computer.Audio.Play(My.Resources.KH_Close_Menu, AudioPlayMode.Background)
        Me.Close()
        Menú.Show()
    End Sub

    Private Sub Insertar_Click(sender As Object, e As EventArgs) Handles Insertar.Click 'Botón para ageragr registros.'
        My.Computer.Audio.Play(My.Resources.KH_Save_Sound, AudioPlayMode.Background)
        Using cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True") 'aquí se hace la conexión
            'con la base.'
            Dim insertar As New SqlCommand("insertarproducto", cone) 'llama al procedimiento almacenado'
            insertar.CommandType = CommandType.StoredProcedure 'especifica que la variable se trata de un procedimiento almacenado'
            insertar.Parameters.AddWithValue("@id_juego", TextBox1.Text) 'aquí toma los registros de los Textbox para agregarlos a la tabla.'
            insertar.Parameters.AddWithValue("@Nombre", TextBox2.Text)
            insertar.Parameters.AddWithValue("@Género", TextBox3.Text)
            insertar.Parameters.AddWithValue("@Plataformas", TextBox4.Text)
            insertar.Parameters.AddWithValue("@desarrollador", TextBox5.Text)
            insertar.Parameters.AddWithValue("@Unidades_existentes", TextBox6.Text)
            insertar.Parameters.AddWithValue("@Precio_Unitario", TextBox7.Text)
            Try
                cone.Open() ''abre la conexión
                insertar.ExecuteNonQuery() 'ejecuta el procedimiento'
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cone.Dispose() 'cierra la conexión'
                insertar.Dispose()
                MsgBox("Producto Registrado Correctamente", vbInformation, "Sistema") 'arroja un mensaje'
            End Try
            TextBox1.Text = "" 'se limpian los TextBox después de la inserción'
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            Me.ProductosTableAdapter2.Fill(Me.Tienda_juegosDataSet4.productos) 'Actualiza inmediatamente la tabla después de la inserción'
        End Using
    End Sub
    Sub BindData()
        Dim dt As New DataTable
        Dim da As SqlDataAdapter
        Try
            cone.Open()
            da = New SqlDataAdapter("selprodu", cone)
            da.Fill(dt)
            ProductosDataGridView.DataSource = ProductosTableAdapter
            cone.Dispose()
        Catch ex As Exception

        End Try

    End Sub


    'Permite que al hacer click en las celdas, los registros aparezcan en los TextBox'
    Private Sub ProductosDataGridView_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick
        Using cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True")
            Try
                TextBox1.Text = ProductosDataGridView.SelectedCells.Item(0).Value
                TextBox2.Text = ProductosDataGridView.SelectedCells.Item(1).Value
                TextBox3.Text = ProductosDataGridView.SelectedCells.Item(2).Value
                TextBox4.Text = ProductosDataGridView.SelectedCells.Item(3).Value
                TextBox5.Text = ProductosDataGridView.SelectedCells.Item(4).Value
                TextBox6.Text = ProductosDataGridView.SelectedCells.Item(5).Value
                TextBox7.Text = ProductosDataGridView.SelectedCells.Item(6).Value
            Catch ex As Exception

            End Try
        End Using

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click 'Botón para modificar registros'
        My.Computer.Audio.Play(My.Resources.KH_Save_Sound, AudioPlayMode.Background)
        Using cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True") 'Conexión con la base de datos'
            Dim modificar As New SqlCommand("modifprodu", cone) 'llama procedimiento almacenado'
            modificar.CommandType = CommandType.StoredProcedure
            modificar.Parameters.AddWithValue("@id_juego", TextBox1.Text) 'Toma los registros de las Textbox para introducirlas en la tabla'
            modificar.Parameters.AddWithValue("@Nombre", TextBox2.Text)
            modificar.Parameters.AddWithValue("@Género", TextBox3.Text)
            modificar.Parameters.AddWithValue("@Plataformas", TextBox4.Text)
            modificar.Parameters.AddWithValue("@desarrollador", TextBox5.Text)
            modificar.Parameters.AddWithValue("@Unidades_existentes", TextBox6.Text)
            modificar.Parameters.AddWithValue("@Precio_Unitario", TextBox7.Text)
            Try 'comienza la conexión'
                cone.Open()
                modificar.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cone.Dispose()
                modificar.Dispose()
                MsgBox("Producto Modificado Correctamente", vbInformation, "Sistema") 'Termina la conexión'
            End Try
            TextBox1.Text = "" 'Limpia los Textbox después de la modificación'
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            Me.ProductosTableAdapter2.Fill(Me.Tienda_juegosDataSet4.productos) 'Actualiza la tabla después de la modificación'
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click 'Botón para eliminar registros'
        My.Computer.Audio.Play(My.Resources.KH_Save_Sound, AudioPlayMode.Background)
        Using cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True") 'conexión con la base de datos.'
            Dim eliminar As New SqlCommand("elimprodu", cone) 'llama al procedimiento almacenado'
            eliminar.CommandType = CommandType.StoredProcedure
            eliminar.Parameters.AddWithValue("@id_juego", TextBox1.Text) 'Utiliza el id del juego para saber que registro eliminar'

            Try
                cone.Open() 'empieza la conexión'
                eliminar.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                cone.Dispose()
                eliminar.Dispose()
                MsgBox("El producto ha sido eliminado", vbInformation, "Sistema") 'Termina la conexión'
            End Try
            TextBox1.Text = "" 'limpia TextBox'
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
            TextBox5.Text = ""
            TextBox6.Text = ""
            TextBox7.Text = ""
            Me.ProductosTableAdapter2.Fill(Me.Tienda_juegosDataSet4.productos) 'Actualiza la tabla'
        End Using
    End Sub


    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.Click
        My.Computer.Audio.Play(My.Resources.KH_Menu_Extend, AudioPlayMode.Background)
        Desarrollador.Show()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        Desarrollador.Show()
    End Sub

End Class
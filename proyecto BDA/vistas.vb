Imports System.Data 'importar librerías'
Imports System.Data.SqlClient
Public Class vistas
    Dim cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True") 'Conexión con la base de datos'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.KH_Close_Menu, AudioPlayMode.Background)
        Me.Close()
        Menú.Show()
    End Sub

    Private Sub vistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet7.Xbox' Puede moverla o quitarla según sea necesario.
        Me.XboxTableAdapter.Fill(Me.Tienda_juegosDataSet7.Xbox)
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet7.SONY' Puede moverla o quitarla según sea necesario.
        Me.SONYTableAdapter.Fill(Me.Tienda_juegosDataSet7.SONY)
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet7.OTROS' Puede moverla o quitarla según sea necesario.
        Me.OTROSTableAdapter.Fill(Me.Tienda_juegosDataSet7.OTROS)
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet7.Nintendo' Puede moverla o quitarla según sea necesario.
        Me.NintendoTableAdapter.Fill(Me.Tienda_juegosDataSet7.Nintendo)
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet7.Juegos' Puede moverla o quitarla según sea necesario.
        Me.JuegosTableAdapter.Fill(Me.Tienda_juegosDataSet7.Juegos)
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet6.venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.Tienda_juegosDataSet6.venta)
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet6.Desarrolladores' Puede moverla o quitarla según sea necesario.
        Me.DesarrolladoresTableAdapter.Fill(Me.Tienda_juegosDataSet6.Desarrolladores)
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet6.fact' Puede moverla o quitarla según sea necesario.
        Me.FactTableAdapter.Fill(Me.Tienda_juegosDataSet6.fact)
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet6.cli' Puede moverla o quitarla según sea necesario.
        Me.CliTableAdapter.Fill(Me.Tienda_juegosDataSet6.cli)
        'TODO: esta línea de código carga datos en la tabla 'Tienda_juegosDataSet6.product' Puede moverla o quitarla según sea necesario.
        Me.ProductTableAdapter.Fill(Me.Tienda_juegosDataSet6.product)
        FactDataGridView.Hide()
        CliDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        VentaDataGridView.Hide()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
        ProductDataGridView.Show()
        XboxDataGridView.Hide()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Hide()
        SONYDataGridView.Hide()


    End Sub

    Private Sub PRODUCTOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTOSToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Hide()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Hide()
        SONYDataGridView.Hide()
        FactDataGridView.Hide()
        CliDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        VentaDataGridView.Hide()
        ProductDataGridView.Show()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
    End Sub

    Private Sub VENTASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENTASToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Hide()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Hide()
        SONYDataGridView.Hide()
        FactDataGridView.Hide()
        CliDataGridView.Hide()
        ProductDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        Label1.Show()
        Label2.Show()
        promedio.Show()
        total.Show()
        VentaDataGridView.Show()
        Using cone As New SqlConnection("Data Source=LENOVO-PC;Initial Catalog=tienda_juegos;Integrated Security=True") 'Usar la conexión de la base de datos'
            Dim prom As New SqlCommand("promedio_ventas", cone) 'llama al procedimiento almacenado'
            prom.CommandType = CommandType.StoredProcedure
            Dim adaptador1 As New SqlDataAdapter(prom) 'adapta el procedimiento almacenado'
            Dim ds As New DataSet()
            adaptador1.Fill(ds, "promedio")
            Me.promedio.Text = ds.Tables("promedio").Rows(0).Item(0) 'toma el valor de la tabla promedio y lo coloca en el Textbox correspondiente'
            Dim tot As New SqlCommand("total_ventas", cone) 'hace lo mismo que el anterior pero para obtener el total de ventas'
            tot.CommandType = CommandType.StoredProcedure
            Dim adaptador2 As New SqlDataAdapter(tot)
            Dim ds1 As New DataSet()
            adaptador2.Fill(ds, "total")
            Me.total.Text = ds.Tables("total").Rows(0).Item(0)
        End Using

    End Sub

    Private Sub EMPLEADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMPLEADOSToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Hide()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Hide()
        SONYDataGridView.Hide()
        ProductDataGridView.Hide()
        FactDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        VentaDataGridView.Hide()
        CliDataGridView.Show()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
    End Sub

    Private Sub FACTURAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACTURAToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Hide()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Hide()
        SONYDataGridView.Hide()
        CliDataGridView.Hide()
        ProductDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        VentaDataGridView.Hide()
        FactDataGridView.Show()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
    End Sub

    Private Sub DESARROLLADORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DESARROLLADORToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Hide()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Hide()
        SONYDataGridView.Hide()
        FactDataGridView.Hide()
        CliDataGridView.Hide()
        VentaDataGridView.Hide()
        ProductDataGridView.Hide()
        DesarrolladoresDataGridView1.Show()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
    End Sub

    Private Sub SONYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SONYToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Hide()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Hide()
        SONYDataGridView.Show()
        CliDataGridView.Hide()
        ProductDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        VentaDataGridView.Hide()
        FactDataGridView.Hide()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
    End Sub
    Private Sub NINTENDOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NINTENDOToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Hide()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Show()
        JuegosDataGridView.Hide()
        SONYDataGridView.Hide()
        CliDataGridView.Hide()
        ProductDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        VentaDataGridView.Hide()
        FactDataGridView.Hide()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
    End Sub

    Private Sub XBOXToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XBOXToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Show()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Hide()
        SONYDataGridView.Hide()
        CliDataGridView.Hide()
        ProductDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        VentaDataGridView.Hide()
        FactDataGridView.Hide()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
    End Sub

    Private Sub JUEGOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JUEGOSToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Hide()
        OTROSDataGridView.Hide()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Show()
        SONYDataGridView.Hide()
        CliDataGridView.Hide()
        ProductDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        VentaDataGridView.Hide()
        FactDataGridView.Hide()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
    End Sub

    Private Sub OTROSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OTROSToolStripMenuItem.Click
        My.Computer.Audio.Play(My.Resources.KH_Select, AudioPlayMode.Background)
        XboxDataGridView.Hide()
        OTROSDataGridView.Show()
        NintendoDataGridView.Hide()
        JuegosDataGridView.Hide()
        SONYDataGridView.Hide()
        CliDataGridView.Hide()
        ProductDataGridView.Hide()
        DesarrolladoresDataGridView1.Hide()
        VentaDataGridView.Hide()
        FactDataGridView.Hide()
        Label1.Hide()
        Label2.Hide()
        promedio.Hide()
        total.Hide()
    End Sub


End Class
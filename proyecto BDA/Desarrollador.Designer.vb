<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Desarrollador
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Desarrollador))
        Me.Tienda_juegosDataSet5 = New proyecto_BDA.tienda_juegosDataSet5()
        Me.DesarrolladoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DesarrolladoresTableAdapter = New proyecto_BDA.tienda_juegosDataSet5TableAdapters.DesarrolladoresTableAdapter()
        Me.TableAdapterManager = New proyecto_BDA.tienda_juegosDataSet5TableAdapters.TableAdapterManager()
        Me.DesarrolladoresDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Insertar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.Tienda_juegosDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesarrolladoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DesarrolladoresDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Tienda_juegosDataSet5
        '
        Me.Tienda_juegosDataSet5.DataSetName = "tienda_juegosDataSet5"
        Me.Tienda_juegosDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DesarrolladoresBindingSource
        '
        Me.DesarrolladoresBindingSource.DataMember = "Desarrolladores"
        Me.DesarrolladoresBindingSource.DataSource = Me.Tienda_juegosDataSet5
        '
        'DesarrolladoresTableAdapter
        '
        Me.DesarrolladoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = proyecto_BDA.tienda_juegosDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DesarrolladoresDataGridView
        '
        Me.DesarrolladoresDataGridView.AutoGenerateColumns = False
        Me.DesarrolladoresDataGridView.BackgroundColor = System.Drawing.SystemColors.WindowText
        Me.DesarrolladoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DesarrolladoresDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DesarrolladoresDataGridView.DataSource = Me.DesarrolladoresBindingSource
        Me.DesarrolladoresDataGridView.Location = New System.Drawing.Point(12, 27)
        Me.DesarrolladoresDataGridView.Name = "DesarrolladoresDataGridView"
        Me.DesarrolladoresDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DesarrolladoresDataGridView.Size = New System.Drawing.Size(243, 357)
        Me.DesarrolladoresDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id_desarrollador"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_desarrollador"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre_desarrollador"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre_desarrollador"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Insertar
        '
        Me.Insertar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Insertar.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Insertar.ForeColor = System.Drawing.Color.Black
        Me.Insertar.Location = New System.Drawing.Point(514, 27)
        Me.Insertar.Name = "Insertar"
        Me.Insertar.Size = New System.Drawing.Size(98, 52)
        Me.Insertar.TabIndex = 2
        Me.Insertar.Text = "Insertar"
        Me.Insertar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(514, 120)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 52)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(514, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 52)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(261, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(46, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(261, 120)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(132, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(258, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 18)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ID_Desarrollador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(261, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 18)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nombre_Desarrollador"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Algerian", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(514, 306)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 52)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Desarrollador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(621, 412)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Insertar)
        Me.Controls.Add(Me.DesarrolladoresDataGridView)
        Me.MaximizeBox = False
        Me.Name = "Desarrollador"
        Me.Text = "Desarrollador"
        CType(Me.Tienda_juegosDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesarrolladoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DesarrolladoresDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Tienda_juegosDataSet5 As tienda_juegosDataSet5
    Friend WithEvents DesarrolladoresBindingSource As BindingSource
    Friend WithEvents DesarrolladoresTableAdapter As tienda_juegosDataSet5TableAdapters.DesarrolladoresTableAdapter
    Friend WithEvents TableAdapterManager As tienda_juegosDataSet5TableAdapters.TableAdapterManager
    Friend WithEvents DesarrolladoresDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Insertar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class

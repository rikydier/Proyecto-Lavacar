﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Usuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.btnCrearUsuario = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnVerTodos = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbControlUsuarios = New System.Windows.Forms.TabControl()
        Me.tbRegistar = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxRights = New System.Windows.Forms.ComboBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtPW = New System.Windows.Forms.TextBox()
        Me.tbTodos = New System.Windows.Forms.TabPage()
        Me.dtgUsuarios = New System.Windows.Forms.DataGridView()
        Me.DbLujan21DataSet = New Lavacar.dbLujan21DataSet()
        Me.TblAdmiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblAdmiTableAdapter = New Lavacar.dbLujan21DataSetTableAdapters.tblAdmiTableAdapter()
        Me.AdmiIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmiNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmiApellidosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmiUsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmiPWDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AdmiRightsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        Me.tbControlUsuarios.SuspendLayout()
        Me.tbRegistar.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbTodos.SuspendLayout()
        CType(Me.dtgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbLujan21DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblAdmiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrearUsuario
        '
        Me.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.btnCrearUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCrearUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnCrearUsuario.Image = Global.Lavacar.My.Resources.Resources.if_AddThis_Social_Network_communicate_page_curl_437908
        Me.btnCrearUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCrearUsuario.Location = New System.Drawing.Point(6, 19)
        Me.btnCrearUsuario.Name = "btnCrearUsuario"
        Me.btnCrearUsuario.Size = New System.Drawing.Size(115, 40)
        Me.btnCrearUsuario.TabIndex = 0
        Me.btnCrearUsuario.Text = "Crear"
        Me.btnCrearUsuario.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnModificar.Image = Global.Lavacar.My.Resources.Resources.if_note_edit_66829
        Me.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModificar.Location = New System.Drawing.Point(128, 19)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(115, 40)
        Me.btnModificar.TabIndex = 1
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(120, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnBorrar.Image = Global.Lavacar.My.Resources.Resources.if_1_2058800
        Me.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBorrar.Location = New System.Drawing.Point(251, 19)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(115, 40)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnVerTodos
        '
        Me.btnVerTodos.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer), CType(CType(187, Byte), Integer))
        Me.btnVerTodos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerTodos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.btnVerTodos.Image = Global.Lavacar.My.Resources.Resources.if_icon_45_note_list_314884
        Me.btnVerTodos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnVerTodos.Location = New System.Drawing.Point(371, 19)
        Me.btnVerTodos.Name = "btnVerTodos"
        Me.btnVerTodos.Size = New System.Drawing.Size(115, 40)
        Me.btnVerTodos.TabIndex = 7
        Me.btnVerTodos.Text = "Ver todos"
        Me.btnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVerTodos.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCrearUsuario)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnVerTodos)
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 242)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 67)
        Me.GroupBox2.TabIndex = 52
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acciones"
        '
        'tbControlUsuarios
        '
        Me.tbControlUsuarios.Controls.Add(Me.tbRegistar)
        Me.tbControlUsuarios.Controls.Add(Me.tbTodos)
        Me.tbControlUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.tbControlUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.tbControlUsuarios.Name = "tbControlUsuarios"
        Me.tbControlUsuarios.SelectedIndex = 0
        Me.tbControlUsuarios.Size = New System.Drawing.Size(516, 247)
        Me.tbControlUsuarios.TabIndex = 53
        '
        'tbRegistar
        '
        Me.tbRegistar.Controls.Add(Me.GroupBox1)
        Me.tbRegistar.Location = New System.Drawing.Point(4, 22)
        Me.tbRegistar.Name = "tbRegistar"
        Me.tbRegistar.Padding = New System.Windows.Forms.Padding(3)
        Me.tbRegistar.Size = New System.Drawing.Size(508, 221)
        Me.tbRegistar.TabIndex = 0
        Me.tbRegistar.Text = "Registro"
        Me.tbRegistar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbxRights)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtPW)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 217)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del usuario"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Lavacar.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(298, 140)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(123, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Nombre"
        '
        'cbxRights
        '
        Me.cbxRights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRights.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRights.FormattingEnabled = True
        Me.cbxRights.Items.AddRange(New Object() {"Administrador", "Supervisor", "Gerente"})
        Me.cbxRights.Location = New System.Drawing.Point(70, 158)
        Me.cbxRights.Name = "cbxRights"
        Me.cbxRights.Size = New System.Drawing.Size(160, 26)
        Me.cbxRights.TabIndex = 50
        '
        'txtUsuario
        '
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(70, 106)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(160, 24)
        Me.txtUsuario.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(126, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 21)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Rights"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(298, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 21)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(294, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Apellidos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 21)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Usuario"
        '
        'txtApellidos
        '
        Me.txtApellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.Location = New System.Drawing.Point(255, 52)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(160, 24)
        Me.txtApellidos.TabIndex = 46
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(69, 52)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 24)
        Me.txtNombre.TabIndex = 45
        '
        'txtPW
        '
        Me.txtPW.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPW.Location = New System.Drawing.Point(256, 106)
        Me.txtPW.Name = "txtPW"
        Me.txtPW.Size = New System.Drawing.Size(160, 24)
        Me.txtPW.TabIndex = 6
        Me.txtPW.UseSystemPasswordChar = True
        '
        'tbTodos
        '
        Me.tbTodos.Controls.Add(Me.dtgUsuarios)
        Me.tbTodos.Location = New System.Drawing.Point(4, 22)
        Me.tbTodos.Name = "tbTodos"
        Me.tbTodos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbTodos.Size = New System.Drawing.Size(508, 221)
        Me.tbTodos.TabIndex = 1
        Me.tbTodos.Text = "Usuarios Registrados"
        Me.tbTodos.UseVisualStyleBackColor = True
        '
        'dtgUsuarios
        '
        Me.dtgUsuarios.AllowUserToAddRows = False
        Me.dtgUsuarios.AllowUserToDeleteRows = False
        Me.dtgUsuarios.AutoGenerateColumns = False
        Me.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AdmiIdDataGridViewTextBoxColumn, Me.AdmiNombreDataGridViewTextBoxColumn, Me.AdmiApellidosDataGridViewTextBoxColumn, Me.AdmiUsuarioDataGridViewTextBoxColumn, Me.AdmiPWDataGridViewTextBoxColumn, Me.AdmiRightsDataGridViewTextBoxColumn})
        Me.dtgUsuarios.DataSource = Me.TblAdmiBindingSource
        Me.dtgUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtgUsuarios.Location = New System.Drawing.Point(3, 3)
        Me.dtgUsuarios.Name = "dtgUsuarios"
        Me.dtgUsuarios.ReadOnly = True
        Me.dtgUsuarios.Size = New System.Drawing.Size(502, 218)
        Me.dtgUsuarios.TabIndex = 0
        '
        'DbLujan21DataSet
        '
        Me.DbLujan21DataSet.DataSetName = "dbLujan21DataSet"
        Me.DbLujan21DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblAdmiBindingSource
        '
        Me.TblAdmiBindingSource.DataMember = "tblAdmi"
        Me.TblAdmiBindingSource.DataSource = Me.DbLujan21DataSet
        '
        'TblAdmiTableAdapter
        '
        Me.TblAdmiTableAdapter.ClearBeforeFill = True
        '
        'AdmiIdDataGridViewTextBoxColumn
        '
        Me.AdmiIdDataGridViewTextBoxColumn.DataPropertyName = "admiId"
        Me.AdmiIdDataGridViewTextBoxColumn.HeaderText = "admiId"
        Me.AdmiIdDataGridViewTextBoxColumn.Name = "AdmiIdDataGridViewTextBoxColumn"
        Me.AdmiIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdmiNombreDataGridViewTextBoxColumn
        '
        Me.AdmiNombreDataGridViewTextBoxColumn.DataPropertyName = "admiNombre"
        Me.AdmiNombreDataGridViewTextBoxColumn.HeaderText = "admiNombre"
        Me.AdmiNombreDataGridViewTextBoxColumn.Name = "AdmiNombreDataGridViewTextBoxColumn"
        Me.AdmiNombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdmiApellidosDataGridViewTextBoxColumn
        '
        Me.AdmiApellidosDataGridViewTextBoxColumn.DataPropertyName = "admiApellidos"
        Me.AdmiApellidosDataGridViewTextBoxColumn.HeaderText = "admiApellidos"
        Me.AdmiApellidosDataGridViewTextBoxColumn.Name = "AdmiApellidosDataGridViewTextBoxColumn"
        Me.AdmiApellidosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdmiUsuarioDataGridViewTextBoxColumn
        '
        Me.AdmiUsuarioDataGridViewTextBoxColumn.DataPropertyName = "admiUsuario"
        Me.AdmiUsuarioDataGridViewTextBoxColumn.HeaderText = "admiUsuario"
        Me.AdmiUsuarioDataGridViewTextBoxColumn.Name = "AdmiUsuarioDataGridViewTextBoxColumn"
        Me.AdmiUsuarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdmiPWDataGridViewTextBoxColumn
        '
        Me.AdmiPWDataGridViewTextBoxColumn.DataPropertyName = "admiPW"
        Me.AdmiPWDataGridViewTextBoxColumn.HeaderText = "admiPW"
        Me.AdmiPWDataGridViewTextBoxColumn.Name = "AdmiPWDataGridViewTextBoxColumn"
        Me.AdmiPWDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AdmiRightsDataGridViewTextBoxColumn
        '
        Me.AdmiRightsDataGridViewTextBoxColumn.DataPropertyName = "admiRights"
        Me.AdmiRightsDataGridViewTextBoxColumn.HeaderText = "admiRights"
        Me.AdmiRightsDataGridViewTextBoxColumn.Name = "AdmiRightsDataGridViewTextBoxColumn"
        Me.AdmiRightsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(516, 326)
        Me.Controls.Add(Me.tbControlUsuarios)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Usuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        Me.GroupBox2.ResumeLayout(False)
        Me.tbControlUsuarios.ResumeLayout(False)
        Me.tbRegistar.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbTodos.ResumeLayout(False)
        CType(Me.dtgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbLujan21DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblAdmiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCrearUsuario As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnVerTodos As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbControlUsuarios As TabControl
    Friend WithEvents tbRegistar As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxRights As ComboBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellidos As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtPW As TextBox
    Friend WithEvents tbTodos As TabPage
    Friend WithEvents dtgUsuarios As DataGridView
    Friend WithEvents DbLujan21DataSet As dbLujan21DataSet
    Friend WithEvents TblAdmiBindingSource As BindingSource
    Friend WithEvents TblAdmiTableAdapter As dbLujan21DataSetTableAdapters.tblAdmiTableAdapter
    Friend WithEvents AdmiIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdmiNombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdmiApellidosDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdmiUsuarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdmiPWDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AdmiRightsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class

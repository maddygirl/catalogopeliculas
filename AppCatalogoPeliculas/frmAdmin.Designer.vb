<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdmin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdmin))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbGeneroPeli = New System.Windows.Forms.ComboBox()
        Me.txtPosterURL = New System.Windows.Forms.TextBox()
        Me.txtSinopsisPeli = New System.Windows.Forms.TextBox()
        Me.txtDuracionPeli = New System.Windows.Forms.TextBox()
        Me.txtDirectorPeli = New System.Windows.Forms.TextBox()
        Me.txtTituloPeli = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtID_Peli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvListaPeliculas = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblCatelera = New System.Windows.Forms.Label()
        Me.cmbCartelera = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvListaPeliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lblCatelera)
        Me.GroupBox1.Controls.Add(Me.txtAnio)
        Me.GroupBox1.Controls.Add(Me.cmbCartelera)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.cmbGeneroPeli)
        Me.GroupBox1.Controls.Add(Me.txtPosterURL)
        Me.GroupBox1.Controls.Add(Me.txtSinopsisPeli)
        Me.GroupBox1.Controls.Add(Me.txtDuracionPeli)
        Me.GroupBox1.Controls.Add(Me.txtDirectorPeli)
        Me.GroupBox1.Controls.Add(Me.txtTituloPeli)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtID_Peli)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1066, 238)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(760, 25)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(282, 24)
        Me.txtAnio.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(373, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 216)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'cmbGeneroPeli
        '
        Me.cmbGeneroPeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeneroPeli.FormattingEnabled = True
        Me.cmbGeneroPeli.Items.AddRange(New Object() {"Drama", "Comedia", "Aventura", "Terror", "Ciencia ficción", "Fantasía", "Musical", "Animación", "Documental", "Western", "Romance", "Misterio", "Suspense", "Crimen", "Bélico", "Familiar", "Histórico", "Artístico", "Experimental"})
        Me.cmbGeneroPeli.Location = New System.Drawing.Point(133, 78)
        Me.cmbGeneroPeli.Name = "cmbGeneroPeli"
        Me.cmbGeneroPeli.Size = New System.Drawing.Size(234, 25)
        Me.cmbGeneroPeli.TabIndex = 16
        '
        'txtPosterURL
        '
        Me.txtPosterURL.Location = New System.Drawing.Point(758, 158)
        Me.txtPosterURL.Name = "txtPosterURL"
        Me.txtPosterURL.Size = New System.Drawing.Size(284, 24)
        Me.txtPosterURL.TabIndex = 15
        '
        'txtSinopsisPeli
        '
        Me.txtSinopsisPeli.Location = New System.Drawing.Point(758, 112)
        Me.txtSinopsisPeli.Name = "txtSinopsisPeli"
        Me.txtSinopsisPeli.Size = New System.Drawing.Size(284, 24)
        Me.txtSinopsisPeli.TabIndex = 14
        '
        'txtDuracionPeli
        '
        Me.txtDuracionPeli.Location = New System.Drawing.Point(758, 66)
        Me.txtDuracionPeli.Name = "txtDuracionPeli"
        Me.txtDuracionPeli.Size = New System.Drawing.Size(284, 24)
        Me.txtDuracionPeli.TabIndex = 13
        '
        'txtDirectorPeli
        '
        Me.txtDirectorPeli.Location = New System.Drawing.Point(133, 185)
        Me.txtDirectorPeli.Name = "txtDirectorPeli"
        Me.txtDirectorPeli.Size = New System.Drawing.Size(234, 24)
        Me.txtDirectorPeli.TabIndex = 11
        '
        'txtTituloPeli
        '
        Me.txtTituloPeli.Location = New System.Drawing.Point(133, 137)
        Me.txtTituloPeli.Name = "txtTituloPeli"
        Me.txtTituloPeli.Size = New System.Drawing.Size(234, 24)
        Me.txtTituloPeli.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(643, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 18)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Póster URL:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(643, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 18)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sinopsis:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(643, 71)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 18)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Duración:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(645, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Año:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Director:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Título:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Género:"
        '
        'txtID_Peli
        '
        Me.txtID_Peli.Location = New System.Drawing.Point(133, 23)
        Me.txtID_Peli.Name = "txtID_Peli"
        Me.txtID_Peli.ReadOnly = True
        Me.txtID_Peli.Size = New System.Drawing.Size(234, 24)
        Me.txtID_Peli.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Pelicula:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSalir)
        Me.GroupBox2.Controls.Add(Me.btnLimpiar)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.btnConsultar)
        Me.GroupBox2.Controls.Add(Me.btnInsertar)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 271)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1066, 114)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(889, 40)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(155, 50)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(717, 40)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(155, 50)
        Me.btnLimpiar.TabIndex = 4
        Me.btnLimpiar.Text = "Reset"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(540, 40)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(155, 50)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(363, 40)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(155, 50)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(192, 40)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(155, 50)
        Me.btnConsultar.TabIndex = 1
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(21, 40)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(155, 50)
        Me.btnInsertar.TabIndex = 0
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.dgvListaPeliculas)
        Me.GroupBox3.Location = New System.Drawing.Point(13, 402)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1066, 240)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'dgvListaPeliculas
        '
        Me.dgvListaPeliculas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaPeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaPeliculas.Location = New System.Drawing.Point(0, 0)
        Me.dgvListaPeliculas.Name = "dgvListaPeliculas"
        Me.dgvListaPeliculas.ReadOnly = True
        Me.dgvListaPeliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaPeliculas.Size = New System.Drawing.Size(1066, 240)
        Me.dgvListaPeliculas.TabIndex = 75
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1089, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegistroToolStripMenuItem
        '
        Me.RegistroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearUsuarioToolStripMenuItem})
        Me.RegistroToolStripMenuItem.Name = "RegistroToolStripMenuItem"
        Me.RegistroToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RegistroToolStripMenuItem.Text = "Registro"
        '
        'CrearUsuarioToolStripMenuItem
        '
        Me.CrearUsuarioToolStripMenuItem.Name = "CrearUsuarioToolStripMenuItem"
        Me.CrearUsuarioToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.CrearUsuarioToolStripMenuItem.Text = "Crear Usuario"
        '
        'lblCatelera
        '
        Me.lblCatelera.AutoSize = True
        Me.lblCatelera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCatelera.Location = New System.Drawing.Point(643, 210)
        Me.lblCatelera.Name = "lblCatelera"
        Me.lblCatelera.Size = New System.Drawing.Size(68, 18)
        Me.lblCatelera.TabIndex = 23
        Me.lblCatelera.Text = "Cartelera"
        '
        'cmbCartelera
        '
        Me.cmbCartelera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCartelera.FormattingEnabled = True
        Me.cmbCartelera.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbCartelera.Location = New System.Drawing.Point(760, 207)
        Me.cmbCartelera.Name = "cmbCartelera"
        Me.cmbCartelera.Size = New System.Drawing.Size(284, 25)
        Me.cmbCartelera.TabIndex = 22
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1089, 666)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdmin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvListaPeliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnConsultar As Button
    Friend WithEvents btnInsertar As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtID_Peli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbGeneroPeli As ComboBox
    Friend WithEvents txtPosterURL As TextBox
    Friend WithEvents txtSinopsisPeli As TextBox
    Friend WithEvents txtDuracionPeli As TextBox
    Friend WithEvents txtDirectorPeli As TextBox
    Friend WithEvents txtTituloPeli As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents dgvListaPeliculas As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents RegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblCatelera As Label
    Friend WithEvents cmbCartelera As ComboBox
End Class

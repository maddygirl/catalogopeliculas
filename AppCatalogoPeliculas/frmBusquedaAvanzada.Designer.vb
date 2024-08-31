<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaAvanzada
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lblCatelera = New System.Windows.Forms.Label()
        Me.cmbCartelera = New System.Windows.Forms.ComboBox()
        Me.txtAnio = New System.Windows.Forms.TextBox()
        Me.cmbGeneroPeli = New System.Windows.Forms.ComboBox()
        Me.txtDuracionPeli = New System.Windows.Forms.TextBox()
        Me.txtDirectorPeli = New System.Windows.Forms.TextBox()
        Me.txtTituloPeli = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(20, 335)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(137, 50)
        Me.btnLimpiar.TabIndex = 49
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBuscar.Location = New System.Drawing.Point(320, 335)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(137, 50)
        Me.btnBuscar.TabIndex = 48
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lblCatelera
        '
        Me.lblCatelera.AutoSize = True
        Me.lblCatelera.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCatelera.ForeColor = System.Drawing.Color.White
        Me.lblCatelera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCatelera.Location = New System.Drawing.Point(20, 267)
        Me.lblCatelera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCatelera.Name = "lblCatelera"
        Me.lblCatelera.Size = New System.Drawing.Size(121, 20)
        Me.lblCatelera.TabIndex = 47
        Me.lblCatelera.Text = "En Cartelera:"
        '
        'cmbCartelera
        '
        Me.cmbCartelera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCartelera.FormattingEnabled = True
        Me.cmbCartelera.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbCartelera.Location = New System.Drawing.Point(163, 263)
        Me.cmbCartelera.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbCartelera.Name = "cmbCartelera"
        Me.cmbCartelera.Size = New System.Drawing.Size(277, 24)
        Me.cmbCartelera.TabIndex = 46
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(163, 166)
        Me.txtAnio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(277, 22)
        Me.txtAnio.TabIndex = 45
        '
        'cmbGeneroPeli
        '
        Me.cmbGeneroPeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeneroPeli.FormattingEnabled = True
        Me.cmbGeneroPeli.Items.AddRange(New Object() {"Drama", "Comedia", "Aventura", "Terror", "Ciencia ficción", "Fantasía", "Musical", "Animación", "Documental", "Western", "Romance", "Misterio", "Suspense", "Crimen", "Bélico", "Familiar", "Histórico", "Artístico", "Experimental"})
        Me.cmbGeneroPeli.Location = New System.Drawing.Point(163, 15)
        Me.cmbGeneroPeli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbGeneroPeli.Name = "cmbGeneroPeli"
        Me.cmbGeneroPeli.Size = New System.Drawing.Size(277, 24)
        Me.cmbGeneroPeli.TabIndex = 44
        '
        'txtDuracionPeli
        '
        Me.txtDuracionPeli.Location = New System.Drawing.Point(163, 213)
        Me.txtDuracionPeli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDuracionPeli.Name = "txtDuracionPeli"
        Me.txtDuracionPeli.Size = New System.Drawing.Size(277, 22)
        Me.txtDuracionPeli.TabIndex = 43
        '
        'txtDirectorPeli
        '
        Me.txtDirectorPeli.Location = New System.Drawing.Point(163, 117)
        Me.txtDirectorPeli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDirectorPeli.Name = "txtDirectorPeli"
        Me.txtDirectorPeli.Size = New System.Drawing.Size(277, 22)
        Me.txtDirectorPeli.TabIndex = 42
        '
        'txtTituloPeli
        '
        Me.txtTituloPeli.Location = New System.Drawing.Point(163, 66)
        Me.txtTituloPeli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTituloPeli.Name = "txtTituloPeli"
        Me.txtTituloPeli.Size = New System.Drawing.Size(277, 22)
        Me.txtTituloPeli.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 217)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Duración:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(20, 170)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Año:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(20, 126)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Director:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(20, 70)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Título:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(20, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Género:"
        '
        'frmBusquedaAvanzada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(479, 404)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.lblCatelera)
        Me.Controls.Add(Me.cmbCartelera)
        Me.Controls.Add(Me.txtAnio)
        Me.Controls.Add(Me.cmbGeneroPeli)
        Me.Controls.Add(Me.txtDuracionPeli)
        Me.Controls.Add(Me.txtDirectorPeli)
        Me.Controls.Add(Me.txtTituloPeli)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmBusquedaAvanzada"
        Me.Text = "Busqueda Avanzada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents lblCatelera As Label
    Friend WithEvents cmbCartelera As ComboBox
    Friend WithEvents txtAnio As TextBox
    Friend WithEvents cmbGeneroPeli As ComboBox
    Friend WithEvents txtDuracionPeli As TextBox
    Friend WithEvents txtDirectorPeli As TextBox
    Friend WithEvents txtTituloPeli As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class

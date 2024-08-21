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
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCatelera
        '
        Me.lblCatelera.AutoSize = True
        Me.lblCatelera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCatelera.Location = New System.Drawing.Point(12, 217)
        Me.lblCatelera.Name = "lblCatelera"
        Me.lblCatelera.Size = New System.Drawing.Size(68, 13)
        Me.lblCatelera.TabIndex = 33
        Me.lblCatelera.Text = "En Cartelera:"
        '
        'cmbCartelera
        '
        Me.cmbCartelera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCartelera.FormattingEnabled = True
        Me.cmbCartelera.Items.AddRange(New Object() {"Si", "No"})
        Me.cmbCartelera.Location = New System.Drawing.Point(94, 214)
        Me.cmbCartelera.Name = "cmbCartelera"
        Me.cmbCartelera.Size = New System.Drawing.Size(234, 21)
        Me.cmbCartelera.TabIndex = 32
        '
        'txtAnio
        '
        Me.txtAnio.Location = New System.Drawing.Point(94, 135)
        Me.txtAnio.Name = "txtAnio"
        Me.txtAnio.Size = New System.Drawing.Size(234, 20)
        Me.txtAnio.TabIndex = 31
        '
        'cmbGeneroPeli
        '
        Me.cmbGeneroPeli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGeneroPeli.FormattingEnabled = True
        Me.cmbGeneroPeli.Items.AddRange(New Object() {"Drama", "Comedia", "Aventura", "Terror", "Ciencia ficción", "Fantasía", "Musical", "Animación", "Documental", "Western", "Romance", "Misterio", "Suspense", "Crimen", "Bélico", "Familiar", "Histórico", "Artístico", "Experimental"})
        Me.cmbGeneroPeli.Location = New System.Drawing.Point(94, 12)
        Me.cmbGeneroPeli.Name = "cmbGeneroPeli"
        Me.cmbGeneroPeli.Size = New System.Drawing.Size(234, 21)
        Me.cmbGeneroPeli.TabIndex = 30
        '
        'txtDuracionPeli
        '
        Me.txtDuracionPeli.Location = New System.Drawing.Point(94, 173)
        Me.txtDuracionPeli.Name = "txtDuracionPeli"
        Me.txtDuracionPeli.Size = New System.Drawing.Size(234, 20)
        Me.txtDuracionPeli.TabIndex = 29
        '
        'txtDirectorPeli
        '
        Me.txtDirectorPeli.Location = New System.Drawing.Point(94, 95)
        Me.txtDirectorPeli.Name = "txtDirectorPeli"
        Me.txtDirectorPeli.Size = New System.Drawing.Size(234, 20)
        Me.txtDirectorPeli.TabIndex = 28
        '
        'txtTituloPeli
        '
        Me.txtTituloPeli.Location = New System.Drawing.Point(94, 54)
        Me.txtTituloPeli.Name = "txtTituloPeli"
        Me.txtTituloPeli.Size = New System.Drawing.Size(234, 20)
        Me.txtTituloPeli.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Duración:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Año:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Director:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Título:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Género:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(237, 272)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(103, 41)
        Me.btnBuscar.TabIndex = 34
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 272)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(103, 41)
        Me.btnLimpiar.TabIndex = 35
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'frmBusquedaAvanzada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 325)
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
        Me.Name = "frmBusquedaAvanzada"
        Me.Text = "Busqueda Avanzada"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnLimpiar As Button
End Class

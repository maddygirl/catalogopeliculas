<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Taquilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Taquilla))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.mkbCantEntradas = New System.Windows.Forms.MaskedTextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.cmbTipoEntrada = New System.Windows.Forms.ComboBox()
        Me.cmbPelicula = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ckbCombo3 = New System.Windows.Forms.CheckBox()
        Me.ckbCombo2 = New System.Windows.Forms.CheckBox()
        Me.ckbCombo1 = New System.Windows.Forms.CheckBox()
        Me.ckbNachos = New System.Windows.Forms.CheckBox()
        Me.ckbRefresco = New System.Windows.Forms.CheckBox()
        Me.ckbPalomitas = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtTotalPago = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtSubTotal = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnticket = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(633, 633)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.mkbCantEntradas)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.cmbTipoEntrada)
        Me.GroupBox1.Controls.Add(Me.cmbPelicula)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(652, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(406, 202)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "BOLETERIA"
        '
        'mkbCantEntradas
        '
        Me.mkbCantEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkbCantEntradas.Location = New System.Drawing.Point(203, 163)
        Me.mkbCantEntradas.Mask = "9999"
        Me.mkbCantEntradas.Name = "mkbCantEntradas"
        Me.mkbCantEntradas.Size = New System.Drawing.Size(180, 23)
        Me.mkbCantEntradas.TabIndex = 7
        Me.mkbCantEntradas.ValidatingType = GetType(Integer)
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(203, 117)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.ReadOnly = True
        Me.txtPrecio.Size = New System.Drawing.Size(180, 23)
        Me.txtPrecio.TabIndex = 6
        '
        'cmbTipoEntrada
        '
        Me.cmbTipoEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTipoEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoEntrada.FormattingEnabled = True
        Me.cmbTipoEntrada.Items.AddRange(New Object() {"Regular 2D Adulto", "Regular 2D Niño", "Regular 2D Adulto Mayot"})
        Me.cmbTipoEntrada.Location = New System.Drawing.Point(203, 75)
        Me.cmbTipoEntrada.Name = "cmbTipoEntrada"
        Me.cmbTipoEntrada.Size = New System.Drawing.Size(180, 25)
        Me.cmbTipoEntrada.TabIndex = 5
        '
        'cmbPelicula
        '
        Me.cmbPelicula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPelicula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPelicula.FormattingEnabled = True
        Me.cmbPelicula.Items.AddRange(New Object() {"Toys Story", "Megalodón", "Barbie", "Matrix", "Los Minions 2", "Son como niños"})
        Me.cmbPelicula.Location = New System.Drawing.Point(203, 27)
        Me.cmbPelicula.Name = "cmbPelicula"
        Me.cmbPelicula.Size = New System.Drawing.Size(180, 25)
        Me.cmbPelicula.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cant. Entradas:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de Entradas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Peliculas:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ckbCombo3)
        Me.GroupBox2.Controls.Add(Me.ckbCombo2)
        Me.GroupBox2.Controls.Add(Me.ckbCombo1)
        Me.GroupBox2.Controls.Add(Me.ckbNachos)
        Me.GroupBox2.Controls.Add(Me.ckbRefresco)
        Me.GroupBox2.Controls.Add(Me.ckbPalomitas)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(652, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(406, 164)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DULCERIA"
        '
        'ckbCombo3
        '
        Me.ckbCombo3.AutoSize = True
        Me.ckbCombo3.Location = New System.Drawing.Point(268, 124)
        Me.ckbCombo3.Name = "ckbCombo3"
        Me.ckbCombo3.Size = New System.Drawing.Size(99, 21)
        Me.ckbCombo3.TabIndex = 5
        Me.ckbCombo3.Text = "Combo #3"
        Me.ckbCombo3.UseVisualStyleBackColor = True
        '
        'ckbCombo2
        '
        Me.ckbCombo2.AutoSize = True
        Me.ckbCombo2.Location = New System.Drawing.Point(268, 78)
        Me.ckbCombo2.Name = "ckbCombo2"
        Me.ckbCombo2.Size = New System.Drawing.Size(99, 21)
        Me.ckbCombo2.TabIndex = 4
        Me.ckbCombo2.Text = "Combo #2"
        Me.ckbCombo2.UseVisualStyleBackColor = True
        '
        'ckbCombo1
        '
        Me.ckbCombo1.AutoSize = True
        Me.ckbCombo1.Location = New System.Drawing.Point(268, 26)
        Me.ckbCombo1.Name = "ckbCombo1"
        Me.ckbCombo1.Size = New System.Drawing.Size(99, 21)
        Me.ckbCombo1.TabIndex = 3
        Me.ckbCombo1.Text = "Combo #1"
        Me.ckbCombo1.UseVisualStyleBackColor = True
        '
        'ckbNachos
        '
        Me.ckbNachos.AutoSize = True
        Me.ckbNachos.Location = New System.Drawing.Point(23, 124)
        Me.ckbNachos.Name = "ckbNachos"
        Me.ckbNachos.Size = New System.Drawing.Size(133, 21)
        Me.ckbNachos.TabIndex = 2
        Me.ckbNachos.Text = "Nachos ₡3500"
        Me.ckbNachos.UseVisualStyleBackColor = True
        '
        'ckbRefresco
        '
        Me.ckbRefresco.AutoSize = True
        Me.ckbRefresco.Location = New System.Drawing.Point(23, 78)
        Me.ckbRefresco.Name = "ckbRefresco"
        Me.ckbRefresco.Size = New System.Drawing.Size(144, 21)
        Me.ckbRefresco.TabIndex = 1
        Me.ckbRefresco.Text = "Refresco ₡2500"
        Me.ckbRefresco.UseVisualStyleBackColor = True
        '
        'ckbPalomitas
        '
        Me.ckbPalomitas.AutoSize = True
        Me.ckbPalomitas.Location = New System.Drawing.Point(23, 26)
        Me.ckbPalomitas.Name = "ckbPalomitas"
        Me.ckbPalomitas.Size = New System.Drawing.Size(149, 21)
        Me.ckbPalomitas.TabIndex = 0
        Me.ckbPalomitas.Text = "Palomitas ₡2900"
        Me.ckbPalomitas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtTotalPago)
        Me.GroupBox3.Controls.Add(Me.txtImpuesto)
        Me.GroupBox3.Controls.Add(Me.txtDesc)
        Me.GroupBox3.Controls.Add(Me.txtSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(652, 393)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(406, 189)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FACTURA"
        '
        'txtTotalPago
        '
        Me.txtTotalPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalPago.Location = New System.Drawing.Point(203, 147)
        Me.txtTotalPago.Name = "txtTotalPago"
        Me.txtTotalPago.ReadOnly = True
        Me.txtTotalPago.Size = New System.Drawing.Size(180, 23)
        Me.txtTotalPago.TabIndex = 11
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpuesto.Location = New System.Drawing.Point(203, 106)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.ReadOnly = True
        Me.txtImpuesto.Size = New System.Drawing.Size(180, 23)
        Me.txtImpuesto.TabIndex = 10
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(203, 70)
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.Size = New System.Drawing.Size(180, 23)
        Me.txtDesc.TabIndex = 9
        '
        'txtSubTotal
        '
        Me.txtSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubTotal.Location = New System.Drawing.Point(203, 31)
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.ReadOnly = True
        Me.txtSubTotal.Size = New System.Drawing.Size(180, 23)
        Me.txtSubTotal.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Total a Pagar:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Impuesto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Descuento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Sub Total:"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1086, 26)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(220, 154)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1086, 223)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(220, 154)
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1086, 424)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(220, 154)
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCalcular.Location = New System.Drawing.Point(683, 599)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(124, 57)
        Me.btnCalcular.TabIndex = 7
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(1039, 599)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(124, 57)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(1182, 599)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(124, 57)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnticket
        '
        Me.btnticket.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnticket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnticket.Location = New System.Drawing.Point(855, 599)
        Me.btnticket.Name = "btnticket"
        Me.btnticket.Size = New System.Drawing.Size(124, 57)
        Me.btnticket.TabIndex = 10
        Me.btnticket.Text = "Generar Ticket"
        Me.btnticket.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(167, 433)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(332, 55)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "ACY MOVIES"
        '
        'Taquilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1326, 678)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnticket)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Taquilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Taquilla"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents cmbTipoEntrada As ComboBox
    Friend WithEvents cmbPelicula As ComboBox
    Friend WithEvents ckbCombo3 As CheckBox
    Friend WithEvents ckbCombo2 As CheckBox
    Friend WithEvents ckbCombo1 As CheckBox
    Friend WithEvents ckbNachos As CheckBox
    Friend WithEvents ckbRefresco As CheckBox
    Friend WithEvents ckbPalomitas As CheckBox
    Friend WithEvents txtTotalPago As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtSubTotal As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnticket As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents mkbCantEntradas As MaskedTextBox
End Class

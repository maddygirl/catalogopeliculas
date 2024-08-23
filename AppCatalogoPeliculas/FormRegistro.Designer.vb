<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRegistro))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.cmbRol = New System.Windows.Forms.ComboBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPassword_usuario = New System.Windows.Forms.TextBox()
        Me.txtNombre_usuario = New System.Windows.Forms.TextBox()
        Me.txtID_usuario = New System.Windows.Forms.TextBox()
        Me.lblRol = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gold
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(308, 422)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.btnVerificar)
        Me.GroupBox1.Controls.Add(Me.btnSalir)
        Me.GroupBox1.Controls.Add(Me.btnRegistrar)
        Me.GroupBox1.Controls.Add(Me.cmbRol)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Controls.Add(Me.txtPassword_usuario)
        Me.GroupBox1.Controls.Add(Me.txtNombre_usuario)
        Me.GroupBox1.Controls.Add(Me.txtID_usuario)
        Me.GroupBox1.Controls.Add(Me.lblRol)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.lblUsuario)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(308, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(443, 422)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGISTRO DE USUARIO"
        '
        'btnVerificar
        '
        Me.btnVerificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnVerificar.Location = New System.Drawing.Point(53, 331)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(124, 52)
        Me.btnVerificar.TabIndex = 13
        Me.btnVerificar.Text = "VERIFICAR CORREO"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(313, 331)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(124, 52)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRegistrar.Location = New System.Drawing.Point(183, 331)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(124, 52)
        Me.btnRegistrar.TabIndex = 10
        Me.btnRegistrar.Text = "REGISTRAR"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        Me.btnRegistrar.Visible = False
        '
        'cmbRol
        '
        Me.cmbRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Items.AddRange(New Object() {"Usuario", "Administrador"})
        Me.cmbRol.Location = New System.Drawing.Point(157, 263)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(280, 25)
        Me.cmbRol.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(157, 216)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(280, 21)
        Me.txtEmail.TabIndex = 8
        '
        'txtPassword_usuario
        '
        Me.txtPassword_usuario.Location = New System.Drawing.Point(157, 169)
        Me.txtPassword_usuario.Name = "txtPassword_usuario"
        Me.txtPassword_usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword_usuario.Size = New System.Drawing.Size(280, 21)
        Me.txtPassword_usuario.TabIndex = 7
        '
        'txtNombre_usuario
        '
        Me.txtNombre_usuario.Location = New System.Drawing.Point(157, 124)
        Me.txtNombre_usuario.Name = "txtNombre_usuario"
        Me.txtNombre_usuario.Size = New System.Drawing.Size(280, 21)
        Me.txtNombre_usuario.TabIndex = 6
        '
        'txtID_usuario
        '
        Me.txtID_usuario.Location = New System.Drawing.Point(157, 77)
        Me.txtID_usuario.Name = "txtID_usuario"
        Me.txtID_usuario.ReadOnly = True
        Me.txtID_usuario.Size = New System.Drawing.Size(280, 21)
        Me.txtID_usuario.TabIndex = 5
        '
        'lblRol
        '
        Me.lblRol.AutoSize = True
        Me.lblRol.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRol.ForeColor = System.Drawing.Color.White
        Me.lblRol.Location = New System.Drawing.Point(16, 269)
        Me.lblRol.Name = "lblRol"
        Me.lblRol.Size = New System.Drawing.Size(50, 20)
        Me.lblRol.TabIndex = 4
        Me.lblRol.Text = "ROL:"
        Me.lblRol.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.White
        Me.lblEmail.Location = New System.Drawing.Point(16, 221)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(68, 20)
        Me.lblEmail.TabIndex = 3
        Me.lblEmail.Text = "EMAIL:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.White
        Me.lblPassword.Location = New System.Drawing.Point(16, 174)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(134, 20)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "CONTRASEÑA:"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuario.ForeColor = System.Drawing.Color.White
        Me.lblUsuario.Location = New System.Drawing.Point(16, 129)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(96, 20)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "USUARIO:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.White
        Me.lblId.Location = New System.Drawing.Point(16, 82)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(33, 20)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID:"
        '
        'FormRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(763, 443)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormRegistro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACY MOVIES"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPassword_usuario As TextBox
    Friend WithEvents txtNombre_usuario As TextBox
    Friend WithEvents txtID_usuario As TextBox
    Friend WithEvents lblRol As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblId As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents btnVerificar As Button
End Class

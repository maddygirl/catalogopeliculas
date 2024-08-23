<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPelicula
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
        Me.lblDisponible = New System.Windows.Forms.Label()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.pbPoster = New System.Windows.Forms.PictureBox()
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDisponible
        '
        Me.lblDisponible.AutoSize = True
        Me.lblDisponible.Font = New System.Drawing.Font("Bahnschrift SemiCondensed", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisponible.ForeColor = System.Drawing.Color.Green
        Me.lblDisponible.Location = New System.Drawing.Point(299, 303)
        Me.lblDisponible.Name = "lblDisponible"
        Me.lblDisponible.Size = New System.Drawing.Size(210, 19)
        Me.lblDisponible.TabIndex = 9
        Me.lblDisponible.Text = "Pelicula Disponible en Cartelera"
        '
        'lblSummary
        '
        Me.lblSummary.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummary.Location = New System.Drawing.Point(300, 95)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(327, 186)
        Me.lblSummary.TabIndex = 8
        Me.lblSummary.Text = "Summary Placeholder"
        Me.lblSummary.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(586, 286)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(86, 36)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Bahnschrift SemiBold SemiConden", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(293, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(379, 99)
        Me.lblTitulo.TabIndex = 6
        Me.lblTitulo.Text = "PLACEHOLDER PARA EL TITULO"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbPoster
        '
        Me.pbPoster.Location = New System.Drawing.Point(12, 12)
        Me.pbPoster.Name = "pbPoster"
        Me.pbPoster.Size = New System.Drawing.Size(275, 310)
        Me.pbPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPoster.TabIndex = 5
        Me.pbPoster.TabStop = False
        '
        'frmPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 334)
        Me.Controls.Add(Me.lblDisponible)
        Me.Controls.Add(Me.lblSummary)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.pbPoster)
        Me.Name = "frmPelicula"
        Me.Text = "Informacion de Pelicula"
        CType(Me.pbPoster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDisponible As Label
    Friend WithEvents lblSummary As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents pbPoster As PictureBox
End Class

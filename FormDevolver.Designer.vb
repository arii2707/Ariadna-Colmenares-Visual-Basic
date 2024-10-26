<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDevolver
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
        lblTitulo = New Label()
        lblAutor = New Label()
        txtTitulo = New TextBox()
        txtAutor = New TextBox()
        btnDevolver = New Button()
        txtResultado = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitulo.ForeColor = Color.Purple
        lblTitulo.Location = New Point(197, 121)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(138, 22)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Titulo del Libro"
        ' 
        ' lblAutor
        ' 
        lblAutor.AutoSize = True
        lblAutor.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAutor.ForeColor = Color.Purple
        lblAutor.Location = New Point(199, 164)
        lblAutor.Name = "lblAutor"
        lblAutor.Size = New Size(136, 22)
        lblAutor.TabIndex = 1
        lblAutor.Text = "Autor del Libro"
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(341, 120)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(168, 23)
        txtTitulo.TabIndex = 2
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(341, 166)
        txtAutor.Name = "txtAutor"
        txtAutor.Size = New Size(168, 23)
        txtAutor.TabIndex = 3
        ' 
        ' btnDevolver
        ' 
        btnDevolver.ForeColor = Color.Purple
        btnDevolver.Location = New Point(389, 210)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(75, 23)
        btnDevolver.TabIndex = 4
        btnDevolver.Text = "Devolver"
        btnDevolver.UseVisualStyleBackColor = True
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(341, 239)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(168, 23)
        txtResultado.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Times New Roman", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(158, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(494, 72)
        Label1.TabIndex = 7
        Label1.Text = "Biblioteca Velaris"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._011ebc07eb551c1271e958002ded42fa
        PictureBox1.Location = New Point(546, 166)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(211, 209)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' FormDevolver
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(txtResultado)
        Controls.Add(btnDevolver)
        Controls.Add(txtAutor)
        Controls.Add(txtTitulo)
        Controls.Add(lblAutor)
        Controls.Add(lblTitulo)
        Name = "FormDevolver"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents btnDevolver As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class

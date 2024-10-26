<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrestar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitulo = New Label()
        lblAutor = New Label()
        txtTitulo = New TextBox()
        txtAutor = New TextBox()
        btnPrestar = New Button()
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
        lblTitulo.Location = New Point(208, 132)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(138, 22)
        lblTitulo.TabIndex = 0
        lblTitulo.Text = "Título del Libro"
        ' 
        ' lblAutor
        ' 
        lblAutor.AutoSize = True
        lblAutor.Font = New Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAutor.ForeColor = Color.Purple
        lblAutor.Location = New Point(210, 174)
        lblAutor.Name = "lblAutor"
        lblAutor.Size = New Size(136, 22)
        lblAutor.TabIndex = 1
        lblAutor.Text = "Autor del Libro"
        ' 
        ' txtTitulo
        ' 
        txtTitulo.Location = New Point(352, 134)
        txtTitulo.Name = "txtTitulo"
        txtTitulo.Size = New Size(192, 23)
        txtTitulo.TabIndex = 2
        ' 
        ' txtAutor
        ' 
        txtAutor.Location = New Point(352, 176)
        txtAutor.Name = "txtAutor"
        txtAutor.Size = New Size(192, 23)
        txtAutor.TabIndex = 3
        ' 
        ' btnPrestar
        ' 
        btnPrestar.ForeColor = Color.Purple
        btnPrestar.Location = New Point(415, 215)
        btnPrestar.Name = "btnPrestar"
        btnPrestar.Size = New Size(75, 23)
        btnPrestar.TabIndex = 4
        btnPrestar.Text = "Prestar"
        btnPrestar.UseVisualStyleBackColor = True
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(352, 254)
        txtResultado.Name = "txtResultado"
        txtResultado.Size = New Size(192, 23)
        txtResultado.TabIndex = 6
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.OldLace
        Label1.Font = New Font("Times New Roman", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(162, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(494, 72)
        Label1.TabIndex = 7
        Label1.Text = "Biblioteca Velaris"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._011ebc07eb551c1271e958002ded42fa
        PictureBox1.Location = New Point(568, 174)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(211, 209)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' FormPrestar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(txtResultado)
        Controls.Add(btnPrestar)
        Controls.Add(txtAutor)
        Controls.Add(txtTitulo)
        Controls.Add(lblAutor)
        Controls.Add(lblTitulo)
        Name = "FormPrestar"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents btnPrestar As Button
    Friend WithEvents txtResultado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnPrestar = New Button()
        btnDevolver = New Button()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPrestar
        ' 
        btnPrestar.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrestar.ForeColor = Color.Purple
        btnPrestar.Location = New Point(236, 212)
        btnPrestar.Name = "btnPrestar"
        btnPrestar.Size = New Size(145, 41)
        btnPrestar.TabIndex = 0
        btnPrestar.Text = "Prestar"
        btnPrestar.UseVisualStyleBackColor = True
        ' 
        ' btnDevolver
        ' 
        btnDevolver.Font = New Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDevolver.ForeColor = Color.Purple
        btnDevolver.Location = New Point(419, 212)
        btnDevolver.Name = "btnDevolver"
        btnDevolver.Size = New Size(145, 41)
        btnDevolver.TabIndex = 1
        btnDevolver.Text = "Devolver"
        btnDevolver.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.OldLace
        Label1.Font = New Font("Times New Roman", 48F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Purple
        Label1.Location = New Point(159, 75)
        Label1.Name = "Label1"
        Label1.Size = New Size(494, 72)
        Label1.TabIndex = 2
        Label1.Text = "Biblioteca Velaris"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._011ebc07eb551c1271e958002ded42fa
        PictureBox1.Location = New Point(19, 150)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(211, 209)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.OldLace
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(570, 200)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(174, 159)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.OldLace
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(btnDevolver)
        Controls.Add(btnPrestar)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnPrestar As Button
    Friend WithEvents btnDevolver As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class

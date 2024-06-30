<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Updater
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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnVerificar = New System.Windows.Forms.Button()
        Me.cbDiretorio = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ckbTodos = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstArquivos = New System.Windows.Forms.ListView()
        Me.Nome_Arquivo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.data = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.caminho = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ProgressBar1)
        Me.GroupBox1.Controls.Add(Me.btnVerificar)
        Me.GroupBox1.Controls.Add(Me.cbDiretorio)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(721, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Escolha Driver:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(270, 36)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(430, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'btnVerificar
        '
        Me.btnVerificar.Location = New System.Drawing.Point(199, 33)
        Me.btnVerificar.Name = "btnVerificar"
        Me.btnVerificar.Size = New System.Drawing.Size(53, 27)
        Me.btnVerificar.TabIndex = 1
        Me.btnVerificar.Text = "Verificar"
        Me.btnVerificar.UseVisualStyleBackColor = True
        '
        'cbDiretorio
        '
        Me.cbDiretorio.FormattingEnabled = True
        Me.cbDiretorio.Items.AddRange(New Object() {"C:/", "D:/", "E:/"})
        Me.cbDiretorio.Location = New System.Drawing.Point(21, 37)
        Me.cbDiretorio.Name = "cbDiretorio"
        Me.cbDiretorio.Size = New System.Drawing.Size(161, 21)
        Me.cbDiretorio.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ProgressBar2)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 548)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(721, 72)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(306, 31)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(310, 22)
        Me.ProgressBar2.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Location = New System.Drawing.Point(167, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 28)
        Me.Label8.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(13, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 28)
        Me.Label9.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(164, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Arquivos Desatualizados"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(639, 25)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 34)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Atualizar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Arquivos Encontrados"
        '
        'ckbTodos
        '
        Me.ckbTodos.AutoSize = True
        Me.ckbTodos.Location = New System.Drawing.Point(22, 15)
        Me.ckbTodos.Name = "ckbTodos"
        Me.ckbTodos.Size = New System.Drawing.Size(109, 17)
        Me.ckbTodos.TabIndex = 4
        Me.ckbTodos.Text = "Selecionar Todos"
        Me.ckbTodos.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(212, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 12)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Label11"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(232, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Não Atualizar"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Red
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(373, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(11, 12)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Label5"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Green
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(567, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(11, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(393, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Arquivos Para Atualizar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(587, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Arquivos Atualizados"
        '
        'lstArquivos
        '
        Me.lstArquivos.CheckBoxes = True
        Me.lstArquivos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Nome_Arquivo, Me.data, Me.caminho})
        Me.lstArquivos.HideSelection = False
        Me.lstArquivos.Location = New System.Drawing.Point(12, 114)
        Me.lstArquivos.Name = "lstArquivos"
        Me.lstArquivos.Size = New System.Drawing.Size(721, 382)
        Me.lstArquivos.TabIndex = 3
        Me.lstArquivos.UseCompatibleStateImageBehavior = False
        Me.lstArquivos.View = System.Windows.Forms.View.Details
        '
        'Nome_Arquivo
        '
        Me.Nome_Arquivo.Text = "Nomes do Arquivo"
        Me.Nome_Arquivo.Width = 150
        '
        'data
        '
        Me.data.Text = "Última Atualização"
        Me.data.Width = 150
        '
        'caminho
        '
        Me.caminho.Text = "Caminho"
        Me.caminho.Width = 380
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.ckbTodos)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 502)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(721, 40)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'Updater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 632)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.lstArquivos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Updater"
        Me.Text = "Updater"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnVerificar As System.Windows.Forms.Button
    Friend WithEvents cbDiretorio As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lstArquivos As System.Windows.Forms.ListView
    Friend WithEvents Nome_Arquivo As System.Windows.Forms.ColumnHeader
    Friend WithEvents data As System.Windows.Forms.ColumnHeader
    Friend WithEvents caminho As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ckbTodos As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox

End Class

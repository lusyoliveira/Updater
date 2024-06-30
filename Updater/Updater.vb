Imports System.IO.File
Imports System.IO.Directory
Imports System.IO

Public Class Updater
    Dim x, y As Integer

    Private Sub ckbTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckbTodos.CheckedChanged
        For x = 0 To lstArquivos.Items.Count - 1
            lstArquivos.Items(x).Checked = ckbTodos.Checked
        Next
    End Sub

    Private Sub Updater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub btnVerificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerificar.Click
        Dim nomearq As String
        Dim x As Integer

        If cbDiretorio.Text <> "" Then

            Me.lstArquivos.Items.Clear()
            For Each nomearq In Directory.GetFiles(cbDiretorio.Text)
                'Me.lstArquivos.Items.Add(New String(nomearq))
                'Me.lstArquivos.Items.Add(New String("" & File.GetLastWriteTime(cbDiretorio.Text)))
                lstArquivos.Items.Add(New String(nomearq))
                lstArquivos.Items(x).SubItems.Add(New String("" & File.GetLastWriteTime(cbDiretorio.Text)))
                lstArquivos.Items(x).SubItems.Add(New String(nomearq))

                If x Mod 2 = 0 Then
                    lstArquivos.Items(x).ForeColor = Color.Red
                    lstArquivos.Items(x).BackColor = Color.LightGray
                Else
                    lstArquivos.Items(x).ForeColor = Color.Black
                    lstArquivos.Items(x).BackColor = Color.White
                End If
                x += 1
            Next
        Else
            MsgBox("Informe o Diretorio")
        End If

    End Sub
End Class

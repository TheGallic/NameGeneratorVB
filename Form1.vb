Imports System.IO

Public Class Form1
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim myFile As String
        Dim finalList = New Dictionary(Of String, String)
        Dim thisline As String
        If (lbxChooseSex.SelectedItem = "Fille") Then
            myFile = My.Resources.Fille
        Else
            myFile = My.Resources.Garcon
        End If


        Dim monStringReader As New StringReader(myFile)
        'On lit le fichier texte selectionné
        While monStringReader.Peek <> -1
            thisline = monStringReader.ReadLine()
            Dim myarray() = thisline.Split(";")

            If (tbxFirstLetter.Text = "") Then
                If (nudNameSize.Value = 8) Then
                    If (myarray(0).Length >= 8) Then
                        finalList.Add(myarray(0), myarray(1))
                    End If
                Else
                    If (nudNameSize.Value = myarray(0).Length) Then
                        finalList.Add(myarray(0), myarray(1))
                    End If
                End If
            Else
                If (nudNameSize.Value = 8) Then
                    If (myarray(0).Length >= 8 And tbxFirstLetter.Text = myarray(0).Chars(0)) Then
                        finalList.Add(myarray(0), myarray(1))
                    End If
                Else
                    If (nudNameSize.Value = myarray(0).Length And tbxFirstLetter.Text = myarray(0).Chars(0)) Then
                        finalList.Add(myarray(0), myarray(1))
                    End If
                End If
            End If

        End While

        If (finalList.Count <= 0) Then
            lblResult.Text = "Aucun résultat!! Refaite une recherche."
        Else
            lblResult.Text = finalList.Count & " résultats trouvés."
            'On genere un nombre aléatoire qui correspondra au numéro de la ligne à lire
            Dim myNumber As Integer = 0
            Dim random As Random = New Random()
            myNumber = random.Next(0, finalList.Count)

            If (rbtRandom.Checked = True) Then
                tbxName.Text = finalList.ElementAt(myNumber).Key.ToString()
                tbxUse.Text = "A été utilisé " & finalList.ElementAt(myNumber).Value.ToString() & " fois depuis 2006"
            ElseIf (rbtMin.Checked = True) Then
                Dim maxvalue As Integer = 10000

                For index = 0 To finalList.Count - 1
                    If (finalList.ElementAt(index).Value < maxvalue) Then
                        tbxName.Text = finalList.ElementAt(index).Key.ToString()
                        tbxUse.Text = "A été utilisé " & finalList.ElementAt(index).Value.ToString() & " fois depuis 2006"
                        maxvalue = finalList.ElementAt(index).Value
                    End If
                    index += 1
                Next

            ElseIf (rbtMax.Checked = True) Then
                Dim maxvalue As Integer = 0

                For index = 0 To finalList.Count - 1
                    If (finalList.ElementAt(index).Value > maxvalue) Then
                        tbxName.Text = finalList.ElementAt(index).Key.ToString()
                        tbxUse.Text = "A été utilisé " & finalList.ElementAt(index).Value.ToString() & " fois depuis 2006"
                        maxvalue = finalList.ElementAt(index).Value
                    End If
                    index += 1
                Next
            End If

        End If
    End Sub
End Class

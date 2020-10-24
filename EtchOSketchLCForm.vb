Public Class EtchOSketchLCForm
    Dim drawPen As New System.Drawing.Pen(Color.Black, 1)
    Dim erasePen As New System.Drawing.Pen(Color.FromName("Control"), 10)
    Dim g As System.Drawing.Graphics
    Sub Draw(x As Integer, y As Integer)
        g = DrawBox.CreateGraphics()
        g.DrawLine(drawPen, x, y, x - 1, y - 1)
    End Sub
    Sub Eraser(x As Integer, y As Integer)
        g = DrawBox.CreateGraphics()
        g.DrawLine(erasePen, x, y, x - 1, y - 1)
    End Sub
    Sub PictureBox1_MouseHoldMove(sender As Object, e As MouseEventArgs) Handles DrawBox.MouseDown, DrawBox.MouseMove
        If e.Button.ToString = "Left" Then
            Draw(e.X, e.Y)
        ElseIf e.Button.ToString = "Right" Then
            Eraser(e.X, e.Y)
        ElseIf e.Button.ToString = "Middle" Then
            ColorChooser()
        End If
    End Sub
    Sub ColorChooser()
        ColorChoose.ShowDialog()
        drawPen.Color = ColorChoose.Color
    End Sub
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click
        ColorChooser()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorChooser()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DrawBox.Image = Nothing
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        drawPen.Width = 1
    End Sub
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        drawPen.Width = 2
    End Sub
    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        drawPen.Width = 3
    End Sub
    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        drawPen.Width = 4
    End Sub
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        drawPen.Width = 5
    End Sub
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        erasePen.Width = 5
    End Sub

    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        erasePen.Width = 10
    End Sub

    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        erasePen.Width = 20
    End Sub

    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        erasePen.Width = 30
    End Sub

    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        erasePen.Width = 40
    End Sub

    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        erasePen.Width = 50
    End Sub

    Private Sub DrawWaveformsButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsButton.Click
        Dim x As Double
        Dim y As Double
        Dim graphPen As New Pen(Color.Black, 3)
        Dim g As Graphics

        g = DrawBox.CreateGraphics
        'Sine
        For r As Double = 0 To 450
            y = Math.Sin(r / 280 * 2 * Math.PI) * 100 + 100
            x = r

            g.DrawLine(graphPen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))

        Next

        'Cosine
        For r As Double = 0 To 450
            y = Math.Cos(r / 280 * 2 * Math.PI) * 100 + 100
            x = r

            g.DrawLine(graphPen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))

        Next

        'Tangent
        For r As Double = 0 To 450
            y = Math.Tan(r / 99 * 2 * Math.PI) * 20 + 20
            x = r

            g.DrawLine(graphPen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))

        Next

    End Sub
End Class

Option Strict On
Option Explicit On
'Lane Coleman
'RCET 0265
'Fall 2020
'Etch-O-Sketch Form
'https://github.com/colelane/EtchOSketchLCForm.git
Public Class EtchOSketchLCForm
    Dim drawPen As New System.Drawing.Pen(Color.Black, 1)
    Dim erasePen As New System.Drawing.Pen(Color.FromName("Control"), 10)
    Dim g As System.Drawing.Graphics
    Dim lastX, lasty As Integer
    Sub Draw(x As Integer, y As Integer)
        g = DrawBox.CreateGraphics ' DrawPictureBox - TJR
        If lastX = Nothing Then
            g.DrawLine(drawPen, x, y, x, y)

        Else
            g.DrawLine(drawPen, x, y, lastX, lasty)

        End If
        lastX = x
        lasty = y
    End Sub
    Sub Eraser(x As Integer, y As Integer)
        g = DrawBox.CreateGraphics
        If lastX = Nothing Then
            g.DrawLine(erasePen, x, y, x, y)

        Else
            g.DrawLine(erasePen, x, y, lastX, lasty)

        End If
        lastX = x
        lasty = y
    End Sub
    Sub PictureBox1_MouseHoldMove(sender As Object, e As MouseEventArgs) Handles DrawBox.MouseDown, DrawBox.MouseMove
        ActiveControl = DrawBox
        If e.Button.ToString = "Left" Then
            Draw(e.X, e.Y)
        ElseIf e.Button.ToString = "Right" Then
            Eraser(e.X, e.Y)
        ElseIf e.Button.ToString = "Middle" Then
            ColorChooser()
        End If
    End Sub
    Private Sub DrawBox_Mouseup(sender As Object, e As MouseEventArgs) Handles DrawBox.MouseUp
        'Removes Reference point to draw if mouse is unclicked
        lastX = 0
        lasty = 0
    End Sub
    Sub ColorChooser()
        ColorChoose.ShowDialog()
        drawPen.Color = ColorChoose.Color
    End Sub
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click
        ColorChooser()
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) 'No event ?? - TJR
        ColorChooser()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Public Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Clear()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) 'No event ?? - TJR
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
        erasePen.Width = 20
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
        'Clears Graphics.
        If g IsNot Nothing Then
            g.Clear(Color.FromName("Control"))
        End If
        DrawWaveforms()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim result As MsgBoxResult
        result = MsgBox("Esc for Clear" & vbNewLine & "Enter for Draw Waveforms" & vbNewLine &
                        "If hotkeys are broken, click in the drawbox" & vbNewLine &
                        "Push the buttons to do the things. Got it?", MsgBoxStyle.YesNo)
        If result = vbNo Then
            Dim bruhForm As New Form
            bruhForm.BackgroundImage = My.Resources.facepalm
            bruhForm.Show()
        End If
    End Sub
    'remove commented code - TJR
    Private Sub EtchOSketchLCForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveControl = DrawBox
    End Sub

    Sub DrawWaveforms()
        Dim SinPen As New System.Drawing.Pen(Color.Black, 3)
        Dim CoSinPen As New System.Drawing.Pen(Color.Red, 3)
        Dim TangentPen As New System.Drawing.Pen(Color.Blue, 3)
        Dim LinePen As New System.Drawing.Pen(Color.Black, 1)
        Dim x As Double
        Dim y As Double
        Dim LastX As Integer
        Dim LastY As Integer
        g = DrawBox.CreateGraphics

        'Draws Graph Lines
        For i = 1 To 10
            g.DrawLine(LinePen, 62 * i, 500, 62 * i, -500)
            g.DrawLine(LinePen, 1000, 34 * i, -1000, 34 * i)

        Next

        'Draw SinWave
        For Cycles As Double = 0 To 1000
            y = Math.Sin(Cycles / 400 * 2 * Math.PI) * 100 + 150
            x = Cycles
            g.DrawLine(SinPen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
        Next

        'Draw CoSinWave
        For Cycles As Double = 0 To 1000
            y = Math.Cos(Cycles / 400 * 2 * Math.PI) * 100 + 150
            x = Cycles
            g.DrawLine(CoSinPen, CType(x, Single), CType(y, Single), CType(x, Single) + 1, CType(y, Single))
        Next

        'Draw Tangent Wave
        For Cycles As Double = 0 To 1000
            y = Math.Tan(Cycles / 550 * 2 * Math.PI) * 20 + 150
            x = Cycles

            If LastX = Nothing Then
                LastX = CInt(x)
                LastY = CInt(y)
            ElseIf y - LastY < -50 Then
                LastX = CInt(x)
                LastY = CInt(y)
            End If
            g.DrawLine(TangentPen, CType(x, Single), CType(y, Single), LastX, LastY)

            LastY = CInt(y)
            LastX = CInt(x)

        Next

    End Sub
    Sub Clear()
        'This For loop 'shakes' the drawing picturebox.

        For i = 1 To 100
            DrawBox.Left = DrawBox.Left + 5
            DrawBox.Top = DrawBox.Top + 5
            DrawBox.Left = DrawBox.Left - 10
            DrawBox.Top = DrawBox.Top - 10
            DrawBox.Left = DrawBox.Left + 10
            DrawBox.Top = DrawBox.Top + 10
            DrawBox.Left = DrawBox.Left - 5
            DrawBox.Top = DrawBox.Top - 5
        Next
        'Clears the graphics.
        If g IsNot Nothing Then
            g.Clear(Color.FromName("Control"))
        End If
    End Sub
End Class

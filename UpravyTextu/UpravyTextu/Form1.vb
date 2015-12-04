Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Update() Handles TextBox1.TextChanged
        ToolStripStatusLabelCarky.Text = "Pocet carek: " & TextBox1.Text.Where(Function(c As Char) c.Equals(","c)).LongCount()
        ToolStripStatusLabelSlova.Text = "Pocet slov: " & TextBox1.Text.Where(Function(c As Char) Not (c.Equals(" "c))).LongCount()
        Dim reg As New Regex("[\w ]+")
        ToolStripStatusNejdelsi.Text = "Nejdelsi slovo: " & TextBox1.Text.Split(" ").Max(Function(s As String) s.Length) '.OrderByDescending(Function(s As String) s.Length).First.Length

    End Sub

End Class
Public Class Form1
    Dim cantidadDias(26) As Integer
    Dim rangoA(26) As Integer
    Dim rangoB(26) As Integer
    Dim diaAño As Integer
    Dim mes As Integer
    Dim grupo As Integer
    Dim cantidadMiembros As Integer
    Dim diaMes As Integer

    Sub Inicializar()
        rangoA(1) = 1
        rangoB(1) = 2
        cantidadDias(26) = 13
        rangoA(26) = 351
        rangoB(26) = 360
        diaMes = ComboBox2.SelectedIndex + 1
        For i = 1 To 25
            cantidadDias(i) = i + 1
            'Console.WriteLine(cantidadDias(i))
        Next
        For i = 2 To 25
            rangoA(i) = rangoB(i - 1) + 1
            rangoB(i) = rangoA(i) + (cantidadDias(i) - 1)
            'Console.WriteLine("({0}, {1})", rangoA(i), rangoB(i))
        Next
        Console.WriteLine()
        If ComboBox1.SelectedIndex >= 0 And ComboBox1.SelectedIndex < 12 Then
            mes = CInt(ComboBox1.SelectedItem.ToString)
            If mes = 1 Then
                'Console.WriteLine(ComboBox1.SelectedItem.ToString)
                diaAño = CInt(ComboBox2.SelectedItem.ToString)
            Else
                diaAño = ((mes - 1) * 30) + CInt(ComboBox2.SelectedItem.ToString)
            End If
        Else : MsgBox("Por favor selecciona un mes y una fecha")
        End If
        'Console.WriteLine(dia)
    End Sub

    Public Sub Evaluar()
        For i = 1 To 26
            If diaAño >= rangoA(i) And diaAño < rangoB(i) Then
                grupo = i
                cantidadMiembros = i + 1
                Exit For
            End If
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Inicializar()
        Evaluar()
        MsgBox("Fecha: " & diaMes & "/" & mes & vbNewLine & "Grupo: " & grupo & vbNewLine & "Numero de integrantes: " & cantidadMiembros)
    End Sub
End Class


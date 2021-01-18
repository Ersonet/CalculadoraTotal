Public Class FrmCalcu
    Private Sub BtnCal_Click(sender As Object, e As EventArgs) Handles BtnCal.Click
        Dim operacion, a, b, c, d As Double

        If RbSum.Checked = True Then
            operacion = Val(TxtNum1.Text) + Val(TxtNum2.Text) + Val(TxtNum3.Text)
            LblResutado.Text = operacion
        ElseIf RbRest.Checked = True Then
            operacion = Val(TxtNum1.Text) - Val(TxtNum2.Text) - Val(TxtNum3.Text)
            LblResutado.Text = operacion
        ElseIf RbMulti.Checked = True Then
            operacion = Val(TxtNum1.Text) * Val(TxtNum2.Text) * Val(TxtNum3.Text)
            LblResutado.Text = operacion
        ElseIf RbDiv.Checked = True Then
            operacion = (Val(TxtNum1.Text) / Val(TxtNum2.Text)) / Val(TxtNum3.Text)
            LblResutado.Text = operacion
        ElseIf RbAll.Checked = True Then
            a = Val(TxtNum1.Text) + Val(TxtNum2.Text) + Val(TxtNum3.Text)
            b = Val(TxtNum1.Text) - Val(TxtNum2.Text) - Val(TxtNum3.Text)
            c = Val(TxtNum1.Text) * Val(TxtNum2.Text) * Val(TxtNum3.Text)
            d = (Val(TxtNum1.Text) / Val(TxtNum2.Text)) / Val(TxtNum3.Text)
            LblResultado2.Text = "la suma es: " & a & vbCrLf & "la resta es: " & b & vbCrLf & "la multiplicaciòn es: " & c & vbCrLf & "la division es: " & d
        End If
    End Sub

    Private Sub BtnClean_Click(sender As Object, e As EventArgs) Handles BtnClean.Click
        TxtNum1.Text = ""
        TxtNum2.Text = ""
        TxtNum3.Text = ""
        LblResutado.Text = ""
        LblResultado2.Text = ""
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        If MsgBox(" ¿Desea salir de la zona de operaciòn? ", vbQuestion + vbYesNo) = vbYes Then
            End
        End If
    End Sub

    Private Sub FrmCalcu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

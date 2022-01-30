Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles button_aceptar.Click
        Dim arroz_texto As String = arroz_cantidad.Text
        Dim azucar_texto As String = azucar_cantidad.Text
        Dim frijol_texto As String = frijol_cantidad.Text

        'aqui convierto el texto en numero decimal
        Dim arroz_cant As Double = Convert.ToDouble(arroz_texto)
        Dim azucar_cant As Double = Convert.ToDouble(azucar_texto)
        Dim frijol_cant As Double = Convert.ToDouble(frijol_texto)

        'aqui encuentro el valor correspondiente por cada producto
        Dim arroz_total As Double = 2 * arroz_cant
        Dim azucar_total As Double = 2.5 * azucar_cant
        Dim frijol_total As Double = 1.75 * frijol_cant

        'valor total sin iva
        Dim total_sin_iva = arroz_total + azucar_total + frijol_total

        'valor iva
        Dim valor_iva As Double = total_sin_iva * 0.12

        'valor total con iva
        Dim total_con_iva As Double = total_sin_iva + valor_iva

        'descuento de aniversario
        Dim descuento_aniversario As Double = (0.025 * total_con_iva)

        'monto total
        Dim monto_total As Double = total_con_iva - descuento_aniversario

        label_iva.Text = "VALOR IVA: " + valor_iva.ToString()
        label_pago_con_iva.Text = "PAGO CON IVA: " + total_con_iva.ToString()
        label_pago_sin_iva.Text = "PAGO SIN IVA: " + total_sin_iva.ToString()
        label_descuento.Text = "DESCUENTO: " + descuento_aniversario.ToString()
        label_monto_total.Text = "MONTO TOTAL: " + monto_total.ToString()

    End Sub

    Private Sub button_limpiar_Click(sender As Object, e As EventArgs) Handles button_limpiar.Click
        arroz_cantidad.Text = ""
        azucar_cantidad.Text = ""
        frijol_cantidad.Text = ""
        label_iva.Text = "VALOR IVA: "
        label_pago_con_iva.Text = "PAGO CON IVA: "
        label_pago_sin_iva.Text = "PAGO SIN IVA: "
        label_descuento.Text = "DESCUENTO: "
        label_monto_total.Text = "MONTO TOTAL: "
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class

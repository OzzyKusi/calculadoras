Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Sumar los numeros utilizando el servicio web'
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Dim Suma As Double = servicio.Suma(Nro1, Nro2)
        txtResultado.Text = Suma
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnRestar.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Restar los numeros utilizando el servicio web'
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Dim Resta As Double = servicio.Resta(Nro1, Nro2)
        txtResultado.Text = Resta
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnMultiplicar.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Multiplicar los numeros utilizando el servicio web'
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Dim Multiplicar As Double = servicio.Multipllicar(Nro1, Nro2)
        txtResultado.Text = Multiplicar
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDividir.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Dividir los numeros utilizando el servicio web'
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Dim Division As Double = servicio.Division(Nro1, Nro2)
        txtResultado.Text = Division
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnFactorial.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Factorial de un numero utilizando el servicio web'
        Dim Nro1 As Double
        Nro1 = txtNro1.Text
        Dim Factorial As Double = servicio.Fact(Nro1)
        txtResultado.Text = Factorial
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Potencia los numeros utilizando el servicio web'
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Dim Potencia As Double = servicio.Potencia(Nro1, Nro2)
        txtResultado.Text = Potencia
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnRaiz.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Raiz de un numero utilizando el servicio web'
        Dim Nro1 As Double
        Nro1 = txtNro1.Text
        Dim Raiz As Double = servicio.Raiz(Nro1)
        txtResultado.Text = Raiz
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnMax.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Potencia los numeros utilizando el servicio web'
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)
        Dim Maximo As Double = servicio.Minimo(Nro1, Nro2)
        txtResultado.Text = Maximo
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Potencia los numeros utilizando el servicio web'
        Dim Nro1 As Double
        Nro1 = txtNro1.Text
        Dim Seno As Double = servicio.Seno(Nro1)
        txtResultado.Text = Seno
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        'LLamar a servicio web'
        Dim servicio As New ServiceReference1.WebService1SoapClient
        'Potencia los numeros utilizando el servicio web'
        Dim Nro1 As Double
        Nro1 = txtNro1.Text
        Dim Coseno As Double = servicio.Coseno(Nro1)
        txtResultado.Text = Coseno
    End Sub

End Class

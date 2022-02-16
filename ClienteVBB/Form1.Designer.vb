<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNro1 = New System.Windows.Forms.TextBox()
        Me.txtNro2 = New System.Windows.Forms.TextBox()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btnRestar = New System.Windows.Forms.Button()
        Me.btnMultiplicar = New System.Windows.Forms.Button()
        Me.btnDividir = New System.Windows.Forms.Button()
        Me.btnFactorial = New System.Windows.Forms.Button()
        Me.btnPotencia = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.btnMax = New System.Windows.Forms.Button()
        Me.btnSin = New System.Windows.Forms.Button()
        Me.btnCos = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtNro1
        '
        Me.txtNro1.Location = New System.Drawing.Point(211, 56)
        Me.txtNro1.Name = "txtNro1"
        Me.txtNro1.Size = New System.Drawing.Size(212, 20)
        Me.txtNro1.TabIndex = 0
        '
        'txtNro2
        '
        Me.txtNro2.Location = New System.Drawing.Point(211, 101)
        Me.txtNro2.Name = "txtNro2"
        Me.txtNro2.Size = New System.Drawing.Size(212, 20)
        Me.txtNro2.TabIndex = 1
        '
        'btnSuma
        '
        Me.btnSuma.Location = New System.Drawing.Point(130, 166)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(75, 23)
        Me.btnSuma.TabIndex = 2
        Me.btnSuma.Text = "Sumar"
        Me.btnSuma.UseVisualStyleBackColor = True
        '
        'btnRestar
        '
        Me.btnRestar.Location = New System.Drawing.Point(226, 166)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(75, 23)
        Me.btnRestar.TabIndex = 3
        Me.btnRestar.Text = "Restar"
        Me.btnRestar.UseVisualStyleBackColor = True
        '
        'btnMultiplicar
        '
        Me.btnMultiplicar.Location = New System.Drawing.Point(327, 166)
        Me.btnMultiplicar.Name = "btnMultiplicar"
        Me.btnMultiplicar.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiplicar.TabIndex = 4
        Me.btnMultiplicar.Text = "Multiplicar"
        Me.btnMultiplicar.UseVisualStyleBackColor = True
        '
        'btnDividir
        '
        Me.btnDividir.Location = New System.Drawing.Point(429, 166)
        Me.btnDividir.Name = "btnDividir"
        Me.btnDividir.Size = New System.Drawing.Size(75, 23)
        Me.btnDividir.TabIndex = 5
        Me.btnDividir.Text = "Dividir"
        Me.btnDividir.UseVisualStyleBackColor = True
        '
        'btnFactorial
        '
        Me.btnFactorial.Location = New System.Drawing.Point(130, 227)
        Me.btnFactorial.Name = "btnFactorial"
        Me.btnFactorial.Size = New System.Drawing.Size(75, 23)
        Me.btnFactorial.TabIndex = 6
        Me.btnFactorial.Text = "Factorial"
        Me.btnFactorial.UseVisualStyleBackColor = True
        '
        'btnPotencia
        '
        Me.btnPotencia.Location = New System.Drawing.Point(226, 227)
        Me.btnPotencia.Name = "btnPotencia"
        Me.btnPotencia.Size = New System.Drawing.Size(75, 23)
        Me.btnPotencia.TabIndex = 7
        Me.btnPotencia.Text = "Potencia"
        Me.btnPotencia.UseVisualStyleBackColor = True
        '
        'btnRaiz
        '
        Me.btnRaiz.Location = New System.Drawing.Point(327, 227)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(75, 23)
        Me.btnRaiz.TabIndex = 8
        Me.btnRaiz.Text = "Raiz Cua"
        Me.btnRaiz.UseVisualStyleBackColor = True
        '
        'btnMax
        '
        Me.btnMax.Location = New System.Drawing.Point(429, 227)
        Me.btnMax.Name = "btnMax"
        Me.btnMax.Size = New System.Drawing.Size(75, 23)
        Me.btnMax.TabIndex = 9
        Me.btnMax.Text = "MAX"
        Me.btnMax.UseVisualStyleBackColor = True
        '
        'btnSin
        '
        Me.btnSin.Location = New System.Drawing.Point(226, 276)
        Me.btnSin.Name = "btnSin"
        Me.btnSin.Size = New System.Drawing.Size(75, 23)
        Me.btnSin.TabIndex = 10
        Me.btnSin.Text = "Seno"
        Me.btnSin.UseVisualStyleBackColor = True
        '
        'btnCos
        '
        Me.btnCos.Location = New System.Drawing.Point(327, 276)
        Me.btnCos.Name = "btnCos"
        Me.btnCos.Size = New System.Drawing.Size(75, 23)
        Me.btnCos.TabIndex = 11
        Me.btnCos.Text = "Coseno"
        Me.btnCos.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(211, 325)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(212, 20)
        Me.txtResultado.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 456)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.btnCos)
        Me.Controls.Add(Me.btnSin)
        Me.Controls.Add(Me.btnMax)
        Me.Controls.Add(Me.btnRaiz)
        Me.Controls.Add(Me.btnPotencia)
        Me.Controls.Add(Me.btnFactorial)
        Me.Controls.Add(Me.btnDividir)
        Me.Controls.Add(Me.btnMultiplicar)
        Me.Controls.Add(Me.btnRestar)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.txtNro2)
        Me.Controls.Add(Me.txtNro1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNro1 As TextBox
    Friend WithEvents txtNro2 As TextBox
    Friend WithEvents btnSuma As Button
    Friend WithEvents btnRestar As Button
    Friend WithEvents btnMultiplicar As Button
    Friend WithEvents btnDividir As Button
    Friend WithEvents btnFactorial As Button
    Friend WithEvents btnPotencia As Button
    Friend WithEvents btnRaiz As Button
    Friend WithEvents btnMax As Button
    Friend WithEvents btnSin As Button
    Friend WithEvents btnCos As Button
    Friend WithEvents txtResultado As TextBox
End Class

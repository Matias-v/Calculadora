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
        Me.lbl_primervalor = New System.Windows.Forms.Label()
        Me.txt_primervalor = New System.Windows.Forms.TextBox()
        Me.txt_segundovalor = New System.Windows.Forms.TextBox()
        Me.lbl_segundovalor = New System.Windows.Forms.Label()
        Me.cnb_operador = New System.Windows.Forms.ComboBox()
        Me.btn_calcular = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.lbl_resultado = New System.Windows.Forms.Label()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.lbl_operador = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_primervalor
        '
        Me.lbl_primervalor.AutoSize = True
        Me.lbl_primervalor.Location = New System.Drawing.Point(48, 23)
        Me.lbl_primervalor.Name = "lbl_primervalor"
        Me.lbl_primervalor.Size = New System.Drawing.Size(62, 13)
        Me.lbl_primervalor.TabIndex = 1
        Me.lbl_primervalor.Text = "Primer valor"
        '
        'txt_primervalor
        '
        Me.txt_primervalor.Location = New System.Drawing.Point(12, 39)
        Me.txt_primervalor.Name = "txt_primervalor"
        Me.txt_primervalor.Size = New System.Drawing.Size(146, 20)
        Me.txt_primervalor.TabIndex = 2
        '
        'txt_segundovalor
        '
        Me.txt_segundovalor.Location = New System.Drawing.Point(174, 39)
        Me.txt_segundovalor.Name = "txt_segundovalor"
        Me.txt_segundovalor.Size = New System.Drawing.Size(146, 20)
        Me.txt_segundovalor.TabIndex = 3
        '
        'lbl_segundovalor
        '
        Me.lbl_segundovalor.AutoSize = True
        Me.lbl_segundovalor.Location = New System.Drawing.Point(208, 23)
        Me.lbl_segundovalor.Name = "lbl_segundovalor"
        Me.lbl_segundovalor.Size = New System.Drawing.Size(76, 13)
        Me.lbl_segundovalor.TabIndex = 4
        Me.lbl_segundovalor.Text = "Segundo valor"
        '
        'cnb_operador
        '
        Me.cnb_operador.FormattingEnabled = True
        Me.cnb_operador.Items.AddRange(New Object() {"Suma", "Resta", "Division", "Multiplicacion"})
        Me.cnb_operador.Location = New System.Drawing.Point(88, 106)
        Me.cnb_operador.Name = "cnb_operador"
        Me.cnb_operador.Size = New System.Drawing.Size(232, 21)
        Me.cnb_operador.TabIndex = 5
        '
        'btn_calcular
        '
        Me.btn_calcular.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_calcular.Location = New System.Drawing.Point(19, 217)
        Me.btn_calcular.Name = "btn_calcular"
        Me.btn_calcular.Size = New System.Drawing.Size(90, 24)
        Me.btn_calcular.TabIndex = 6
        Me.btn_calcular.Text = "Calcular"
        Me.btn_calcular.UseVisualStyleBackColor = False
        '
        'btn_limpiar
        '
        Me.btn_limpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_limpiar.Location = New System.Drawing.Point(125, 217)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(90, 24)
        Me.btn_limpiar.TabIndex = 7
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = False
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_salir.Location = New System.Drawing.Point(230, 217)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(90, 24)
        Me.btn_salir.TabIndex = 8
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'lbl_resultado
        '
        Me.lbl_resultado.AutoSize = True
        Me.lbl_resultado.Location = New System.Drawing.Point(85, 164)
        Me.lbl_resultado.Name = "lbl_resultado"
        Me.lbl_resultado.Size = New System.Drawing.Size(55, 13)
        Me.lbl_resultado.TabIndex = 9
        Me.lbl_resultado.Text = "Resultado"
        '
        'txt_resultado
        '
        Me.txt_resultado.Enabled = False
        Me.txt_resultado.Location = New System.Drawing.Point(163, 164)
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(157, 20)
        Me.txt_resultado.TabIndex = 10
        '
        'lbl_operador
        '
        Me.lbl_operador.AutoSize = True
        Me.lbl_operador.Location = New System.Drawing.Point(14, 109)
        Me.lbl_operador.Name = "lbl_operador"
        Me.lbl_operador.Size = New System.Drawing.Size(51, 13)
        Me.lbl_operador.TabIndex = 11
        Me.lbl_operador.Text = "Operador"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 292)
        Me.Controls.Add(Me.lbl_operador)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.lbl_resultado)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_calcular)
        Me.Controls.Add(Me.cnb_operador)
        Me.Controls.Add(Me.lbl_segundovalor)
        Me.Controls.Add(Me.txt_segundovalor)
        Me.Controls.Add(Me.txt_primervalor)
        Me.Controls.Add(Me.lbl_primervalor)
        Me.Name = "Form1"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_primervalor As Label
    Friend WithEvents txt_primervalor As TextBox
    Friend WithEvents txt_segundovalor As TextBox
    Friend WithEvents lbl_segundovalor As Label
    Friend WithEvents cnb_operador As ComboBox
    Friend WithEvents btn_calcular As Button
    Friend WithEvents btn_limpiar As Button
    Friend WithEvents btn_salir As Button
    Friend WithEvents lbl_resultado As Label
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents lbl_operador As Label
End Class

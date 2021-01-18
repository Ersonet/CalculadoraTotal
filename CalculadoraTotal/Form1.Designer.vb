<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCalcu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCalcu))
        Me.GrBOper = New System.Windows.Forms.GroupBox()
        Me.RbAll = New System.Windows.Forms.RadioButton()
        Me.RbDiv = New System.Windows.Forms.RadioButton()
        Me.RbMulti = New System.Windows.Forms.RadioButton()
        Me.RbRest = New System.Windows.Forms.RadioButton()
        Me.RbSum = New System.Windows.Forms.RadioButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BtnCal = New System.Windows.Forms.Button()
        Me.LblRta = New System.Windows.Forms.Label()
        Me.BtnClean = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LblResutado = New System.Windows.Forms.Label()
        Me.TxtNum1 = New System.Windows.Forms.TextBox()
        Me.TxtNum2 = New System.Windows.Forms.TextBox()
        Me.TxtNum3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblResultado2 = New System.Windows.Forms.Label()
        Me.GrBOper.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrBOper
        '
        Me.GrBOper.Controls.Add(Me.RbAll)
        Me.GrBOper.Controls.Add(Me.RbDiv)
        Me.GrBOper.Controls.Add(Me.RbMulti)
        Me.GrBOper.Controls.Add(Me.RbRest)
        Me.GrBOper.Controls.Add(Me.RbSum)
        Me.GrBOper.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrBOper.Location = New System.Drawing.Point(11, 147)
        Me.GrBOper.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GrBOper.Name = "GrBOper"
        Me.GrBOper.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.GrBOper.Size = New System.Drawing.Size(128, 232)
        Me.GrBOper.TabIndex = 0
        Me.GrBOper.TabStop = False
        Me.GrBOper.Text = "Operaciones"
        '
        'RbAll
        '
        Me.RbAll.AutoSize = True
        Me.RbAll.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAll.Location = New System.Drawing.Point(5, 194)
        Me.RbAll.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RbAll.Name = "RbAll"
        Me.RbAll.Size = New System.Drawing.Size(59, 20)
        Me.RbAll.TabIndex = 5
        Me.RbAll.TabStop = True
        Me.RbAll.Text = "Todas"
        Me.RbAll.UseVisualStyleBackColor = True
        '
        'RbDiv
        '
        Me.RbDiv.AutoSize = True
        Me.RbDiv.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbDiv.Location = New System.Drawing.Point(5, 154)
        Me.RbDiv.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RbDiv.Name = "RbDiv"
        Me.RbDiv.Size = New System.Drawing.Size(62, 20)
        Me.RbDiv.TabIndex = 4
        Me.RbDiv.TabStop = True
        Me.RbDiv.Text = "Dividir"
        Me.RbDiv.UseVisualStyleBackColor = True
        '
        'RbMulti
        '
        Me.RbMulti.AutoSize = True
        Me.RbMulti.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbMulti.Location = New System.Drawing.Point(5, 109)
        Me.RbMulti.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RbMulti.Name = "RbMulti"
        Me.RbMulti.Size = New System.Drawing.Size(84, 20)
        Me.RbMulti.TabIndex = 3
        Me.RbMulti.TabStop = True
        Me.RbMulti.Text = "Multiplicar"
        Me.RbMulti.UseVisualStyleBackColor = True
        '
        'RbRest
        '
        Me.RbRest.AutoSize = True
        Me.RbRest.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbRest.Location = New System.Drawing.Point(5, 69)
        Me.RbRest.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RbRest.Name = "RbRest"
        Me.RbRest.Size = New System.Drawing.Size(60, 20)
        Me.RbRest.TabIndex = 2
        Me.RbRest.TabStop = True
        Me.RbRest.Text = "Restar"
        Me.RbRest.UseVisualStyleBackColor = True
        '
        'RbSum
        '
        Me.RbSum.AutoSize = True
        Me.RbSum.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSum.Location = New System.Drawing.Point(5, 25)
        Me.RbSum.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RbSum.Name = "RbSum"
        Me.RbSum.Size = New System.Drawing.Size(63, 20)
        Me.RbSum.TabIndex = 1
        Me.RbSum.TabStop = True
        Me.RbSum.Text = "Sumar"
        Me.RbSum.UseVisualStyleBackColor = True
        '
        'BtnCal
        '
        Me.BtnCal.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCal.Location = New System.Drawing.Point(166, 266)
        Me.BtnCal.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnCal.Name = "BtnCal"
        Me.BtnCal.Size = New System.Drawing.Size(118, 35)
        Me.BtnCal.TabIndex = 9
        Me.BtnCal.Text = "Calcular"
        Me.BtnCal.UseVisualStyleBackColor = True
        '
        'LblRta
        '
        Me.LblRta.AutoSize = True
        Me.LblRta.Font = New System.Drawing.Font("Futura Bk BT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRta.Location = New System.Drawing.Point(77, 9)
        Me.LblRta.Name = "LblRta"
        Me.LblRta.Size = New System.Drawing.Size(143, 19)
        Me.LblRta.TabIndex = 2
        Me.LblRta.Text = "EL RESULTADO ES:"
        Me.LblRta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnClean
        '
        Me.BtnClean.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClean.Location = New System.Drawing.Point(166, 307)
        Me.BtnClean.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnClean.Name = "BtnClean"
        Me.BtnClean.Size = New System.Drawing.Size(118, 35)
        Me.BtnClean.TabIndex = 10
        Me.BtnClean.Text = "Limpiar"
        Me.BtnClean.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Location = New System.Drawing.Point(166, 348)
        Me.BtnSalir.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(118, 31)
        Me.BtnSalir.TabIndex = 11
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'LblResutado
        '
        Me.LblResutado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblResutado.AutoSize = True
        Me.LblResutado.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResutado.Location = New System.Drawing.Point(129, 59)
        Me.LblResutado.Name = "LblResutado"
        Me.LblResutado.Size = New System.Drawing.Size(0, 16)
        Me.LblResutado.TabIndex = 5
        Me.LblResutado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNum1
        '
        Me.TxtNum1.Location = New System.Drawing.Point(166, 179)
        Me.TxtNum1.Name = "TxtNum1"
        Me.TxtNum1.Size = New System.Drawing.Size(118, 23)
        Me.TxtNum1.TabIndex = 6
        '
        'TxtNum2
        '
        Me.TxtNum2.Location = New System.Drawing.Point(166, 208)
        Me.TxtNum2.Name = "TxtNum2"
        Me.TxtNum2.Size = New System.Drawing.Size(118, 23)
        Me.TxtNum2.TabIndex = 7
        '
        'TxtNum3
        '
        Me.TxtNum3.Location = New System.Drawing.Point(166, 237)
        Me.TxtNum3.Name = "TxtNum3"
        Me.TxtNum3.Size = New System.Drawing.Size(118, 23)
        Me.TxtNum3.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ingrese los nùmeros"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblResultado2
        '
        Me.LblResultado2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblResultado2.AutoSize = True
        Me.LblResultado2.Font = New System.Drawing.Font("Futura Bk BT", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblResultado2.Location = New System.Drawing.Point(55, 59)
        Me.LblResultado2.Name = "LblResultado2"
        Me.LblResultado2.Size = New System.Drawing.Size(0, 16)
        Me.LblResultado2.TabIndex = 10
        Me.LblResultado2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmCalcu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(307, 391)
        Me.Controls.Add(Me.LblResultado2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNum3)
        Me.Controls.Add(Me.TxtNum2)
        Me.Controls.Add(Me.TxtNum1)
        Me.Controls.Add(Me.LblResutado)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnClean)
        Me.Controls.Add(Me.LblRta)
        Me.Controls.Add(Me.BtnCal)
        Me.Controls.Add(Me.GrBOper)
        Me.Font = New System.Drawing.Font("Keep Calm Med", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FrmCalcu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ÁREA DE OPERACIONES"
        Me.GrBOper.ResumeLayout(False)
        Me.GrBOper.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrBOper As GroupBox
    Friend WithEvents RbAll As RadioButton
    Friend WithEvents RbDiv As RadioButton
    Friend WithEvents RbMulti As RadioButton
    Friend WithEvents RbRest As RadioButton
    Friend WithEvents RbSum As RadioButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BtnCal As Button
    Friend WithEvents LblRta As Label
    Friend WithEvents BtnClean As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblResutado As Label
    Friend WithEvents TxtNum1 As TextBox
    Friend WithEvents TxtNum2 As TextBox
    Friend WithEvents TxtNum3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblResultado2 As Label
End Class

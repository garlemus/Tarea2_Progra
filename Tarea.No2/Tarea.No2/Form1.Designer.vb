<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.button_aceptar = New System.Windows.Forms.Button()
        Me.button_limpiar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.frijol_cantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.azucar_cantidad = New System.Windows.Forms.TextBox()
        Me.arroz_cantidad = New System.Windows.Forms.TextBox()
        Me.cantidades = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.R3Label6 = New System.Windows.Forms.TextBox()
        Me.R2Label5 = New System.Windows.Forms.TextBox()
        Me.R1Label4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TOTAL = New System.Windows.Forms.Label()
        Me.R4Label7 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.botones = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.resultados = New System.Windows.Forms.GroupBox()
        Me.label_monto_total = New System.Windows.Forms.Label()
        Me.label_descuento = New System.Windows.Forms.Label()
        Me.label_pago_sin_iva = New System.Windows.Forms.Label()
        Me.label_pago_con_iva = New System.Windows.Forms.Label()
        Me.label_iva = New System.Windows.Forms.Label()
        Me.cantidades.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.botones.SuspendLayout()
        Me.resultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_aceptar
        '
        Me.button_aceptar.BackColor = System.Drawing.Color.IndianRed
        Me.button_aceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_aceptar.Location = New System.Drawing.Point(44, 29)
        Me.button_aceptar.Name = "button_aceptar"
        Me.button_aceptar.Size = New System.Drawing.Size(75, 23)
        Me.button_aceptar.TabIndex = 0
        Me.button_aceptar.Text = "ACEPTAR"
        Me.button_aceptar.UseVisualStyleBackColor = False
        '
        'button_limpiar
        '
        Me.button_limpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.button_limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_limpiar.Location = New System.Drawing.Point(184, 29)
        Me.button_limpiar.Name = "button_limpiar"
        Me.button_limpiar.Size = New System.Drawing.Size(75, 23)
        Me.button_limpiar.TabIndex = 1
        Me.button_limpiar.Text = "LIMPIAR"
        Me.button_limpiar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ARROZ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "FRIJOL"
        '
        'frijol_cantidad
        '
        Me.frijol_cantidad.Location = New System.Drawing.Point(141, 148)
        Me.frijol_cantidad.Name = "frijol_cantidad"
        Me.frijol_cantidad.Size = New System.Drawing.Size(90, 20)
        Me.frijol_cantidad.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "AZUCAR"
        '
        'azucar_cantidad
        '
        Me.azucar_cantidad.Location = New System.Drawing.Point(141, 239)
        Me.azucar_cantidad.Name = "azucar_cantidad"
        Me.azucar_cantidad.Size = New System.Drawing.Size(90, 20)
        Me.azucar_cantidad.TabIndex = 7
        '
        'arroz_cantidad
        '
        Me.arroz_cantidad.Location = New System.Drawing.Point(141, 57)
        Me.arroz_cantidad.Name = "arroz_cantidad"
        Me.arroz_cantidad.Size = New System.Drawing.Size(90, 20)
        Me.arroz_cantidad.TabIndex = 2
        '
        'cantidades
        '
        Me.cantidades.Controls.Add(Me.Label1)
        Me.cantidades.Controls.Add(Me.azucar_cantidad)
        Me.cantidades.Controls.Add(Me.arroz_cantidad)
        Me.cantidades.Controls.Add(Me.Label3)
        Me.cantidades.Controls.Add(Me.Label2)
        Me.cantidades.Controls.Add(Me.frijol_cantidad)
        Me.cantidades.Location = New System.Drawing.Point(30, 29)
        Me.cantidades.Name = "cantidades"
        Me.cantidades.Size = New System.Drawing.Size(273, 305)
        Me.cantidades.TabIndex = 8
        Me.cantidades.TabStop = False
        Me.cantidades.Text = "CANTIDADES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "IVA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Pago sin IVA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.R3Label6)
        Me.GroupBox2.Controls.Add(Me.R2Label5)
        Me.GroupBox2.Controls.Add(Me.R1Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 212)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Valor Agregado"
        '
        'R3Label6
        '
        Me.R3Label6.Location = New System.Drawing.Point(118, 167)
        Me.R3Label6.Name = "R3Label6"
        Me.R3Label6.Size = New System.Drawing.Size(90, 20)
        Me.R3Label6.TabIndex = 12
        '
        'R2Label5
        '
        Me.R2Label5.Location = New System.Drawing.Point(118, 110)
        Me.R2Label5.Name = "R2Label5"
        Me.R2Label5.Size = New System.Drawing.Size(90, 20)
        Me.R2Label5.TabIndex = 11
        '
        'R1Label4
        '
        Me.R1Label4.Location = New System.Drawing.Point(118, 58)
        Me.R1Label4.Name = "R1Label4"
        Me.R1Label4.Size = New System.Drawing.Size(90, 20)
        Me.R1Label4.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Pago con IVA"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TOTAL)
        Me.GroupBox3.Controls.Add(Me.R4Label7)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(322, 35)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1, 1)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "RESULTADOS"
        '
        'TOTAL
        '
        Me.TOTAL.AutoSize = True
        Me.TOTAL.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.TOTAL.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TOTAL.Location = New System.Drawing.Point(317, 182)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.Size = New System.Drawing.Size(15, 13)
        Me.TOTAL.TabIndex = 14
        Me.TOTAL.Text = "Q"
        '
        'R4Label7
        '
        Me.R4Label7.Location = New System.Drawing.Point(320, 81)
        Me.R4Label7.Name = "R4Label7"
        Me.R4Label7.Size = New System.Drawing.Size(90, 20)
        Me.R4Label7.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(247, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Monto Total"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(247, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Descuento"
        '
        'botones
        '
        Me.botones.Controls.Add(Me.Button1)
        Me.botones.Controls.Add(Me.button_aceptar)
        Me.botones.Controls.Add(Me.button_limpiar)
        Me.botones.Location = New System.Drawing.Point(328, 307)
        Me.botones.Name = "botones"
        Me.botones.Size = New System.Drawing.Size(444, 69)
        Me.botones.TabIndex = 12
        Me.botones.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(323, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "SALIR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'resultados
        '
        Me.resultados.Controls.Add(Me.label_monto_total)
        Me.resultados.Controls.Add(Me.label_descuento)
        Me.resultados.Controls.Add(Me.label_pago_sin_iva)
        Me.resultados.Controls.Add(Me.label_pago_con_iva)
        Me.resultados.Controls.Add(Me.label_iva)
        Me.resultados.Location = New System.Drawing.Point(334, 35)
        Me.resultados.Name = "resultados"
        Me.resultados.Size = New System.Drawing.Size(438, 244)
        Me.resultados.TabIndex = 13
        Me.resultados.TabStop = False
        Me.resultados.Text = "RESULTADOS"
        '
        'label_monto_total
        '
        Me.label_monto_total.AutoSize = True
        Me.label_monto_total.Location = New System.Drawing.Point(228, 158)
        Me.label_monto_total.Name = "label_monto_total"
        Me.label_monto_total.Size = New System.Drawing.Size(88, 13)
        Me.label_monto_total.TabIndex = 12
        Me.label_monto_total.Text = "MONTO TOTAL:"
        '
        'label_descuento
        '
        Me.label_descuento.AutoSize = True
        Me.label_descuento.Location = New System.Drawing.Point(228, 99)
        Me.label_descuento.Name = "label_descuento"
        Me.label_descuento.Size = New System.Drawing.Size(77, 13)
        Me.label_descuento.TabIndex = 11
        Me.label_descuento.Text = "DESCUENTO:"
        '
        'label_pago_sin_iva
        '
        Me.label_pago_sin_iva.AutoSize = True
        Me.label_pago_sin_iva.Location = New System.Drawing.Point(34, 182)
        Me.label_pago_sin_iva.Name = "label_pago_sin_iva"
        Me.label_pago_sin_iva.Size = New System.Drawing.Size(81, 13)
        Me.label_pago_sin_iva.TabIndex = 10
        Me.label_pago_sin_iva.Text = "PAGO SIN IVA:"
        '
        'label_pago_con_iva
        '
        Me.label_pago_con_iva.AutoSize = True
        Me.label_pago_con_iva.Location = New System.Drawing.Point(30, 122)
        Me.label_pago_con_iva.Name = "label_pago_con_iva"
        Me.label_pago_con_iva.Size = New System.Drawing.Size(86, 13)
        Me.label_pago_con_iva.TabIndex = 9
        Me.label_pago_con_iva.Text = "PAGO CON IVA:"
        '
        'label_iva
        '
        Me.label_iva.AutoSize = True
        Me.label_iva.Location = New System.Drawing.Point(35, 58)
        Me.label_iva.Name = "label_iva"
        Me.label_iva.Size = New System.Drawing.Size(27, 13)
        Me.label_iva.TabIndex = 8
        Me.label_iva.Text = "IVA:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 386)
        Me.Controls.Add(Me.resultados)
        Me.Controls.Add(Me.botones)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cantidades)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.cantidades.ResumeLayout(False)
        Me.cantidades.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.botones.ResumeLayout(False)
        Me.resultados.ResumeLayout(False)
        Me.resultados.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents button_aceptar As Button
    Friend WithEvents button_limpiar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents frijol_cantidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents azucar_cantidad As TextBox
    Friend WithEvents arroz_cantidad As TextBox
    Friend WithEvents cantidades As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents R3Label6 As TextBox
    Friend WithEvents R2Label5 As TextBox
    Friend WithEvents R1Label4 As TextBox
    Friend WithEvents TOTAL As Label
    Friend WithEvents R4Label7 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents botones As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents resultados As GroupBox
    Friend WithEvents label_iva As Label
    Friend WithEvents label_monto_total As Label
    Friend WithEvents label_descuento As Label
    Friend WithEvents label_pago_sin_iva As Label
    Friend WithEvents label_pago_con_iva As Label
End Class

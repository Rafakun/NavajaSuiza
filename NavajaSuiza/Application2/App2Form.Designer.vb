﻿Namespace Application2
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Public Class App2Form
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(App2Form))
            Me.btnConvertir_Pesetas = New System.Windows.Forms.Button()
            Me.lblConvertido = New System.Windows.Forms.Label()
            Me.tbxDinero = New System.Windows.Forms.TextBox()
            Me.btnConvertir_Euros = New System.Windows.Forms.Button()
            Me.lblDinero = New System.Windows.Forms.Label()
            Me.ImagenCabecera = New System.Windows.Forms.PictureBox()
            Me.App2Titulo = New System.Windows.Forms.Label()
            Me.btnCalcula_IvaApp4 = New System.Windows.Forms.Button()
            CType(Me.ImagenCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'btnConvertir_Pesetas
            '
            Me.btnConvertir_Pesetas.Location = New System.Drawing.Point(95, 247)
            Me.btnConvertir_Pesetas.Name = "btnConvertir_Pesetas"
            Me.btnConvertir_Pesetas.Size = New System.Drawing.Size(108, 23)
            Me.btnConvertir_Pesetas.TabIndex = 0
            Me.btnConvertir_Pesetas.Text = "Convertir a Pesetas"
            Me.btnConvertir_Pesetas.UseVisualStyleBackColor = True
            '
            'lblConvertido
            '
            Me.lblConvertido.AutoSize = True
            Me.lblConvertido.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblConvertido.Location = New System.Drawing.Point(125, 285)
            Me.lblConvertido.Name = "lblConvertido"
            Me.lblConvertido.Size = New System.Drawing.Size(133, 24)
            Me.lblConvertido.TabIndex = 1
            Me.lblConvertido.Text = "lblConvertido"
            Me.lblConvertido.Visible = False
            '
            'tbxDinero
            '
            Me.tbxDinero.Location = New System.Drawing.Point(198, 221)
            Me.tbxDinero.MaxLength = 10
            Me.tbxDinero.Name = "tbxDinero"
            Me.tbxDinero.Size = New System.Drawing.Size(144, 20)
            Me.tbxDinero.TabIndex = 2
            '
            'btnConvertir_Euros
            '
            Me.btnConvertir_Euros.Location = New System.Drawing.Point(234, 247)
            Me.btnConvertir_Euros.Name = "btnConvertir_Euros"
            Me.btnConvertir_Euros.Size = New System.Drawing.Size(108, 23)
            Me.btnConvertir_Euros.TabIndex = 3
            Me.btnConvertir_Euros.Text = "Convertir a Euros"
            Me.btnConvertir_Euros.UseVisualStyleBackColor = True
            '
            'lblDinero
            '
            Me.lblDinero.AutoSize = True
            Me.lblDinero.Location = New System.Drawing.Point(117, 224)
            Me.lblDinero.Name = "lblDinero"
            Me.lblDinero.Size = New System.Drawing.Size(41, 13)
            Me.lblDinero.TabIndex = 4
            Me.lblDinero.Text = "Dinero:"
            '
            'ImagenCabecera
            '
            Me.ImagenCabecera.Image = CType(resources.GetObject("ImagenCabecera.Image"), System.Drawing.Image)
            Me.ImagenCabecera.Location = New System.Drawing.Point(12, 4)
            Me.ImagenCabecera.Name = "ImagenCabecera"
            Me.ImagenCabecera.Size = New System.Drawing.Size(404, 153)
            Me.ImagenCabecera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.ImagenCabecera.TabIndex = 6
            Me.ImagenCabecera.TabStop = False
            '
            'App2Titulo
            '
            Me.App2Titulo.AutoSize = True
            Me.App2Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.App2Titulo.Location = New System.Drawing.Point(33, 160)
            Me.App2Titulo.Name = "App2Titulo"
            Me.App2Titulo.Size = New System.Drawing.Size(359, 32)
            Me.App2Titulo.TabIndex = 7
            Me.App2Titulo.Text = "Conversor Pesetas Euros"
            '
            'btnCalcula_IvaApp4
            '
            Me.btnCalcula_IvaApp4.Location = New System.Drawing.Point(12, 302)
            Me.btnCalcula_IvaApp4.Name = "btnCalcula_IvaApp4"
            Me.btnCalcula_IvaApp4.Size = New System.Drawing.Size(83, 23)
            Me.btnCalcula_IvaApp4.TabIndex = 8
            Me.btnCalcula_IvaApp4.Text = "Calcula IVA"
            Me.btnCalcula_IvaApp4.UseVisualStyleBackColor = True
            Me.btnCalcula_IvaApp4.Visible = False
            '
            'App2Form
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(428, 351)
            Me.Controls.Add(Me.btnCalcula_IvaApp4)
            Me.Controls.Add(Me.App2Titulo)
            Me.Controls.Add(Me.ImagenCabecera)
            Me.Controls.Add(Me.lblDinero)
            Me.Controls.Add(Me.btnConvertir_Euros)
            Me.Controls.Add(Me.tbxDinero)
            Me.Controls.Add(Me.lblConvertido)
            Me.Controls.Add(Me.btnConvertir_Pesetas)
            Me.Name = "App2Form"
            Me.Text = "App2Form"
            CType(Me.ImagenCabecera, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents btnConvertir_Pesetas As Button
        Friend WithEvents lblConvertido As Label
        Friend WithEvents tbxDinero As TextBox
        Friend WithEvents btnConvertir_Euros As Button
        Friend WithEvents lblDinero As Label
        Friend WithEvents ImagenCabecera As PictureBox
        Friend WithEvents App2Titulo As Label
        Friend WithEvents btnCalcula_IvaApp4 As Button
    End Class
End Namespace

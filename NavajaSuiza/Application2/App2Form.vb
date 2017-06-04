﻿Namespace NavajaSuiza.Application2
    Partial Public Class App2Form
        ''' <summary>
        ''' Declaración de clases
        ''' </summary>
        Dim Aplicacion As New App2Logica
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App2Form()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' Función para comprobar que el número introducido es correcto.
        ''' </summary>
        ''' <param name="NumAConvertir">Número introducido por el usuario</param>
        Public Function Comprobar(ByVal NumAConvertir As String) As Boolean
            Dim Resultado As Double
            Dim Bool As Boolean = True
            If Double.TryParse(NumAConvertir, Resultado) = False Then
                lblConvertido.Text = "Error al introducir número."
                Bool = False
            End If
            Return Bool
        End Function

        ''' <summary>
        ''' Llama a la función para convertir, pasandole el valor 0 que convierte a pesetas.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnConvertir_Pesetas_Click(sender As Object, e As EventArgs) Handles btnConvertir_Pesetas.Click
            Try
                Dim Dinero = tbxDinero.Text
                If Comprobar(Dinero) Then
                    lblConvertido.Text = Aplicacion.Convertir(Dinero, 0)
                End If
            Catch ex As Exception
                'Aquí registraría un error en una hipotetica base de datos
            Finally
                lblConvertido.Visible = True
            End Try
        End Sub
        ''' <summary>
        ''' Llama a la función para convertir, pasandole el valor 1 que convierte a euros.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnConvertir_Euros_Click(sender As Object, e As EventArgs) Handles btnConvertir_Euros.Click
            Try
                Dim Dinero = tbxDinero.Text
                If Comprobar(Dinero) Then
                    lblConvertido.Text = Aplicacion.Convertir(Dinero, 1)
                End If
            Catch ex As Exception
                'Aquí registraría un error en una hipotetica base de datos
            Finally
                lblConvertido.Visible = True
            End Try
        End Sub
    End Class
End Namespace
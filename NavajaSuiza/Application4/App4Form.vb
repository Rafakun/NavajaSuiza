﻿Namespace Application4
    Partial Public Class App4Form
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App4Form()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' Declaración de variables locales
        ''' </summary>
        Dim totalCalculaIVA = Main.MainForm.totalCalculaIVA

        ''' <summary>
        ''' Se iguala el Textbox a la variable publica "TotalCalculaIva"
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub App4Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            txtCalculaIva.Text = totalCalculaIVA
            cbxIVA.SelectedIndex = 0
        End Sub
        ''' <summary>
        ''' Constructor Form
        ''' </summary>
        Public Sub App1Form()
            InitializeComponent()
        End Sub
        ''' <summary>
        ''' Función para comprobar que el número introducido es correcto.
        ''' </summary>
        ''' <param name="numeroIva">Número introducido por el usuario</param>
        ''' <returns>Booleano según el numero pueda o no parsearse. (True/False, respectivamente)</returns>
        Public Function Comprobar(ByVal numeroIva As String) As Boolean
            Dim numeroPrimo As Integer
            Dim bool As Boolean = True
            If Double.TryParse(numeroIva, numeroPrimo) = False Then
                lblTotal.Text = "No has introducido" + vbCrLf + "un valor valido."
                bool = False
            End If
            Return bool
        End Function

        ''' <summary>
        ''' Llama a la función Calcular Primo
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        Private Sub btnCalcula_Iva(sender As Object, e As EventArgs) Handles btnCalcular_Iva.Click
            Try
                If Comprobar(txtCalculaIva.Text) Then
                    Dim IVA = cbxIVA.Text.Replace("%", "")
                    lblTotal.Text = App4Logica.CalculaIVA(txtCalculaIva.Text, IVA)
                End If
            Catch ex As Exception
                lblTotal.Text = ex.Message
                'Aquí registraría un error en una hipotetica base de datos
            Finally
                lblTotal.Visible = True
            End Try
        End Sub
    End Class
End Namespace

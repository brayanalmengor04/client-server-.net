Imports BLL

Public Class principal
    Private libroBLL As New LibroBLL()
    Private Sub principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnCalificar_Click(sender As Object, e As EventArgs) Handles btnCalificar.Click
        Dim usuarioId As Integer = Convert.ToInt32(txtUsuarioId.Text)
        Dim libroId As Integer = Convert.ToInt32(txtLibroId.Text)
        Dim calificacion As Integer = Convert.ToInt32(txtCalificacion.Text)

        Dim promedio As Double = libroBLL.CalificarLibro(usuarioId, libroId, calificacion)
        MessageBox.Show("Calificación registrada. Nuevo promedio: " & promedio.ToString("F2"))
    End Sub

    Private Sub btnCalificacion_Click(sender As Object, e As EventArgs) Handles btnCalificacion.Click
        Dim libroId As Integer = Convert.ToInt32(txtLibroId.Text)

        Dim promedio As Double = libroBLL.ObtenerPromedioCalificacion(libroId)
        MessageBox.Show("Promedio de calificación actual: " & promedio.ToString("F2"))
    End Sub
End Class

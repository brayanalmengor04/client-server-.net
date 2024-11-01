Imports DAL

Public Class LibroBLL

    Private db As New Database()
    Public Function CalificarLibro(usuarioId As Integer, libroId As Integer, calificacion As Integer) As Double
        Dim query As String = "CALL CalificarLibro(@usuario_id, @libro_id, @calificacion);"
        Dim params As New Dictionary(Of String, Object) From {
            {"@usuario_id", usuarioId},
            {"@libro_id", libroId},
            {"@calificacion", calificacion}
        }

        Dim dt As DataTable = db.ExecuteQuery(query, params)

        ' Devuelve el nuevo promedio de calificación
        If dt.Rows.Count > 0 Then
            Return Convert.ToDouble(dt.Rows(0)("PromedioCalificacion"))
        End If

        Return 0
    End Function

    ' Método para obtener el promedio de calificación de un libro
    Public Function ObtenerPromedioCalificacion(libroId As Integer) As Double
        Dim query As String = "CALL ObtenerPromedioCalificacion(@libro_id);"
        Dim params As New Dictionary(Of String, Object) From {
            {"@libro_id", libroId}
        }

        Dim dt As DataTable = db.ExecuteQuery(query, params)

        ' Retorna el promedio de calificación
        If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)("PromedioCalificacion")) Then
            Return Convert.ToDouble(dt.Rows(0)("PromedioCalificacion"))
        End If

        Return 0 ' Si no hay calificaciones, retorna 0
    End Function



    'Agregar Crud de libro aqui ---------------------------------------------------------------'


End Class

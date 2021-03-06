﻿Public Class Cls_Extras
    Public Function registrarExtra(pNombre As String, pCosto As Decimal)
        Try

            extra.extNombre = pNombre
            extra.extCosto = pCosto

            DB.tblExtras.Add(extra)
            DB.SaveChanges()

            Return True
        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al registrar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function

    Public Function modificarExtra(pId As String, pNombre As String, pCosto As Decimal)
        Try
            extra = (From temp In DB.tblExtras Where temp.extId = pId Select temp).First()
            extra.extNombre = pNombre
            extra.extCosto = pCosto

            DB.SaveChanges()
            Return True
        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al modificar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function
    Public Function borrrarExtra(pNombre As String)
        Try
            extra = (From temp In DB.tblExtras Where temp.extNombre = pNombre Select temp).First()
            DB.tblExtras.Remove(extra)
            DB.SaveChanges()

            Return True
        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al modificar los datos" & vbCrLf & ex.Message)
            Return False
        End Try
    End Function
    Public Function extraerExtras()
        Try

            Dim lista As New Collection

            For Each extra In DB.tblExtras
                lista.Add(extra.extNombre)
                '' lista.Add(extra.extCosto)
            Next

            Return lista

        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error" & vbCrLf & ex.Message)
            Return "Nada"
        End Try
    End Function

    Public Function buscarExtra(pNombre As String)
        Try
            extra = (From temp In DB.tblExtras Where temp.extNombre = pNombre Select temp).First()
            Dim lista As New Collection
            lista.Add(extra.extCosto)

            Return lista
        Catch ex As Exception
            ''Mensaje de error
            MsgBox("Error al modificar los datos" & vbCrLf & ex.Message)
            Return "Nada"
        End Try
    End Function
End Class

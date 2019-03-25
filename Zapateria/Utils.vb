Friend NotInheritable Class Utils
    Public Shared Function isNumberInteger(ByVal e)
        Return (Asc(e.KeyChar) <> 8 And Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57)
    End Function

    Public Shared Function isNumberFloat(ByVal e)
        Return (Asc(e.KeyChar) <> 8 And (Asc(e.KeyChar) < 44 Or (Asc(e.KeyChar) > 44 And Asc(e.KeyChar) < 46) Or (Asc(e.KeyChar) > 46 And Asc(e.KeyChar) < 48) Or Asc(e.KeyChar) > 57))
    End Function
End Class
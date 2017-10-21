Public Class Holder
    Public Property name As String
    Public Property is_alias As Boolean
End Class

Public Class Bank
    Public Property name As String
    Public Property national_identifier As String
End Class

Public Class ThisAccount
    Public Property id As String
    Public Property holders As Holder()
    Public Property number As String
    Public Property kind As String
    Public Property IBAN As String
    Public Property swift_bic As String
    Public Property bank As Bank
End Class

Public Class OtherAccount
    Public Property id As String
    Public Property holders As Holder()
    Public Property number As String
    Public Property kind As String
    Public Property IBAN As String
    Public Property swift_bic As String
    Public Property bank As Bank
End Class

Public Class NewBalance
    Public Property currency As String
    Public Property amount As String
End Class

Public Class Value
    Public Property currency As String
    Public Property amount As String
End Class

Public Class Details
    Public Property type As String
    Public Property description As String
    Public Property posted As DateTime
    Public Property completed As DateTime
    Public Property new_balance As NewBalance
    Public Property value As Value
End Class

Public Class User
    Public Property id As String
    Public Property provider As String
    Public Property display_name As String
End Class

Public Class Comment
    Public Property id As String
    Public Property value As String
    Public Property execdate As DateTime
    Public Property user As User
End Class

Public Class Tag
    Public Property id As String
    Public Property value As String
    Public Property execdate As DateTime
    Public Property user As User
End Class

Public Class Image
    Public Property id As String
    Public Property label As String
    Public Property URL As String
    Public Property execdate As DateTime
    Public Property user As User
End Class

Public Class Where
    Public Property latitude As Double
    Public Property longitude As Double
    Public Property execdate As DateTime
    Public Property user As User
End Class

Public Class Metadata
    Public Property narrative As String
    Public Property comments As Comment()
    Public Property tags As Tag()
    Public Property images As Image()
    Public Property where As Where
End Class

Public Class Transaction
    Public Property id As String
    Public Property this_account As ThisAccount
    Public Property other_account As OtherAccount
    Public Property details As Details
    Public Property metadata As Metadata
End Class


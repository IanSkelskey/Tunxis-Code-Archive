Option Explicit On
Option Strict On
Option Infer Off
Public Class Dues

    'Class Properties
    Public Property BasicCharge As Double
    Public Property AdditionalCharge As Double

    'Default Constructor
    Public Sub New()
        _BasicCharge = 0
        _AdditionalCharge = 0
    End Sub

    'Parameterized Constructor
    Public Sub New(ByVal BasicChargeIn As Double, ByVal AdditionalChargeIn As Double)
        _BasicCharge = BasicChargeIn
        _AdditionalCharge = AdditionalChargeIn
    End Sub

    Public Function GetMonthlyDues() As Double
        Return BasicCharge + AdditionalCharge
    End Function

End Class

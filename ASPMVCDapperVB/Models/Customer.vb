Imports System.ComponentModel.DataAnnotations

Public Class Customer

    Public Property CustomerID() As Integer
        Get
            Return m_CustomerID
        End Get
        Set(value As Integer)
            m_CustomerID = value
        End Set
    End Property
    Private m_CustomerID As Integer

    <Display(Name:="Company Name")>
    Public Property CompanyName() As String
        Get
            Return m_CompanyName
        End Get
        Set(value As String)
            m_CompanyName = value
        End Set
    End Property
    Private m_CompanyName As String

    <Display(Name:="Address")>
    Public Property Address() As String
        Get
            Return m_Address
        End Get
        Set(value As String)
            m_Address = value
        End Set
    End Property
    Private m_Address As String

    <Display(Name:="City")>
    Public Property City() As String
        Get
            Return m_City
        End Get
        Set(value As String)
            m_City = value
        End Set
    End Property
    Private m_City As String

    <Display(Name:="State")>
    Public Property State() As String
        Get
            Return m_State
        End Get
        Set(value As String)
            m_State = value
        End Set
    End Property
    Private m_State As String

    <Display(Name:="Intro Date")>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    Public Property IntroDate() As DateTime
        Get
            Return m_IntroDate
        End Get
        Set(value As DateTime)
            m_IntroDate = value
        End Set
    End Property
    Private m_IntroDate As DateTime

    <Display(Name:="Credit Limit")>
    <DisplayFormat(DataFormatString:="{0:n2}")>
    Public Property CreditLimit() As Decimal
        Get
            Return m_CreditLimit
        End Get
        Set(value As Decimal)
            m_CreditLimit = value
        End Set
    End Property
    Private m_CreditLimit As Decimal

End Class


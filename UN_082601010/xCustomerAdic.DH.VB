'*****************************************************************************
' <Copyright File='xcustomeradic.sdo.vb' Company='JanuSanthosh Inc'> 
' Dynamics SL - DH File Creation
' Created by D.Santhosh - SL Consultant 
' </Copyright> 
'*****************************************************************************
Option Strict Off
Option Explicit On
Imports Solomon.Kernel
Module sdoxcustomeradic
    Public Class xcustomeradic
        Inherits SolomonDataObject
        <
        DataBinding(PropertyIndex:=0, StringSize:=60)
        >
        Public Property Addr1() As String
            Get
                Return Me.GetPropertyValue("Addr1")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Addr1", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=1, StringSize:=60)
        >
        Public Property Addr2() As String
            Get
                Return Me.GetPropertyValue("Addr2")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Addr2", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=2, StringSize:=60)
        >
        Public Property ApellidoMaterno() As String
            Get
                Return Me.GetPropertyValue("ApellidoMaterno")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ApellidoMaterno", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=3, StringSize:=60)
        >
        Public Property ApellidoPaterno() As String
            Get
                Return Me.GetPropertyValue("ApellidoPaterno")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ApellidoPaterno", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=4, StringSize:=30)
        >
        Public Property Attn() As String
            Get
                Return Me.GetPropertyValue("Attn")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Attn", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=5, StringSize:=10)
        >
        Public Property Banco() As String
            Get
                Return Me.GetPropertyValue("Banco")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Banco", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=6, StringSize:=10)
        >
        Public Property BillToId() As String
            Get
                Return Me.GetPropertyValue("BillToId")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("BillToId", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=7, StringSize:=30)
        >
        Public Property City() As String
            Get
                Return Me.GetPropertyValue("City")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("City", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=8, StringSize:=30)
        >
        Public Property Ciudad() As String
            Get
                Return Me.GetPropertyValue("Ciudad")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Ciudad", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=9, StringSize:=1)
        >
        Public Property Clave() As String
            Get
                Return Me.GetPropertyValue("Clave")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Clave", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=10, StringSize:=10)
        >
        Public Property COGSAcct() As String
            Get
                Return Me.GetPropertyValue("COGSAcct")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("COGSAcct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=11, StringSize:=31)
        >
        Public Property COGSSub() As String
            Get
                Return Me.GetPropertyValue("COGSSub")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("COGSSub", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=12, StringSize:=60)
        >
        Public Property Colonia() As String
            Get
                Return Me.GetPropertyValue("Colonia")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Colonia", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=13, StringSize:=3)
        >
        Public Property Country() As String
            Get
                Return Me.GetPropertyValue("Country")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Country", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=14)
        >
        Public Property Crtd_DateTime() As Integer
            Get
                Return Me.GetPropertyValue("Crtd_DateTime")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("Crtd_DateTime", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=15, StringSize:=10)
        >
        Public Property Crtd_Prog() As String
            Get
                Return Me.GetPropertyValue("Crtd_Prog")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Crtd_Prog", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=16, StringSize:=10)
        >
        Public Property Crtd_User() As String
            Get
                Return Me.GetPropertyValue("Crtd_User")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Crtd_User", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=17, StringSize:=30)
        >
        Public Property CiudadId() As String
            Get
                Return Me.GetPropertyValue("CiudadId")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CiudadId", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=18, StringSize:=18)
        >
        Public Property CURP() As String
            Get
                Return Me.GetPropertyValue("CURP")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CURP", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=19, StringSize:=15)
        >
        Public Property CustId() As String
            Get
                Return Me.GetPropertyValue("CustId")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("CustId", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=20, StringSize:=30)
        >
        Public Property Descr() As String
            Get
                Return Me.GetPropertyValue("Descr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Descr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=21, StringSize:=4)
        >
        Public Property DigitosCuenta() As String
            Get
                Return Me.GetPropertyValue("DigitosCuenta")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("DigitosCuenta", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=22, StringSize:=10)
        >
        Public Property DiscAcct() As String
            Get
                Return Me.GetPropertyValue("DiscAcct")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("DiscAcct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=23, StringSize:=31)
        >
        Public Property DiscSub() As String
            Get
                Return Me.GetPropertyValue("DiscSub")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("DiscSub", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=24, StringSize:=70)
        >
        Public Property Domicilio() As String
            Get
                Return Me.GetPropertyValue("Domicilio")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Domicilio", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=25, StringSize:=100)
        >
        Public Property EmailAddr() As String
            Get
                Return Me.GetPropertyValue("EmailAddr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("EmailAddr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=26, StringSize:=15)
        >
        Public Property Escolaridad() As String
            Get
                Return Me.GetPropertyValue("Escolaridad")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Escolaridad", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=27, StringSize:=10)
        >
        Public Property EstadoCivil() As String
            Get
                Return Me.GetPropertyValue("EstadoCivil")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("EstadoCivil", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=28, StringSize:=30)
        >
        Public Property Fax() As String
            Get
                Return Me.GetPropertyValue("Fax")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Fax", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=29)
        >
        Public Property FechaNacimiento() As Integer
            Get
                Return Me.GetPropertyValue("FechaNacimiento")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("FechaNacimiento", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=30, StringSize:=15)
        >
        Public Property FOB() As String
            Get
                Return Me.GetPropertyValue("FOB")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("FOB", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=31, StringSize:=4)
        >
        Public Property FrghtCode() As String
            Get
                Return Me.GetPropertyValue("FrghtCode")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("FrghtCode", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=32, StringSize:=10)
        >
        Public Property FrtAcct() As String
            Get
                Return Me.GetPropertyValue("FrtAcct")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("FrtAcct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=33, StringSize:=31)
        >
        Public Property FrtSub() As String
            Get
                Return Me.GetPropertyValue("FrtSub")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("FrtSub", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=34, StringSize:=10)
        >
        Public Property FrtTermsID() As String
            Get
                Return Me.GetPropertyValue("FrtTermsID")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("FrtTermsID", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=35, StringSize:=10)
        >
        Public Property GeoCode() As String
            Get
                Return Me.GetPropertyValue("GeoCode")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("GeoCode", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=36, StringSize:=10)
        >
        Public Property LadaCasa() As String
            Get
                Return Me.GetPropertyValue("LadaCasa")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("LadaCasa", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=37, StringSize:=10)
        >
        Public Property LadaOficina() As String
            Get
                Return Me.GetPropertyValue("LadaOficina")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("LadaOficina", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=38)
        >
        Public Property Lupd_DateTime() As Integer
            Get
                Return Me.GetPropertyValue("Lupd_DateTime")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("Lupd_DateTime", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=39, StringSize:=8)
        >
        Public Property Lupd_Prog() As String
            Get
                Return Me.GetPropertyValue("Lupd_Prog")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Lupd_Prog", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=40, StringSize:=10)
        >
        Public Property Lupd_User() As String
            Get
                Return Me.GetPropertyValue("Lupd_User")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Lupd_User", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=41, StringSize:=10)
        >
        Public Property MapLocation() As String
            Get
                Return Me.GetPropertyValue("MapLocation")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("MapLocation", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=42, StringSize:=10)
        >
        Public Property MetodoPago() As String
            Get
                Return Me.GetPropertyValue("MetodoPago")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("MetodoPago", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=43, StringSize:=10)
        >
        Public Property MiscAcct() As String
            Get
                Return Me.GetPropertyValue("MiscAcct")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("MiscAcct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=44, StringSize:=31)
        >
        Public Property MiscSub() As String
            Get
                Return Me.GetPropertyValue("MiscSub")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("MiscSub", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=45, StringSize:=100)
        >
        Public Property Name() As String
            Get
                Return Me.GetPropertyValue("Name")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Name", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=46, StringSize:=100)
        >
        Public Property Nombre() As String
            Get
                Return Me.GetPropertyValue("Nombre")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Nombre", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=47)
        >
        Public Property NoteId() As Integer
            Get
                Return Me.GetPropertyValue("NoteId")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("NoteId", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=48, StringSize:=10)
        >
        Public Property NoInterior() As String
            Get
                Return Me.GetPropertyValue("NoInterior")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("NoInterior", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=49, StringSize:=30)
        >
        Public Property Numero() As String
            Get
                Return Me.GetPropertyValue("Numero")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Numero", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=50, StringSize:=30)
        >
        Public Property Phone() As String
            Get
                Return Me.GetPropertyValue("Phone")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Phone", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=51, StringSize:=10)
        >
        Public Property RangoSocial() As String
            Get
                Return Me.GetPropertyValue("RangoSocial")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("RangoSocial", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=52, StringSize:=100)
        >
        Public Property RazonSocial() As String
            Get
                Return Me.GetPropertyValue("RazonSocial")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("RazonSocial", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=53, StringSize:=30)
        >
        Public Property s4Future01() As String
            Get
                Return Me.GetPropertyValue("s4Future01")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("s4Future01", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=54, StringSize:=30)
        >
        Public Property s4future02() As String
            Get
                Return Me.GetPropertyValue("s4future02")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("s4future02", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=55)
        >
        Public Property s4Future03() As Double
            Get
                Return Me.GetPropertyValue("s4Future03")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("s4Future03", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=56)
        >
        Public Property s4Future04() As Double
            Get
                Return Me.GetPropertyValue("s4Future04")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("s4Future04", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=57)
        >
        Public Property s4Future05() As Double
            Get
                Return Me.GetPropertyValue("s4Future05")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("s4Future05", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=58)
        >
        Public Property s4Future06() As Double
            Get
                Return Me.GetPropertyValue("s4Future06")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("s4Future06", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=59)
        >
        Public Property s4Future07() As Integer
            Get
                Return Me.GetPropertyValue("s4Future07")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("s4Future07", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=60)
        >
        Public Property s4Future08() As Integer
            Get
                Return Me.GetPropertyValue("s4Future08")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("s4Future08", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=61)
        >
        Public Property s4Future09() As Integer
            Get
                Return Me.GetPropertyValue("s4Future09")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("s4Future09", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=62)
        >
        Public Property s4Future10() As Integer
            Get
                Return Me.GetPropertyValue("s4Future10")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("s4Future10", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=63, StringSize:=10)
        >
        Public Property s4future11() As String
            Get
                Return Me.GetPropertyValue("s4future11")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("s4future11", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=64, StringSize:=10)
        >
        Public Property s4Future12() As String
            Get
                Return Me.GetPropertyValue("s4Future12")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("s4Future12", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=65, StringSize:=30)
        >
        Public Property Salut() As String
            Get
                Return Me.GetPropertyValue("Salut")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Salut", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=66, StringSize:=2)
        >
        Public Property Sexo() As String
            Get
                Return Me.GetPropertyValue("Sexo")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Sexo", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=67, StringSize:=15)
        >
        Public Property ShipViaId() As String
            Get
                Return Me.GetPropertyValue("ShipViaId")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("ShipViaId", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=68, StringSize:=10)
        >
        Public Property SiteId() As String
            Get
                Return Me.GetPropertyValue("SiteId")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("SiteId", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=69, StringSize:=10)
        >
        Public Property SlsAcct() As String
            Get
                Return Me.GetPropertyValue("SlsAcct")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("SlsAcct", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=70, StringSize:=10)
        >
        Public Property SlsPerId() As String
            Get
                Return Me.GetPropertyValue("SlsPerId")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("SlsPerId", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=71, StringSize:=31)
        >
        Public Property SlsSub() As String
            Get
                Return Me.GetPropertyValue("SlsSub")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("SlsSub", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=72, StringSize:=3)
        >
        Public Property State() As String
            Get
                Return Me.GetPropertyValue("State")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("State", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=73, StringSize:=1)
        >
        Public Property Status() As String
            Get
                Return Me.GetPropertyValue("Status")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Status", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=74, StringSize:=10)
        >
        Public Property TaxId00() As String
            Get
                Return Me.GetPropertyValue("TaxId00")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxId00", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=75, StringSize:=10)
        >
        Public Property TaxId01() As String
            Get
                Return Me.GetPropertyValue("TaxId01")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxId01", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=76, StringSize:=10)
        >
        Public Property TaxId02() As String
            Get
                Return Me.GetPropertyValue("TaxId02")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxId02", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=77, StringSize:=10)
        >
        Public Property TaxId03() As String
            Get
                Return Me.GetPropertyValue("TaxId03")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxId03", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=78, StringSize:=15)
        >
        Public Property TaxLocId() As String
            Get
                Return Me.GetPropertyValue("TaxLocId")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxLocId", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=79, StringSize:=15)
        >
        Public Property TaxRegNbr() As String
            Get
                Return Me.GetPropertyValue("TaxRegNbr")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TaxRegNbr", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=80, StringSize:=20)
        >
        Public Property TelefonoCasa() As String
            Get
                Return Me.GetPropertyValue("TelefonoCasa")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TelefonoCasa", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=81, StringSize:=20)
        >
        Public Property TelefonoCelular() As String
            Get
                Return Me.GetPropertyValue("TelefonoCelular")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TelefonoCelular", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=82, StringSize:=20)
        >
        Public Property TelefonoOficina() As String
            Get
                Return Me.GetPropertyValue("TelefonoOficina")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TelefonoOficina", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=83, StringSize:=10)
        >
        Public Property TipoPersona() As String
            Get
                Return Me.GetPropertyValue("TipoPersona")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("TipoPersona", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=84, StringSize:=30)
        >
        Public Property User1() As String
            Get
                Return Me.GetPropertyValue("User1")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User1", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=85, StringSize:=30)
        >
        Public Property User2() As String
            Get
                Return Me.GetPropertyValue("User2")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User2", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=86)
        >
        Public Property User3() As Double
            Get
                Return Me.GetPropertyValue("User3")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("User3", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=87)
        >
        Public Property User4() As Double
            Get
                Return Me.GetPropertyValue("User4")
            End Get
            Set(ByVal setval As Double)
                Me.SetPropertyValue("User4", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=88, StringSize:=50)
        >
        Public Property User5() As String
            Get
                Return Me.GetPropertyValue("User5")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User5", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=89, StringSize:=50)
        >
        Public Property User6() As String
            Get
                Return Me.GetPropertyValue("User6")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("User6", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=90)
        >
        Public Property User7() As Integer
            Get
                Return Me.GetPropertyValue("User7")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User7", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=91)
        >
        Public Property User8() As Integer
            Get
                Return Me.GetPropertyValue("User8")
            End Get
            Set(ByVal setval As Integer)
                Me.SetPropertyValue("User8", setval)
            End Set
        End Property

        <
        DataBinding(PropertyIndex:=92, StringSize:=10)
        >
        Public Property Zip() As String
            Get
                Return Me.GetPropertyValue("Zip")
            End Get
            Set(ByVal setval As String)
                Me.SetPropertyValue("Zip", setval)
            End Set
        End Property

    End Class
    Public bxCustomerAdic As xcustomeradic = New xcustomeradic, nxCustomerAdic As xcustomeradic = New xcustomeradic

    Public CSR_xCustomerAdic As Short
    Public Sub Init_xCustomerAdic(ByRef x_Level As Short, ByRef x_Cursor As Boolean)
        Call SetAddr(x_Level, "bxCustomerAdic", bxCustomerAdic, nxCustomerAdic)
        If x_Cursor = True Then
            Call SqlCursorEx(CSR_xCustomerAdic, x_Level, "CSR_xCustomerAdic", "xCustomerAdic", "xCustomerAdic")
        End If
    End Sub

End Module

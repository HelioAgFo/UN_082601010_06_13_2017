'*********************************************************
'
'    Copyright (c) Microsoft. All rights reserved.
'    This code is licensed under the Microsoft Public License.
'    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF
'    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY
'    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR
'    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT.
'
'*********************************************************
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Form1
#Region "Windows Form Designer generated code "
    <System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
        MyBase.New()
        'This call is required by the Windows Form Designer.
        m_IsInitializing = true
        InitializeComponent()
        m_IsInitializing = False
    End Sub
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Update1 As Microsoft.Dynamics.SL.Controls.DSLUpdate
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Update1 = New Microsoft.Dynamics.SL.Controls.DSLUpdate()
        Me.SAFHelpProvider = New System.Windows.Forms.HelpProvider()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cCustid = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cTaxLocId = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cTaxId00 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cTipoPersona = New Microsoft.Dynamics.SL.Controls.DSLCombo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cRazonSocial = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cCiudadId = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cDigitosCuenta = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cMetodoPago = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cFax = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cTelefonoCasa = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cEmailAddr = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cCity = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cState = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cAddr2 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cCountry = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cNumeroInt = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cNo = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cAddr1 = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.czip = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cNombre = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cApM = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.cApP = New Microsoft.Dynamics.SL.Controls.DSLMaskedText()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Update1
        '
        Me.Update1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Update1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Update1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update1.Image = CType(resources.GetObject("Update1.Image"), System.Drawing.Image)
        Me.Update1.Levels = Nothing
        Me.Update1.Location = New System.Drawing.Point(682, 12)
        Me.Update1.Name = "Update1"
        Me.Update1.Size = New System.Drawing.Size(25, 25)
        Me.Update1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Update1.TabIndex = 0
        Me.Update1.TabStop = False
        Me.Update1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cCustid)
        Me.GroupBox1.Controls.Add(Me.cTaxLocId)
        Me.GroupBox1.Controls.Add(Me.cTaxId00)
        Me.GroupBox1.Controls.Add(Me.cTipoPersona)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(698, 60)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Facturacion"
        '
        'cCustid
        '
        Me.cCustid.FieldName = """bxCustomerAdic.CustId""; 0; 0; 15"
        Me.cCustid.Level = "0,k"
        Me.cCustid.Location = New System.Drawing.Point(9, 30)
        Me.cCustid.Mask = "xx-xxxxxxxxxxxxx"
        Me.cCustid.Name = "cCustid"
        Me.cCustid.PV = "Customer_all"
        Me.cCustid.Size = New System.Drawing.Size(100, 22)
        Me.cCustid.TabIndex = 6
        Me.cCustid.TextLength = 16
        '
        'cTaxLocId
        '
        Me.cTaxLocId.Default = "0; ""XAXX010101000""; 0; 127; 0"
        Me.cTaxLocId.Enabled = False
        Me.cTaxLocId.FieldName = """bxCustomerAdic.TaxLocId""; 0; 0; 15"
        Me.cTaxLocId.Location = New System.Drawing.Point(500, 30)
        Me.cTaxLocId.Mask = "xxxxxxxxxxxxxxx"
        Me.cTaxLocId.Name = "cTaxLocId"
        Me.cTaxLocId.Size = New System.Drawing.Size(150, 20)
        Me.cTaxLocId.TabIndex = 5
        Me.cTaxLocId.TextLength = 15
        '
        'cTaxId00
        '
        Me.cTaxId00.Default = "0; ""IVA16""; 0; 127; 0"
        Me.cTaxId00.Enabled = False
        Me.cTaxId00.FieldName = """bxCustomerAdic.TaxId00""; 0; 0; 10"
        Me.cTaxId00.Location = New System.Drawing.Point(335, 30)
        Me.cTaxId00.Mask = "xxxxxxxxxx"
        Me.cTaxId00.Name = "cTaxId00"
        Me.cTaxId00.PV = """salestax_all"","
        Me.cTaxId00.Size = New System.Drawing.Size(100, 20)
        Me.cTaxId00.TabIndex = 4
        Me.cTaxId00.TextLength = 10
        '
        'cTipoPersona
        '
        Me.cTipoPersona.Enabled = False
        Me.cTipoPersona.FieldName = """bxCustomerAdic.TipoPersona""; 0; 0; 10"
        Me.cTipoPersona.FormattingEnabled = True
        Me.cTipoPersona.Heading = "TipoPersona "
        Me.cTipoPersona.List = "F;Persona Fisica,M;Persona Moral"
        Me.cTipoPersona.Location = New System.Drawing.Point(150, 30)
        Me.cTipoPersona.Name = "cTipoPersona"
        Me.cTipoPersona.Size = New System.Drawing.Size(120, 25)
        Me.cTipoPersona.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(500, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "RFC:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(330, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cód Impuesto 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo Persona:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CustId:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cRazonSocial)
        Me.GroupBox2.Controls.Add(Me.cCiudadId)
        Me.GroupBox2.Controls.Add(Me.cDigitosCuenta)
        Me.GroupBox2.Controls.Add(Me.cMetodoPago)
        Me.GroupBox2.Controls.Add(Me.cFax)
        Me.GroupBox2.Controls.Add(Me.cTelefonoCasa)
        Me.GroupBox2.Controls.Add(Me.cEmailAddr)
        Me.GroupBox2.Controls.Add(Me.cCity)
        Me.GroupBox2.Controls.Add(Me.cState)
        Me.GroupBox2.Controls.Add(Me.cAddr2)
        Me.GroupBox2.Controls.Add(Me.cCountry)
        Me.GroupBox2.Controls.Add(Me.cNumeroInt)
        Me.GroupBox2.Controls.Add(Me.cNo)
        Me.GroupBox2.Controls.Add(Me.cAddr1)
        Me.GroupBox2.Controls.Add(Me.czip)
        Me.GroupBox2.Controls.Add(Me.cNombre)
        Me.GroupBox2.Controls.Add(Me.cApM)
        Me.GroupBox2.Controls.Add(Me.cApP)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(698, 482)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'cRazonSocial
        '
        Me.cRazonSocial.Enabled = False
        Me.cRazonSocial.FieldName = """bxCustomerAdic.RazonSocial""; 0; 0; 255"
        Me.cRazonSocial.Location = New System.Drawing.Point(6, 40)
        Me.cRazonSocial.Mask = resources.GetString("cRazonSocial.Mask")
        Me.cRazonSocial.Name = "cRazonSocial"
        Me.cRazonSocial.Size = New System.Drawing.Size(500, 20)
        Me.cRazonSocial.TabIndex = 42
        Me.cRazonSocial.TextLength = 255
        '
        'cCiudadId
        '
        Me.cCiudadId.Enabled = False
        Me.cCiudadId.FieldName = """bxCustomerAdic.CiudadId""; 0; 0; 30"
        Me.cCiudadId.Location = New System.Drawing.Point(6, 340)
        Me.cCiudadId.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.cCiudadId.Name = "cCiudadId"
        Me.cCiudadId.Size = New System.Drawing.Size(150, 22)
        Me.cCiudadId.TabIndex = 41
        Me.cCiudadId.TextLength = 30
        '
        'cDigitosCuenta
        '
        Me.cDigitosCuenta.Enabled = False
        Me.cDigitosCuenta.FieldName = """bxCustomerAdic.DigitosCuenta""; 0; 0; 200"
        Me.cDigitosCuenta.Location = New System.Drawing.Point(200, 440)
        Me.cDigitosCuenta.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxx"
        Me.cDigitosCuenta.Name = "cDigitosCuenta"
        Me.cDigitosCuenta.Size = New System.Drawing.Size(150, 20)
        Me.cDigitosCuenta.TabIndex = 40
        Me.cDigitosCuenta.TextLength = 100
        '
        'cMetodoPago
        '
        Me.cMetodoPago.Enabled = False
        Me.cMetodoPago.FieldName = """bxCustomerAdic.MetodoPago""; 0; 0; 200"
        Me.cMetodoPago.Location = New System.Drawing.Point(6, 440)
        Me.cMetodoPago.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.cMetodoPago.Name = "cMetodoPago"
        Me.cMetodoPago.Size = New System.Drawing.Size(150, 20)
        Me.cMetodoPago.TabIndex = 39
        Me.cMetodoPago.TextLength = 200
        '
        'cFax
        '
        Me.cFax.Enabled = False
        Me.cFax.FieldName = """bxCustomerAdic.Fax""; 0; 0; 30"
        Me.cFax.Location = New System.Drawing.Point(200, 390)
        Me.cFax.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.cFax.Name = "cFax"
        Me.cFax.Size = New System.Drawing.Size(150, 20)
        Me.cFax.TabIndex = 38
        Me.cFax.TextLength = 30
        '
        'cTelefonoCasa
        '
        Me.cTelefonoCasa.Enabled = False
        Me.cTelefonoCasa.FieldName = """bxCustomerAdic.TelefonoCasa""; 0; 0; 20"
        Me.cTelefonoCasa.Location = New System.Drawing.Point(6, 390)
        Me.cTelefonoCasa.Mask = "99-9999-9999"
        Me.cTelefonoCasa.Name = "cTelefonoCasa"
        Me.cTelefonoCasa.Size = New System.Drawing.Size(150, 20)
        Me.cTelefonoCasa.TabIndex = 37
        Me.cTelefonoCasa.TextLength = 12
        '
        'cEmailAddr
        '
        Me.cEmailAddr.Enabled = False
        Me.cEmailAddr.FieldName = """bxCustomerAdic.EmailAddr""; 0; 0; 255"
        Me.cEmailAddr.Location = New System.Drawing.Point(200, 340)
        Me.cEmailAddr.Mask = resources.GetString("cEmailAddr.Mask")
        Me.cEmailAddr.Name = "cEmailAddr"
        Me.cEmailAddr.Size = New System.Drawing.Size(400, 20)
        Me.cEmailAddr.TabIndex = 36
        Me.cEmailAddr.TextLength = 255
        '
        'cCity
        '
        Me.cCity.Enabled = False
        Me.cCity.FieldName = """bxCustomerAdic.City""; 0; 0; 30"
        Me.cCity.Location = New System.Drawing.Point(403, 290)
        Me.cCity.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.cCity.Name = "cCity"
        Me.cCity.PV = """xsp_xFEMunicipios_All"", ""bxCustomerAdic.State""; 0; 0; 0; 0, "
        Me.cCity.Size = New System.Drawing.Size(200, 20)
        Me.cCity.TabIndex = 35
        Me.cCity.TextLength = 30
        '
        'cState
        '
        Me.cState.Enabled = False
        Me.cState.FieldName = """bxCustomerAdic.State""; 0; 0; 3"
        Me.cState.Location = New System.Drawing.Point(200, 290)
        Me.cState.Mask = "xxx"
        Me.cState.Name = "cState"
        Me.cState.PV = """State_All"","
        Me.cState.Size = New System.Drawing.Size(100, 20)
        Me.cState.TabIndex = 34
        Me.cState.TextLength = 3
        '
        'cAddr2
        '
        Me.cAddr2.Enabled = False
        Me.cAddr2.FieldName = """bxCustomerAdic.Colonia""; 0; 0; 255"
        Me.cAddr2.Location = New System.Drawing.Point(400, 240)
        Me.cAddr2.Mask = resources.GetString("cAddr2.Mask")
        Me.cAddr2.Name = "cAddr2"
        Me.cAddr2.Size = New System.Drawing.Size(200, 20)
        Me.cAddr2.TabIndex = 33
        Me.cAddr2.TextLength = 255
        '
        'cCountry
        '
        Me.cCountry.Enabled = False
        Me.cCountry.FieldName = """bxCustomerAdic.Country""; 0; 0; 10"
        Me.cCountry.Location = New System.Drawing.Point(6, 290)
        Me.cCountry.Mask = "xxxxxxxxxx"
        Me.cCountry.Name = "cCountry"
        Me.cCountry.Size = New System.Drawing.Size(100, 20)
        Me.cCountry.TabIndex = 32
        Me.cCountry.TextLength = 10
        '
        'cNumeroInt
        '
        Me.cNumeroInt.Enabled = False
        Me.cNumeroInt.FieldName = """bxCustomerAdic.NoInterior""; 0; 0; 128"
        Me.cNumeroInt.Location = New System.Drawing.Point(200, 240)
        Me.cNumeroInt.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.cNumeroInt.Name = "cNumeroInt"
        Me.cNumeroInt.Size = New System.Drawing.Size(100, 20)
        Me.cNumeroInt.TabIndex = 31
        Me.cNumeroInt.TextLength = 108
        '
        'cNo
        '
        Me.cNo.Enabled = False
        Me.cNo.FieldName = """bxCustomerAdic.Numero""; 0; 0; 255"
        Me.cNo.Location = New System.Drawing.Point(6, 240)
        Me.cNo.Mask = resources.GetString("cNo.Mask")
        Me.cNo.Name = "cNo"
        Me.cNo.Size = New System.Drawing.Size(100, 20)
        Me.cNo.TabIndex = 30
        Me.cNo.TextLength = 255
        '
        'cAddr1
        '
        Me.cAddr1.Enabled = False
        Me.cAddr1.FieldName = """bxCustomerAdic.Domicilio""; 0; 0; 255"
        Me.cAddr1.Location = New System.Drawing.Point(103, 190)
        Me.cAddr1.Mask = resources.GetString("cAddr1.Mask")
        Me.cAddr1.Name = "cAddr1"
        Me.cAddr1.Size = New System.Drawing.Size(400, 20)
        Me.cAddr1.TabIndex = 29
        Me.cAddr1.TextLength = 255
        '
        'czip
        '
        Me.czip.Enabled = False
        Me.czip.FieldName = """bxCustomerAdic.Zip""; 0; 0; 10"
        Me.czip.Location = New System.Drawing.Point(6, 190)
        Me.czip.Mask = "9999999999"
        Me.czip.Name = "czip"
        Me.czip.Size = New System.Drawing.Size(70, 20)
        Me.czip.TabIndex = 28
        Me.czip.TextLength = 10
        '
        'cNombre
        '
        Me.cNombre.Enabled = False
        Me.cNombre.FieldName = """bxCustomerAdic.Nombre""; 0; 0; 100"
        Me.cNombre.Location = New System.Drawing.Point(6, 140)
        Me.cNombre.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx" &
    "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.cNombre.Name = "cNombre"
        Me.cNombre.Size = New System.Drawing.Size(300, 20)
        Me.cNombre.TabIndex = 27
        Me.cNombre.TextLength = 140
        '
        'cApM
        '
        Me.cApM.Enabled = False
        Me.cApM.FieldName = """bxCustomerAdic.ApellidoMaterno""; 0; 0; 60"
        Me.cApM.Location = New System.Drawing.Point(353, 90)
        Me.cApM.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.cApM.Name = "cApM"
        Me.cApM.Size = New System.Drawing.Size(300, 20)
        Me.cApM.TabIndex = 26
        Me.cApM.TextLength = 60
        '
        'cApP
        '
        Me.cApP.Enabled = False
        Me.cApP.FieldName = """bxCustomerAdic.ApellidoPaterno""; 0; 0; 60"
        Me.cApP.Location = New System.Drawing.Point(6, 90)
        Me.cApP.Mask = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx"
        Me.cApP.Name = "cApP"
        Me.cApP.Size = New System.Drawing.Size(300, 20)
        Me.cApP.TabIndex = 25
        Me.cApP.TextLength = 60
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(200, 420)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 17)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Numero de Cuenta:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 420)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(113, 17)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Metodo de Pago:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(200, 370)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(61, 17)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "Fax/Ext:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 370)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 17)
        Me.Label19.TabIndex = 20
        Me.Label19.Text = "Telefono/Ext:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(200, 320)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(44, 17)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Email:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 320)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 17)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Ciudad:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(400, 270)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 17)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "Municipio:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(200, 270)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(55, 17)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "Estado:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 270)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 17)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Pais:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(400, 220)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Colonia:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(200, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "No. Interior:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 17)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "No."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(100, 170)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 17)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Calle"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 170)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "CP:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 17)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Nombre:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(350, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Apellido Materno:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Apellido Paterno: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(214, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Razon Social / Nombre Completo:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(719, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Update1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Location = New System.Drawing.Point(4, 23)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Datos de Facturación 08.260.20"
        CType(Me.Update1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SAFHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cTipoPersona As Microsoft.Dynamics.SL.Controls.DSLCombo
    Friend WithEvents cTaxId00 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cTaxLocId As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents cApP As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cApM As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cNombre As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents czip As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cAddr1 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cNo As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cNumeroInt As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cCountry As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cAddr2 As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cState As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cCity As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cEmailAddr As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cTelefonoCasa As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cFax As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cMetodoPago As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cDigitosCuenta As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cCiudadId As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cCustid As Microsoft.Dynamics.SL.Controls.DSLMaskedText
    Friend WithEvents cRazonSocial As Microsoft.Dynamics.SL.Controls.DSLMaskedText
#End Region
End Class

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
Option Explicit On
Option Strict Off
Friend Class Form1
    Inherits System.Windows.Forms.Form

    Protected m_IsInitializing As Boolean
    Protected ReadOnly Property IsInitializing() As Boolean
        Get
            Return m_IsInitializing
        End Get
    End Property

    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

        Dim sCustId As String
        Dim sExiste As String

        Call ApplInit()

        Call Init_xCustomerAdic(LEVEL0, True)

        With nxCustomerAdic
            .Crtd_DateTime = bpes.Today
            .Crtd_Prog = bpes.ScrnNbr
            .Crtd_User = bpes.UserId
            .Lupd_DateTime = bpes.Today
            .Lupd_Prog = bpes.ScrnNbr
            .Lupd_User = bpes.UserId
        End With
        sCustId = ApplGetParmValue(PRMSECTION_VBRDT, "CustId")
        'sExiste = ApplGetParmValue(PRMSECTION_VBRDT, "Existe")

        Call ScreenInit()
        'sCustId = "GD01"
        'Stop
        If Trim(sCustId) <> "" Then
            bxCustomerAdic.CustId = sCustId
            'Call SetProps(Me, cCustid, cCustid, "Enabled", False)
        Else
            bxCustomerAdic.CustId = ""
            Call SetProps(Me, cCustid, cCustid, "Enabled", True)
        End If
        Call DispField(cCustid)
        serr1 = CallChks(Me, cCustid, cCustid, True, False)

    End Sub

    Private Sub Form1_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        'Standard Screen Exit Call
        Call ScreenExit("", "")

    End Sub


    Private Sub cCustid_ChkEvent_1(ByRef ChkStrg As String, ByRef RetVal As Short) Handles cCustid.ChkEvent
        'Stop
        serr = PVChkFetch1(PNULL, CSR_xCustomerAdic, ChkStrg, bCustomer)
        If serr = NOTFOUND Then
            RetVal = NoAction
        Else
            Call DispFields(PNULL, PNULL, PNULL)
        End If

        Dim Query As String
        Query = "Select * from xCustomerAdic where custid = " + SParm(Trim(ChkStrg))
        Call sql(c1, Query)
        serr1 = SFetch1(c1, bxCustomerAdic)
        If serr1 = NOTFOUND Then
            RetVal = NoAction
        Else
            Call DispFields(PNULL, PNULL, PNULL)
        End If

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

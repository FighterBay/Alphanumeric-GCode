Imports System.IO

Module Gcode
    Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
    Public Function Print_char(ByVal str As String, ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)
        Select Case str
            Case "0"
                Zero(x, y, up, down)
            Case "1"
                Zero1(x, y, up, down)
            Case "2"
                Zero2(x, y, up, down)
            Case "3"
                Zero3(x, y, up, down)
            Case "4"
                Zero4(x, y, up, down)
            Case "5"
                Zero5(x, y, up, down)
            Case "6"
                Zero6(x, y, up, down)
            Case "7"
                Zero7(x, y, up, down)
            Case "8"
                Zero8(x, y, up, down)
            Case "9"
                Zero9(x, y, up, down)
            Case "A"
                A(x, y, up, down)
            Case "B"
                B(x, y, up, down)
            Case "C"
                C(x, y, up, down)
            Case "D"
                D(x, y, up, down)
            Case "E"
                E(x, y, up, down)
            Case "F"
                F(x, y, up, down)
            Case "G"
                G(x, y, up, down)
            Case "H"
                H(x, y, up, down)
            Case "I"
                I(x, y, up, down)
            Case "J"
                MsgBox("J")
                J(x, y, up, down)
            Case "K"
                K(x, y, up, down)
            Case "L"
                L(x, y, up, down)
            Case "M"
                M(x, y, up, down)
            Case "N"
                N(x, y, up, down)
            Case "O"
                O(x, y, up, down)
            Case "P"
                P(x, y, up, down)
            Case "Q"
                Q(x, y, up, down)
            Case "R"
                R(x, y, up, down)
            Case "S"
                S(x, y, up, down)
            Case "T"
                T(x, y, up, down)
            Case "U"
                U(x, y, up, down)
            Case "V"
                V(x, y, up, down)
            Case "W"
                W(x, y, up, down)
            Case "X"
                lx(x, y, up, down)
            Case "Y"
                ly(x, y, up, down)
            Case "Z"
                Z(x, y, up, down)
            Case "/"
                Slash(x, y, up, down)
        End Select
    End Function
    Private Function template_chooser(ByVal CyNo As Integer)

        If CyNo = 1 Then
            Return "-111.680|-132.285"
        ElseIf CyNo > 1 And CyNo <= 9 Then
            Return "|"
        ElseIf CyNo > 9 And CyNo <= 12 Then
            Return "|"

        End If
    End Function

    Private Sub Zero1(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = 1) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 2.41956 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -0.58044 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -0.58044 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -1.56084 & " Y" & y + 0)

        file.Close()

        'End If

    End Sub

    Private Sub Zero(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = 0) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z-35")
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.725 + x & " Y" & 0.825 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G03 X" & -0.075 + x & " Y" & 0.825 + y & " I" & -0.9 + x & " J" & 0.825 + y)
        file.WriteLine("G01 X" & -0.075 + x & " Y" & 2.175 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & -1.725 + x & " Y" & 2.175 + y & " I" & -0.9 + x & " J" & 2.175 + y)
        file.WriteLine("G00 X" & -1.725 + x & " Y" & 0.825 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x - 1 & " Y" & y)

        file.Close()

        'End If

    End Sub
    Private Sub Zero2(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = 2) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -0.00246 + x & " Y" & 2.43702 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G03 X" & -0.49428 + x & " Y" & 2.95881 + y & " I" & -0.673551 + x & " J" & 2.297136 + y)
        file.WriteLine("G03 X" & -1.24983 + x & " Y" & 2.89038 + y & " I" & -0.779733 + x & " J" & 1.905198 + y)
        file.WriteLine("G03 X" & -1.33728 + x & " Y" & 1.56261 + y & " I" & -0.921345 + x & " J" & 2.201985 + y)
        file.WriteLine("G02 X" & -0.19221 + x & " Y" & 0.54918 + y & " I" & -4.17003 + x & " J" & -2.791743 + y)
        file.WriteLine("G02 X" & -0.00243 + x & " Y" & 0 + y & " I" & -0.814005 + x & " J" & 0.026943 + y)
        file.WriteLine("G01 X" & x + -1.62039 & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.6604 & " Y" & y + 0)

        file.Close()

        'End If

    End Sub

    Private Sub Zero3(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = 3) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0.52716 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G02 X" & -0.33639 + x & " Y" & 0.1167 + y & " I" & -0.581214 + x & " J" & 0.66042 + y)
        file.WriteLine("G02 X" & -1.29876 + x & " Y" & 0.09324 + y & " I" & -0.845418 + x & " J" & 1.247148 + y)
        file.WriteLine("G02 X" & -1.45539 + x & " Y" & 1.50342 + y & " I" & -1.005531 + x & " J" & 0.839595 + y)
        file.WriteLine("G02 X" & -0.80517 + x & " Y" & 1.65753 + y & " I" & -0.927321 + x & " J" & 0.724158 + y)
        file.WriteLine("G02 X" & -1.28376 + x & " Y" & 1.75743 + y & " I" & -0.776286 + x & " J" & 2.99232 + y)
        file.WriteLine("G02 X" & x + -1.49091 & " Y" & 2.70996 + y & " I" & -1.05867 + x & " J" & 2.305176 + y)
        file.WriteLine("G02 X" & x + -0.36954 & " Y" & 2.8428 + y & " I" & -0.851415 + x & " J" & 2.111106 + y)
        file.WriteLine("G02 X" & x + -0.12081 & " Y" & 2.51877 + y & " I" & -0.71241 + x & " J" & 2.322153 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.47131 & " Y" & y + 0)

        file.Close()

        'End If

    End Sub

    Private Sub Zero4(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = 4) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.80039 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.80039 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & 0 + x & " Y" & 0.84405 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.99086 + x & " Y" & 0.84405 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.97126 & " Y" & y + 0)

        file.Close()

        'End If


    End Sub
    Private Sub Zero5(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)


        'If (nigga = 5) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0.15879 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G02 X" & -1.10649 + x & " Y" & 0.09636 + y & " I" & -0.609948 + x & " J" & 1.132743 + y)
        file.WriteLine("G02 X" & -1.26828 + x & " Y" & 1.63152 + y & " I" & -0.714876 + x & " J" & 0.913737 + y)
        file.WriteLine("G02 X" & -0.0594 + x & " Y" & 1.71609 + y & " I" & -0.600258 + x & " J" & 0.765087 + y)
        file.WriteLine("G01 X" & -0.1605 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.53306 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.6004 & " Y" & y + 0)

        file.Close()

        'End If

    End Sub


    Private Sub Zero6(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = 6) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.68633 + x & " Y" & 2.54349 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G02 X" & -1.38609 + x & " Y" & 2.88033 + y & " I" & -1.020576 + x & " J" & 2.252322 + y)
        file.WriteLine("G02 X" & -0.38289 + x & " Y" & 2.70459 + y & " I" & -0.988701 + x & " J" & 2.197575 + y)
        file.WriteLine("G02 X" & -0.06801 + x & " Y" & 2.07483 + y & " I" & -1.551135 + x & " J" & 1.726875 + y)
        file.WriteLine("G01 X" & -0.06231 + x & " Y" & 0.76293 + y & " I" & -2.916699 + x & " J" & 1.406475 + y)
        file.WriteLine("G01 X" & -0.61722 + x & " Y" & 0.07572 + y & " I" & -1.037568 + x & " J" & 0.982806 + y)
        file.WriteLine("G01 X" & -1.8108 + x & " Y" & 0.59562 + y & " I" & -0.983223 + x & " J" & 0.865518 + y)
        file.WriteLine("G01 X" & -1.23963 + x & " Y" & 1.7526 + y & " I" & -0.933165 + x & " J" & 0.881832 + y)
        file.WriteLine("G01 X" & -0.06228 + x & " Y" & 0.7629 + y & " I" & -0.94314 + x & " J" & 0.910182 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.8404 & " Y" & y + 0)

        file.Close()

        'End If

    End Sub

    Private Sub Zero7(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = 7) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -0.2955 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.74 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.7204 & " Y" & y + 0)

        file.Close()

        'End If

    End Sub

    Private Sub Zero8(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = 8) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -0.61683 + x & " Y" & 1.64364 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.22235 + x & " Y" & 1.64364 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & -1.62144 + x & " Y" & 1.45524 + y & " I" & -1.07346 + x & " J" & 0.811353 + y)
        file.WriteLine("G03 X" & -1.62831 + x & " Y" & 0.25797 + y & " I" & -1.109466 + x & " J" & 0.853653 + y)
        file.WriteLine("G03 X" & -0.36912 + x & " Y" & 0.16851 + y & " I" & -0.939357 + x & " J" & 1.048911 + y)
        file.WriteLine("G03 X" & -0.23838 + x & " Y" & 1.4208 + y & " I" & -0.808821 + x & " J" & 0.847383 + y)
        file.WriteLine("G03 X" & -0.61683 + x & " Y" & 1.64361 + y & " I" & -0.86262 + x & " J" & 0.793293 + y)
        file.WriteLine("G01 X" & -1.22235 + x & " Y" & 1.64361 + y & " I" & -0 + x & " J" & 0 + y)
        file.WriteLine("G02 X" & -1.58016 + x & " Y" & 1.81302 + y & " I" & -1.120593 + x & " J" & 2.321094 + y)
        file.WriteLine("G02 X" & -1.58703 + x & " Y" & 2.74881 + y & " I" & -1.154103 + x & " J" & 2.284068 + y)
        file.WriteLine("G02 X" & -0.34161 + x & " Y" & 2.77632 + y & " I" & -0.948882 + x & " J" & 2.063802 + y)
        file.WriteLine("G02 X" & -0.29343 + x & " Y" & 1.81302 + y & " I" & -0.771447 + x & " J" & 2.271972 + y)
        file.WriteLine("G02 X" & -0.61683 + x & " Y" & 1.64361 + y & " I" & -0.708006 + x & " J" & 2.211075 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.9004 & " Y" & y + 0)

        file.Close()

        'End If


    End Sub


    Private Sub Zero9(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = 9) Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -0.03729 + x & " Y" & 0.47013 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -0.4575 + x & " Y" & 0.07734 + y & " I" & -0.848679 + x & " J" & 0.916992 + y)
        file.WriteLine("G02 X" & -1.3785 + x & " Y" & 0.22968 + y & " I" & -0.806637 + x & " J" & 0.826743 + y)
        file.WriteLine("G02 X" & -1.69704 + x & " Y" & 0.79752 + y & " I" & -0.605835 + x & " J" & 1.036389 + y)
        file.WriteLine("G02 X" & -1.74552 + x & " Y" & 2.29329 + y & " I" & 2.317215 + x & " J" & 1.676277 + y)
        file.WriteLine("G02 X" & -1.33002 + x & " Y" & 2.88882 + y & " I" & -0.934419 + x & " J" & 2.17011 + y)
        file.WriteLine("G02 X" & -0.08355 + x & " Y" & 2.48025 + y & " I" & -0.897429 + x & " J" & 2.102928 + y)
        file.WriteLine("G02 X" & -0.65832 + x & " Y" & 1.23378 + y & " I" & -0.900807 + x & " J" & 2.10135 + y)
        file.WriteLine("G02 X" & -1.7769 + x & " Y" & 2.02926 + y & " I" & -0.895932 + x & " J" & 2.083863 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.7804 & " Y" & y + 0)

        file.Close()

        'End If

    End Sub

    Private Sub R(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)


        'If (nigga = "R") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.02801 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & -1.02801 + x & " Y" & 1.5 + y & " I" & -1.02801 + x & " J" & 2.25 + y)
        file.WriteLine("G01 X" & 0 + x & " Y" & 1.5 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -0.9 + x & " Y" & 1.5 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & -1.53687 + x & " Y" & 0.93792 + y & " I" & -0.852954 + x & " J" & 0.804864 + y)
        file.WriteLine("G01 X" & -1.64415 + x & " Y" & 0.38658 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G02 X" & -1.80003 + x & " Y" & 0 + y & " I" & -2.72127 + x & " J" & 0.596151 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.7803 & " Y" & y + 0)

        file.Close()

        'End If

    End Sub

    Private Sub S(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "S") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 X" & -0.00009 + x & " Y" & 0.67524 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G02 X" & -0.28494 + x & " Y" & 0.17355 + y & " I" & -0.567927 + x & " J" & 0.665931 + y)
        file.WriteLine("G02 X" & -1.54962 + x & " Y" & 0.1785 + y & " I" & -0.913011 + x & " J" & 1.266333 + y)
        file.WriteLine("G02 X" & -1.71438 + x & " Y" & 1.24257 + y & " I" & -1.19904 + x & " J" & 0.777576 + y)
        file.WriteLine("G02 X" & -1.18578 + x & " Y" & 1.58583 + y & " I" & -0.806949 + x & " J" & 0.42378 + y)
        file.WriteLine("G02 X" & -0.65718 + x & " Y" & 1.7094 + y & " I" & -0.200553 + x & " J" & -1.436343 + y)
        file.WriteLine("G03 X" & -0.27273 + x & " Y" & 2.60871 + y & " I" & -0.739485 + x & " J" & 2.276412 + y)
        file.WriteLine("G03 X" & -1.50843 + x & " Y" & 2.81466 + y & " I" & -0.993237 + x & " J" & 2.09574 + y)
        file.WriteLine("G03 X" & -1.75557 + x & " Y" & 2.4714 + y & " I" & -1.122618 + x & " J" & 2.27628 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & x + -2.7804 & " Y" & y + 0)

        file.Close()

        'End If

    End Sub

    Private Sub T(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "T") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -0.92331 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -0.92331 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.87218 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.85258 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub U(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "U") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 0.9 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G02 X" & -1.8 + x & " Y" & 0.9 + y & " I" & -0.9 + x & " J" & 0.9 + y)
        file.WriteLine("G02 X" & -1.8 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.7804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub


    Private Sub V(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "V") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.05 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.1 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.0804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub W(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)


        'If (nigga = "W") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -0.675 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.35 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.025 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.7 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.0804 + x & " Y" & 0 + y)

        file.Close()

        'End If
    End Sub

    Private Sub lx(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "X") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -2.1 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -2.1 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.0804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub ly(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "Y") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.05 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.05 + x & " Y" & 1.5 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.05 + x & " Y" & 1.5 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -2.1 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.0804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub Z(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "Z") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -2.1 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.1 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.0804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub A(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "A") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.05 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.1 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -0.34998 + x & " Y" & 0.99999 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.74999 + x & " Y" & 0.99999 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.0804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub B(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "B") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.09902 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & -1.09902 + x & " Y" & 1.65132 + y & " I" & -1.09902 + x & " J" & 2.325654 + y)
        file.WriteLine("G01 X" & -0.00003 + x & " Y" & 1.65132 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.09893 + x & " Y" & 1.65132 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G03 X" & -1.10448 + x & " Y" & 0 + y & " I" & -1.104477 + x & " J" & 0.825675 + y)
        file.WriteLine("G01 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.91054 + x & " Y" & 0 + y)

        file.Close()

        'End If


    End Sub

    Private Sub C(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)


        'If (nigga = "C") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.10774 + x & " Y" & 0.43869 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G03 X" & -1.55181 + x & " Y" & 0.05328 + y & " I" & -1.194018 + x & " J" & 1.163064 + y)
        file.WriteLine("G03 X" & -0.26562 + x & " Y" & 0.53601 + y & " I" & -1.212795 + x & " J" & 1.104828 + y)
        file.WriteLine("G03 X" & -0.3195 + x & " Y" & 2.53698 + y & " I" & -1.86129 + x & " J" & 1.494252 + y)
        file.WriteLine("G03 X" & -1.52778 + x & " Y" & 2.94486 + y & " I" & -1.191582 + x & " J" & 1.94719 + y)
        file.WriteLine("G03 X" & -2.00493 + x & " Y" & 2.61393 + y & " I" & -1.193874 + x & " J" & 1.953966 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.08814 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub
    Private Sub D(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "D") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 2.99994 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -0.61872 + x & " Y" & 2.99994 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & -1.39539 + x & " Y" & 2.68443 + y & " I" & -0.61872 + x & " J" & 1.886211 + y)
        file.WriteLine("G03 X" & -1.26924 + x & " Y" & 0.2643 + y & " I" & -0.271761 + x & " J" & 1.529646 + y)
        file.WriteLine("G03 X" & -0.50697 + x & " Y" & 0 + y & " I" & -0.506976 + x & " J" & 1.231242 + y)
        file.WriteLine("G01 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.8704 + x & " Y" & 0 + y)

        file.Close()

        'End If
    End Sub

    Private Sub E(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "E") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.8 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.8 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 1.51374 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.15263 + x & " Y" & 1.51374 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.7804 + x & " Y" & 0 + y)

        file.Close()

        'End If
    End Sub

    Private Sub F(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "F") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.68216 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 1.5 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.09506 + x & " Y" & 1.5 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.66256 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub G(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "G") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.24842 + x & " Y" & 1.23645 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -2.12013 + x & " Y" & 1.23645 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.12013 + x & " Y" & 0.76914 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & -1.69257 + x & " Y" & 0.15168 + y & " I" & -1.148937 + x & " J" & 0.984888 + y)
        file.WriteLine("G03 X" & -0.53016 + x & " Y" & 0.26577 + y & " I" & -1.182498 + x & " J" & 0.93345 + y)
        file.WriteLine("G03 X" & -0.30771 + x & " Y" & 2.51931 + y & " I" & -1.760439 + x & " J" & 1.524945 + y)
        file.WriteLine("G03 X" & -1.29897 + x & " Y" & 2.99712 + y & " I" & -1.219233 + x & " J" & 1.895394 + y)
        file.WriteLine("G03 X" & -2.02638 + x & " Y" & 2.51931 + y & " I" & -1.234497 + x & " J" & 2.106369 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.10053 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub H(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "H") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 1.5 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.8 + x & " Y" & 1.5 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.8 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.8 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.7804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub I(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "I") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -0.9804 + x & " Y" & 0 + y)

        file.Close()
        'End If

    End Sub

    Private Sub J(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "J") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.52715 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.52715 + x & " Y" & 0.76365 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & 0 + x & " Y" & 0.76365 + y & " I" & -0.763581 + x & " J" & 0.76365 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.50755 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub K(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "K") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 1.10526 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.80687 + x & " Y" & 3.06177 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -0.5421 + x & " Y" & 1.69227 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.8 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.78727 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub L(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "L") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.59768 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.57808 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub M(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "M") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.2 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.4 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.4 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.3804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub N(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "N") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.1 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -2.1 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.0804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub O(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "O") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.81158 + x & " Y" & 0.31809 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G03 X" & -0.43485 + x & " Y" & 0.31809 + y & " I" & -1.123218 + x & " J" & 0.903915 + y)
        file.WriteLine("G03 X" & -0.43485 + x & " Y" & 2.682 + y & " I" & -1.823688 + x & " J" & 1.500048 + y)
        file.WriteLine("G03 X" & -1.81128 + x & " Y" & 2.682 + y & " I" & -1.123062 + x & " J" & 2.096304 + y)
        file.WriteLine("G03 X" & -1.81128 + x & " Y" & 0.31809 + y & " I" & -0.422442 + x & " J" & 1.500039 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.2304 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub P(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "P") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & 0 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.05 + x & " Y" & 3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & -1.05 + x & " Y" & 1.5 + y & " I" & -1.05 + x & " J" & 2.25 + y)
        file.WriteLine("G01 X" & 0 + x & " Y" & 1.5 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.7804 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub

    Private Sub Q(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "Q") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.14956 + x & " Y" & 0 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & -1.17354 + x & " Y" & 0.58407 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G01 X" & -1.75173 + x & " Y" & 0.23841 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G03 X" & -0.45033 + x & " Y" & 0.32061 + y & " I" & -1.142454 + x & " J" & 0.935568 + y)
        file.WriteLine("G03 X" & -0.45033 + x & " Y" & 2.69013 + y & " I" & -1.783743 + x & " J" & 1.505367 + y)
        file.WriteLine("G03 X" & -1.83 + x & " Y" & 2.69013 + y & " I" & -1.140171 + x & " J" & 2.077197 + y)
        file.WriteLine("G03 X" & -1.75113 + x & " Y" & 0.23844 + y & " I" & -0.497169 + x & " J" & 1.505889 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -3.2904 + x & " Y" & 0 + y)

        file.Close()

        'End If

    End Sub


    Private Sub Slash(ByVal x As Decimal, ByVal y As Decimal, ByVal up As Decimal, ByVal down As Decimal)

        'If (nigga = "Q") Then
        Dim FILE_NAME As String = "1.txt"
        Dim file As StreamWriter

        file = My.Computer.FileSystem.OpenTextFileWriter(FILE_NAME, True, utf8WithoutBom)


        file.WriteLine("G21")

        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 G90 X" & x & "Y" & y)
        file.WriteLine("F2400")
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -1.5 + x & " Y" & 3.3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & down)
        file.WriteLine("G01 Z" & down)
        file.WriteLine("G01 X" & 0 + x & " Y" & -0.3 + y & " I" & 0 + x & " J" & 0 + y)
        file.WriteLine("G00 Z" & up)
        file.WriteLine("G00 X" & -2.4804 + x & " Y" & 0 + y)

        file.Close()

    End Sub

End Module

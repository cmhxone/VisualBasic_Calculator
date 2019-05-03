Public Class MainForm
    Private Function ConvPostfix(formular As String) As ArrayList ' 인자로 전달받은 수식을 후위표현식으로 반환해주는 함수
        Dim charArr = formular.ToCharArray()    ' charArr 변수에 수식을 CharArray 값으로 변환한 값을 할당한다
        Dim postfixArr = New ArrayList()    ' 후위식을 담을 ArrayList 객체의 생성
        Dim brackList = New ArrayList()
        Dim operatorStack = New Stack()     ' 연산자를 담을 Stack 객체의 생성

        ' 입력 식의 길이값-1(마지막 인덱스) 까지 반복한다
        For i = 0 To charArr.Length - 1
            ' 숫자의 경우 ArrayList에 바로 추가한다
            If charArr(i) Like "[0-9]" Then
                If i <> 0 Then
                    If charArr(i - 1) Like "[0-9]" Then
                        postfixArr(postfixArr.ToArray.Length - 1) *= 10
                        postfixArr(postfixArr.ToArray.Length - 1) += CInt(CStr(charArr(i)))
                    Else
                        postfixArr.Add(CInt(CStr(charArr(i))))
                    End If
                Else
                    postfixArr.Add(CInt(CStr(charArr(i))))
                End If
            Else    ' 연산자의 경우 연산자 우선순위에 따라 후위표현식으로 변환하여 준다
                    Select Case charArr(i)
                    Case "+"
                        If operatorStack.ToArray.Length <> 0 Then
                            If operatorStack.Peek() = "(" Then
                                operatorStack.Push(charArr(i))
                            Else
                                For j = 0 To operatorStack.ToArray.Length - 1
                                    postfixArr.Add(operatorStack.Pop())
                                Next
                                operatorStack.Push(charArr(i))
                            End If
                        Else
                                operatorStack.Push(charArr(i))
                        End If

                    Case "-"
                        If operatorStack.ToArray.Length <> 0 Then
                            If operatorStack.Peek() = "(" Then
                                operatorStack.Push(charArr(i))
                            Else
                                For j = 0 To operatorStack.ToArray.Length - 1
                                    postfixArr.Add(operatorStack.Pop())
                                Next
                                operatorStack.Push(charArr(i))
                            End If
                        Else
                            operatorStack.Push(charArr(i))
                        End If

                    Case "/"
                        If operatorStack.ToArray.Length <> 0 Then
                            If operatorStack.Peek() = "+" Or operatorStack.Peek() = "-" Or operatorStack.Peek() = "(" Then
                                operatorStack.Push(charArr(i))
                            Else
                                For j = 0 To operatorStack.ToArray.Length - 1
                                    postfixArr.Add(operatorStack.Pop())
                                Next
                                operatorStack.Push(charArr(i))
                            End If
                        Else
                            operatorStack.Push(charArr(i))
                        End If

                    Case "*"
                        If operatorStack.ToArray.Length <> 0 Then
                            If operatorStack.Peek() = "+" Or operatorStack.Peek() = "-" Or operatorStack.Peek() = "(" Then
                                operatorStack.Push(charArr(i))
                            Else
                                For j = 0 To operatorStack.ToArray.Length - 1
                                    postfixArr.Add(operatorStack.Pop())
                                Next
                                operatorStack.Push(charArr(i))
                            End If
                        Else
                            operatorStack.Push(charArr(i))
                        End If

                    Case "("
                        operatorStack.Push(charArr(i))

                    Case ")"
                        If operatorStack.ToArray.Length > 0 Then
                            Do
                                If operatorStack.Peek() = "(" Then
                                    operatorStack.Pop()
                                    Exit Do
                                Else
                                    postfixArr.Add(operatorStack.Pop())
                                End If
                            Loop

                        End If
                End Select
            End If
        Next

        ' 스택에 남아있는 연산자를 모두 postfixArr에 넣어준다
        If operatorStack.ToArray.Length <> 0 Then
            For i = 0 To operatorStack.ToArray().Length - 1
                postfixArr.Add(operatorStack.Pop())
            Next
        End If

        ConvPostfix = postfixArr ' 리턴 문
    End Function

    ' 인자로 전달받은 후위식을 연산하는 함수
    Private Function CalcPostfix(postfixFormular As ArrayList) As Integer
        Dim result = 0
        Dim index = 0

        ' 후위식의 길이가 3 이상인 경우 ArrayList의 값들을 비교해 연산자인경우 수식을 계산한다
        If postfixFormular.ToArray().Length >= 3 Then
            Do
                If index < postfixFormular.ToArray().Length Then
                    Select Case CStr(postfixFormular(index))
                        Case "+"
                            postfixFormular(index - 2) = postfixFormular(index - 2) + postfixFormular(index - 1)
                            postfixFormular.RemoveAt(index)
                            postfixFormular.RemoveAt(index - 1)
                            index -= 2
                        Case "-"
                            postfixFormular(index - 2) = postfixFormular(index - 2) - postfixFormular(index - 1)
                            postfixFormular.RemoveAt(index)
                            postfixFormular.RemoveAt(index - 1)
                            index -= 2
                        Case "/"
                            postfixFormular(index - 2) = postfixFormular(index - 2) / postfixFormular(index - 1)
                            postfixFormular.RemoveAt(index)
                            postfixFormular.RemoveAt(index - 1)
                            index -= 2
                        Case "*"
                            postfixFormular(index - 2) = postfixFormular(index - 2) * postfixFormular(index - 1)
                            postfixFormular.RemoveAt(index)
                            postfixFormular.RemoveAt(index - 1)
                            index -= 2
                    End Select
                Else
                    Exit Do
                End If

                index += 1
            Loop

            result = postfixFormular(0) ' 루프가 끝나면 결과값에 계산식의 첫번째 인덱스를 저장한다
        ElseIf postfixFormular.ToArray().Length <> 0 Then   ' 계산식이 짧은경우 숫자를 찾아내서 결과값에 대입한다
            For i = 0 To postfixFormular.ToArray().Length - 1
                Select Case CStr(postfixFormular(i))
                    Case "+"
                    Case "-"
                    Case "*"
                    Case "/"
                    Case Else
                        result = postfixFormular(i)
                End Select
            Next
        End If

        CalcPostfix = result ' 리턴 문
    End Function

    ' 숫자버튼을 누르는 경우 숫자를 텍스트박스에 입력하는 기능 구현
    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        tb_result.Text += "0"
    End Sub
    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        tb_result.Text += "1"
    End Sub
    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        tb_result.Text += "2"
    End Sub
    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        tb_result.Text += "3"
    End Sub
    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        tb_result.Text += "4"
    End Sub
    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        tb_result.Text += "5"
    End Sub
    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        tb_result.Text += "6"
    End Sub
    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        tb_result.Text += "7"
    End Sub
    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        tb_result.Text += "8"
    End Sub
    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        tb_result.Text += "9"
    End Sub

    ' 각 연산 기호를 입력 시 텍스트 박스에 추가하는 기능 구현
    Private Sub btn_multiply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click
        tb_result.Text += "*"
    End Sub
    Private Sub btn_divide_Click(sender As Object, e As EventArgs) Handles btn_divide.Click
        tb_result.Text += "/"
    End Sub
    Private Sub btn_sum_Click(sender As Object, e As EventArgs) Handles btn_sum.Click
        tb_result.Text += "+"
    End Sub
    Private Sub btn_sub_Click(sender As Object, e As EventArgs) Handles btn_sub.Click
        tb_result.Text += "-"
    End Sub
    Private Sub btn_left_brac_Click(sender As Object, e As EventArgs) Handles btn_left_brac.Click
        tb_result.Text += "("
    End Sub
    Private Sub btn_right_brac_Click(sender As Object, e As EventArgs) Handles btn_right_brac.Click
        tb_result.Text += ")"
    End Sub

    ' 지우기 버튼과 수정버튼을 누르는 경우 텍스트를 삭제하는 기능 구현
    Private Sub btn_backspace_Click(sender As Object, e As EventArgs) Handles btn_backspace.Click
        Dim temp = tb_result.Text.ToCharArray()
        tb_result.Text = ""

        For i = 0 To temp.Length - 2
            tb_result.Text += temp(i)
        Next
    End Sub
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        tb_result.Text = ""
    End Sub

    ' 결과값 출력 버튼을 누르는 경우 결과 값을 레이블에 표시해주는 기능 구현
    Private Sub btn_result_Click(sender As Object, e As EventArgs) Handles btn_result.Click
        Dim postfixArr = ConvPostfix(tb_result.Text)
        lb_postfix.Text = "입력식 : " + tb_result.Text + vbCrLf
        lb_postfix.Text += "후위식 : "

        tb_result.Text = ""

        For j = 0 To postfixArr.ToArray().Length - 1
            lb_postfix.Text += CStr(postfixArr(j)) + " "
        Next

        tb_result.Text = CStr(CalcPostfix(postfixArr))
    End Sub

End Class

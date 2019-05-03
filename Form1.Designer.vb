<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tb_result = New System.Windows.Forms.TextBox()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_7 = New System.Windows.Forms.Button()
        Me.btn_8 = New System.Windows.Forms.Button()
        Me.btn_backspace = New System.Windows.Forms.Button()
        Me.btn_divide = New System.Windows.Forms.Button()
        Me.btn_9 = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.btn_4 = New System.Windows.Forms.Button()
        Me.btn_5 = New System.Windows.Forms.Button()
        Me.btn_6 = New System.Windows.Forms.Button()
        Me.btn_sum = New System.Windows.Forms.Button()
        Me.btn_1 = New System.Windows.Forms.Button()
        Me.btn_2 = New System.Windows.Forms.Button()
        Me.btn_3 = New System.Windows.Forms.Button()
        Me.btn_sub = New System.Windows.Forms.Button()
        Me.btn_0 = New System.Windows.Forms.Button()
        Me.btn_left_brac = New System.Windows.Forms.Button()
        Me.btn_right_brac = New System.Windows.Forms.Button()
        Me.btn_result = New System.Windows.Forms.Button()
        Me.lb_postfix = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tb_result
        '
        Me.tb_result.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.tb_result.Location = New System.Drawing.Point(12, 12)
        Me.tb_result.Name = "tb_result"
        Me.tb_result.ReadOnly = True
        Me.tb_result.Size = New System.Drawing.Size(218, 30)
        Me.tb_result.TabIndex = 0
        Me.tb_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_clear
        '
        Me.btn_clear.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_clear.Location = New System.Drawing.Point(12, 48)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(106, 50)
        Me.btn_clear.TabIndex = 1
        Me.btn_clear.Text = "C"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_7
        '
        Me.btn_7.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_7.Location = New System.Drawing.Point(12, 104)
        Me.btn_7.Name = "btn_7"
        Me.btn_7.Size = New System.Drawing.Size(50, 50)
        Me.btn_7.TabIndex = 1
        Me.btn_7.Text = "7"
        Me.btn_7.UseVisualStyleBackColor = True
        '
        'btn_8
        '
        Me.btn_8.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_8.Location = New System.Drawing.Point(68, 104)
        Me.btn_8.Name = "btn_8"
        Me.btn_8.Size = New System.Drawing.Size(50, 50)
        Me.btn_8.TabIndex = 1
        Me.btn_8.Text = "8"
        Me.btn_8.UseVisualStyleBackColor = True
        '
        'btn_backspace
        '
        Me.btn_backspace.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_backspace.Location = New System.Drawing.Point(124, 48)
        Me.btn_backspace.Name = "btn_backspace"
        Me.btn_backspace.Size = New System.Drawing.Size(50, 50)
        Me.btn_backspace.TabIndex = 1
        Me.btn_backspace.Text = "<-"
        Me.btn_backspace.UseVisualStyleBackColor = True
        '
        'btn_divide
        '
        Me.btn_divide.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_divide.Location = New System.Drawing.Point(180, 48)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(50, 50)
        Me.btn_divide.TabIndex = 1
        Me.btn_divide.Text = "/"
        Me.btn_divide.UseVisualStyleBackColor = True
        '
        'btn_9
        '
        Me.btn_9.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_9.Location = New System.Drawing.Point(124, 104)
        Me.btn_9.Name = "btn_9"
        Me.btn_9.Size = New System.Drawing.Size(50, 50)
        Me.btn_9.TabIndex = 1
        Me.btn_9.Text = "9"
        Me.btn_9.UseVisualStyleBackColor = True
        '
        'btn_multiply
        '
        Me.btn_multiply.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_multiply.Location = New System.Drawing.Point(180, 104)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(50, 50)
        Me.btn_multiply.TabIndex = 1
        Me.btn_multiply.Text = "*"
        Me.btn_multiply.UseVisualStyleBackColor = True
        '
        'btn_4
        '
        Me.btn_4.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_4.Location = New System.Drawing.Point(12, 160)
        Me.btn_4.Name = "btn_4"
        Me.btn_4.Size = New System.Drawing.Size(50, 50)
        Me.btn_4.TabIndex = 1
        Me.btn_4.Text = "4"
        Me.btn_4.UseVisualStyleBackColor = True
        '
        'btn_5
        '
        Me.btn_5.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_5.Location = New System.Drawing.Point(68, 160)
        Me.btn_5.Name = "btn_5"
        Me.btn_5.Size = New System.Drawing.Size(50, 50)
        Me.btn_5.TabIndex = 1
        Me.btn_5.Text = "5"
        Me.btn_5.UseVisualStyleBackColor = True
        '
        'btn_6
        '
        Me.btn_6.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_6.Location = New System.Drawing.Point(124, 160)
        Me.btn_6.Name = "btn_6"
        Me.btn_6.Size = New System.Drawing.Size(50, 50)
        Me.btn_6.TabIndex = 1
        Me.btn_6.Text = "6"
        Me.btn_6.UseVisualStyleBackColor = True
        '
        'btn_sum
        '
        Me.btn_sum.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_sum.Location = New System.Drawing.Point(180, 160)
        Me.btn_sum.Name = "btn_sum"
        Me.btn_sum.Size = New System.Drawing.Size(50, 50)
        Me.btn_sum.TabIndex = 1
        Me.btn_sum.Text = "+"
        Me.btn_sum.UseVisualStyleBackColor = True
        '
        'btn_1
        '
        Me.btn_1.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_1.Location = New System.Drawing.Point(12, 216)
        Me.btn_1.Name = "btn_1"
        Me.btn_1.Size = New System.Drawing.Size(50, 50)
        Me.btn_1.TabIndex = 1
        Me.btn_1.Text = "1"
        Me.btn_1.UseVisualStyleBackColor = True
        '
        'btn_2
        '
        Me.btn_2.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_2.Location = New System.Drawing.Point(68, 216)
        Me.btn_2.Name = "btn_2"
        Me.btn_2.Size = New System.Drawing.Size(50, 50)
        Me.btn_2.TabIndex = 1
        Me.btn_2.Text = "2"
        Me.btn_2.UseVisualStyleBackColor = True
        '
        'btn_3
        '
        Me.btn_3.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_3.Location = New System.Drawing.Point(124, 216)
        Me.btn_3.Name = "btn_3"
        Me.btn_3.Size = New System.Drawing.Size(50, 50)
        Me.btn_3.TabIndex = 1
        Me.btn_3.Text = "3"
        Me.btn_3.UseVisualStyleBackColor = True
        '
        'btn_sub
        '
        Me.btn_sub.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_sub.Location = New System.Drawing.Point(180, 216)
        Me.btn_sub.Name = "btn_sub"
        Me.btn_sub.Size = New System.Drawing.Size(50, 50)
        Me.btn_sub.TabIndex = 1
        Me.btn_sub.Text = "-"
        Me.btn_sub.UseVisualStyleBackColor = True
        '
        'btn_0
        '
        Me.btn_0.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_0.Location = New System.Drawing.Point(12, 272)
        Me.btn_0.Name = "btn_0"
        Me.btn_0.Size = New System.Drawing.Size(50, 50)
        Me.btn_0.TabIndex = 1
        Me.btn_0.Text = "0"
        Me.btn_0.UseVisualStyleBackColor = True
        '
        'btn_left_brac
        '
        Me.btn_left_brac.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_left_brac.Location = New System.Drawing.Point(68, 272)
        Me.btn_left_brac.Name = "btn_left_brac"
        Me.btn_left_brac.Size = New System.Drawing.Size(50, 50)
        Me.btn_left_brac.TabIndex = 1
        Me.btn_left_brac.Text = "("
        Me.btn_left_brac.UseVisualStyleBackColor = True
        '
        'btn_right_brac
        '
        Me.btn_right_brac.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_right_brac.Location = New System.Drawing.Point(124, 272)
        Me.btn_right_brac.Name = "btn_right_brac"
        Me.btn_right_brac.Size = New System.Drawing.Size(50, 50)
        Me.btn_right_brac.TabIndex = 1
        Me.btn_right_brac.Text = ")"
        Me.btn_right_brac.UseVisualStyleBackColor = True
        '
        'btn_result
        '
        Me.btn_result.Font = New System.Drawing.Font("휴먼둥근헤드라인", 15.0!)
        Me.btn_result.Location = New System.Drawing.Point(180, 272)
        Me.btn_result.Name = "btn_result"
        Me.btn_result.Size = New System.Drawing.Size(50, 50)
        Me.btn_result.TabIndex = 1
        Me.btn_result.Text = "="
        Me.btn_result.UseVisualStyleBackColor = True
        '
        'lb_postfix
        '
        Me.lb_postfix.AutoSize = True
        Me.lb_postfix.Location = New System.Drawing.Point(236, 12)
        Me.lb_postfix.Name = "lb_postfix"
        Me.lb_postfix.Size = New System.Drawing.Size(42, 12)
        Me.lb_postfix.TabIndex = 2
        Me.lb_postfix.Text = "Label1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 334)
        Me.Controls.Add(Me.lb_postfix)
        Me.Controls.Add(Me.btn_result)
        Me.Controls.Add(Me.btn_sub)
        Me.Controls.Add(Me.btn_sum)
        Me.Controls.Add(Me.btn_multiply)
        Me.Controls.Add(Me.btn_right_brac)
        Me.Controls.Add(Me.btn_3)
        Me.Controls.Add(Me.btn_6)
        Me.Controls.Add(Me.btn_9)
        Me.Controls.Add(Me.btn_divide)
        Me.Controls.Add(Me.btn_backspace)
        Me.Controls.Add(Me.btn_left_brac)
        Me.Controls.Add(Me.btn_2)
        Me.Controls.Add(Me.btn_5)
        Me.Controls.Add(Me.btn_8)
        Me.Controls.Add(Me.btn_0)
        Me.Controls.Add(Me.btn_1)
        Me.Controls.Add(Me.btn_4)
        Me.Controls.Add(Me.btn_7)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.tb_result)
        Me.Name = "MainForm"
        Me.Text = "Postfix Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_result As TextBox
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_7 As Button
    Friend WithEvents btn_8 As Button
    Friend WithEvents btn_backspace As Button
    Friend WithEvents btn_divide As Button
    Friend WithEvents btn_9 As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents btn_4 As Button
    Friend WithEvents btn_5 As Button
    Friend WithEvents btn_6 As Button
    Friend WithEvents btn_sum As Button
    Friend WithEvents btn_1 As Button
    Friend WithEvents btn_2 As Button
    Friend WithEvents btn_3 As Button
    Friend WithEvents btn_sub As Button
    Friend WithEvents btn_0 As Button
    Friend WithEvents btn_left_brac As Button
    Friend WithEvents btn_right_brac As Button
    Friend WithEvents btn_result As Button
    Friend WithEvents lb_postfix As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class istasyon_is_durumu
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
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

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Bos_Kasa_Kapi_Btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CNV_Btn = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Kapi6V_Text = New System.Windows.Forms.TextBox()
        Me.Kapi5V_Text = New System.Windows.Forms.TextBox()
        Me.Kapi4V_Text = New System.Windows.Forms.TextBox()
        Me.Kapi3V_Text = New System.Windows.Forms.TextBox()
        Me.Kapi2V_Text = New System.Windows.Forms.TextBox()
        Me.Kapi1V_Text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Kapi_Button6 = New System.Windows.Forms.Button()
        Me.Kapi_Button5 = New System.Windows.Forms.Button()
        Me.Kapi_Button4 = New System.Windows.Forms.Button()
        Me.Kapi_Button3 = New System.Windows.Forms.Button()
        Me.Kapi_Button2 = New System.Windows.Forms.Button()
        Me.Kapi_Button1 = New System.Windows.Forms.Button()
        Me.Kapi6_Text = New System.Windows.Forms.TextBox()
        Me.Kapi5_Text = New System.Windows.Forms.TextBox()
        Me.Kapi4_Text = New System.Windows.Forms.TextBox()
        Me.Kapi3_Text = New System.Windows.Forms.TextBox()
        Me.Kapi2_Text = New System.Windows.Forms.TextBox()
        Me.Kapi1_Text = New System.Windows.Forms.TextBox()
        Me.Bos_Kasa_Tamami_Hazir_Btn = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PLCHazir_Aciklama_Combo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Plc_Grv_Drm_Degistir_Btn = New System.Windows.Forms.Button()
        Me.Plc_istasyon_Durumu_Text = New System.Windows.Forms.TextBox()
        Me.CNV_Tamami_Hazir_Btn = New System.Windows.Forms.Button()
        Me.BTN_kapat = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bos_Kasa_Kapi_Btn
        '
        Me.Bos_Kasa_Kapi_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Bos_Kasa_Kapi_Btn.Location = New System.Drawing.Point(52, 92)
        Me.Bos_Kasa_Kapi_Btn.Name = "Bos_Kasa_Kapi_Btn"
        Me.Bos_Kasa_Kapi_Btn.Size = New System.Drawing.Size(175, 38)
        Me.Bos_Kasa_Kapi_Btn.TabIndex = 0
        Me.Bos_Kasa_Kapi_Btn.Text = "Boş Kasa Kapıları"
        Me.Bos_Kasa_Kapi_Btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(190, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 29)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Örgü Robot Programı"
        '
        'CNV_Btn
        '
        Me.CNV_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CNV_Btn.Location = New System.Drawing.Point(52, 136)
        Me.CNV_Btn.Name = "CNV_Btn"
        Me.CNV_Btn.Size = New System.Drawing.Size(175, 38)
        Me.CNV_Btn.TabIndex = 146
        Me.CNV_Btn.Text = "Konveyorler"
        Me.CNV_Btn.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Kapi6V_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi5V_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi4V_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi3V_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi2V_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi1V_Text)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Kapi_Button6)
        Me.GroupBox1.Controls.Add(Me.Kapi_Button5)
        Me.GroupBox1.Controls.Add(Me.Kapi_Button4)
        Me.GroupBox1.Controls.Add(Me.Kapi_Button3)
        Me.GroupBox1.Controls.Add(Me.Kapi_Button2)
        Me.GroupBox1.Controls.Add(Me.Kapi_Button1)
        Me.GroupBox1.Controls.Add(Me.Kapi6_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi5_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi4_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi3_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi2_Text)
        Me.GroupBox1.Controls.Add(Me.Kapi1_Text)
        Me.GroupBox1.Controls.Add(Me.Bos_Kasa_Tamami_Hazir_Btn)
        Me.GroupBox1.Location = New System.Drawing.Point(246, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 265)
        Me.GroupBox1.TabIndex = 147
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(279, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 162
        Me.Label7.Text = "İşVar/Yok"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(167, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 13)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "KasaVar/Yok"
        '
        'Kapi6V_Text
        '
        Me.Kapi6V_Text.Location = New System.Drawing.Point(153, 220)
        Me.Kapi6V_Text.Name = "Kapi6V_Text"
        Me.Kapi6V_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi6V_Text.TabIndex = 160
        '
        'Kapi5V_Text
        '
        Me.Kapi5V_Text.Location = New System.Drawing.Point(153, 194)
        Me.Kapi5V_Text.Name = "Kapi5V_Text"
        Me.Kapi5V_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi5V_Text.TabIndex = 159
        '
        'Kapi4V_Text
        '
        Me.Kapi4V_Text.Location = New System.Drawing.Point(153, 168)
        Me.Kapi4V_Text.Name = "Kapi4V_Text"
        Me.Kapi4V_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi4V_Text.TabIndex = 158
        '
        'Kapi3V_Text
        '
        Me.Kapi3V_Text.Location = New System.Drawing.Point(153, 142)
        Me.Kapi3V_Text.Name = "Kapi3V_Text"
        Me.Kapi3V_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi3V_Text.TabIndex = 157
        '
        'Kapi2V_Text
        '
        Me.Kapi2V_Text.Location = New System.Drawing.Point(153, 116)
        Me.Kapi2V_Text.Name = "Kapi2V_Text"
        Me.Kapi2V_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi2V_Text.TabIndex = 156
        '
        'Kapi1V_Text
        '
        Me.Kapi1V_Text.Location = New System.Drawing.Point(153, 90)
        Me.Kapi1V_Text.Name = "Kapi1V_Text"
        Me.Kapi1V_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi1V_Text.TabIndex = 155
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 15)
        Me.Label2.TabIndex = 154
        Me.Label2.Text = "Boş Kasa Kapıları"
        '
        'Kapi_Button6
        '
        Me.Kapi_Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kapi_Button6.Location = New System.Drawing.Point(33, 219)
        Me.Kapi_Button6.Name = "Kapi_Button6"
        Me.Kapi_Button6.Size = New System.Drawing.Size(113, 20)
        Me.Kapi_Button6.TabIndex = 153
        Me.Kapi_Button6.Text = "6. Kapı"
        Me.Kapi_Button6.UseVisualStyleBackColor = True
        '
        'Kapi_Button5
        '
        Me.Kapi_Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kapi_Button5.Location = New System.Drawing.Point(33, 194)
        Me.Kapi_Button5.Name = "Kapi_Button5"
        Me.Kapi_Button5.Size = New System.Drawing.Size(113, 20)
        Me.Kapi_Button5.TabIndex = 152
        Me.Kapi_Button5.Text = "5. Kapı"
        Me.Kapi_Button5.UseVisualStyleBackColor = True
        '
        'Kapi_Button4
        '
        Me.Kapi_Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kapi_Button4.Location = New System.Drawing.Point(33, 167)
        Me.Kapi_Button4.Name = "Kapi_Button4"
        Me.Kapi_Button4.Size = New System.Drawing.Size(113, 20)
        Me.Kapi_Button4.TabIndex = 151
        Me.Kapi_Button4.Text = "4. Kapı"
        Me.Kapi_Button4.UseVisualStyleBackColor = True
        '
        'Kapi_Button3
        '
        Me.Kapi_Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kapi_Button3.Location = New System.Drawing.Point(33, 141)
        Me.Kapi_Button3.Name = "Kapi_Button3"
        Me.Kapi_Button3.Size = New System.Drawing.Size(113, 20)
        Me.Kapi_Button3.TabIndex = 150
        Me.Kapi_Button3.Text = "3. Kapı"
        Me.Kapi_Button3.UseVisualStyleBackColor = True
        '
        'Kapi_Button2
        '
        Me.Kapi_Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kapi_Button2.Location = New System.Drawing.Point(33, 115)
        Me.Kapi_Button2.Name = "Kapi_Button2"
        Me.Kapi_Button2.Size = New System.Drawing.Size(113, 20)
        Me.Kapi_Button2.TabIndex = 149
        Me.Kapi_Button2.Text = "2. Kapı"
        Me.Kapi_Button2.UseVisualStyleBackColor = True
        '
        'Kapi_Button1
        '
        Me.Kapi_Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Kapi_Button1.Location = New System.Drawing.Point(33, 90)
        Me.Kapi_Button1.Name = "Kapi_Button1"
        Me.Kapi_Button1.Size = New System.Drawing.Size(113, 20)
        Me.Kapi_Button1.TabIndex = 148
        Me.Kapi_Button1.Text = "1. Kapı"
        Me.Kapi_Button1.UseVisualStyleBackColor = True
        '
        'Kapi6_Text
        '
        Me.Kapi6_Text.Location = New System.Drawing.Point(259, 220)
        Me.Kapi6_Text.Name = "Kapi6_Text"
        Me.Kapi6_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi6_Text.TabIndex = 6
        '
        'Kapi5_Text
        '
        Me.Kapi5_Text.Location = New System.Drawing.Point(259, 194)
        Me.Kapi5_Text.Name = "Kapi5_Text"
        Me.Kapi5_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi5_Text.TabIndex = 5
        '
        'Kapi4_Text
        '
        Me.Kapi4_Text.Location = New System.Drawing.Point(259, 168)
        Me.Kapi4_Text.Name = "Kapi4_Text"
        Me.Kapi4_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi4_Text.TabIndex = 4
        '
        'Kapi3_Text
        '
        Me.Kapi3_Text.Location = New System.Drawing.Point(259, 142)
        Me.Kapi3_Text.Name = "Kapi3_Text"
        Me.Kapi3_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi3_Text.TabIndex = 3
        '
        'Kapi2_Text
        '
        Me.Kapi2_Text.Location = New System.Drawing.Point(259, 116)
        Me.Kapi2_Text.Name = "Kapi2_Text"
        Me.Kapi2_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi2_Text.TabIndex = 2
        '
        'Kapi1_Text
        '
        Me.Kapi1_Text.Location = New System.Drawing.Point(259, 90)
        Me.Kapi1_Text.Name = "Kapi1_Text"
        Me.Kapi1_Text.Size = New System.Drawing.Size(100, 20)
        Me.Kapi1_Text.TabIndex = 1
        '
        'Bos_Kasa_Tamami_Hazir_Btn
        '
        Me.Bos_Kasa_Tamami_Hazir_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Bos_Kasa_Tamami_Hazir_Btn.Location = New System.Drawing.Point(53, 28)
        Me.Bos_Kasa_Tamami_Hazir_Btn.Name = "Bos_Kasa_Tamami_Hazir_Btn"
        Me.Bos_Kasa_Tamami_Hazir_Btn.Size = New System.Drawing.Size(198, 23)
        Me.Bos_Kasa_Tamami_Hazir_Btn.TabIndex = 0
        Me.Bos_Kasa_Tamami_Hazir_Btn.Text = "Tamamını Görev Alabilir Yap"
        Me.Bos_Kasa_Tamami_Hazir_Btn.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PLCHazir_Aciklama_Combo)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Plc_Grv_Drm_Degistir_Btn)
        Me.GroupBox2.Controls.Add(Me.Plc_istasyon_Durumu_Text)
        Me.GroupBox2.Controls.Add(Me.CNV_Tamami_Hazir_Btn)
        Me.GroupBox2.Location = New System.Drawing.Point(246, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 162)
        Me.GroupBox2.TabIndex = 155
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'PLCHazir_Aciklama_Combo
        '
        Me.PLCHazir_Aciklama_Combo.FormattingEnabled = True
        Me.PLCHazir_Aciklama_Combo.Location = New System.Drawing.Point(153, 62)
        Me.PLCHazir_Aciklama_Combo.Name = "PLCHazir_Aciklama_Combo"
        Me.PLCHazir_Aciklama_Combo.Size = New System.Drawing.Size(279, 21)
        Me.PLCHazir_Aciklama_Combo.TabIndex = 157
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 13)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "İstanyon görev durumu"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 13)
        Me.Label4.TabIndex = 155
        Me.Label4.Text = "İstasyon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.Location = New System.Drawing.Point(115, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 154
        Me.Label3.Text = "Konveyörler"
        '
        'Plc_Grv_Drm_Degistir_Btn
        '
        Me.Plc_Grv_Drm_Degistir_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Plc_Grv_Drm_Degistir_Btn.Location = New System.Drawing.Point(70, 116)
        Me.Plc_Grv_Drm_Degistir_Btn.Name = "Plc_Grv_Drm_Degistir_Btn"
        Me.Plc_Grv_Drm_Degistir_Btn.Size = New System.Drawing.Size(209, 20)
        Me.Plc_Grv_Drm_Degistir_Btn.TabIndex = 149
        Me.Plc_Grv_Drm_Degistir_Btn.Text = "Durumu Görev Alabilir Yap"
        Me.Plc_Grv_Drm_Degistir_Btn.UseVisualStyleBackColor = True
        '
        'Plc_istasyon_Durumu_Text
        '
        Me.Plc_istasyon_Durumu_Text.Location = New System.Drawing.Point(152, 90)
        Me.Plc_istasyon_Durumu_Text.Name = "Plc_istasyon_Durumu_Text"
        Me.Plc_istasyon_Durumu_Text.Size = New System.Drawing.Size(100, 20)
        Me.Plc_istasyon_Durumu_Text.TabIndex = 2
        '
        'CNV_Tamami_Hazir_Btn
        '
        Me.CNV_Tamami_Hazir_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.CNV_Tamami_Hazir_Btn.Location = New System.Drawing.Point(53, 28)
        Me.CNV_Tamami_Hazir_Btn.Name = "CNV_Tamami_Hazir_Btn"
        Me.CNV_Tamami_Hazir_Btn.Size = New System.Drawing.Size(198, 23)
        Me.CNV_Tamami_Hazir_Btn.TabIndex = 0
        Me.CNV_Tamami_Hazir_Btn.Text = "Tamamını Görev Alabilir Yap"
        Me.CNV_Tamami_Hazir_Btn.UseVisualStyleBackColor = True
        '
        'BTN_kapat
        '
        Me.BTN_kapat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.BTN_kapat.Location = New System.Drawing.Point(52, 422)
        Me.BTN_kapat.Name = "BTN_kapat"
        Me.BTN_kapat.Size = New System.Drawing.Size(175, 38)
        Me.BTN_kapat.TabIndex = 156
        Me.BTN_kapat.Text = "Kapat"
        Me.BTN_kapat.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(52, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 38)
        Me.Button1.TabIndex = 157
        Me.Button1.Text = "Parametreler"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.Location = New System.Drawing.Point(52, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(175, 38)
        Me.Button2.TabIndex = 158
        Me.Button2.Text = "İstasyon Kasa Sayıları"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(234, 92)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(613, 368)
        Me.DataGridView1.TabIndex = 159
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'istasyon_is_durumu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 502)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_kapat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CNV_Btn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Bos_Kasa_Kapi_Btn)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "istasyon_is_durumu"
        Me.Text = "istasyon_is_durumu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bos_Kasa_Kapi_Btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CNV_Btn As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Bos_Kasa_Tamami_Hazir_Btn As Button
    Friend WithEvents Kapi6_Text As TextBox
    Friend WithEvents Kapi5_Text As TextBox
    Friend WithEvents Kapi4_Text As TextBox
    Friend WithEvents Kapi3_Text As TextBox
    Friend WithEvents Kapi2_Text As TextBox
    Friend WithEvents Kapi1_Text As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Kapi_Button6 As Button
    Friend WithEvents Kapi_Button5 As Button
    Friend WithEvents Kapi_Button4 As Button
    Friend WithEvents Kapi_Button3 As Button
    Friend WithEvents Kapi_Button2 As Button
    Friend WithEvents Kapi_Button1 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Plc_istasyon_Durumu_Text As TextBox
    Friend WithEvents CNV_Tamami_Hazir_Btn As Button
    Friend WithEvents Plc_Grv_Drm_Degistir_Btn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PLCHazir_Aciklama_Combo As ComboBox
    Friend WithEvents BTN_kapat As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Kapi6V_Text As TextBox
    Friend WithEvents Kapi5V_Text As TextBox
    Friend WithEvents Kapi4V_Text As TextBox
    Friend WithEvents Kapi3V_Text As TextBox
    Friend WithEvents Kapi2V_Text As TextBox
    Friend WithEvents Kapi1V_Text As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Timer1 As Timer
End Class

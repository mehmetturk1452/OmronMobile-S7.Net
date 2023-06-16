<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.Btnbaglan = New System.Windows.Forms.Button()
        Me.BaglantiDurumuCheckbox = New System.Windows.Forms.CheckBox()
        Me.BosKasaCikisiIseDonusturtimer = New System.Windows.Forms.Timer(Me.components)
        Me.BaglantiDurumuLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Temizleme = New System.Windows.Forms.Button()
        Me.Tekrar_Aktar_Btn = New System.Windows.Forms.Button()
        Me.İs_Alabilme_Durumu = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IstasyonKapiGuncelleTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timerkon = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(11, 97)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 355)
        Me.PictureBox1.TabIndex = 138
        Me.PictureBox1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(350, 97)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(781, 355)
        Me.DataGridView1.TabIndex = 139
        '
        'btnStop
        '
        Me.btnStop.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.btnStop.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnStop.ForeColor = System.Drawing.Color.Black
        Me.btnStop.Location = New System.Drawing.Point(1052, 50)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(79, 41)
        Me.btnStop.TabIndex = 140
        Me.btnStop.Text = "Kapat"
        Me.btnStop.UseVisualStyleBackColor = False
        '
        'Btnbaglan
        '
        Me.Btnbaglan.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Btnbaglan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Btnbaglan.ForeColor = System.Drawing.Color.Black
        Me.Btnbaglan.Location = New System.Drawing.Point(12, 50)
        Me.Btnbaglan.Name = "Btnbaglan"
        Me.Btnbaglan.Size = New System.Drawing.Size(79, 41)
        Me.Btnbaglan.TabIndex = 141
        Me.Btnbaglan.Text = "Bağlan"
        Me.Btnbaglan.UseVisualStyleBackColor = False
        '
        'BaglantiDurumuCheckbox
        '
        Me.BaglantiDurumuCheckbox.AutoSize = True
        Me.BaglantiDurumuCheckbox.Enabled = False
        Me.BaglantiDurumuCheckbox.Location = New System.Drawing.Point(96, 65)
        Me.BaglantiDurumuCheckbox.Margin = New System.Windows.Forms.Padding(2)
        Me.BaglantiDurumuCheckbox.Name = "BaglantiDurumuCheckbox"
        Me.BaglantiDurumuCheckbox.Size = New System.Drawing.Size(15, 14)
        Me.BaglantiDurumuCheckbox.TabIndex = 142
        Me.BaglantiDurumuCheckbox.UseVisualStyleBackColor = True
        '
        'BosKasaCikisiIseDonusturtimer
        '
        Me.BosKasaCikisiIseDonusturtimer.Interval = 8000
        '
        'BaglantiDurumuLabel
        '
        Me.BaglantiDurumuLabel.AutoSize = True
        Me.BaglantiDurumuLabel.Location = New System.Drawing.Point(121, 65)
        Me.BaglantiDurumuLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.BaglantiDurumuLabel.Name = "BaglantiDurumuLabel"
        Me.BaglantiDurumuLabel.Size = New System.Drawing.Size(0, 13)
        Me.BaglantiDurumuLabel.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.Location = New System.Drawing.Point(300, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 29)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Örgü Robot Programı"
        '
        'Temizleme
        '
        Me.Temizleme.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Temizleme.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Temizleme.ForeColor = System.Drawing.Color.Black
        Me.Temizleme.Location = New System.Drawing.Point(784, 50)
        Me.Temizleme.Name = "Temizleme"
        Me.Temizleme.Size = New System.Drawing.Size(136, 41)
        Me.Temizleme.TabIndex = 145
        Me.Temizleme.Text = "Listeyi Temizle"
        Me.Temizleme.UseVisualStyleBackColor = False
        '
        'Tekrar_Aktar_Btn
        '
        Me.Tekrar_Aktar_Btn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Tekrar_Aktar_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Tekrar_Aktar_Btn.ForeColor = System.Drawing.Color.Black
        Me.Tekrar_Aktar_Btn.Location = New System.Drawing.Point(923, 50)
        Me.Tekrar_Aktar_Btn.Name = "Tekrar_Aktar_Btn"
        Me.Tekrar_Aktar_Btn.Size = New System.Drawing.Size(126, 41)
        Me.Tekrar_Aktar_Btn.TabIndex = 146
        Me.Tekrar_Aktar_Btn.Text = "Tekrar Aktar"
        Me.Tekrar_Aktar_Btn.UseVisualStyleBackColor = False
        '
        'İs_Alabilme_Durumu
        '
        Me.İs_Alabilme_Durumu.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.İs_Alabilme_Durumu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.İs_Alabilme_Durumu.ForeColor = System.Drawing.Color.Black
        Me.İs_Alabilme_Durumu.Location = New System.Drawing.Point(11, 457)
        Me.İs_Alabilme_Durumu.Name = "İs_Alabilme_Durumu"
        Me.İs_Alabilme_Durumu.Size = New System.Drawing.Size(161, 56)
        Me.İs_Alabilme_Durumu.TabIndex = 147
        Me.İs_Alabilme_Durumu.Text = "İstasyonların Görev Durumları"
        Me.İs_Alabilme_Durumu.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(956, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 56)
        Me.Button1.TabIndex = 148
        Me.Button1.Text = "İş Göndermeyi Durdur"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(178, 457)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 56)
        Me.Button2.TabIndex = 149
        Me.Button2.Text = "Çalışan İstasyonları Yeniden Çek"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "Label2"
        '
        'IstasyonKapiGuncelleTimer
        '
        Me.IstasyonKapiGuncelleTimer.Interval = 60000
        '
        'Timerkon
        '
        Me.Timerkon.Interval = 10000
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(911, 457)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 151
        Me.Label3.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 585)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.İs_Alabilme_Durumu)
        Me.Controls.Add(Me.Tekrar_Aktar_Btn)
        Me.Controls.Add(Me.Temizleme)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BaglantiDurumuLabel)
        Me.Controls.Add(Me.BaglantiDurumuCheckbox)
        Me.Controls.Add(Me.Btnbaglan)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Private WithEvents btnStop As Button
    Private WithEvents Btnbaglan As Button
    Friend WithEvents BaglantiDurumuCheckbox As CheckBox
    Friend WithEvents BosKasaCikisiIseDonusturtimer As Timer
    Friend WithEvents BaglantiDurumuLabel As Label
    Friend WithEvents Label1 As Label
    Private WithEvents Temizleme As Button
    Private WithEvents Tekrar_Aktar_Btn As Button
    Private WithEvents İs_Alabilme_Durumu As Button
    Private WithEvents Button1 As Button
    Private WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents IstasyonKapiGuncelleTimer As Timer
    Friend WithEvents Timerkon As Timer
    Friend WithEvents Label3 As Label
End Class

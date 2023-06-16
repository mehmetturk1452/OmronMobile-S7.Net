Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports S7.Net
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Mobile.Communication.Client
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Data.DataTable
Imports System.Data.OleDb




Public Class istasyon_is_durumu
    Public plc As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)

    Public KonvrHazirAdres(80) As String
    Public KonvrHazirAciklama(80) As String
    Public DoluKonAdres(80) As String
    Public BosKonAdres(80) As String
    Public değiştirilecekadres As String
    Dim SqlKomut As New SqlClient.SqlCommand
    Dim DeğikenAtamaSQLbaglanti As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Dim gridgosterbaglanti As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Dim yazbaglanti As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")

    Dim BosKasaKontrolBaglanti_update As New SqlClient.SqlConnection(My.Settings.ASRS_Sql_Baglanti)

    Dim kapi_text(6) As TextBox
    Dim kapi_text1(6) As TextBox
    Dim data As New DataSet
    Public Sub DegişkenAtama()
        SqlKomut.CommandText = "select * from [dbo].[PLC_Dolu_Konv_Data_Block_Sayac_Adresleri]"
        DeğikenAtamaSQLbaglanti.Open()
        SqlKomut.Connection = DeğikenAtamaSQLbaglanti
        SqlKomut.CommandType = CommandType.Text
        Dim okunan As SqlDataReader
        okunan = SqlKomut.ExecuteReader()
        Dim i As Integer
        i = 1
        While (okunan.Read())
            DoluKonAdres(i) = okunan("adres")
            i += 1

        End While
        DeğikenAtamaSQLbaglanti.Close()

        SqlKomut.CommandText = "select * from [dbo].[PLC_Bos_Konv_Data_Block_Sayac_Adresleri]"
        DeğikenAtamaSQLbaglanti.Open()

        SqlKomut.Connection = DeğikenAtamaSQLbaglanti
        SqlKomut.CommandType = CommandType.Text
        Dim okunanbos As SqlDataReader
        okunanbos = SqlKomut.ExecuteReader()
        Dim a As Integer
        a = 1
        While (okunanbos.Read())


            BosKonAdres(a) = okunanbos("adres")
            a += 1

        End While
        DeğikenAtamaSQLbaglanti.Close()



        SqlKomut.CommandText = "select * from [dbo].[PLC_Konveyor_Hazir_Data_Block_Adresleri]"
        DeğikenAtamaSQLbaglanti.Open()

        SqlKomut.Connection = DeğikenAtamaSQLbaglanti
        SqlKomut.CommandType = CommandType.Text
        Dim okunanhazir As SqlDataReader
        okunanhazir = SqlKomut.ExecuteReader()
        Dim b As Integer
        b = 1
        While (okunanhazir.Read())


            KonvrHazirAdres(b) = okunanhazir("adres")
            KonvrHazirAciklama(b) = okunanhazir("aciklama")
            PLCHazir_Aciklama_Combo.Items.Add(KonvrHazirAciklama(b))
            b += 1

        End While
        DeğikenAtamaSQLbaglanti.Close()
    End Sub
    Public Sub kapiupdate(kapı)
        BosKasaKontrolBaglanti_update.Open()
        SqlKomut.Connection = BosKasaKontrolBaglanti_update
        SqlKomut.CommandText = "update [dbo].[IC_KasaHazirBos] set kh_gorevvar='0' where kh_kapiid='" & kapı & "'"

        SqlKomut.ExecuteNonQuery()
        BosKasaKontrolBaglanti_update.Close()


    End Sub
    Public Sub KapidurumlariniYukle()
        SqlKomut.CommandText = "select * from [dbo].[IC_KasaHazirBos]"
        BosKasaKontrolBaglanti_update.Open()

        SqlKomut.Connection = BosKasaKontrolBaglanti_update
        SqlKomut.CommandType = CommandType.Text
        Dim okunanhazir As SqlDataReader
        okunanhazir = SqlKomut.ExecuteReader()
        Dim i As Integer
        i = 1

        kapi_text(1) = Kapi1_Text
        kapi_text(2) = Kapi2_Text
        kapi_text(3) = Kapi3_Text
        kapi_text(4) = Kapi4_Text
        kapi_text(5) = Kapi5_Text
        kapi_text(6) = Kapi6_Text
        kapi_text1(1) = Kapi1V_Text
        kapi_text1(2) = Kapi2V_Text
        kapi_text1(3) = Kapi3V_Text
        kapi_text1(4) = Kapi4V_Text
        kapi_text1(5) = Kapi5V_Text
        kapi_text1(6) = Kapi6V_Text
        While (okunanhazir.Read())


            kapi_text(i).Text = okunanhazir("kh_gorevvar").ToString
            kapi_text1(i).Text = okunanhazir("kh_hazir").ToString
            i += 1

        End While

        BosKasaKontrolBaglanti_update.Close()
    End Sub
    Private Sub istasyon_is_durumu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call DegişkenAtama()
        değiştirilecekadres = "boş"

    End Sub

    Private Sub Bos_Kasa_Kapi_Btn_Click(sender As Object, e As EventArgs) Handles Bos_Kasa_Kapi_Btn.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = False
        DataGridView1.Visible = False
        Call KapidurumlariniYukle()
        Timer1.Start()
    End Sub

    Private Sub Bos_Kasa_Tamami_Hazir_Btn_Click(sender As Object, e As EventArgs) Handles Bos_Kasa_Tamami_Hazir_Btn.Click
        Dim i As Integer
        i = 1
        While i < 7
            Call kapiupdate(i)
            i += 1
        End While
        Call KapidurumlariniYukle()
    End Sub

    Private Sub Kapi_Button1_Click(sender As Object, e As EventArgs) Handles Kapi_Button1.Click
        Call kapiupdate(1)
        Call KapidurumlariniYukle()
    End Sub

    Private Sub Kapi_Button2_Click(sender As Object, e As EventArgs) Handles Kapi_Button2.Click
        Call kapiupdate(2)
        Call KapidurumlariniYukle()
    End Sub

    Private Sub Kapi_Button3_Click(sender As Object, e As EventArgs) Handles Kapi_Button3.Click
        Call kapiupdate(3)
        Call KapidurumlariniYukle()
    End Sub

    Private Sub Kapi_Button4_Click(sender As Object, e As EventArgs) Handles Kapi_Button4.Click
        Call kapiupdate(4)
        Call KapidurumlariniYukle()
    End Sub

    Private Sub Kapi_Button5_Click(sender As Object, e As EventArgs) Handles Kapi_Button5.Click
        Call kapiupdate(5)
        Call KapidurumlariniYukle()
    End Sub

    Private Sub Kapi_Button6_Click(sender As Object, e As EventArgs) Handles Kapi_Button6.Click
        Call kapiupdate(6)
        Call KapidurumlariniYukle()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles CNV_Tamami_Hazir_Btn.Click
        Dim i As Integer
        i = 1
        While i < 81
            plc.Open()
            plc.Write(KonvrHazirAdres(i), 1)
            If değiştirilecekadres <> "boş" Then
                Plc_istasyon_Durumu_Text.Text = plc.Read(değiştirilecekadres)
            End If
            plc.Close()
            i += 1
        End While

    End Sub

    Private Sub CNV_Btn_Click(sender As Object, e As EventArgs) Handles CNV_Btn.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = True
        Timer1.Stop()
        DataGridView1.Visible = False
    End Sub

    Private Sub PLCHazir_Aciklama_Combo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles PLCHazir_Aciklama_Combo.SelectedIndexChanged
        plc.Open()
        SqlKomut.CommandText = "select * from [dbo].[PLC_Konveyor_Hazir_Data_Block_Adresleri]"
        DeğikenAtamaSQLbaglanti.Open()

        SqlKomut.Connection = DeğikenAtamaSQLbaglanti
        SqlKomut.CommandType = CommandType.Text
        Dim okunanhazir As SqlDataReader
        okunanhazir = SqlKomut.ExecuteReader()
        Dim b As Integer
        b = 1
        While (okunanhazir.Read())

            If KonvrHazirAciklama(b) = PLCHazir_Aciklama_Combo.SelectedItem Then
                Plc_istasyon_Durumu_Text.Text = plc.Read(KonvrHazirAdres(b))
                değiştirilecekadres = KonvrHazirAdres(b)
            End If
            b += 1

        End While
        DeğikenAtamaSQLbaglanti.Close()

        plc.Close()
    End Sub

    Private Sub Plc_Grv_Drm_Degistir_Btn_Click(sender As Object, e As EventArgs) Handles Plc_Grv_Drm_Degistir_Btn.Click
        plc.Open()
        If değiştirilecekadres <> "boş" Then
            plc.Write(değiştirilecekadres, 1)
        Else
            MsgBox("Lütfen Değiştirmek istediğiniz adresi seçiniz")
        End If
        Plc_istasyon_Durumu_Text.Text = plc.Read(değiştirilecekadres)
        plc.Close()

    End Sub

    Private Sub BTN_kapat_Click(sender As Object, e As EventArgs) Handles BTN_kapat.Click
        Timer1.Stop()
        Close()
    End Sub
    Public Sub goster()
        Data.Clear()

        Dim adaptor As New SqlClient.SqlDataAdapter("SELECT        dbo.IstasyonKasaSayıları.kimlik, dbo.IstasyonKasaSayıları.numara, dbo.IstasyonKasaSayıları.Hedef1, dbo.IstasyonKasaSayıları.Hedef2, dbo.IstasyonKasaSayıları.SonDoluSayi, dbo.IstasyonKasaSayıları.SonBossayi, 
                         dbo.IstasyonKasaSayıları.Tarih, dbo.Omron_Komut.CalismaDurumu
FROM            dbo.IstasyonKasaSayıları INNER JOIN
                         dbo.Omron_Komut ON dbo.IstasyonKasaSayıları.Hedef1 = dbo.Omron_Komut.Hedef1
WHERE        (dbo.Omron_Komut.CalismaDurumu = N'Evet')", gridgosterbaglanti)
        adaptor.Fill(Data, "sanal")
        DataGridView1.DataSource = Data.Tables("sanal")
    End Sub

    Public Sub yaz()
        Dim c As Integer
        c = 1
        While c < 81


            plc.Open()
            Try
                yazbaglanti.Open()
                SqlKomut.Connection = yazbaglanti
                SqlKomut.CommandText = "UPDATE [dbo].[IstasyonKasaSayıları]
   SET [SonDoluSayi] ='" & plc.Read(DoluKonAdres(c)) & "'
      ,[SonBossayi] = '" & plc.Read(BosKonAdres(c)) & "'
      ,[Tarih] = getdate()
 WHERE [numara]='" & c & "'"

                SqlKomut.ExecuteNonQuery()
                yazbaglanti.Close()
            Catch
                MsgBox("Sayılar sql'e yazılırken hata alındı")
                yazbaglanti.Close()
            End Try
            plc.Close()
            c += 1
        End While

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        DataGridView1.Visible = True
        Call yaz()
        Call goster()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Bos_Kasa_Kapi_Btn.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Stop()
    End Sub
End Class
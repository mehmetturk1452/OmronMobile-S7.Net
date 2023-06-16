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
Imports Mobile.Communication.Common
Imports Mobile.Communication
Imports System.Data.SqlClient
Imports System.Diagnostics
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Data.DataTable
Imports System.Data.OleDb







Public Class Form1
    Public client1 = New RobotClient("Robot", IPAddress.Parse("192.168.15.2"), 7171)
    Public ip(15) As String
    Public acilisbulundu As String





    Dim isleriyazbaglanti As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Dim BosKasaKontrolBaglanti As New SqlClient.SqlConnection(My.Settings.ASRS_Sql_Baglanti)
    Dim BosKasaKontrolBaglanti_update As New SqlClient.SqlConnection(My.Settings.ASRS_Sql_Baglanti)
    Dim BosKasaKontrolBaglantikapiters_update As New SqlClient.SqlConnection(My.Settings.ASRS_Sql_Baglanti)

    Dim DeğikenAtamaSQLbaglanti As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Dim İsAtmaTarihSQLbaglanti As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Dim istasyonkapiguncellleBaglanti As New SqlClient.SqlConnection("Server=192.168.55.240; Database=OrguPlc_Omron;User Id= sa;Password=Sa123Sa")
    Public acilisnumarasi As Integer
    Public isnumarasi As Integer
    Public timerkontrol As Integer
    Public sayac
    Dim gosteryenile As Boolean

    Dim timer2sqlkomut As New SqlClient.SqlCommand
    Dim SqlKomut As New SqlClient.SqlCommand

    Dim data As New DataSet
    Public plc As New Plc(CpuType.S71500, "192.168.15.70", 0, 1)
    Public DoluKonAdres(80) As String
    Public BosKonAdres(80) As String
    Public KonvrHazirAdres(80) As String
    Public konveyorcalisma(80) As String
    Public kapı As String

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
            b += 1

        End While
        DeğikenAtamaSQLbaglanti.Close()


        SqlKomut.CommandText = "select * from [dbo].[Omron_Komut] "
        DeğikenAtamaSQLbaglanti.Open()

        SqlKomut.Connection = DeğikenAtamaSQLbaglanti
        SqlKomut.CommandType = CommandType.Text
        Dim okunancnvcls As SqlDataReader
        okunancnvcls = SqlKomut.ExecuteReader()
        Dim c As Integer
        c = 1
        While (okunancnvcls.Read())


            konveyorcalisma(c) = okunancnvcls("CalismaDurumu")
            c += 1

        End While

        DeğikenAtamaSQLbaglanti.Close()

    End Sub
    Public Sub kapiupdate(kapı)
        Try
            BosKasaKontrolBaglanti_update.Open()
            SqlKomut.Connection = BosKasaKontrolBaglanti_update
            SqlKomut.CommandText = "update [dbo].[IC_KasaHazirBos] set kh_gorevvar='1' where kh_kapiid='" & kapı & "'"

            SqlKomut.ExecuteNonQuery()
            BosKasaKontrolBaglanti_update.Close()
        Catch
            BaglantiDurumuLabel.Text = "Boş Kasa Kapıları Güncellenemedi"
            BaglantiDurumuCheckbox.Checked = False
        End Try



    End Sub

    Public Sub kapiupdateters(kapı)
        Dim taskkapiters As Task = Task.Run(Sub()

                                                Try
                                                    BosKasaKontrolBaglantikapiters_update.Open()
                                                    SqlKomut.Connection = BosKasaKontrolBaglantikapiters_update
                                                    SqlKomut.CommandText = "update [dbo].[IC_KasaHazirBos] set kh_gorevvar='0' where kh_kapiid='" & kapı & "'"

                                                    SqlKomut.ExecuteNonQuery()
                                                    BosKasaKontrolBaglantikapiters_update.Close()
                                                Catch
                                                    BaglantiDurumuLabel.Text = "Boş Kasa Kapıları Güncellenemedi"
                                                    BaglantiDurumuCheckbox.Checked = False
                                                End Try

                                            End Sub)

        Task.WaitAll(taskkapiters)


    End Sub
    Public Sub SQLIsKayıt(kapı, hedef1, hedef2, d_sayi, b_sayi, durumu)


        Try
            İsAtmaTarihSQLbaglanti.Open()
            SqlKomut.Connection = İsAtmaTarihSQLbaglanti
            SqlKomut.CommandText = "INSERT INTO [dbo].[Omron_Verilmis_Isler]
           ([Hedef1]
           ,[Hedef2]
           ,[Tarih]
           ,[d_kasa_sayisi]
           ,[b_kasa_sayisi]
           ,[istasyonun_durumu]
           ,[kapi])
     VALUES
           ('" & hedef1 & "','" & hedef2 & "',getdate()," & d_sayi & "," & b_sayi & ",'" & durumu & "','" & kapı & "')"

            SqlKomut.ExecuteNonQuery()
            İsAtmaTarihSQLbaglanti.Close()
        Catch
            BaglantiDurumuLabel.Text = "İş sql tablosuna yazdırılamadı"
            BaglantiDurumuCheckbox.Checked = False
        End Try
    End Sub


    Public Sub goster()
    
                                                  data.Clear()

                                                  Dim adaptor As New SqlClient.SqlDataAdapter("SELECT*FROM [dbo].[Omron_Verilmis_Isler] where Tarih> DATEAdd(hour, -5, GETDATE())", isleriyazbaglanti)
                                                  adaptor.Fill(data, "sanal")
        DataGridView1.DataSource = data.Tables("sanal")
        DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.RowCount - 1


    End Sub
    Public Sub is_gonder(i, kapı, d_sayi, b_sayi, durumu)

        Dim taskisgonder As Task = Task.Run(Sub()
                                                SqlKomut.CommandText = "DECLARE @id VARCHAR(20)
SET @id = (SELECT max(kimlik) as jobid from Omron_Verilmis_Isler)


SELECT        TOP (100) PERCENT Gomut.kimlik, Gomut.numara, Gomut.Hedef1, Gomut.Hedef2, Gomut.Hedef3, Gomut.CalismaDurumu, Gomut.Aciklama, ISNULL(oncecik.Oncelik, 1) AS Oncelik, isnull(verilmis_isler.Tamamlandi,'işyok') as Tamamlandi,@id as jobid
FROM            (SELECT        kimlik, numara, Hedef1, Hedef2, Hedef3, CalismaDurumu, Aciklama
                          FROM            dbo.Omron_Komut) AS Gomut LEFT OUTER JOIN
                             (SELECT DISTINCT SUBSTRING(Hedef1, 0, 5) AS Hedef1, ISNULL(Tamamlandi, 'işvar') AS Tamamlandi
                               FROM            dbo.Omron_Verilmis_Isler AS Omron_Verilmis_Isler_1
                               WHERE        (Tamamlandi IS NULL)) AS verilmis_isler ON SUBSTRING(Gomut.Hedef1, 0, 5) = verilmis_isler.Hedef1 LEFT OUTER JOIN
                             (SELECT        Hedef1, Hedef2, MIN(oncelik) AS Oncelik
                               FROM            (SELECT        TOP (100) PERCENT Hedef1, Hedef2, CASE WHEN ISNULL(DATEDIFF(MINUTE, Tarih, GETDATE()), 1) = 0 THEN 1 ELSE ISNULL(DATEDIFF(MINUTE, Tarih, GETDATE()), 1) 
                                                                                   END AS oncelik
                                                         FROM            dbo.Omron_Verilmis_Isler
                                                         ORDER BY oncelik DESC) AS derivedtbl_1
                               GROUP BY Hedef1, Hedef2) AS oncecik ON Gomut.Hedef1 = oncecik.Hedef1 AND Gomut.Hedef2 = oncecik.Hedef2
ORDER BY CAST(Gomut.numara AS numeric)"

                                                SqlKomut.Connection = DeğikenAtamaSQLbaglanti
                                                SqlKomut.CommandType = CommandType.Text
                                                Dim okunan As SqlDataReader
                                                DeğikenAtamaSQLbaglanti.Open()
                                                okunan = SqlKomut.ExecuteReader()
                                                Dim a As Integer
                                                a = 1
                                                While (okunan.Read())
                                                    If a = i Then
                                                        Try
                                                            If okunan("Oncelik") = 1 Then

                                                                Dim hedef1 As String
                                                                hedef1 = okunan("Hedef1")
                                                                Call plc_write(i, hedef1)
                                                            ElseIf okunan("Tamamlandi").ToString.Replace(" ", "") = "işyok" Or okunan("Tamamlandi").ToString.Replace(" ", "") = "işvar" Then

                                                                Dim siradakiisno As Integer
                                                                siradakiisno = Convert.ToInt32(okunan("jobid")) + 1

                                                                Dim robotkomut As String
                                                                robotkomut = ("queueMulti 4 2 BosKon" & kapı.ToString & " pickup " & okunan("Oncelik") & " " & okunan("Hedef1") & " dropoff 20 " & okunan("Hedef2") & " dropoff 20 " & okunan("Hedef3") & " dropoff " & okunan("Oncelik") & " " & (siradakiisno))

                                                                Dim hedef1 As String
                                                                Dim hedef2 As String
                                                                hedef1 = okunan("Hedef1")
                                                                hedef2 = okunan("Hedef2")
                                                                client1.sendcommand(robotkomut)

                                                                Call SQLIsKayıt(kapı, hedef1, hedef2, d_sayi, b_sayi, durumu)
                                                                Call kapiupdate(kapı)
                                                                Call plc_write(i, hedef1)


                                                                BaglantiDurumuLabel.Text = "Bağlantı Sağlandı"
                                                                BaglantiDurumuCheckbox.Checked = True





                                                            End If
                                                        Catch
                                                            BaglantiDurumuLabel.Text = "İş gönderilirken hata oluştu"
                                                            BaglantiDurumuCheckbox.Checked = False

                                                        End Try
                                                        Exit While

                                                    End If

                                                    a += 1
                                                End While
                                                DeğikenAtamaSQLbaglanti.Close()
                                            End Sub)
        Task.WaitAll(taskisgonder)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ip(1) = "192.168.15.203"
        CheckForIllegalCrossThreadCalls = False
        Call DegişkenAtama()
        Call goster()

        'BosKasaCikisiIseDonusturtimer.Interval = 100
        sayac = 1
        isnumarasi = 1
        acilisnumarasi = 1
    End Sub



    Private Sub Btnbaglan_Click(sender As Object, e As EventArgs) Handles Btnbaglan.Click
        Try
            client1.Password = "1234"
            client1.Connect()

            BaglantiDurumuCheckbox.Checked = True
            BaglantiDurumuLabel.Text = "Bağlantı Sağlandı"
            BosKasaCikisiIseDonusturtimer.Start()
            IstasyonKapiGuncelleTimer.Start()
            Timerkon.Start()
        Catch exception1 As Exception
            'Dim local1 As Exception = exception1
            'ProjectData.SetProjectError(local1)
            'Interaction.MsgBox(local1.Message, DirectCast(MsgBoxStyle.ApplicationModal, MsgBoxStyle), Nothing)
            'ProjectData.ClearProjectError()
            MsgBox("Robotlara bağlantı sağlanamadı. Lütfen internet ayarlarını kontrol ettikten sonra tekrar deneyiniz.")
            Exit Sub

        End Try

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Environment.Exit(0)
        Close()

    End Sub
    Public Sub plc_write(i, hedef1)
        Try
            plc.Write(KonvrHazirAdres(i), 0)
            If plc.Read(KonvrHazirAdres(i)) = True Then

                MsgBox("DİKKAT!!" & hedef1 & " program istasyonun iş alabilir durumunu kapatamadı.")
                BaglantiDurumuLabel.Text = "Konveyor İş Alabilir Durumları Güncellenemedi"
                BaglantiDurumuCheckbox.Checked = False

            End If
            ' If plc.Read(KonvrHazirAdres(i)) = True Then
            'plc.Write(KonvrHazirAdres(i), 0)
            'End If


            plc.Close()
        Catch
            BaglantiDurumuLabel.Text = "Konveyor İş Alabilir Durumları Güncellenemedi"

            BaglantiDurumuCheckbox.Checked = False
        End Try


    End Sub

    Public Sub plc_writeters(i, hedef1)
        Dim taskplcters As Task = Task.Run(Sub()
                                               Try
                                                   plc.Open()
                                                   plc.Write(KonvrHazirAdres(i), 1)
                                                   If plc.Read(KonvrHazirAdres(i)) = False Then

                                                       MsgBox("DİKKAT!!" & hedef1 & " program istasyonun iş alabilir durumunu açamadı.")
                                                       BaglantiDurumuLabel.Text = "Konveyor İş Alabilir Durumları Güncellenemedi1"
                                                       BaglantiDurumuCheckbox.Checked = False

                                                   End If
                                                   ' If plc.Read(KonvrHazirAdres(i)) = True Then
                                                   'plc.Write(KonvrHazirAdres(i), 0)
                                                   'End If


                                                   plc.Close()
                                               Catch
                                                   BaglantiDurumuLabel.Text = "Konveyor İş Alabilir Durumları Güncellenemedi2"

                                                   BaglantiDurumuCheckbox.Checked = False
                                               End Try
                                           End Sub)

        Task.WaitAll(taskplcters)

    End Sub

    Public Sub plc_bağlantisi(kapı)
        Dim taskplcbaglantisi As Task = Task.Run(Sub()
                                                     Try
                                                         plc.Open()
                                                         Dim dolusayi(80) As Integer
                                                         Dim bossayi(80) As Integer
                                                         Dim isAlmaDurumu(80) As Boolean


                                                         While acilisnumarasi < 81

                                                             dolusayi(acilisnumarasi) = plc.Read(DoluKonAdres(acilisnumarasi))
                                                             bossayi(acilisnumarasi) = plc.Read(BosKonAdres(acilisnumarasi))
                                                             isAlmaDurumu(acilisnumarasi) = plc.Read(KonvrHazirAdres(acilisnumarasi))
                                                             acilisbulundu = "bulunamadı"
                                                             If dolusayi(acilisnumarasi) = 4 And bossayi(acilisnumarasi) < 3 And isAlmaDurumu(acilisnumarasi) = True And konveyorcalisma(acilisnumarasi) = "Evet" Then
                                                                 Dim d_sayi As Integer
                                                                 Dim b_sayi As Integer
                                                                 Dim durumu As String
                                                                 d_sayi = dolusayi(acilisnumarasi)
                                                                 b_sayi = bossayi(acilisnumarasi)
                                                                 durumu = isAlmaDurumu(acilisnumarasi).ToString
                                                                 gosteryenile = True
                                                                 Call is_gonder(acilisnumarasi, kapı, d_sayi, b_sayi, durumu)

                                                                 acilisbulundu = "bulundu"
                                                                 If acilisnumarasi = 80 Then
                                                                     acilisnumarasi = 0
                                                                 End If
                                                                 acilisnumarasi += 1
                                                                 Exit While
                                                             End If

                                                             If acilisnumarasi = 80 Then
                                                                 acilisnumarasi = 1
                                                                 Exit While
                                                             End If
                                                             acilisnumarasi += 1
                                                         End While

                                                         If acilisbulundu = "bulunamadı" Then

                                                             While isnumarasi < 81

                                                                 dolusayi(isnumarasi) = plc.Read(DoluKonAdres(isnumarasi))
                                                                 bossayi(isnumarasi) = plc.Read(BosKonAdres(isnumarasi))
                                                                 isAlmaDurumu(isnumarasi) = plc.Read(KonvrHazirAdres(isnumarasi))

                                                                 If dolusayi(isnumarasi) >= 2 And bossayi(isnumarasi) < 3 And isAlmaDurumu(isnumarasi) = True And konveyorcalisma(isnumarasi) = "Evet" Then
                                                                     Dim d_sayi As Integer
                                                                     Dim b_sayi As Integer
                                                                     Dim durumu As String
                                                                     d_sayi = dolusayi(isnumarasi)
                                                                     b_sayi = bossayi(isnumarasi)
                                                                     durumu = isAlmaDurumu(isnumarasi).ToString
                                                                     gosteryenile = True
                                                                     Call is_gonder(isnumarasi, kapı, d_sayi, b_sayi, durumu)

                                                                     If isnumarasi = 80 Then
                                                                         isnumarasi = 0
                                                                     End If
                                                                     isnumarasi += 1
                                                                     Exit While
                                                                 End If

                                                                 If isnumarasi = 80 Then
                                                                     isnumarasi = 1
                                                                     Exit While
                                                                 End If
                                                                 isnumarasi += 1
                                                             End While
                                                         End If

                                                     Catch
                                                         BaglantiDurumuLabel.Text = "PLC bağlantısı aşamasında hata alındı"
                                                         BaglantiDurumuCheckbox.Checked = "False"
                                                     End Try
                                                     plc.Close()
                                                 End Sub)
        Task.WaitAll(taskplcbaglantisi)

    End Sub
    Public Sub arkaplantimerici()
        Dim taskarkaplan As Task = Task.Run(Sub()
                                                Try
                                                    SqlKomut.CommandText = "select * from [dbo].[IC_KasaHazirBos] where kh_hazir='1' and kh_gorevvar='0'"

                                                    SqlKomut.Connection = BosKasaKontrolBaglanti
                                                    SqlKomut.CommandType = CommandType.Text
                                                    Dim okunan As SqlDataReader
                                                    BosKasaKontrolBaglanti.Open()
                                                    okunan = SqlKomut.ExecuteReader()
                                                    While (okunan.Read())

                                                        If okunan("kh_kapiid") IsNot "" Then
                                                            Dim kapı As String
                                                            kapı = okunan("kh_kapiid")

                                                            Call plc_bağlantisi(kapı)
                                                        End If


                                                    End While
                                                    BosKasaKontrolBaglanti.Close()
                                                Catch
                                                    BaglantiDurumuLabel.Text = "Timer Döngüsü Tamamlanamadı"
                                                    BaglantiDurumuCheckbox.Checked = "False"
                                                End Try
                                                BosKasaKontrolBaglanti.Close()
                                                'BosKasaCikisiIseDonusturtimer.Interval = 8000

                                            End Sub)
        Task.WaitAll(taskarkaplan)

    End Sub

    Private Sub BosKasaCikisiIseDonusturtimer_Tick(sender As Object, e As EventArgs) Handles BosKasaCikisiIseDonusturtimer.Tick
        gosteryenile = False
        Call arkaplantimerici()
        If gosteryenile = True Then
            Call goster()
        End If
        Label2.Text = sayac
        sayac = sayac + 1

    End Sub

    Private Sub Temizleme_Click(sender As Object, e As EventArgs) Handles Temizleme.Click
        data.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Tekrar_Aktar_Btn.Click
        Call goster()
    End Sub

    Private Sub İs_Alabilme_Durumu_Click(sender As Object, e As EventArgs) Handles İs_Alabilme_Durumu.Click
        istasyon_is_durumu.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ''BosKasaCikisiIseDonusturtimer.Stop()
        BaglantiDurumuLabel.Text = "Durduruldu"
        BaglantiDurumuCheckbox.Checked = False

    End Sub

    Private Sub BaglantiDurumuCheckbox_CheckedChanged(sender As Object, e As EventArgs) Handles BaglantiDurumuCheckbox.CheckedChanged
        If BaglantiDurumuCheckbox.Checked = False Then
            BosKasaCikisiIseDonusturtimer.Stop()
            IstasyonKapiGuncelleTimer.Stop()
        End If


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        BosKasaCikisiIseDonusturtimer.Stop()
        IstasyonKapiGuncelleTimer.Stop()
        Call DegişkenAtama()
        MsgBox("Timer Başlatıldı")
        BosKasaCikisiIseDonusturtimer.Start()
        IstasyonKapiGuncelleTimer.Start()

    End Sub

    Private Sub IstasyonKapiGuncelleTimer_Tick(sender As Object, e As EventArgs) Handles IstasyonKapiGuncelleTimer.Tick

        Call StartTask()
    End Sub





    Private Sub StartTask()
        Dim task1 As Task = Task.Run(Sub()
                                         timer2sqlkomut.CommandText = "SELECT        TOP (100) PERCENT OmronKomut.numara, OmronKomut.Hedef1, OmronKomut.Hedef2, MaxVerilmis.tarih, MaxVerilmis.kapi
                                         FROM            (SELECT        TOP (100) PERCENT VerilmisMax.Hedef1, CASE WHEN isnull(DATEDIFF(minute, VerilmisMax.Tarih, getdate()), 10) = 0 THEN 1 ELSE isnull(DATEDIFF(minute, VerilmisMax.Tarih, getdate()), 10) END AS tarih, 
                                                                                             VerilmisTamami.kapi
                                                                   FROM            (SELECT        TOP (100) PERCENT Hedef1, MAX(Tarih) AS Tarih
                                                                                             FROM            dbo.Omron_Verilmis_Isler
                                                                                             GROUP BY Hedef1
                                                                                             ORDER BY Hedef1) AS VerilmisMax LEFT OUTER JOIN
                                                                                                 (SELECT        kimlik, Hedef1, Hedef2, Tarih, d_kasa_sayisi, b_kasa_sayisi, istasyonun_durumu, kapi
                                                                                                   FROM            dbo.Omron_Verilmis_Isler AS Omron_Verilmis_Isler_1) AS VerilmisTamami ON VerilmisMax.Tarih = VerilmisTamami.Tarih AND VerilmisMax.Hedef1 = VerilmisTamami.Hedef1
                                                                   ORDER BY VerilmisMax.Hedef1) AS MaxVerilmis RIGHT OUTER JOIN
                                                                      (SELECT        kimlik, numara, Hedef1, Hedef2, Hedef3, CalismaDurumu, Aciklama
                                                                        FROM            dbo.Omron_Komut) AS OmronKomut ON MaxVerilmis.Hedef1 = OmronKomut.Hedef1
                                         WHERE        (MaxVerilmis.tarih > 30) AND (MaxVerilmis.kapi IS NOT NULL)"

                                         timer2sqlkomut.Connection = istasyonkapiguncellleBaglanti
                                         timer2sqlkomut.CommandType = CommandType.Text
                                         Dim okunan As SqlDataReader
                                         istasyonkapiguncellleBaglanti.Close()
                                         istasyonkapiguncellleBaglanti.Open()
                                         okunan = timer2sqlkomut.ExecuteReader()

                                         While (okunan.Read())


                                             plc_writeters(okunan("numara"), okunan("Hedef1"))



                                         End While

                                         istasyonkapiguncellleBaglanti.Close()

                                         timer2sqlkomut.CommandText = "SELECT        tarih, kapi
                                         FROM            (SELECT        CASE WHEN isnull(DATEDIFF(minute, KapiMAx.Tarih, getdate()), 10) = 0 THEN 1 ELSE isnull(DATEDIFF(minute, KapiMAx.Tarih, getdate()), 10) END AS tarih, kapi
                                                                   FROM            (SELECT        MAX(Tarih) AS Tarih, kapi
                                                                                             FROM            dbo.Omron_Verilmis_Isler
                                                                                             GROUP BY kapi
                                                                                             HAVING         (kapi IS NOT NULL)) AS KapiMAx) AS tablo
                                         WHERE        (tarih > 30)"

                                         timer2sqlkomut.Connection = istasyonkapiguncellleBaglanti
                                         timer2sqlkomut.CommandType = CommandType.Text
                                         Dim okunan1 As SqlDataReader
                                         istasyonkapiguncellleBaglanti.Close()
                                         istasyonkapiguncellleBaglanti.Open()
                                         okunan1 = timer2sqlkomut.ExecuteReader()

                                         While (okunan1.Read())



                                             kapiupdateters(okunan1("kapi"))






                                         End While





                                         istasyonkapiguncellleBaglanti.Close()
                                     End Sub)



        Task.WaitAll(task1)
    End Sub


    Private Sub Timerkon_Tick(sender As Object, e As EventArgs) Handles Timerkon.Tick

        If BaglantiDurumuLabel.Text = "Bağlantı Sağlandı" And timerkontrol = Label2.Text Then
            BosKasaCikisiIseDonusturtimer.Stop()
            IstasyonKapiGuncelleTimer.Stop()
            Label3.Text = Label3.Text + 1
            Button1.PerformClick()
        End If

        If BaglantiDurumuLabel.Text <> "Durduruldu" And timerkontrol = Label2.Text Then

            MsgBox("Timer yeniden başlatıldı ancak" & BaglantiDurumuLabel.Text & "hatasına düşmüştü")
                Label3.Text = Label3.Text + 1
                Button1.PerformClick()

        End If

        timerkontrol = Label2.Text
    End Sub


End Class
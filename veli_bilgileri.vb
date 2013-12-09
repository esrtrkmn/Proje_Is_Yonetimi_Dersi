Imports System.Data.SqlClient

Public Class veli_bilgileri
    Private ogr_no As Integer
    Private veli_tcno As String
    Private veli_ad As String
    Private veli_soyad As String
    Private veli_yakinligi As String
    Private veli_meslegi As String
    Private veli_geliri As String
    Private veli_adres As String
    Private veli_ilce As String
    Private veli_il As String
    Private veli_posta As String
    Private veli_tel As String
    Private veli_cep_tel As String
    Private veli_is_tel As String
    Private veli_is_fax As String
    Private veli_is_adres As String
    Private veli_is_ilce As String
    Private veli_is_il As String
    Private veli_is_posta As String
    Private veli_mail As String

    Public no As String
    Public ad As String
    Public soyad As String
    
    Private sql As String
    Private baglanti As New SqlConnection("server=.\SQLEXPRESS; database=proje; trusted_connection=yes;")
    Private com As New SqlCommand()
    Sub baglan()
        com.Connection = baglanti
        com.CommandText = sql
        baglanti.Open()
        com.ExecuteNonQuery()
        baglanti.Close()
    End Sub
    
    

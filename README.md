# StockOrderManagement Masaüstü Uygulaması

C# WinForms ve SQL Server kullanılarak geliştirilmiş, stok ve sipariş yönetimi yapan masaüstü uygulamasıdır.  
Bu proje, iş başvuruları ve portföy amacıyla hazırlanmıştır.

## Mimari Yapı
- Katmanlı Mimari (UI, Business, Data, Type Katmanları)
- Repository yapısı ile veri erişimi
- UI ve veri erişimi katmanlarının ayrılması

## Kullanılan Teknolojiler
- C# (.NET Framework, Windows Forms)
- SQL Server
- ADO.NET

## Uygulama Modülleri
- Kategori Yönetimi
- Marka Yönetimi
- Ürün Yönetimi
- Kullanıcı Yönetimi
- Sipariş Yönetimi

## Özellikler
- Her modül için ayrı giriş (ekleme) formları
- Listeleme, güncelleme ve silme (CRUD) işlemleri
- Temel veri doğrulama kontrolleri
- Katmanlar arası bağımsız yapı

## Kurulum
1. Projeyi bilgisayarınıza klonlayın
2. SQL Server üzerinde veritabanını oluşturun
3. `app.config` dosyasındaki connection string bilgisini düzenleyin
4. Projeyi Visual Studio üzerinden çalıştırın

## Not
Bu proje, katmanlı mimari ve temel CRUD işlemlerini uygulamak amacıyla geliştirilmiştir.

## Veritabanı
Bu proje geliştirme aşamasında Microsoft Northwind örnek veritabanı kullanılarak oluşturulmuştur.
Amaç, CRUD işlemleri ve katmanlı mimari yapısını uygulamaktır.

> Not: Proje yapısı, Northwind yerine özel olarak tasarlanmış bir veritabanına 
kolayca uyarlanabilecek şekilde geliştirilmiştir.

## Uygulama Görselleri

Aşağıda StockOrderManagement uygulamasının bazı ekran görüntüleri bulunmaktadır:

##Ürün Giriş Formu
(Ürün-Giriş-Formu)

##Ürün Güncelleme-Silme Formu
(Ürün-Güncelleme-Formu)
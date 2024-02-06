
**Onion Architecture - CQRS Design Pattern Api Project**

## Kullanılan Teknolojiler

 - C# .Net Core 7.0 Web Api
 - Entity Framework Core
 - Microsoft Identity
 - Fluent Validation
 - Auto Mapper
 - Mssql
 - JWT
 - Redis Cache

## Proje Detayları
Projemi onion(clean) architecture ile geliştirdim. Mediatr kütüphanesi ile CQRS design pattern uyguladım. Küçük bir e-ticaret alt yapısı kurguladım ve asıl amacım deneyim kazanmak. Projede Kategori, Ürün, Marka, Kullanıcı, Rol tabloları oluşturdum. Global Exception Middleware yazarak exceptionları Middleware seviyesinde global olarak yakaladım ve gerekli işlemleri yaptım. Fluent Validation kütüphanesini kullanarak Validation PipelineBehavior geliştrdim ve validasyonlarımı Mediatr sayesinde burada yaptım. AutoMapper ile mapleme işlemlerini gerçekleştirdim. Güvenlik olarak JWT kullandım. Projemde iş kurallarını nesne bazında Rules olarak geliştirdim bu sayede iç içe karmaşık ''if-else'' yazmamış oldum. Her iş kuralının kendine ait exception sınıflarını kodladım. Daha okunaklı gelişime daha açık hale gelmiş oldu. Cache için Redis kullandım. Yine Rediside PipelineBehavior ile geliştirdim ve isteklerimi cache tutup cacheTime geçmediyse mevcutta bir cache varsa cevap olarak buradan döndüm. Bogus kütüphanesini kullanarak 1milyon fake data ekledim ve bunu Sql sorgusu - Entity Framework - Cache olarak cevap sürelerini karşılaştırdım. Projeyi tamamen deneyim amaçlı geliştirdim.

## Clone oluşturmak için
Visual studio ide üzerinden projeyi locale çektikten sona Presentation katmanında api projesi altında 'appsettings.Development.json' dosyasında Database yolunu belirtebilirsiniz. Yine bu dosya içerisinde projenin JWT ve Redis ayarlarıda tutulmaktadır redis db içinde connectionString verip çalıştırabilirsiniz.
Brand Controller içerisinde CreateBrand metodunda fake 1milyon brand oluşturacaktır istek atarken dikkat edilmesi gerekmektedir.


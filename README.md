Bu proje, personellere cihaz atama işlemlerini yönetmek amacıyla geliştirilmiş bir web uygulamasıdır. SQL Server ve .NET Core MVC teknolojilerini kullanarak cihaz ve personel kayıtlarını takip edebilir, cihazların hangi personellere atandığını kolayca görüntüleyebilirsiniz.Projede temel CRUD operasyonları Entity Framework Core kullanılarak gerçekleştirilmiştir.

Proje Özeti


Cihaz Yönetimi: Cihazların kayıt altına alınması, güncellenmesi ve silinmesi.

Personel Yönetimi: Personel bilgileri ile birlikte departmanlarına göre düzenleme yapma imkanı.

Cihaz Atama: Cihazların uygun olan personellere atanması ve atanan cihazların durumu hakkında bilgi alma.

Cihaz Durumları: Cihazların atanmış veya atanmamış olduğunun sorgulanması.

Kullanılan Teknolojiler


Back-end: ASP.NET Core MVC

ORM: Entity Framework Core

Veritabanı: SQL Server

Ön Yüz: Razor View

Diyagramlar & Grafikler: Projede personel ve cihaz dağılımını görselleştirmek için grafikler kullanılmıştır.

Bu proje, SQL Server .bacpac dosyası ile çalışmaktadır. Projenin düzgün çalışması için veritabanı yedeğini SQL Server'a geri yüklemeniz gerekmektedir.
Veritabanı başarıyla yüklendikten sonra, appsettings.json dosyasındaki ConnectionStrings bölümünü veritabanı bağlantı bilgilerinizle güncelleyin.
Bu projede sadece admin yetkisine sahip kullanıcılar sisteme giriş yapabilir.Veritabanında önceden oluşturulmuş bir admin kullanıcısı bulunmaktadır. İlk giriş için bu bilgileri kullanabilirsiniz.

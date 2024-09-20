# Device Management System


Bu proje, personellere cihaz atama işlemlerini yönetmek amacıyla geliştirilmiş bir web uygulamasıdır. SQL Server ve .NET Core MVC teknolojilerini kullanarak cihaz ve personel kayıtlarını takip edebilir, cihazların hangi personellere atandığını kolayca görüntüleyebilirsiniz.Projede temel CRUD operasyonları Entity Framework Core kullanılarak gerçekleştirilmiştir.

## Proje Özeti

Cihaz Yönetimi: Cihazların kayıt altına alınması, güncellenmesi ve silinmesi.<br>
Personel Yönetimi: Personel bilgileri ile birlikte departmanlarına göre düzenleme yapma imkanı.<br>
Cihaz Atama: Cihazların uygun olan personellere atanması ve atanan cihazların durumu hakkında bilgi alma.<br>
Cihaz Durumları: Cihazların atanmış veya atanmamış olduğunun sorgulanması.

## Kullanılan Teknolojiler

Back-end: ASP.NET Core MVC<br>
ORM: Entity Framework Core<br>
Veritabanı: SQL Server<br>
Ön Yüz: Razor View<br>
Diyagramlar & Grafikler: Projede personel ve cihaz dağılımını görselleştirmek için grafikler kullanılmıştır.<br><br>

Bu proje, SQL Server .bacpac dosyası ile çalışmaktadır. Projenin düzgün çalışması için veritabanı yedeğini SQL Server'a geri yüklemeniz gerekmektedir.<br>
Veritabanı başarıyla yüklendikten sonra, appsettings.json dosyasındaki ConnectionStrings bölümünü veritabanı bağlantı bilgilerinizle güncelleyin.<br>
Bu projede sadece admin yetkisine sahip kullanıcılar sisteme giriş yapabilir.Veritabanında önceden oluşturulmuş bir admin kullanıcısı bulunmaktadır. İlk giriş için bu bilgileri kullanabilirsiniz.

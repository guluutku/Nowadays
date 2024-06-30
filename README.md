Portal Gurup için hazırlanmış çalışma ve değerlendirme projesi.

Projede .NET Framewrok Core, MSSQL, Docker, Repository/UnitOfWork Pattern, Interface ve SwaggerUI (REST API) kullanıldı.

Projeyi kullanmak:

- Projeyi çalıştırdıktan sonra http://localhost:5137/swagger/index.html adresinden SwaggerUI sayfasına gidilebilir.
- SwaggerUI sayfasında Company, Employee, Project, Issue ve report olamk üzere 5 ana tablodan vardır.
- Her tabloda GetAll..., Get..., Add..., Update..., Delete..., olmak üzere 5 farklı fonksiyon vardır.
- GetAll...: Tablodaki bütün verileri liste olarak alır.
- Get...: Tablodaki sadece ID ile istenen veriyi alır.
- Add...: Tabloya otomatik ID ile yeni bir veri eklenir. NOT: Veri eklerken ID kısmını 0 olarak bırakınız.
- Update...: Tablodaki ID ile belirtilen veriyi değiştirmeyi sağlar.
- Delete...: Tablodaki verinin 'isActive(bool)' elemanını false yaparak, veriyi inaktif hale getirir.

Projede Yapılanlar:
- SwaggerUI yaratıldı.
- Proje ve MSSQL veri tabanı arası bağlantı yaratıldı.
- SwaggerUI ile veri tabanında CRUD işlemleri yapılabiliyor.
- Veriyi silme işlemi tamamen silmek yerine veri pasif hale getiriliyor. 

Projede Yaılacaklar:
- SwaggerUI özelleştirilecek.
- CRUD işlemlerinde indexleme kullanılabilecek.
- Çalışanlar için TC numarası ile tüzel kişi olup olmadıklarını belirleyen soruşturma eklenecek.
- Tablolara eklenmemiş olan veriler eklenecek

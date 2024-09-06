# JWT Auth Test

Bu proje, .NET kullanarak JSON Web Token (JWT) ile basit bir kimlik doğrulama ve yetkilendirme sistemini test etmek için oluşturulmuştur. JWT, web uygulamalarında kullanıcı kimlik doğrulaması ve veri güvenliği sağlamak için yaygın olarak kullanılan bir yöntemdir.

## Proje Özeti

Bu proje, JWT kullanarak güvenli bir API oluşturmayı amaçlamaktadır. Projede JWT token'ları oluşturma, doğrulama ve geçerliliğini kontrol etme işlevleri bulunmaktadır.

## Özellikler

- JWT token'larının oluşturulması
- JWT token'larının doğrulanması
- Token geçerliliğinin kontrol edilmesi
- Swagger ile API testleri

## Gereksinimler

- .NET 6.0 veya üzeri
- PostgreSQL (veya tercih edilen diğer veritabanı)
- Swagger (API dokümantasyonu için)

## Kurulum

1. **Projeyi Klonlayın**:

   ```bash
   git clone git@github.com:ahmetcarrdak/JwtAuthTest.git
   cd JwtAuthTest
   ```

2. **Bağımlılıkları Yükleyin**:

   ```bash
   dotnet restore
   ```

3. **Veritabanını Yapılandırın**:
   Veritabanı bağlantı dizesini `appsettings.json` dosyasına ekleyin.

4. **Veritabanı Migrations'ları Uygulayın**:

   ```bash
   dotnet ef database update
   ```

5. **Uygulamayı Başlatın**:

   ```bash
   dotnet run
   ```

## API Kullanımı

### JWT Token Oluşturma

**Endpoint**: `POST /api/auth/login`

**Body**:
```json
{
  "username": "your-username",
  "password": "your-password"
}
```

**Başarı Yanıtı**:
```json
{
  "token": "your-jwt-token"
}
```

### Token Geçerliliğini Kontrol Etme

**Endpoint**: `GET /api/auth/check`

**Başlık**:
```
Authorization: Bearer your-jwt-token
```

**Başarı Yanıtı**:
```json
{
  "valid": true
}
```

## Swagger ile Test Etme

Proje başlatıldığında, Swagger dokümantasyonu genellikle `http://localhost:5000/swagger` adresinde bulunabilir. Bu sayfayı kullanarak API'yi test edebilir ve dökümantasyonu görüntüleyebilirsiniz.

## Katkıda Bulunanlar

- Ahmet Çardak - [ahmetcarrdak](https://github.com/ahmetcarrdak)

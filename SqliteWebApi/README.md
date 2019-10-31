# Boş bir web projesinden web api oluşturma:(web api from the scratch)

dotnet new web -o SqliteWebApi


## Eklenen Paketler :
dotnet add package Microsoft.EntityFramework

## Entity Framwrok Komutları : 
## Entity Framework tool kurulumu
dotnet tool install --global dotnet-ef

## Design Paketi kurulumu :
dotnet add package Microsoft.EntityFrameworkCore.Design

## DbContextten Veritabanı oluşturma : 

dotnet ef migrations add ilkOlusturma
dotnet database update

## Controllar hazırlandıktan sonra curl ile test etme
### POST Methodu ile veri Ekleme
curl -d  '{"content":"Mesajlar"}' -H "Content-Type: application/json" -X POST https://localhost:5001/api/Blog -i -k
### GET Methodu ile Veri Çağırma
curl -i -X GET https://localhost:5001/api/Blog -k

dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design

# Bu kısımda yazılan Model.cs dosyasından TodoContext e uygun bir veri tabanı dosyyası oluşturuluyor...

dotnet ef migrations add InitialCreate 
dotnet ef database update 

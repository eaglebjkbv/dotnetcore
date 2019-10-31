# Generic Repository Pattern Kullanımına örnek bir proje 
##Boş Solution oluşturmak
dotnet new sln -o GenericRepos 

## klasöre Giriş :
cd GenericRepos 

## Peronel.Domains Projesini oluşturmak
dotnet new classlib -o Personnel.Domains

## Peronel.Domains projesini Solution a ekleme
dotnet sln add Personnel.Domains/Personnel.Domains.csproj

## Peronel.DAL Projesini oluşturma
dotnet new classlib -o Personnel.DAL  

## Solution a Peronel.DAL Projesini ekleme
dotnet sln add Personnel.DAL/Personnel.DAL.csproj

## EntityFrameworkCore Dll ekleme
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore


##Personnel.DAL a Personnel.Domains i referans yapma
dotnet add Personnel.DAL/Personnel.DAL.csproj reference Personnel.Domains/Personnel.Domains.csproj

##Personnel.Console.UI projesini oluşturmak
dotnet new console -o Personnel.Console.UI

## Main Programı Solution a ekleme
dotnet sln add Personnel.Console.UI/Personnel.Console.UI.csproj

## Main Programa tüm diğer proje referanslarını ekleme
dotnet add Personnel.Console.UI/Personnel.Console.UI.csproj reference **/*.csproj

## Migrations öncesi
dotnet add package Microsoft.EntityFrameworkCore.Design 

## Migrations oluşturmak için
dotnet ef migrations add InitialCreate --project Personnel.DAL/Personnel.DAL.csproj --startup-project Personnel.Console.UI/Personnel.Console.UI.csproj

## Veri Tabanı Code First Oluşturmak İçin
dotnet ef database update --project Personnel.DAL/Personnel.DAL.csproj --startup-project Personnel.Console.UI/Personnel.Console.UI.csproj

## Projeyi Çalıştırmak için 
dotnet run --project Personnel.Console.UI/Personnel.Console.UI.csproj

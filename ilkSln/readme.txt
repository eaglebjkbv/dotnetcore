Yeni Bir Solution oluşturma
# dotnet new sln -o ilkSln

solution klasörüne girme 
# cd ilkSln

Solution içinde yeni bir proje oluşturma
# dotnet new console -o AnaProgram

yeni bir classlib oluşturma
# dotnet new classlib -o DataDal

şimdi bu oluşturulan projeleri solution a ekleyelim
# dotnet sln add AnaProgram/AnaProgram.csproj DataDal/DataDal.csproj

program yazıldıktan sonra AnaProgram a classlib i dahil etme
# dotnet add AnaProgram/AnaProgram.csproj reference DataDal/DataDal.cspro

programı çalıştırma :

# cd AnaProgram
# dotnet run




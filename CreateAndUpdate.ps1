Remove-Item "C:\tmp\DATABASE.FDB"
Remove-Item DatabaseTest/Migrations/* 
dotnet ef migrations add Teste1 --project DatabaseTest
dotnet ef database update --project DatabaseTest
dotnet ef migrations add Teste2 --project DatabaseTest
dotnet ef database update --project DatabaseTest
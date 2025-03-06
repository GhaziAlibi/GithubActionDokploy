# GithubActionDokploy

###  local test
create user secret for the connection string
```
dotnet user-secrets init
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=myserver;Database=mydb;User Id=myuser;Password=mypassword;"
```
Push-Location src

AutoRest -Namespace Elmah.Io.Client -AddCredentials -CodeGenerator CSharp -OutputDirectory Elmah.Io.Client -Input https://api.elmah.io:443/swagger/docs/v3

dotnet build Elmah.Io.Client

Pop-Location
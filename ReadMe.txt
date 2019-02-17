
-----

suppose that you have a table including column Username

-----


1) For configuration and json file add the following NuGet packages to console app
            
 - Microsoft.Extensions.Configuration
 - Microsoft.Extensions.Configuration.FileExtensions
 - Microsoft.Extensions.Configuration.Json


 2) For configuration add the following NuGet packages to library app

 - Microsoft.Extensions.Configuration
 - Microsoft.Extensions.Configuration.FileExtensions
 - Microsoft.Extensions.Configuration.Json


 3) For sql connection add the following NuGet packages to library app

 - System.Data.SqlClient

 or in PM (Package Manager Console)

 - Install-Package System.Data.SqlClient -Version 4.6.0

 -----
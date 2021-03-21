
# Inlämningsuppgift ASP .NET Core



### ASP. NET  
 
 #### Startup.cs 
ASP.NET applikationen måste innehålla en startup klass (klassnamnet kan bytas ut). Startup.cs körs först när applikationen startar. 
Genom .UseStartup<Startup>(); metoden i program.cs använder vi startup Klassen och dess metoder. Startup innehåller två public metoder:



 
###### * ConfigureServices()
 
ConfigureServices kallas i .Build() i Program.cs. I ConfigureServices() metoden kan man registrera sina klasser (services) med en inbyggd IoC container. IoC container = även kallad för DI (Dependency Inejection), 
är en inbyggd container som finns i ASP.NET Core framework. Efter att ha registrerat services kan man använde dem överallt i applikationen, detta gör man genom att inkludera den i en parameter av en konstruktor i den klass där du vill använda den.
En service är alltså en klass som används i en annan klass. 
Här inkluderas även IServiceCollection parametern som registrerar services i IoC containern.


 
###### * Configure()
 
Denna metod måste finnas i Startup.cs.
Configure() körs direkt efter att vi kallat på .Run() i Program.cs. 
Här kan man konfigurera applikation-requestens pipline genom att använda IApplicationBuilder klassen.
Genom denna klass kommer man åt den inbyggda IoC containern.
För att definiera ett request pipline användes Middleware komponenter. Dessa kommer att exekvera varje request. 
Man väljer och använder endast de middleware komponenter som är nödvändiga i din applikation, detta för att öka prestandan i applikationen. 
Det är även viktigt att veta vilken ordning metoderna kallas på. 
Man kan se middleware som en trappa, där man börjar uppifrån där ett http request kommer in från klienten (webHost) för att sedan ta sig nedåt
när vi når rätt razer pages (Endpoints) för ändamålet. Därefter går vi upp för trappan igen - Razer Page skapar ett html svar som skickas upp genom middleware stegen
tills en http 200 OK genereras och skickas tillbaka till klienten.




 #### wwwroot
 
wwwroot är web root foldern, denna folder innehåller statiska filer. Här finns exempelvis javascirpt, html, images och css-kod etc. Att filerna är statiska betyder att de inte behöver skapas/förändras av en server innan de skickas ut till klienten.

 
 #### Program.cs
Här börjat allt, i Main, när applikationen exekverar. 
Här skapar vi en host (WebHost), .Build(),  för applikationen.  
Därefter kallas .Run(), genom att kalla på .Run() fortsätter mainprocessen att arbeta inuti WebHost. 

CreatDefualtBuilder metoden skapar en instans av WebHostBuilder och skapar Kestrel. Kestrel är webservern som inkluderar och aktiverar ASP.NET Core projekts temlpates. 
Här kallas även ConfigureAppConfiguration() för att bland annat ladda konfiguering från appsettings.json filer.

          
 #### Razor språket 

Razorkod är ett eget språk, där man blandar html och c# språk. 
Filändelsen är .cshtml och man använder mycket @ i razorkod, detta för att koppla samman c#-koden med html.  
Varje razorkod-fil har en C#-fil, en c# klass. 
Razor finns både i MVC och Razor Pages.

            
### Razor Pages
#### Content Page
#### Page Model 

### MVC
#### Model 
#### View 
#### Controller 

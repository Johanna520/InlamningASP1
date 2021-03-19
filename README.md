
# Inlämningsuppgift ASP .NET Core



### ASP. NET  
 
 ##### Startup.cs 

ASP.NET applicationen måste innehålla en startup class (classnamnet kan bytas ut). Startup.cs körs först när applicationen startar. 
Genom r.UseStartup<Startup>(); metoden i program.cs använder vi startup classen och dess metoder. 
 * ConfigureServices()
ConfigureServices kallas i byggfasen .Build() i Program.cs
Här lägger vi in alla services klasser.
 
 * Configure()
Configure() körs direkt efter att vi kallat på .Run() i Program.cs. 
Här inne stller vi in vilka sk. Middleware som ska användas. 


 ##### wwwroot
 wwwroot är web root foldern, denna folder innerhåller statiska filer. Här finns exempelvis javascirpt, html, images och css-kod etc.
 Att filerna är statiska betyder att de inte behvöer skapas/förändras av en server innan de skickas ut till klienten. 
 
 #### Program.cs
Här startar programmet
          
 ##### Razor språket 

            
### Razor Pages
##### Content Page
##### Page Model 

### MVC
#### Model 
#### View 
#### Controller 

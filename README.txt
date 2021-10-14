2021-10-10 11:23 PM you won't believe what happened but I lost my file and to start over again,
can't believe this is happening to me
just created a new project
here we go again...
Run the app and move on to the next part,...
Add a controller in controllers folder
add some coding inside the Controllers/HelloWorldController.cs
run and Append "HelloWorld" to the path in the address bar
worked,...
it's really ennoying having to start everything again but had no choice,
move on to the next part, add a view
In the HelloWorldController class, replace the Index method with the following code:
public IActionResult Index()
{
    return View();
}
just created a new folder in the views folder name HelloWorld
run the the page with the "Hello World" and see the change
worked...
now, im gonna Change the title, footer, and menu link in the layout file
run the app and select the privacy link
worked...next
Open the Views/HelloWorld/Index.cshtml view file and Change the title and <h2> element 
just saved the changes and run the app,...
looks okay...
then in HelloWorldController.cs, I'm gonna change the Welcome method to add a Message
and NumTimes value to the ViewData dictionary
now im gonna Create a Welcome view template named Views/HelloWorld/Welcome.cshtml and 
add some code inside
run the app, all good in the hood
next part, add a data model class
I just added a class name Bottle.cs in the models folder
next, adding NuGet packages by running the following command:
Install-Package Microsoft.EntityFrameworkCore.Design
successfully installed
next, scaffolding Bottle pages,
Use the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the bottle model.
installing...ohh wouahhh surprise I didn't got an error, cuz on my last project it threw an error
well that's great
now let's add Add-Migration InitialCreate and Update-Database
oops got this message: More than one DbContext was found. Specify which one to use.
Use the '-Context' parameter for PowerShell commands and the '--context' parameter for dotnet commands.
Trying to fix it cuz Im pretty sure it wont run the 
so to fix that im not gonna lie I had to google it
so I just run this command in PM for the add-migration and update-database:
-context AmazingBottles.Data.AmazingBottlesContext
and the build succedded
now let me run and see if it works
well perfect
next part, im gonna seed the database by Creating a new class named SeedData in the Models folder
add some bottles brand and material in there...
now, im going to add the initializer in the program.cs folder
test the app
perfect......
next, adding controller methods and views
im gonna open the Open the Models/Bottle.cs file and add some code
well i'm getting there
2012-10-11 1:56AM still up
next step, adding search
Update the Index method found inside Controllers/BottlesController.cs with the following code
great...
now, im gonna Open the Views/Bottles/Index.cshtml file, and add the <form> markup
I just Save my changes and then test the filter
good job!!
2:29AM It's late, im tired but I have to finish this
next, Fix this by specifying the request should be HTTP GET found in the 
Views/Bottles/Index.cshtml file.
goodddddddddddddd...
next, add validation
Update the Bottle class to take advantage of the built-in Required, StringLength, RegularExpression
Run the app and navigate to the Bottles controller.
I'm exhausted!!!
2:37 AM add some images in details.cshtml in the bottles folder
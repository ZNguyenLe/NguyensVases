Started Assignment 1 on 10/4/2021

- Created a project NguyensVases in visual studio 2019
- Commented out the sslport in the launchSettings.json
- Created a Repository on Github and pushed as NguyensVases 

- 4(or more) attributes thought of
	-	Name
	-	Material
	-	Design
	-	Price
	-	Color
	-	Weight
	-	Size

- Added a controller of NguyenVases	
- Tested the app to display default action in http://localhost:62105/NguyenVases
- tested the welcome message in http://localhost:62105/NguyenVases/Welcome
- Changed the Welcome method to return the HTMLEncoder to display the name and numTimes id number in the search bar

Continued Assignment 1 on 10/7/2021

- tested and ran the application to try the name & numtimes on the college computers
  and was successful.

- Changed NumTimes to ID inside NguyenVases.cs
- completed 'add a controller section' for NguyenVases

- Had an issue displaying the view template through the ViewData in and updated
  updated Views Folder and created Index.cshtml
- Had the wrong section selected
- created an entirely new file and now everything is working up to this point.

<<<<<<< HEAD
Continued Assignment 1 on 10/8/2021

- Could not connect to the IISExpress Web server but had another option to connect to NguyensVases and works
- Changed the asp-controller to NguyenVases so that when clicking on "NguyenVases" it will direct to the Vases List Index page

Went back into NguyenVases.cs in Controllers and changed the welcome string to IActionResult with ViewData
- Created a Welcome.cshtml file inside View/NguyenVases and tested the name and numTimes on the search bar

Added a new Model named Vases.cs with the attributes listed above
Opened the NuGet Package Manager and Installed the Microsoft.EntityFrameworkCore.Design Package
Created a new Scaffoled Item called VasesController.cs

crossing my fingers the migration works
Added the migration step as InitialCreate and Changed the <a> link from NguyenVases to Vases to access to page to input data (the big bold letters link towards it)
added info to test if the item was created and displayed

it works successfully (thank goodness)

Added the microsoft.entityframeworkcore.database.command in the appsettings.development.json file
=======
>>>>>>> 4fd97062077388b3584f1c484986ab71d8b88633

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

10-08-2021 Continued working on the assignment
Opened the SQL Server Object Explorer to view the content in the database
Created a SeedData.cs file inside the model folder

Forgot to include the rating inside the vases.cs (Hopefully its not too big of a deal)

Added 10 items inside the SeedData.cs file included with 4 or more attributes.

Updated the Program.cs file

Saved everything and ran the application. The record I set earlier was still there so I had to delete it
closed the application and opened it again and all the seeded data has been placed.

started part 6, controller methods and views

there was a section to specifically add a required event where you must enter numbers instead of letters inside the price textbox

completed part 6?

started part 7, add search to an ASP.NET Core MVC app
updating the VasesController.cs testing the searchString

typed the name in the item list and seemed to work perfectly

now changed the searchstring to Id

tested Id and worked the same way and now changed back to searchString

Working on the LINQ function to get the list of materials

had an error where the VasesMaterialViewModel.cs wasnt defined (x2)
the issue was it was returning the wrong value
it is now resolved

Add a Search Section Part 7 is completed

Started part 8 on 09-10-2021

-Implemented a new field named Rating
-added a new string Rating inside the Vases.cs file

-used the shortcute Ctrl+Shift+B to build the application
-went back to the VasesController and update the bind for the Create and Edit

- went through the views .cshtml files and also added the Rating string field
- Added a new Rating section to the SeedData file and implement the item rating from customers

Part 8 Add a new field completed on 09-10-2021 at 5:02PM Saturday

Started Part 9 Add validation

- Included the Validation rules inside the Vases.cs file while it being required to enter information.

Finished Part 9 Add Validation

Started Part 10

Examine
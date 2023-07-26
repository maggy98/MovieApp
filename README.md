# MvcMovie

## My comment: Remember to build and/or run app from MvcMovie folder (no MovieApp folder) and add SQLite as your extension to VS Code.

# Requirements

1. Tech stack: dotnet core (mine include MVC, SQLite, VS Code)
2. Domain and Views: The main page of the MvcMovie application displays a movie catalog, where users can view a list of movies. The following views are available:

a) Main Page View:

![mainpage](https://github.com/maggy98/MovieApp/assets/62389300/b490e041-5b96-488b-b98a-d4db1b4ca360)

b) Movie Catalog View:
Users can create a new movie entry and add it to the catalog using this view.

![moviecatalog](https://github.com/maggy98/MovieApp/assets/62389300/1293ec6f-bf01-4a27-a58d-c3188b3c09f3)

c) Add Movie View:
Users can fill in the movie details and add a new movie to the catalog.

![creratenew](https://github.com/maggy98/MovieApp/assets/62389300/48fc7c6d-1a3b-47fe-877c-f4c53d6e2dbd)

d) Last Added Movie View:
By clicking on the blue header 'SystemDate,' users can retrieve the last movie added to the catalog. (please click on the blue header 'SystemDate')

![lastaddedmovie](https://github.com/maggy98/MovieApp/assets/62389300/3ce2e739-421b-489c-b747-8192181d17f2)

e) Movies From Given Year View:
Users can use the search engine to retrieve movies from a specific year.

![moviefromgivenyear](https://github.com/maggy98/MovieApp/assets/62389300/af249077-fc1e-4458-b818-fbe1f29aeabd)

f) Movies From Given Genre View:
Users can use the search engine to retrieve movies from a specific genre. (use search engine)

![moviefromgivengenre](https://github.com/maggy98/MovieApp/assets/62389300/7db65588-6ea8-4d81-84f7-6ca4bcf2218f)


Note: The 'dotnet aspnet-codegenerator' command automatically generates functions to operate on the catalog, including Delete, Edit, and Details functionality.

3. Additional requirements:

a) HTTP Request Logging:
The application is configured to log HTTP requests to the console, helping developers monitor and debug the application effectively. Examples of console log outputs are shown below:


<img width="536" alt="consolelog2" src="https://github.com/maggy98/MovieApp/assets/62389300/4e807896-132f-43e8-9cb9-a42394a12fbd">

<img width="536" alt="consolelog3" src="https://github.com/maggy98/MovieApp/assets/62389300/14a98772-7ec9-4f56-be92-2ce809ca0960">

b) Code Compilation:
The code is designed to compile without any warnings, ensuring that the application is robust and free from potential errors. The 'dotnet build' command is used to perform the code compilation, as demonstrated in the screenshot below:

<img width="528" alt="dotnetbuild" src="https://github.com/maggy98/MovieApp/assets/62389300/b5f2df66-fcb6-4a8b-87a4-95d50c8a8e3c">


c) Code Execution:
The application is tested and verified to run without issues using the 'dotnet run' command, as depicted in the screenshot below:

<img width="387" alt="dotnetrun" src="https://github.com/maggy98/MovieApp/assets/62389300/4462ee34-bb16-4a67-8a76-eb14ba570573">


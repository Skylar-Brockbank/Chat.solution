# _Chatty McChatFace's Chatty McChatApp_

#### By _**Jacob Wilson** **Matt Luker** and **Skylar Brockbank**_

#### _A chat app_

## Technologies Used

* _C#_
* _.NET 5_
* _ASP.NET Core MVC_
* _dotnet script, REPL_
* _Razor View Engine_
* _MySQL and MySQL Workbench_
* _Git_
* _Pomelo Entity Framework for MySql_
* _Microsoft Entity Framework (Identity)_

## Description
_An application that lets users chat with one another_


## Setup/Installation Requirements

### Application Setup
* _Install .NET 5.0 [here](https://dotnet.microsoft.com/download/dotnet/5.0)_

* _Click the green "Code" button and Download Zip _
* _Extract the contents of the zip file to a folder on your machine_
* _Navigate to the Factory Directory and `touch appsettings.json` and fill with the following_
```
{
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=chat;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
}
```
* _Replace `[YOUR-PASSWORD-HERE]` with your MySql Password.

* _alternatively you can [clone this repository](https://www.learnhowtoprogram.com/introduction-to-programming/git-html-and-css/practice-github-remote-repositories) from Git Hub_

### Database Setup

* _Download MySQL and MySQL Workbench to set up a local database_

* _Once installed, create a database from the included migration files by navigating to the Chat Directory and typing into the terminal:_
  >dotnet ef database update

### To Run Application

* _Navigate to Factory production folder in terminal_

* _To download obj and bin files needed for the program to run, while still in Chat folder type into the terminal:_
  >dotnet restore
* _To run the program, while still in the Chat directory type into the terminal:_
  >dotnet run
#### Note: The server will not open automatically. The user will need to click on the live share link in terminal, or enter 'localhost:5000' URL into browser.


## Known Bugs

* _Project needs notification method_

## License

*[MIT](https://opensource.org/licenses/MIT) Licenced
*Copyright (c) _2021_ _Jacob Wilson_ _Matt Luker_ _Skylar Brockbank_

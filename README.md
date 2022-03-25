<h1 align="center">Pierre's Bakery V2</h1>


Josh Tillinghast | [LinkedIn](https://www.linkedin.com/in/jwtill/) | [email](mailto:<jwtill@icloud.com>) 

## About this project
An MVC application that tracks the relationships between treats and  flavors for Pierre's Bakery.
## Get Started
### Download and populate project
- Ensure that you have installed the latest versions of Git ([instructions](https://github.com/git-guides/install-git)), as well as MySQL Workbench
- In your command line, clone this repository using `$ git clone https://github.com/jwtill/PBakery.Solution`
- Make a new file called appsettings.json in the root folder of the project
with the following text:
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=josh_tillinghasty;uid=root;pwd=[YourPassword];"
  }
}
- Replace [YourPassword] with the password you use to connect to MySQL. 
– Navigate to the Factory folder, and enter "dotnet restore" to install the required dependencies.
- Enter "dotnet ef database update" in the Bakery directory to rebuild the database.
- Enter "dotnet run" to start the program.




## Technologies Used

This site incorporates the following frameworks and languages:

- C #
- .NET
- MySQL Workbench
- MVC(Model View Controller) design
- HTML
- Entity
- Identity

The following development tools were used to develop this page:

- VS Code
- Google Chrome
- Git


## Known Issues
None at this time

## Acknowledgements

Thanks to all my pairs this week for helping me understand the material in different ways, and to my family for support throughout the program

## License 

MIT License

© 2022 Josh Tillinghast

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

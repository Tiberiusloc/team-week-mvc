# _Botanical Adventure API_

#### By _**Helen Lehrer, Keisha Marie, Kelly Bruce, Tiberius Locket, and Harold Mesa**_

#### _MVC for the Botanical Adventure game._

## Technologies Used

* _C#_
* _.NET Core_
* _MySQL_
* _Entity_
* _Identity_
* _Bootstrap_
* _JavaScript_
* _CSS_

## Description

_The Botanical Adventure MVC is a game where users can search for a botanical items (mushrooms, flowers and trees) in different ecosystems in Oregon(coast, desert and forest). They can also choose a difficulty for the game (easy, medium and hard). The difficulty relates to the population of the botanical item in an ecosystem. The lesser the presence of a flower, mushroom or tree in an area, the harder the difficulty, and the greater the score for finding the item._

_Users can register and login to their personal account._

_The MVC allows users to choose an ecosystem and the difficulty of the game. Then they're presented a splash page with a series of botanical items they may find in that specif ecosystem. When selecting an item, users can see more details for it (name, description, history, picture, symbolism, score, hint, etc.)._

###### * _This MVC is relies on the data provided by the [Botanical Adventure API](https://github.com/curiousmockingbird/team-week-project.git)._

## Setup

* _If you haven't yet, install the dotnet ef tool through your command line (run $ dotnet tool install --global dotnet-ef --version 5.0.1)_
* _On the root directory, create an appsettings.json fie and add the following code:_  
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=forage_mvc;uid=root;pwd=[Your-MySql-password-here];"
  }
}

* _Run '$ dotnet ef database update'_
* _Run '$ dotnet watch run' to run the MVC. It will open the http://localhost:5001 viewport. 


## Bugs

* _No known bugs_

## License

_[MIT License](https://en.wikipedia.org/wiki/MIT_License)_

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) _24 Nov, 2022_ _Helen Lehrer, Keisha Marie, Kelly Bruce, Tiberius Lockett, Harold Mesa_

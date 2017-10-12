# Travel Blog

## By Kaili Nishihira and Michael Woldemedihin

#### _This is dedicated web site to post our travel experiences all over the world., 10.10.17_


## Description

_This is dedicated web site to post our travel experiences all over the world._

|| Behavior  | Input  | Output  |
|---|---|---|---|
|1| User may view a list of all locations on the Home/Index view  | Click `Home` in navigation bar  | View displays buttons with location's names `USA, Seattle`|
|2| User may view a location's details. <li>Click location's button in Index view</li>  | Click `USA, Seattle`  | List of all experiences in Seattle should display. <br>  <br> > Space needle<br> > Flat Stick bar<br> |



## Setup/Installation Requirements

* _Download and install [.NET Core 1.1 SDK](https://www.microsoft.com/net/download/core)_
* _Download and install [Mono](http://www.mono-project.com/download/)_
* _Download and install [MAMP](https://www.mamp.info/en/)_
* _Set MySQL Port to 3306_
* _Clone repository_

#### There are two options to create the database:
##### 1. In MySQL
`> CREATE DATABASE travel_blog;`<br>
`> USE travel_blog;`<br>
`> CREATE TABLE locations (id serial PRIMARY KEY, country VARCHAR(255), city VARCHAR(255));`<br>
`> CREATE TABLE experiences (id serial PRIMARY KEY, title VARCHAR(255), story TEXT, location_id INT );`<br>
`> CREATE TABLE people (id serial PRIMARY KEY, name VARCHAR(255), experience_id INT );`
##### 2. Import from the Cloned Repository
* _Click 'Open start page' in MAMP_
* _Under 'Tools', select 'phpMyAdmin'_
* _Click 'Import' tab_
* _Choose database file (from cloned repository folder)_
* _Click 'Go'_

## Technologies Used
* _C#_
* _.NET_
* _MVC_
* _Entity Framework_
* _[Bootstrap](http://getbootstrap.com/getting-started/)_
* _[MySQL](https://www.mysql.com/)_

### License

Copyright (c) 2017 **_Kaili Nishihira and Michael Woldemedihin_**

*Licensed under the [MIT License](https://opensource.org/licenses/MIT)*


### ASP.Net
#### Add Packages
* Microsoft.AspNetCore.Mvc - Version 1.1.2
* Microsoft.EntityFrameworkCore - Version 1.1.2
* Pomelo.EntityFrameworkCore.MySql - Version 1.1.2
* Microsoft.AspNetCore.StaticFiles - Version 1.1.2
* Microsoft.AspNetCore - Version 1.1.2

### Migration
#### Add Packages
* Microsoft.EntityFrameworkCore.Design - Version 1.1.2

#### Add to .csproj
```
<Item Group>
  <DotNetCliToolReference Include="Microsoft.EntityFrameworkCore.Tools.DotNet" Version="1.0.0" />
</Item Group>
```
If missing, add:
```
<Item Group>
  <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="1.1.2" />
</Item Group>
```

#### Commands in terminal or VS Package Console (Windows only)
* `dotnet restore` (keep running restore if you come across errors)
* `dotnet ef migrations add Initial` (Initial can be any name of your migration, like a commit message)
* `dotnet database update`

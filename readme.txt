github: https://github.com/codemobiles/dotnet6_intro_workshop.git

install dotcore sdk : https://dotnet.microsoft.com/en-us/download
install vscode
- enable shell cmd for vscode on macos
- install vscode extensions;  
  code --install-extension vscode-icons-team.vscode-icons
  code --install-extension esbenp.prettier-vscode
  code --install-extension ms-dotnettools.csharp
  code --install-extension matijarmk.dotnet-core-commands
  code --install-extension eamodio.gitlens
  code --install-extension esbenp.prettier-vscode
  code --install-extension bierner.color-info

- cmd + shfit + p => dotnet
- Enter sdk command
- Enter new and select project folder
- Enter webapi
- Enter <project-name>
- Enter option (skip)
- Project is generated
- Open Program.cs
- Go to menu Run -> Start Debugging
Enter DotnetCore (after enter you may have to clear and repeat start debugging step above again, in order to create both task.json and launch.json)
- .vscode and launch.json and task.json created
- Click Start Debugging again
- Find http (not s first)
- Now listening on: http://localhost:5104
- Test http://localhost:5104/WeatherForecast
- You must see the json result

# Enable ssl
-----
mac: sudo dotnet dev-certs https --trust
windows: dotnet dev-certs https --trust
- after enable self-sign ssl you can run https 


# Swagger
c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo{Title = "CodeMobiles .NET 6 Demo", Version="v2"});

HttpGet
-------------
- HttpGet
- ActionResult and without
- Ok()
- Extension ASP Essential api-

- HttpGet("{id}") parameter


    [HttpGet("{id}")]
    public ActionResult GetProductById(int id) => Ok(new { productId = id, name = "iMac" });

    [HttpGet("search")]
    public ActionResult SearchProduct([FromQuery] string name) => Ok(new { productId = 111, name = name });    
    



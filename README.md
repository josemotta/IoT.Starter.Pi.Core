# IoT.Starter.Pi.Core

### IoT Starter Raspberry Pi Core

For more details about [IoT Starter](https://github.com/josemotta/IoT.Starter "IoT Starter"), please see articles and repos below:

[IoT Starter Core for Netduino Plus 2](https://www.codeproject.com/Articles/1122233/IoT-Starter-Core-for-Netduino-Plus "IoT Starter Core for Netduino Plus 2")  
https://github.com/josemotta/IoT.Starter  
https://github.com/josemotta/IoT.Starter.Np2.Core  
https://github.com/josemotta/IoT.Home.Netduino  


At this project targeted to Raspberry Pi with Linux, the API First Design strategy is used to develop an ASP.NET Core Web Server automatically generated by Swagger Hub. The availability of Visual Studio running at a speedy x64 cpus with Windows 10 are the key advantages of this starter kit. Previous studies were done before this project, please see links below.

https://github.com/josemotta/pi-docker-gpio  
https://github.com/josemotta/IoT.Starter.Api  

## IoT API for Raspberry Pi

Starting from a Swagger API definition, an ASP.NET Core Web API is developed using SwaggerHub. The code is automatically generated and pushed to github. Then it is loaded by a Windows x64 machine and upgraded to ASP.NET Core 2.0, using Visual Studio 2017.

A multi-stage docker image build is accomplished at the speedy Windows x64 machine, generating code for the linux-arm. The same VS solution include separated projects for the web server and web UI. Both docker images are pushed to the cloud and then pulled back into a Raspberry Pi with Raspbian 9.1 stretch installed.

### Modeling:
 
- API is designed at Swagger Hub   
- Web service stub is automatically generated
- Swaggerhub is configured to push code to 'swag' branch at Github 

### Development at x64 with Windows 10:

- Install Docker

	**Web Service**

- Pull Swaggerhub generated code from github
- Upgrade to .NET Core 2 framework and Docker support
- Merge code from swag branch to master
- Create multi-stage docker build for web service    
- Compiles at x64 machine for linux-arm framework  
- Push Docker image to cloud: home-web  

	**Web UI**

- Generate another project based on default razor pages app
- Add multi-stage docker build for web ui  
- Push Docker image to cloud: home-ui   

### Deployment at Raspberry Pi with Linux (hostname "rpi")

- Raspbian GNU/Linux 9.1 (stretch) 
- Install Docker  
- Run both Docker images for home-web and home-ui

### Testing
 
- Go back to x64 machine
- Access home-web and home-ui via any browser  

## Running both images at Raspberry Pi

	alias yhomeui='docker run --privileged -p 80:80 -d josemottalopes/home-ui:latest'
	alias yhomeweb='docker run --privileged -p 5010:5010 -d josemottalopes/home-web:latest'

	root@lumi:~# yhomeui
	yhomeweb74342cf8989ad22a865ae18f91baf50a08a72f7c62ff54618f96f653f9aae65f
	root@lumi:~# yhomeweb
	c8a973db87c04543d305fdea07259a35238aae13c5d4696a8e7a178b1d780f01
	root@lumi:~# docker ps
	CONTAINER ID        IMAGE                            COMMAND                  CREATED             STATUS              PORTS                            NAMES
	c8a973db87c0        josemottalopes/home-web:latest   "dotnet IO.Swagger..."   10 seconds ago      Up 7 seconds        80/tcp, 0.0.0.0:5010->5010/tcp   flamboyant_payne
	74342cf8989a        josemottalopes/home-ui:latest    "dotnet Home.UI.dll"     24 seconds ago      Up 11 seconds       0.0.0.0:80->80/tcp               kind_engelbart
	root@lumi:~# 

Checking at the browser, we see both home-web and home-ui projects running at Raspberry Pi with Linux.

![](https://i.imgur.com/VswT4VT.png)

## Upgrading the API

Changes to API are done editing the API master file at Swaggerhub. In order to smoothly update the project, following configuration should be done, selecting the proper repo and a new branch "swag" to store the changes.

![](https://i.imgur.com/tSo7Cui.png)

Please note that it is necessary to allow full control over some folders, including models, controllers and wwwroot, as shown below. 

![](https://i.imgur.com/OrjIqma.png)

The generated files may include some garbage that should be cleaned properly, including some .json and .sln files from previous Visual Studio versions.

For time to time, I noticed some breaking changes at Swaggerhub generated code. In some cases, a special conversion to ASP.Net Core 2.0 maybe done automatically using Visual Studio (I used Community 2017 Preview2). In this case, change the Output Folder to "home2", in order to allow VS to adjust automatically the solution files, libraries, etc. Then bring the changes to "home" in another safe step.

Use the Visual Studio to setup Docker, apply menu "Add Docker support" for the solution. Then docker-compose and dockerfile maybe adjusted, properly pulling the strings for a smooth operation at Windows x64 machine.



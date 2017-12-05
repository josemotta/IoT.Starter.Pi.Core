# Home.Pi
Home Intelligence with Raspberry Pi

Starter  
[From MVC to Razor Pages](https://www.codeproject.com/Articles/1208668/From-MVC-to-Razor-Pages)

React  
[React Shop - A Tiny E-Commerce](https://www.codeproject.com/Articles/1121533/React-Shop-A-Tiny-E-Commerce)

DAL/DB  
[Building Entity Framework Disconnected Generic Repository](https://www.codeproject.com/Articles/1217014/Building-Entity-Framework-Disconnected-Generic-Rep)

## home-pi-1

Web Client Starter for Home project at port:80 using RazorPageShop from Marcelo Oliveira as template.

**Links:**  
https://app.swaggerhub.com/apis/josemottalopes/home-api/1.0.1  
https://github.com/josemotta/Home.Pi  
https://hub.docker.com/r/josemottalopes/home-pi-1/

#### x64: Build 

	cd razorpageshop
	docker-compose -f docker-compose.pi.yml build   
	docker push josemottalopes/home-pi-1:latest  

#### arm: RaspberryPi (hostname "rpi")  
`docker run --privileged -p 80:80 -d josemottalopes/home-pi-1`  

#### any browser: Client Test
    http://rpi



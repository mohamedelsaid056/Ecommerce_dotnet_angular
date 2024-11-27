
# Ecommerce App using ASP.NET and Angular


Hi Friends,

This is a full stack project using ASP.NET 7 and Angular 16 with other best practices as explained below. I hope you like it.


Demo Link:- https://ski-net.azurewebsites.net/

Git Link:- https://github.com/mohamedelsaid056/Ecommerce_dotnet_angular

## Introduction
In this section, you will learn how to build full fledged Ecommerce app using asp.net core and angular 16. Below are the key takeaways from this project. Anyone who wants to learn and write professional enterpise projects can refer this project. This project not only illustrates how to implement all layers to the point rather it adheres to best practices as followed by industry.
 
Here, you will learn variety of technologies like

-	Angular Lazy loading
-	Angular Routing
-	Angular Reactive Forms
-	Angular Creating a MultiStep form wizard
-	Payment gateway integration
-	Angular Re-usable Reactive form components
-	Angular validation 
-	Async Validation
-	.Net Core
-	Angular
-	C# Generics
-	Repository Pattern
-	Unit of Work Pattern
-	Specification Pattern
-	Caching

 While going through the code, you will see how to implement best practices using tons of client/server techniques. Here, you will see
 
-	How to use specification pattern in conjunction with Repository and Unit of Work pattern
-	How to use multiple DbContext to separate business logic with Identities
-	How to use JWTs token using ASP.NET Identity
-	How to load lazy loaded routes.
-	How to use Automapper
-	How to build a cool theme from bootstrap 
-	How to make use of Reactive Forms
-	How to create interceptors
-	How to implement Paging, Sorting, Searching and Filtering
-	How to implement caching both at client and server level
-	How to use Azure Redis Cache 
-	How to integrate payment gateway using Stripe
-	How to create reusable reactive forms
-	How to make use of Input and Output Binding
-	How to make use various observables
-	How to make use of Generics
-	How to create custom middlewares 
-	How to create custom application service extensions
-	How to persist data at service level
-	How to make API error handling more consistent and generic
-	How to seprate multi layer .net project with its responsibility 
-	How to create multi step form to complete the order
-	How to make use of angular material component with bootstrap
-	Accepting payments via Stripe using the new EU standards for 3D secure
-	Publishing the app on Azure
-	And many more things

## How Project is structured 

Below, I have Pasted the high level glimpse project structure.

![14th](https://user-images.githubusercontent.com/3886381/80864879-4f869780-8ca3-11ea-80b1-01481a1c895e.png)

APIs Structure goes like

![16th](https://user-images.githubusercontent.com/3886381/80864882-51505b00-8ca3-11ea-81aa-260347d156ed.png)

Here, you will get Custom middleware implementation, extension methods, DTOs, Custom Error Handling and few Helper methods as well.
 
Angular Project looks like 

![17th](https://user-images.githubusercontent.com/3886381/80864883-51e8f180-8ca3-11ea-988a-b83f2ecfbeb6.png)

Here is the detailed feature-wise detailing of angular project.

![18th](https://user-images.githubusercontent.com/3886381/80864885-52818800-8ca3-11ea-9cf9-5ff65da70210.png)

Then, we have Core implementation of project. This holds design pattern implementation like show below.

![19th](https://user-images.githubusercontent.com/3886381/80864886-52818800-8ca3-11ea-8e1c-b1da3a1b15f5.png)

Similarly, I have Infrastructure project which holds all repository, interface implementation. This also holds the seed project and data context as well.

![20th](https://user-images.githubusercontent.com/3886381/80864887-531a1e80-8ca3-11ea-9fb2-651e4494a185.png)

## Warning and Disclaimer

Every effort applied to make this project complete and accurate to the topic, but no warranty is implied. Any implementation in this project are MY OWN and also borrowed from best practices segment. ALL content presented AS-IS, for learning purposes only. Author will not be liable for any loss or damages arising from the information presented in this project. This also involves stripe implementation. Just use test card as explained in readme not actual card. Incase, if any amount get deducted from actual card, author won't be responsible for any loss or damage. 

## Client

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 16. You can cd into client folder and do npm i to install the packages then ng serve.

## Development server

This project is built using asp.net 7. you can cd into API directory and say dotnet restore and  then dotnet watch run.

## Server Side Technologies

- .Net Core
- Generic Repository Patterns
- Unit of Work Pattern
- Specification Pattern
- Azure Redis Cache
- Sqlite during devlopment
- Mysql in Production
- Swagger
- Stripe Implementation

## Client Side Technologies

- Angular 16
- Bootstrap 5
- ngx-bootstrap
- Font Awesome
- Lazy Loading
- Caching
- RXJS
- Design Components

## NuGet Paackage In Backend 
####  ORM
install-package Microsoft.EntityFrameworkCore.Sqlite  
install-package Microsoft.EntityFrameworkCore  
install-package Microsoft.EntityFrameworkCore.Design  

####  Redis 
install-package StackExchange.Redis  

#### Identity 
install-package microsoft.aspnetcore.identity.EntityFrameworkCore  
install-package microsoft.aspnetcore.identity  
install-package microsoft.identitymodel.tokens  
install-package System.IdentityModel.Tokens.Jwt 

## Store Data   
using **SQLite** for products and related entities for shopping at **Development** enviroment      
using **SQLserver** for products and related entities for shopping at **Production** enviroment    
using **PostgreSQL** for **Identity tables**   
using **Redis** for saving basket items into the server memory


## third party tools  in client "Angular"

#### Setting up Angular to use HTTPS
mkcert is a simple tool for making locally-trusted development certificates   [mkcert](https://github.com/FiloSottile/mkcert)

#### for notifacation for handle error i use "toast" notifications. 
for more infromation   [toast](https://github.com/scttcper/ngx-toastr)

#### Adding breadcrumbs for navigation hierarchies 
Breadcrumbs are vital in applications with deep navigation hierarchies, offering users an intuitive way to traverse back to higher levels effortlessly.  [Breadcrumbs](https://github.com/udayvunnam/xng-breadcrumb/tree/main)

#### For Adding loading indicators waiting for getting Data form API Request usnig spinner 
A library which has loading spinners for Angular    [ngx-spinner](https://www.npmjs.com/package/ngx-spinner)




## Mobile UX

Currently this project is not mobile friendly as I didn't get time to make it mobile compatible. In case, anyone interested, do submit PR.

## PR and Comments

I am open for extension of this project. Incase, if anyone wants to extend any feature, you can submit PR.

## Stripe Test Cards

You can also follow docs here https://stripe.com/docs/testing

![13th](https://user-images.githubusercontent.com/3886381/80680373-3f708b80-8adc-11ea-9fa6-f9cf557c96a1.png)

## Glimpse of the working solution

Demo Link:- https://ski-net.azurewebsites.net/

![1st](https://github.com/user-attachments/assets/fb5e4259-4bcc-4fe1-bd2f-aa19550e99fb)



![4th](https://user-images.githubusercontent.com/3886381/80680053-b8231800-8adb-11ea-8be7-e0e3dba71dca.png)

![5th](https://github.com/user-attachments/assets/27fcc1ac-6ef6-4b63-a4a8-699dc809184e)

![6th](https://user-images.githubusercontent.com/3886381/80680056-b8bbae80-8adb-11ea-83e8-52e552842f97.png)

![7th](https://user-images.githubusercontent.com/3886381/80680058-b9544500-8adb-11ea-8b6c-e4b274e65a9d.png)

![8th](https://user-images.githubusercontent.com/3886381/80680060-b9ecdb80-8adb-11ea-9420-336fe8f76c12.png)

![9th](https://user-images.githubusercontent.com/3886381/80680061-ba857200-8adb-11ea-9a2b-6a221e687a7d.png)

![10th](https://user-images.githubusercontent.com/3886381/80680062-bb1e0880-8adb-11ea-9592-66c677b63702.png)

![11th](https://user-images.githubusercontent.com/3886381/80680064-bb1e0880-8adb-11ea-963a-7a591aef9759.png)












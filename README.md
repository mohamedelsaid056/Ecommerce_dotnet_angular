# NuGet Paackage In Backend 
### for orm 
install-package Microsoft.EntityFrameworkCore.Sqlite  
install-package Microsoft.EntityFrameworkCore  
install-package Microsoft.EntityFrameworkCore.Design  

### for Redis 
install-package StackExchange.Redis  

### Identity 
install-package microsoft.aspnetcore.identity.EntityFrameworkCore  
install-package microsoft.aspnetcore.identity  
install-package microsoft.identitymodel.tokens  
install-package System.IdentityModel.Tokens.Jwt  



##  database used 
SQLite 

## including file that if you need to check all endpoint in postman 
that will help you to get all endpoint in one file you need to import this file in postman 

## عاوزين نشرح ال Archecture بتاع ال app  وخصوصا استخدام ال repositoy pattern مع ال sececifiction pattern 

# archicture pattern used in app 
unit of work pattern 
generic repo pattern 
specification pattern 
clean archicture pattern  
# third party tools  in client "Angular"

### Setting up Angular to use HTTPS
mkcert is a simple tool for making locally-trusted development certificates   [mkcert](https://github.com/FiloSottile/mkcert)

### for notifacation for handle error i use "toast" notifications. 
for more infromation   [toast](https://github.com/scttcper/ngx-toastr)

### Adding breadcrumbs for navigation hierarchies 
Breadcrumbs are vital in applications with deep navigation hierarchies, offering users an intuitive way to traverse back to higher levels effortlessly.  [Breadcrumbs](https://github.com/udayvunnam/xng-breadcrumb/tree/main)

### For Adding loading indicators waiting for getting Data form API Request usnig spinner 
A library which has loading spinners for Angular    [ngx-spinner](https://www.npmjs.com/package/ngx-spinner)

# Store Data   
using **SQLite** for products and related entities for shopping at **Development** enviroment      
using **SQLserver** for products and related entities for shopping at **Production** enviroment    
using **PostgreSQL** for **Identity tables**   
using **Redis** for saving basket items into the server memory





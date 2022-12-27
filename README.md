### Required to install
Installed [.NET 5.0](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/sdk-5.0.408-windows-x64-installer)  
Installed [ASP.NET Core 5.0 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-aspnetcore-5.0.17-windows-x64-installer)

### How to run the app
```
git clone https://github.com/siaserb/PurchaseAccountant.git
cd PurchaseAccountant/PurchaseAccountant
dotnet run
```

### Endpoints
You can use this domain:
* local: `https://localhost:5001/`

* AuthController
    * Registration: `{domain}/api/auth/register`
    * Login: `{domain}/api/auth/login`
* UserController
    * Get All Currencies: `{domain}/api/user/currencies`
    * Change Default Сurrency: `{domain}/api/user/changeCurrency`
* CategoryController
    * Add new category: `{domain}/api/category`
    * Get list of all categories: `{domain}/api/category/items`
* RecordController
    * Add new record: `{domain}/api/record`
    * Get list of user's records: `{domain}/api/record/items`
    * Get list of user's records by categoryId: `{domain}/api/record/items/{id}`

### Postman
![image_2022-12-27_17-28-38](https://user-images.githubusercontent.com/98982425/209687788-11c33f19-d55f-4044-bc74-f31506103857.png)

![image_2022-12-27_17-18-59](https://user-images.githubusercontent.com/98982425/209687837-f8b07c05-bf4c-4e4d-bbb6-b61bcfeb6e5c.png)

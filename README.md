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
![image_2022-12-27_17-18-16](https://user-images.githubusercontent.com/98982425/209687357-db5d4de5-bc25-4288-a9b9-af4178c8876c.png)

![image_2022-12-27_17-18-59](https://user-images.githubusercontent.com/98982425/209687384-8d7a92e6-5be4-4420-9ce2-ae6207391e7b.png)

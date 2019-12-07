1. Open the Solution in Visual Studio
2. Build the project 
3. Navigate to tools ans select Nuget Package manager -> Package Manager Console (PMC)
4. On the console execute the following command
 Update-Database -Context Property_Sales_IdentityContext



5. On the console execute the following command

Update-Database -Context Property_Sales_DatabaseContext



6. After migration is successful Run the project 

7 if you login as admin  from the following credentials will be able to see the Properties , Sales and Buyers 


User : admin@property.com
Password: 1qaz2wsX@

8. Also you can login with the following credentials to visit the site as a buyer
 will be only able to the propertie and confirm a sale

 User : james@property.com
Password: 1qaz2wsX@

9 You can sign up as a new buyer using the sign up Buyer link 

10 if you need to create another  admin login with the admin credentials on step 7 above and
Click in "Register proprty admin"  to register a new admin 



The Authentication and authorization related inofrmtion was obtained from the following links

Role based access control.
https://docs.microsoft.com/en-us/aspnet/core/security/authorization/roles?view=aspnetcore-3.0

ASP.NET MVC 5 Security And Creating User Role

https://www.c-sharpcorner.com/UploadFile/asmabegam/Asp-Net-mvc-5-security-and-creating-user-role/



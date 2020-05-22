### Project: **Week 10 Code Review - Vendor Order Tracker**
#### Author: **Christopher Huber**

### Github page: https://github.com/CHuber42/Fri-5-22-Code-Review
#### Github repo: You're standing on it.
##### Copyright Christopher Huber, 2020

&nbsp;
     
&nbsp;
         
##### Build instructions/Installation: 

This project is built in C# 8.0 using .netcoreapp2.2 on a system running Ubuntu 18.04.
Dependencies are declared in the VendorOrders.csproj and VendorOrders.Tests.csproj files in their respective folders;
to install, simply clone (or download) this folder into a new directory, git bash to ./VendorOrders/ folder,
and run dotnet restore.

To run: either build the project using dotnet build and run the .exe, or navigate to the
./wordcounter/ folder in a terminal and enter "dotnet run"

##### Development Description:

Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.

Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.

The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.

The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.

Able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.

Provide a link to a page presenting a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".


##### Development specs:

** Spec 1: Add a rudimentary homepage (localhost:5000/) that welcomes Pierre (The app host) and redirects him to the vendors page **
** Spec 2: Add a HttpGet route to VendorsController as a list-of-vendors homepage, and an index view to display this path on **
** Spec 3: Add option to Spec #2 to create a new Vendor by clicking a link ** 
** Spec 4: Add route to VendorsController to "catch" spec 3, redirect to Form view **
** Spec 5: Add Form.cshtml and rudimentary form to handle new Vendor creation **
** Spec 6: Add Vendor Class backbone to instantiate during Form submission/Create() Route **
** Spec 7: Add static list of instances of vendors (_instances) to Vendor class **
** Spec 8: Add Id Attribute + constructor assignment **
** Spec 9: Add Name Attribute to Vendor and assign in constructor with passed-in value from Create() Form **
** Spec 10: Modify Vendors' Index.cshtml route to take a model argument ** 
** Spec 11: Add loop to Vendors' index.cshtml to display current vendors **

##### _Contact_:

CHuber42.Gmail.com

##### _Copyright Christopher Huber 2020, all rights reserved._
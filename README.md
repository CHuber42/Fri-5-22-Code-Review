### Project: **Week 10 Code Review - Vendor Order Tracker**
#### Author: **Christopher Huber**

### Github page: https://github.com/CHuber42/Fri-5-22-Code-Review
#### Github repo: You're standing on it.
##### Copyright Christopher Huber, 2020

&nbsp;
     
&nbsp;
         
##### Build instructions/Installation: 

This project is built in C# 8.0 using .netcoreapp2.2 on a system running Ubuntu 18.04.
Dependencies are declared in the VendorOrders.csproj and VendorOrders.Tests.csproj files in their respective folders.
.NetCoreApp 2.2 Framework is required.

To install, simply clone (or download) this folder into a new directory, git bash to VendorOrders.Solution/VendorOrders/ folder,
and run dotnet restore.

To run: either build the project using dotnet build and run the .exe, or navigate to the
VendorOrders.Solution/VendorOrders/ folder in a terminal and enter "dotnet run"

##### Development Description:

Create a Vendor class. This class should include properties for the vendor's name, a description of the vendor, a List of Orders belonging to the vendor, and any other properties you would like to include.

Create an Order class. This class should include properties for the title, the description, the price, the date, and any other properties you would like to include.

The homepage of the app at the root path (localhost:5000/) should be a splash page welcoming Pierre and providing him with a link to a Vendors page.

The vendors page should contain a link to a page presenting Pierre with a form he can fill out to create a new Vendor. After the form is submitted, the new Vendor object should be saved into a static List and Pierre should be routed back to the homepage.

Able to click a Vendor's name and go to a new page that will display all of that Vendor's orders.

Provide a link to a page presenting a form to create a new Order for a particular Vendor. Hint: The route for this page might look something like: "/vendors/1/orders/new".


##### Development specs:

** Spec 1: Add a rudimentary homepage (localhost:5000/) that welcomes Pierre (The app host) and redirects him to the vendors page ** <br>
** Spec 2: Add a HttpGet route to VendorsController as a list-of-vendors homepage, and an index view to display this path on ** <br>
** Spec 3: Add option to Spec #2 to create a new Vendor by clicking a link **  <br>
** Spec 4: Add route to VendorsController to "catch" spec 3, redirect to Form view ** <br>
** Spec 5: Add Form.cshtml and rudimentary form to handle new Vendor creation ** <br>
** Spec 6: Add Vendor Class backbone to instantiate during Form submission/Create() Route ** <br>
** Spec 7: Add static list of instances of vendors (_instances) to Vendor class ** <br>
** Spec 8: Add Id Attribute + constructor assignment ** <br>
** Spec 9: Add Name Attribute to Vendor and assign in constructor with passed-in value from Create() Form ** <br>
** Spec 10: Modify Vendors' Index.cshtml route to take a model argument **  <br>
** Spec 11: Add loop to Vendors' index.cshtml to display current vendors ** <br>
** Spec 12: Make current vendors clickable/use dynamic routing to display unique page for each Vendor **
### As of this point, Vendor/Cshtml routing is mostly complete. Following specs involve compounding behavior regarding "Orders" <br>

** Spec 13: Add basic backbone for Orders using assigned rubric (title, descrip, price, date) ** <br>
** Spec 14: Add non-static list of orders to Vendors class w/empty list instantiation in constructor ** <br>
** Spec 15: Create new OrdersController to handle redirect to New() form for new Vendor's order ** <br>
** Spec 16: Add html form to Views/Orders/New.cshtml to take in fields for new-order instantiation ** <br>
** Spec 17: Write Create() route to handle new-order-form-submission; redirect to --> Previously displayed Vendor ** <br>
** Spec 18: Update Spec 17 to instantiate a new order from params, add order to list in Vendor's list of orders ** <br>
** Spec 19: Add Show() route to OrdersController, Show.cshtml in views/orders ** <br>
### Core functionality Complete

**Spec 20: Stretch goal: implement Partials (Footer) **


##### _Contact_:

CHuber42.Gmail.com

##### _Copyright Christopher Huber 2020, all rights reserved._
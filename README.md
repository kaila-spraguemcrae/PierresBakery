<br>
<h1 align = "center">
<b> Pierre's Bakery Part Two</b>
</h1>

<p align = "center">
#### This MVC application will allow a user to track vendors who have placed orders, 12.18.2020
</p>

<p align = "center">
 By Kaila Sprague McRae
 </p>

--------------------

## 📖  Description

This is an ASP.NET MVC project designed to track both Vendor information and their corrisponding orders. This project was created as part of the Epicodus coursework for the C# Module. 

--------------------

## 🛠️ Technologies Used

This project uses the following technologies:

- C# v7.3
- .NET Core v2.2
- MS Testing
- ASP.NET MVC

-------------------

## Specs

<details>

| Test | Input | Output |
| :------------- | :------------- | :------------- |
| **Order** |  |  |
| It should create an instance of Order | Order testOrder = new Order(); | typeof(testOrder) == Order |
| It should return given Title | "Pastry Order" | "Pastry Order" |
| It should return given Description | "Order of 20 Pastries" | "Order of 20 Pastries" |
| It should return given Price | 34 | 34 |
| It should return given Date | "2.18.2020" | "12.18.2020" |
| It should instantiate Order with and Id | testOrder2. Id | 2 |
| **Order.GetAll()** |  |  |
| It should return empty static List |  | *Empty List* |
| It should return static List with instances of Order object| testOrder = Title, Description, Price, Date // testOrder2 = Title, Description, Price, Date | {testOrder, testOrder2} |
| **Order.Find()** |  |  |
| It should return instance of Order by Id | Order.Find(2) | testOrder2 |
| **Vendor** |  |  |
| It should create an instance of Vendor | Vendor testVendor = new Vendor(); | typeof(testVendor) == Vendor |
| It should return given Name | "Mary's Cafe" | "Mary's Cafe" |
| It should return given Description | "Small local cafe" | "Small local cafe" |
| It should instantiate Vendor with an Id | testVendor. Id | Id |
| **Vendor.AddOrder(Order order)** |  |  |
| It should add instances of Order to an instance of Category's List<Order> |  |  |
| **Vendor.GetAll()** |  |  |
| It should return empty static List |  | *Empty List* |
| It should return static List with instances of Vendor object| testVendor = Name, Description // testVendor2 = Name, Description | {testVendor, testVendor} |
| **Vendor.Find()** |  |  |
| It should return instance of Vendor by Id | Vendor.Find(2) | testVendor2 |

|  |  |  |

</details>

-------------------

## 🔧 Setup/Installation Requirements

### View Online

_To view my live website, Pierre's Bakery, visit_[https://kaila-spraguemcrae.github.io/FINISH-URL](https://kaila-spraguemcrae.github.io/PierresBakery)

### Open Locally

Go to my GitHub repository here, [https://guthub.com/kaila.spraguemcrae/PierresBakery](https://guthub.com/kaila.spraguemcrae/PierresBakery), and click on the green 'Code' button to clone the repository, Open with GitHub Desktop OR Download the ZIP file

#### Necessary Specifications

- To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running `dotnet --version` in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet-core)

* Please note this project uses .NET Core v2.2

#### To clone (my prefered method):
1. Push the green 'Clone' button and copy the URL.
2. Open Terminal or GitBash and input the command: `git clone https://github.com/kaila-spraguemcrae/PierresBakery`
3. To view the code, open the copied directory with Visual Studio Code or your preferred text editor by inputing the command `code .` in your terminal.

#### Running/viewing application:

1. Once you have opened the code in your preferred text editor you will need to navigate to the 'PierresBakery' folder (`cd PierresBakery`) in the command line and run `dotnet run` or `dotnet watch run`.
2. At this point you should be able to click on the link to the local server's url path to view the compiled project. 

#### Running tests:

1. To run MS tests you will need to navigate to the 'PierresBakery.Tests' folder (`cd PierresBakery.Tests`) in the command line and then run `dotnet restore`. 
2. You should now see 'obj' folders in both the 'PierresBakery.Tests' folder and 'PierresBakery' folder.
3. At this point you should be able to successfully run `dotnet test` in the command line (keep in mind you should still be in the PierresBakery.Tests folder). 

--------------------------

## 🐛 Known Bugs

--------------------------

## 📫 Support and contact details

If you run into any problems or have any questions please contact me via [email](mailto:kaila.sprague@icloud.com).

---------------------------

## 📘 License

MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

Copyright (c) 2020 Kaila Sprague McRae
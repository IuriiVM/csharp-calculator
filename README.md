# csharp-calculator
Application used on C# learning purposes

##Task 1 "Initial architectural proposals"

Imagine simplistic caclulator application which contains next UI elements:
* Read-only text box to show current entry or results of calculation.
* 10 buttons to enter numbers from 0 to 9.
* 4 buttons related with basic arithmetic operations ("/", "*", "-", "+').
* Button to calculate result ("=").
* Button to clean text box with results ("C").

For the sake of simplicity we will not deal currently with:
* Negative numbers.
* Numbers with fractional part.
* More than one arithmetic operation.

Your first goal will be to propose API which can handle clicks on all buttons above. 
Do not think about UI, do not think about C#, concentrate on trying to understand what happens under the hood, which data types are processed and what is the most convenient way to make it work.
I expect to obtain from you list which includes:
* Name of method or methods you want to add.
* List of parameters for each method (if any) including their names and data types (do not bother with C#, just use common sense).
* Type of return value for each method ("no return value" answer is valid).
* Short textual description of each method (what is it's intent).

Please do not google answer, the key of this task is to start discussion about optimal solution and evolve it together. Thank you.

##Task 2 "Skeleton solution, attempt to use test-driven approach"

* Create new .NET Framework class library CSharpCalculator.BO which will contain pure calculation logic. Spend some time to investigate which types of projects you can create in Visual Studio.
* In order to use test-driven approach you need to create other .NET Framework class library CSharpCalculator.BO.Test which will contain unit tests.
* In order to be able to use NUnit framework in CSharpCalculator.BO.Test project, install it as a NuGet package. To do that you will need to become familiar with NuGet Package Manager. I warn you that dealing with it can differ depending on which version of Visual Studio you are using.
* Learn how to write basic unit tests using NUnit (pay attention on TestFixture and Test attributes): https://github.com/nunit/docs/wiki/NUnit-Documentation
* Add new class CalculatorServiceTest in CSharpCalculator.BO.Test project, which will be later used to test class CalculatorService from CSharpCalculator.BO project. Prepare CalculatorServiceTest to be used as test fixture.
* Add reference to CSharpCalculator.BO project in CSharpCalculator.BO.Test project.
* Create in CSharpCalculator.BO.Test project single unit test for each method of your proposed public API which just tries to call this method in still non-existing class CalculatorService.
* Create static class CalculatorService in CSharpCalculator.BO project and place there dummy implementations of your public API methods to satisfy previously created unit tests.
* Learn meaning of *using* directive: https://msdn.microsoft.com/en-us/library/sf0df423.aspx 
* Learn what is the difference between static and non-static classes and how it changes the way you are calling their methods: https://msdn.microsoft.com/en-us/library/79b3xss3.aspx
* Learn difference between public and private access modifiers: https://msdn.microsoft.com/en-us/library/ms173121.aspx
* Make sure your solution is compilable and all tests are green.
* Check-in into your GitHub repository excluding unnecessary files.

Do not bother with UI layer implementation. We will do that later.
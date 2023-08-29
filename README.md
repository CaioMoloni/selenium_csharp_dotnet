# Test Automation Project with C# .NET and Selenium

This repository contains a test automation project developed using C# .NET and Selenium for web application testing. The project utilizes various packages and tools to facilitate efficient and reliable automated tests. The tests are written using NUnit as the testing framework and leverage the Page Object Model design pattern for better maintainability and readability.

## Project Setup

### Prerequisites

Before you begin, ensure you have the following installed:

- [Visual Studio](https://visualstudio.microsoft.com/) - The integrated development environment for C# .NET development.
- [NuGet Package Manager](https://www.nuget.org/) - Used to manage project dependencies.
- [Chrome WebDriver](https://sites.google.com/chromium.org/driver/) - Required for running Selenium tests on Chrome browser.

### Packages Used

- DotNetSeleniumExtras.PageObjects - Provides support for the Page Object Model design pattern.
- DotNetSeleniumExtras.WaitHelpers - Includes additional waiting mechanisms for Selenium.
- Microsoft.NET.Test.Sdk - Supports running unit tests.
- NUnit - A popular unit testing framework for .NET applications.
- NUnit3TestAdapter - Allows running NUnit tests in Visual Studio's Test Explorer.
- Selenium.Support - Provides additional support classes for Selenium.
- Selenium.WebDriver - The core Selenium library for interacting with web elements.
- Selenium.WebDriver.ChromeDriver - The Chrome WebDriver for Selenium.

## Getting Started

1. Clone this repository to your local machine.
2. Open the solution file (`SeleniumTraining.sln`) in Visual Studio.
3. Build the solution to restore NuGet packages.

## Writing Tests

1. Create a new test class in the `Tests` folder.
2. Add NUnit `[TestFixture]` attribute to the class.
3. Use the `[Test]` attribute to mark test methods.
4. Implement your test logic using Selenium and the Page Object Model.

Here's a basic example of a test using Page Object Model:

```csharp
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using DotNetSeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
namespace TestAutomationProject.Tests
{
    [TestFixture]
    public class ExampleTests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            // Additional setup code
        }

        [Test]
        public void LoginPage_InvalidCredentials_DisplayErrorMessage()
        {
            // Arrange
            var loginPage = new LoginPage(driver);
            // Additional setup for the test

            // Act
            loginPage.Login("username", "password");

            // Assert
            Assert.IsTrue(loginPage.IsErrorMessageDisplayed());
        }

        [TearDown]
        public void Teardown()
        {
            driver.Quit();
        }
    }
}
```

Running Tests
Open Test Explorer in Visual Studio (Test > Test Explorer).
Click the Run All button to execute all tests.
License
This project is licensed under the MIT License.


Please make sure to adjust the content according to your project's structure, naming conventions, and additional details that you might want to include.

Authority 👨‍💻
https://www.linkedin.com/in/caio-henrique-de-paula-moloni-06999a143/

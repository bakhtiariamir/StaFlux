# Tescligration
### CLI Tools for Integration Test Hosted Service as Windows Service  

![Platform](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Language](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)   
![RunOn](https://img.shields.io/badge/Powershell-3756b3)   
![PoweredBy](https://img.shields.io/badge/Bakhtiari.ME-8A2BE2)

<img src="https://github.com/bakhtiariamir/Tescligration/blob/master/Docs/Tescligration.gif" width="250" height=250>

> [!NOTE]  
> Publishing service project and install as windows service.
> Commands to control subService
>
> * Arrange Services
> * Assertion of Services includes multi type of data service checking
> * Start Services
> * Stop Services
> * Output

> [!IMPORTANT]  
> Each flow of setup services, start and stop keeps in one profile file.
> Each profile file includes information about Inputs, Outputs, Assertion, Logs of services actions.

> [!WARNING]  
> Maybe some services have relation and sequence for executing Because of that executing flow and testing flow are fully separate with each other

## 💻 Dependencies
### :blue_book: Use [CliFx](https://github.com/Tyrrrz/CliFx) package to create commands

## 🚀 Instruction of installation
```Powershell
dotnet tool install --global Tsecligration --version 1.0.1
```
## :cd: Instruction of Setup tools
* Set the path of configuration and mock data in Environment Variables (:bangbang: this variable maybe use in code under the test)



> ### Code under the testing
> To Arrange test for using external service must use [Tescligration.Moq](https://github.com/bakhtiariamir) package
> In configuration services when add external api as a service in each scope, based on Environment

Setup service to test:
```
tsc --service GetInfo -i 
```
Open help: `tsc -h` or `tsc -s <ServiceName>`


# Etymology
It's a Cli tools for Integration Test, Tescligration is combination of Test Cli and Integration.
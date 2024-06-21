# Learning C# with tests using Xunit test framework.

After taking code pull run below command.

```
dotnet build
```

## Basic commands:

```
dotnet —version
dotnet new - - list
dotnet new console -n StartingProject
```

## Testing setup using Xunit : [ Check official doc](https://learn.microsoft.com/en-gb/dotnet/core/testing/unit-testing-with-dotnet-test)

```
dotnet new sln -o unit-testing-using-dotnet-test
cd unit-testing-using-dotnet-test
dotnet new classlib -o PrimeService
ren .\PrimeService\Class1.cs PrimeService.cs
dotnet sln add ./PrimeService/PrimeService.csproj
dotnet new xunit -o PrimeService.Tests
dotnet add ./PrimeService.Tests/PrimeService.Tests.csproj reference ./PrimeService/PrimeService.csproj
dotnet sln add ./PrimeService.Tests/PrimeService.Tests.csproj
```

## For testing:

```
dotnet test
dotnet test --filter "Category=Fibo"
dotnet test --filter "Category=Unit | Category=Integration"
```

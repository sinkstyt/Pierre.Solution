# Console Application for Pierre's Bakery

### Author _Tyler Sinks_
_originally built April 22, 2021_

## Description
* runs from the console
* calculates order totals
* uses at least two classes
* written in C# using the .Net framework (v5.0.100)
* free of gluten, but laden with gluten instances
* uses this price scheme:

| Bakery Item                  | Price |
|------------------------------|-------|
| Bread (1 loaf)               | 5     |
| Bread (3)                    | 10    |
| Pastry                       | 2     |
| Pastry (3)                   | 5     |

## Setup and Installation
_the code depends on just a few built-in namespaces which will be brought into the picture by following these steps_

1. Use terminal or console to navigate to the desired directory for this project
2. Clone the project to your machine:
> ` $ git clone https://github.com/sinkstyt/Pierre.Solution.git `
3. Change directory into the project's root folder:
> ` $ cd Pierre.Solution `
4. Restore the project's dependencies:
> ` $ dotnet restore Pierre Pierre.Tests `
5. To use the project:
> ` $ dotnet run `
6. Or, to examine the files in VS Code instead of step 5:
> ` $ code . `

#### For those completely new to C# and dotnet, please see these detailed instructions:
* [Installing C# and .NET](https://www.learnhowtoprogram.com/c-and-net-part-time-c-and-react-track/getting-started-with-c/installing-c-and-net)
* [MSTest Configuration and Setup](https://www.learnhowtoprogram.com/c-and-net/test-driven-development-with-c/mstest-configuration-and-setup)

### Specs
| Test                                                                    | Input                    | Output |
|-------------------------------------------------------------------------|--------------------------|--------|
| Bread constructor returns an instance whose type is Bread               | type of (new Bread)      | Bread  |
| Bread instance returns an integer at field LoavesInOrder                | Get(LoavesInOrder)       | 4      |
| Static method PriceOfBreads returns integer when LoavesInOrder is 1     | Bread.PriceOfBreads()    | 5      |
| PriceOfBreads returns accurate integer when LoavesInOrder is 5          | Bread.PriceOfBreads()    | 20     |
| Static method GetAll returns a List including all Bread instances       | Bread.PriceOfBreads()    | 20     |
| Pastry constructor returns an instance whose type is Pastry             | type of (new Pastry)     | Pastry |
| Pastry instance returns integer from field PastriesInOrder              | Get(PastriesInOrder)     | 32     |
| Static method PriceOfPastries returns integer when PastriesInOrder is 1 | Pastry.PriceOfPastries() | 2      |
| PriceOfPastries returns accurate integer when PastriesInOrder is 17     | Pastry.PriceOfPastries() | 19     |
| Static method GetAll returns a List including all Pastry instances      | Pastry.PriceOfPastries() | 19     |

### Technologies Used
* _C# and .net5.0_
* _MS Test_
* `git` _and GitHub_
* [C# and .Net curriculum](https://www.learnhowtoprogram.com/c-and-net)
* _VS Code_

### License
* [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://github.com/saoud/csharp-TDD-template/blob/main/LICENSE)
* Copyright 2021 :copyright: Tyler Sinks

## Known Bugs
* no known bugs
* please feel free to reassess this claim
* changes &amp; suggestions are welcomed

### Contact
[email the author](mailto:tyler.sinks@gmail.com)
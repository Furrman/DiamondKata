# DiamondKata

Coding excercise from [davidwhitney/CodeDojo](https://github.com/davidwhitney/CodeDojos/tree/master/Diamond%20Kata). For references purposes I copy-paste the task description below.

## Problem
Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.

### Examples

```
> diamond.exe A
  A
```

```
> diamond.exe B
   A
  B B
   A
```

```
> diamond.exe C
    A
   B B
  C   C
   B B
    A
```

It may be helpful visualise the whitespace in your rendering like this:

```
> diamond.exe C
_ _ A _ _
_ B _ B _
C _ _ _ C
_ B _ B _
_ _ A _ _
```

## Solution

### Approach

I decided to implement simple cross platform console application with Visual Studio Code as IDE. To achieve cross platform support I used the newest .NET SDK version 8. I wrote application using TDD approach with usage of xUnit as my test library. That is the only package I felt necessary to achieve the goal.

In addition to the code solution I created two additional folders. First one is ***.github*** which contains GitHub Action workflow definition for building application and running tests for every push to *main* branch. Second one ***.vscode*** contains information how to build and run application from Visual Studio Code IDE.

### Project structure

Project is splitted into two folders - `src` and `test`. First one is the place where I put console application together with class responsible for generating diamond string, and the second one for test project with unit tests targeting mentioned class.

I decided to keep main logic just in separate file mostly for Single Responsibiloty Principle. Also, I put this file in the same project as main console program, as I believe there is no reason to overengineer and create separate library for my case.

### Usage

Open solution ***.sln*** file via Visual Studio Code or Visual Studio and run project. Alternatively you can build the application via terminal using command `dotnet build` and run it with command `diamond.exe` or `diamond` from *bin* folder (depending on OS). You can run tests using `dotnet test` command.

I recommend also using Visual Studio Code in browser for review purposes by changing url of my repository from `github.com` to `github.dev` (or click [here](https://github.dev/Furrman/DiamondKata)).
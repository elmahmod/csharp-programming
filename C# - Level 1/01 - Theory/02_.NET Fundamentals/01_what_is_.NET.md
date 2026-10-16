## 🟢 1. What is .NET?

**.NET** is a software development platform created by Microsoft. It is used to build and run different types of applications using programming languages such as C#.

For example, you can use .NET to create:

- 🖥️ Desktop Applications.
- 🌐 Web Applications.
- 📱 Mobile Applications.
- 🎮 Games.
- ☁️ Cloud Services.

### What does Platform mean?

The instructor wrote:

`Platform = Programming Language + Libraries`

This is a simplified explanation, but .NET actually consists of several components:

| Component | Purpose |
|---|---|
| Programming Languages | Languages used to write code |
| Libraries | Ready-made code and functions we can use |
| Runtime | The environment that executes the program |
| Development Tools | Tools used to build applications |

**A simple example using C#:**

```csharp
Console.WriteLine("Hello World!");
```

Here:

- `C#` is the programming language we use.
- `Console.WriteLine()` is a ready-made function from the .NET libraries.
- `.NET Runtime` helps execute the program.

So, **C# is the language, and .NET is the platform that helps us build and run programs.**

---

## 🔵 2. Programming Languages in .NET

The .NET platform supports several programming languages:

| Language | Usage |
|---|---|
| C# | The most popular language for developing .NET applications |
| Visual Basic (VB.NET) | An easy-to-read language used in some business applications |
| F# | A language that supports Functional Programming |

These languages can use many of the shared libraries available in .NET.

---

## 🟢 5. What Does "All Use a Standard Set of Libraries" Mean?

It means that .NET technologies and languages can benefit from a large collection of shared standard libraries.

For example:

```csharp
Math.Sqrt(25);              // Mathematics
DateTime.Now;               // Date and Time
Console.WriteLine("Hello"); // Console Output
```

Instead of writing every function yourself, you can use ready-made functions provided by .NET.

However, this does not mean that all libraries work on every .NET version or operating system. Some libraries are platform-specific.

---

## ⭐ Summary

Remember these basic relationships:

**C#**

Programming Language — Used to write code

⬇️

**.NET**

Development Platform — Libraries, runtime, and tools

⬇️

🖥️ Desktop | 🌐 Web | 📱 Mobile

**The most important point when learning C#:** When you see `.NET Framework` and `.NET` options in Visual Studio, it does not mean you are choosing a different programming language.

In both cases, you can use C#, but you are choosing the runtime platform and libraries that your project will depend on.

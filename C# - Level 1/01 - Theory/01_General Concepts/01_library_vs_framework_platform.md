# Library vs Framework vs Platform

## 📚 1. What is Library?

A library is a collection of pre-written code that developers can use to add functionality to their applications.

A library typically provides a set of functions or classes that a developer can call from their code to perform specific tasks, without having to write all the code from scratch.

**Example:** [String Library](https://github.com/elmahmod/cpp-oop-concepts/blob/main/Small%20Practicing/string_library/clsString.h)

---

## 🏗️ 2. What is Framework?

A framework is a set of libraries and tools that provide structure and support for building and running applications.

A framework defines a set of rules, protocols, and conventions that developers must follow when writing their code. This helps ensure that all parts of an application work well together and follow a consistent design pattern.

---

## 💻 3. What is Platform?

A platform refers to the hardware or software environment in which a piece of software runs.

For example, a computer running the Windows operating system could be considered a platform for running software written for Windows.

---
---


### 💡 Example: Library

```csharp
double result = Math.Sqrt(25);
```

**You call the library** whenever you need it.

**Your Code → Library**

---

### 💡 Example: Framework (Windows Forms)

Windows Forms provides ready-made controls like `Button` and `TextBox`, and manages events.

```csharp
private void button1_Click(object sender, EventArgs e)
{
    MessageBox.Show("Hello!");
}
```

When the user clicks the button, **Windows Forms calls your method automatically** through its event system.

**Framework → Your Code**

💡 This is an example of **Inversion of Control (IoC)**.

---

### 💡 Example: Platform (.NET)

.NET provides the environment and tools needed to build and run C# applications.

- **Runtime:** Executes your application.
- **Libraries:** Provide reusable functionality.
- **SDK:** Provides development and build tools.

**C# Code → .NET Runtime → Windows**

---

### 🧠 Quick Reminder

- **Library:** You call its functions.
- **Framework:** Provides structure and often calls your code.
- **Platform:** Provides the environment and services to build or run applications.

---

### 🌐 Translations

[![Arabic PDF](https://img.shields.io/badge/Arabic-Download_PDF-blue)](https://github.com/user-attachments/files/33532160/01_library_vs_framework_vs_platform_AR.pdf)

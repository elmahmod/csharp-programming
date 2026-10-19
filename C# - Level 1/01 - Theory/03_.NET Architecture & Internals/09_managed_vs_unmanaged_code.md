# Managed Code vs. Unmanaged Code in .NET

## 1. Managed Code

**Managed code** is code that runs under the control of the **Common Language Runtime (CLR)**.

- The CLR executes managed code and provides runtime services such as **memory management**, **security-related services**, and **exception handling**.
- The CLR also supports **cross-language debugging**, allowing developers to work with applications built using different .NET languages.
- Code written in .NET languages, such as **C#** and **VB.NET**, is typically compiled into **Intermediate Language (IL / MSIL)** and executed as managed code by the CLR.

> **Key idea:** Managed code runs under CLR supervision and benefits from its runtime services.

## 2. Unmanaged Code

**Unmanaged code** is code that does **not** run under the control of the CLR.

- It is commonly written in languages such as **native C++** and compiled into machine code.
- Unmanaged applications may perform **low-level operations**, including accessing operating system functionality directly.
- Older technologies mentioned in the course, such as **classic Visual Basic (VB)**, **classic ASP**, and **COM**, are examples of technologies often associated with unmanaged components or interoperability.
- When managed applications need to use unmanaged components, they can communicate through **interoperability mechanisms**, including **wrapper classes**.

> **Key idea:** Unmanaged code executes outside CLR management, but it can still interact with managed .NET applications.

## 3. Interoperability Between Managed and Unmanaged Code

The CLR provides **interoperability support**, allowing managed and unmanaged components to work together.

For example, a C# application can call functionality implemented in a native C++ library through a suitable interop mechanism or wrapper.

```text
Managed .NET Application (C#)
            |
            v
    Interoperability Layer
       / Wrapper
            |
            v
Unmanaged Component (Native C++ / COM)
```

## 4. What Is COM?

**COM = Component Object Model**.

- COM is an older Microsoft component technology introduced in **1993**.
- It allows applications or components to access methods provided by another component **without compiling that component's implementation directly into the application**.
- The course describes this as a form of **client-server communication** through component methods.

## 5. Quick Comparison

| Managed Code | Unmanaged Code |
|---|---|
| Runs under CLR control. | Runs outside CLR control. |
| Benefits from CLR runtime services. | Does not rely on CLR to manage its execution. |
| Example: typical C# code running on .NET Framework. | Example: native C++ code or a COM component. |
| Can call unmanaged components using interoperability support. | Can interact with managed components through appropriate wrappers or interop mechanisms. |

### Summary

- **Managed Code:** Code whose execution is managed by the CLR.
- **Unmanaged Code:** Code whose execution is not managed by the CLR.
- **Interoperability:** The mechanisms that allow the two kinds of code to communicate.

**Technical note:** Whether code is managed depends on how it is compiled and executed, not solely on the programming language's name. For example, C++ can also be used with .NET through C++/CLI.

---
*Based on course material by Mohammed Abu-Hadhoud, ProgrammingAdvices.com (2023).*

---

### 🌐 Translations

[![Arabic PDF](https://img.shields.io/badge/Arabic-Download_PDF-blue)](https://github.com/user-attachments/files/33650987/09_managed_vs_unmanaged_code_AR.pdf)

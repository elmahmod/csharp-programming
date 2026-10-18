# 🧹 Garbage Collector (GC)

**Garbage Collector (GC)** is a component of the **Common Language Runtime (CLR)**. It automatically reclaims memory occupied by objects that an application can no longer access.

GC is part of **Automatic Memory Management** in .NET.

## 1. How Does Garbage Collection Work?

1. **Object creation:** When you use `new`, .NET allocates memory for the object, usually on the **Managed Heap**.
2. **Object usage:** The application accesses the object through references.
3. **Object becomes unreachable:** When the application can no longer reach the object, it becomes eligible for garbage collection.
4. **Memory reclamation:** The GC may reclaim that memory later so it can be reused.

## 2. Simple C# Example

```csharp
Student student = new Student();

student.Name = "Ali";

student = null;
```

Setting `student` to `null` removes that variable's reference to the object. **If no other references can reach the object**, it becomes eligible for garbage collection.

> **Important:** The GC does **not** necessarily remove the object immediately. The .NET runtime determines when garbage collection occurs.

## 3. Benefits of Garbage Collection

- Reduces the need to manually free memory used by managed objects.
- Reclaims memory from objects that are no longer reachable.
- Helps reduce errors related to manual memory management.

**Note:** Object protection and **type safety** are not handled by the GC alone; other CLR services contribute to them.

## 🎯 Summary

The **Garbage Collector** is a CLR component that automatically reclaims the memory of managed objects the application can no longer reach, allowing that memory to be reused.

---

### 🌐 Translations

[![Arabic PDF](https://img.shields.io/badge/Arabic-Download_PDF-blue)](https://github.com/user-attachments/files/33628339/05_garbage_collector_GC_AR.pdf)

# 🤖 Inventory Management

Welcome to Inventory Management project. 
---
This project demonstrates:

1. Custom Types (Product class)
2. Extension Methods (TotalValue and LowStock)
3. Anonymous Types (LINQ query selecting Name and Price)
4. Pointer Types (unsafe block)

---
### Write a short paragraph explaining what pointer types are in C#, when they are used and why they require unsafe context?

### Pointer types in C#
Variable memory addresses are stored in pointer types where they can permit direct memory manipulation (Rashid, 2017).
In C#, pointer types need an unsafe context and are declared with the * symbol (Rashid, 2017).
You get primitive value types, struct containing value types and other pointer types (Rashid, 2017).

#### When do they get used?
- You use pointer types with unmanaged code (Rashid, 2017).
- You use pointer types when performance is crucial (Rashid, 2017).
- You use pointer types when you need no time waste in unnecessary runtime checks, therefore low-level memory operations (Rashid, 2017).

#### Why they require unsafe context?

Any code in C# that isn't within the Common Language Runtime's (CLR) control is considered unsafe code. The programmer doesn't have to worry about it because the CLR handles things like memory management type verification.
Because they are used outside of the CLR, pointers are regarded as "Unsafe." Program security and stability are now the responsibility of the programmer and cannot be ensured by the CLR. The developer is responsible for preventing memory corruption and the compiler knows to allow direct memory access operations (Sanyal, 2020).

---
### References:

Rashid, M. 2017. Pointers And Unsafe Code In C# - Everything You Need To Know [Source Code]. Available at: <<https://www.c-sharpcorner.com/article/pointers-and-unsafe-code-in-c-sharp-everything-you-need-to-know/>> [Accessed 8 August 2025]. 

Sanyal, D. 2020. Why are pointers considered “unsafe” in C#? [Source Code]. Available at:  <<https://www.quora.com/Why-are-pointers-considered-unsafe-in-C>> [Accessed 8 August 2025].

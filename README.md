# YoursTrulyInarius - C# Assignments

This repository contains my C# programming assignments, refactored for maximum compatibility and ease of use.

## Project Structure
- **YoursTrulyInarius.sln**: Solution file created to manage all projects (`p1` and `p2`) from the root directory.
- **/p1**: Exercise 1 - Name Input System.
- **/p2**: Exercise 2 - Item Management Menu System.
- **.gitignore**: Added to ensure no build artifacts (`bin/`, `obj/`) are pushed to the repository.

---

## What We Fixed & Improved

### 1. Root Directory Execution
- Added a `.sln` (Solution) file to the root.
- **Fix**: You can now run `dotnet run --project p2` directly from the root without getting the "Couldn't find a project to run" error.

### 2. Universal Compatibility
- **Refactored structure**: Changed the code from "Top-level statements" to a traditional `class Program { static void Main() { ... } }` structure. This ensures it works on all IDEs, including mobile and older C# versions.
- **Removed Nullable Annotations**: Removed `?` annotations (like `string?`) to prevent "CS8632" build errors in environments that don't support modern nullable reference types.

### 3. Robust Path Handling
- **Fix**: Updated file operations to use `AppDomain.CurrentDomain.BaseDirectory` for `names.txt` and `items.txt`. No more "File not found" errors when running the program from different directories.

### 4. Resilient UI
- **Fix**: Wrapped `Console.Clear()` in a try-catch block to prevent the program from crashing if it's run in a terminal that doesn't support clearing the screen.

---

## How to Run
Run these commands from the root directory:

### Exercise 1: Name Input System
```powershell
dotnet run --project p1
```

### Exercise 2: Item Management Menu System
```powershell
dotnet run --project p2
```

---
*Created as part of BSIT 2 C curriculum.*

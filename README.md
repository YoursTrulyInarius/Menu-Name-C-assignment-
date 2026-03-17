# BSIT 2 C - First C# Assignment

This repository contains my first C# programming assignment. It consists of two separate console applications organized into `p1` and `p2` folders.

## Project Structure
- **/p1**: Exercise 1 - Name Input System
- **/p2**: Exercise 2 - Item Management Menu System

---

## 1. Name Input System (p1)
A simple interactive console application that collects a list of names from the user.

### How it Works:
- **Input Loop**: The program prompts the user to enter names one by one.
- **Exit Condition**: Typing `exit` (case-insensitive) terminates the input process.
- **Persistence**: Once finished, all entered names are saved to a file named `names.txt` within the `p1` directory.
- **Display**: The application reads the saved names from the file and displays them back to the terminal.

### How to Run:
```powershell
cd p1
dotnet run
```

---

## 2. Item Management Menu System (p2)
A menu-driven console application with persistent UI for managing items.

### How it Works:
- **Persistent Menu**: Displays a menu with three options:
  1. **Add item**: Prompts for an item name and appends it to `items.txt`.
  2. **View items**: Displays all items currently saved in `items.txt`.
  3. **Exit**: Displays a farewell message ("thank You for using") and closes the app.
- **UI Design**: Uses `Console.Clear()` to ensure the menu [1-3] always stays at the top of the terminal every time you perform an action.
- **Interaction**: The system uses real-time user input and saves data immediately to a text file.

### How to Run:
```powershell
cd p2
dotnet run
```

---
*Created as part of BSIT 2 C curriculum.*

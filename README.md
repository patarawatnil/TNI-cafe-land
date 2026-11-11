# TNI Cafe Land

A Windows desktop cafe ordering application developed in C# with Windows Forms as a collaborative university project.

## Project Overview

TNI Cafe Land allows a user to register or log in, browse food and beverage menus, build an order, review the order total and member discount, and generate a receipt as a text file.

## Features

- **Registration and login:** Create login credentials and sign in to the application.
- **Menu selection:** Browse menu categories and select available items and serving options.
- **Order management:** Add, edit, remove, and clear items in the current order.
- **Price calculation:** Calculate each item's subtotal from its unit price and quantity, then calculate the order total.
- **Member discount:** Apply the 10% member discount shown in the application.
- **Receipt generation:** Write the order details, total, discount, and net amount to a `.txt` receipt.

## Technologies

- C#
- Windows Forms (WinForms)
- .NET Framework 2.0 (as specified in the original project file)
- Text-file output using `System.IO.StreamWriter`

## My Contribution

This was a collaborative project, with team members responsible for different parts of the application. My recollection is that my assigned work focused on the ordering workflow:

- Selecting food and beverage menu items and specifying quantities.
- Managing the selected order items.
- Calculating item subtotals and the overall order price.
- Generating the customer receipt in text-file format.

The repository contains the consolidated source code available to me. The original project was not developed with Git version control, so the commit history does not represent the original development timeline or identify individual authors of each source file.

## Project Structure

The solution contains a Windows Forms application with the following main forms:

| File | Purpose |
|---|---|
| `login.cs` | Login screen |
| `REGIS.cs` | Registration screen |
| `Form1.cs` | Main screen and order management |
| `Menu_selection.cs` | Menu and quantity selection |
| `Menu_confirmation.cs` | Order confirmation and discount calculation |

Designer and resource files (`*.Designer.cs` and `*.resx`) support the Windows Forms user interface.

## How to Open

1. Open `WindowsFormsApp1.sln` in Visual Studio with support for the .NET Framework 2.0 project format.
2. Allow Visual Studio to load the Windows Forms project.
3. Build and run the application.

> **Compatibility note:** This is an older project targeting .NET Framework 2.0. A modern Visual Studio installation may require legacy targeting components or project adjustments. The project has not been modernized as part of this repository preparation.

## Receipt Output

The original code writes receipt files to the `D:\` drive using a filename containing the date and time. The application may need a writable `D:\` drive, or the output path may need to be changed in `Form1.cs` for another computer.

## Notes

- This repository is a preservation of an older university group project, not a claim of sole authorship.
- Git was not used during the original development. The initial Git commit created for this repository represents the available source snapshot only.
- No database integration was identified in the application code reviewed for this README.

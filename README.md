# Bank Management System

A desktop application built with C# and Windows Forms (WinForms) for automating bank system workflows, managing customer records, and handling financial data.

## Features
- **Multi-Form Architecture:** Interactive desktop workflow connecting main views (`ShowCustomers`) with helper and edit forms (`EditCustomers`, `AddCustomerForm`).
- **Data Persistence & Parsing:** Implements File I/O (`System.IO`, `StreamWriter`) to read, parse, and persist customer database records in structured text formats (`Customers.txt`).
- **Data Mapping & Synchronization:** Synchronizes array structures across creation, reading, and saving operations to prevent index mismatch errors.
- **Data Integrity & Business Logic:** Restricts editing to authorized fields while protecting critical financial metrics (Customer ID, balance, savings accounts) from unauthorized overwrites.

## Tech Stack
- **Language:** C#
- **Platform / Framework:** .NET Framework, Windows Forms (WinForms)
- **IDE:** Visual Studio
- **Data Storage:** File I/O (System.IO), Text Streams (StreamWriter), String Parsing (`.Split()`, `string.Join()`)

## Getting Started
1. Clone the repository or download the ZIP archive.
2. Open the solution file in **Visual Studio**.
3. Build and run the project (`F5`).

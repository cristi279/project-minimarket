 # Project-Minimarket

  A simple point-of-sale system built with C# and Windows Forms for learning desktop application development.

  ## Features

  - Basic product inventory management
  - Sales transaction processing
  - Simple user interface for cashier operations
  - Data persistence using local storage
  - Report generation for daily sales

  ## Technologies Used

  - **Language**: C#
  - **Framework**: .NET Framework 4.7.2
  - **UI**: Windows Forms
  - **IDE**: Visual Studio 2022
  - **Data**: Local file storage (planned migration to SQL Server)

  ## Getting Started

  ### Prerequisites

  - Windows 10/11
  - Visual Studio 2022 (Community edition works)
  - .NET Framework 4.7.2 Developer Pack

  ### Installation

  1. Clone the repository:
     ```bash
     git clone https://github.com/cristi279/project-minimarket.git

  2. Open projet-minimarket.sln in Visual Studio
  3. Build the solution (Ctrl+Shift+B)
  4. Run the application (F5)

  Usage

  1. Launch the application
  2. Use the "Products" tab to add/manage inventory
  3. Switch to "Sales" tab to process transactions
  4. View daily reports in the "Reports" section

  Project Structure

  project-minimarket/
  ├── Properties/
  ├── References/
  ├── Forms/
  │   ├── MainForm.cs
  │   ├── ProductForm.cs
  │   └── SalesForm.cs
  ├── Models/
  │   ├── Product.cs
  │   └── Sale.cs
  ├── Services/
  │   ├── InventoryService.cs
  │   └── SalesService.cs
  ├── Data/
  │   └── storage.json
  ├., projet-minimarket.csproj
  └., projet-minimarket.sln

  Future Improvements

  - [ ] Migrate to SQL Server for data storage
  - [ ] Add user authentication and roles
  - [ ] Implement barcode scanning support
  - [ ] Add export to CSV/PDF for reports
  - [ ] Create unit tests for business logic
  - [ ] Improve UI with modern styling

  Lessons Learned

  This project helped me understand:
  - Windows Forms event-driven programming
  - Basic MVVM separation in desktop apps
  - File I/O for simple data persistence
  - UI validation and user feedback patterns
  - Debugging techniques in Visual Studio

  Acknowledgments

  - Microsoft Learn tutorials for Windows Forms
  - Stack Overflow community for troubleshooting
  - University coursework on object-oriented design

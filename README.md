# Ultimate Resources HR (HRMS)

> **Status: Complete.** A working desktop application built as coursework in 2020.

A Human Resource Management System built with C# WinForms, supporting Admin, Manager and Inquirer roles for managing employee records and salary/payment processing. Designed from a full activity diagram, ERD and logical flowchart before implementation.

## Features

- **Login / Registration** — account creation and sign-in
- **Admin** — employee record management (add, update, view)
- **Manager** — oversight of employee and payment data
- **Inquirer** — read-only lookups
- Salary and employee payment processing forms

## Tech stack

- **C# (.NET Framework, WinForms)** — desktop UI
- **MySql.Data** connector — database connectivity
- **MySQL** — relational backend (`employee_info_table`, `user_info_table`)

## Project structure

```
hrms/
├── HrmsProject.sln          # Visual Studio solution file
├── src/                     # All C# source, forms, and resources
│   ├── Properties/
│   └── Resources/
├── database/
│   └── hrms_database1.sql   # Schema
└── docs/                    # Original design documents
    ├── activity-diagram.pdf
    ├── erd.pdf
    ├── logical-design.pdf
    └── login-ui.pdf
```

## Setup

1. **Database**
   - Create a local MySQL database named `hrms_employee_database`:
     ```sql
     CREATE DATABASE hrms_employee_database;
     ```
   - Import the schema:
     ```
     mysql -u root -p hrms_employee_database < database/hrms_database1.sql
     ```

2. **Open in Visual Studio**
   - Open `HrmsProject.sln` in Visual Studio (Windows).
   - Restore NuGet packages (`MySql.Data` and its dependencies) if prompted.
   - Set the startup project and run — `Program.cs` is the entry point, opening `LoginForm`.

## Design process

The system was designed before implementation using:
- An **activity diagram** mapping the login → permission check → Employee Management / Organisational Management / Payroll / Attendance flow
- An **ERD** covering 10 entities: User, User_Level, Employee, Personal_Information, Department, Position, Performance, Level_Authorization, Attendance, Payroll_Salary, Training
- A **logical design flowchart** for the full process from login through recruitment, probation, transfer, promotion/demotion, payroll, attendance and logout
- A **login UI mockup** for the "Ultimate Resources HR" branding

All four documents are in `docs/`.

## Notes

This was built as coursework and is illustrative rather than production-grade — see the credentials warning above before making this public.

## Author

April Soe Naing — [aprilsoenaing.786@gmail.com](mailto:aprilsoenaing.786@gmail.com)

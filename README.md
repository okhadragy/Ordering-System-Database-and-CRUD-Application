# 🧾 Desktop Ordering Management System (C# + SQL Server)

A complete desktop-based Ordering Management System built using **C# Windows Forms** and **Microsoft SQL Server**. The system handles customer orders, employee roles, cart management, and restaurant menus with full database support and a clean UI.

---

## 🚀 Features

- Role-based user authentication (Admin, Customer, Employee)
- Add/Edit/Delete restaurants and menu items
- Cart and order management
- Order history and payment tracking
- Stored procedures, functions, and SQL views used for efficiency
- ERD and normalized database schema
- Clean and responsive Windows Forms UI

---

## 🧱 Tech Stack

- **Frontend**: C# (Windows Forms)
- **Backend**: Microsoft SQL Server
- **Database**: Stored Procedures, Functions, Views, Triggers

---

## 🗂 Entity Relationship Diagram (ERD)

![ERD](https://github.com/user-attachments/assets/19e53574-d4a5-42ce-8b1f-3912cf2fb69c)

---

## 🛢 Database Schema

![Schema1](https://github.com/user-attachments/assets/ebff852f-2fbc-41cf-8943-f6c5281e95fc)
![Schema2](https://github.com/user-attachments/assets/bfeba084-78b3-4ee6-bb5a-ea4ab9556474)

---

## 🖼️ System Screenshots

![Login](https://github.com/user-attachments/assets/bea582bf-3c89-45be-b2c6-955c993b2bee)
![View Data](https://github.com/user-attachments/assets/ef1c4117-a879-4e08-9ff2-c5e868da5387)
![Data Insertion](https://github.com/user-attachments/assets/c1ef615f-0909-49e9-9767-e44994224dd9)
![Update](https://github.com/user-attachments/assets/75d9ea7a-546a-4712-b3d2-bebb9fbb755e)
![Delete](https://github.com/user-attachments/assets/8e3f13cc-3faa-4ac9-b9e0-eea4709f846b)
![Extra Procedure](https://github.com/user-attachments/assets/45b239d5-aa2c-4aa1-958b-c94d405671eb)

---

## ⚙️ How to Run

1. Clone the repo:
   ```bash
   git clone https://github.com/okhadragy/Ordering-System-Database-and-CRUD-Application.git
   cd Ordering-System-Database-and-CRUD-Application
   ```

2. **Open in Visual Studio**

   * Open the `.sln` file using **Visual Studio**.

3. **Update SQL Server Connection String**

   * In the `App.config` file, make sure the connection string points to your SQL Server instance:

     ```xml
     <connectionStrings>
       <add name="YourDB" connectionString="Data Source=.;Initial Catalog=OrderingDB;Integrated Security=True" />
     </connectionStrings>
     ```

   * Replace `Data Source=.` if your SQL Server instance differs (e.g., `Data Source=localhost\SQLEXPRESS`).

4. **Set Up the Database**

   * Run the SQL script located at `database/setup.sql` using SQL Server Management Studio (SSMS) to:

     * Create all tables
     * Define stored procedures, functions, and views
     * Insert seed data

5. **Build and Run**

   * Build the solution in Visual Studio.
   * Start the application.

---

## 📁 Repo Structure

```
📦 project-root
├── 📂 database
|   ├── dummy_data.sql
│   ├── setup.sql
│   ├── procedures.sql
│   ├── functions.sql
│   └── views.sql
├── 📂 src
│   └── (C# solution and project files)
└── README.md
```

## 📜 License

This project is for educational use. Feel free to fork and enhance.


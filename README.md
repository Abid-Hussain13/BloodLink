# 🩸 BloodLink — Blood Bank Management System

> **Every drop counts. Be someone's reason to live.**

BloodLink is a desktop-based Blood Bank Management System built with **C# Windows Forms** and **SQLite**. It helps hospital staff and blood bank operators manage donors, blood inventory, patient requests, and staff accounts — all from a clean, modern dark/light-themed interface.

---

## 📸 What Does BloodLink Do?

BloodLink streamlines blood bank operations by providing:

- **Donor Management** — Register, update, search, and track donor eligibility and donation history
- **Blood Inventory** — Track blood units by group, collection date, expiry, and status (Available / Reserved / Used / Expired)
- **Patient Requests** — Create and manage blood requests from patients, track fulfillment status
- **Reports & Analytics** — Visual charts for monthly donations, blood stock levels, and request status breakdown
- **Staff Management** — Admin can add, update, and remove operator accounts
- **Auto-expiry** — Blood units are automatically marked as Expired when their date passes
- **Dark / Light Theme** — Toggle between themes with a smooth animated pill switch

---

## 🏗️ Project Structure

```
BloodLink/
│
├── Models/                  # Data models
│   ├── BloodUnit.cs
│   ├── Donor.cs
│   ├── PatientRequest.cs
│   ├── PatientModel.cs
│   ├── BloodIssuance.cs
│   ├── BloodUnitStats.cs
│   ├── User.cs
│   └── Enums.cs             # BloodGroup, Role, Gender, Status enums
│
├── Database/                # SQLite data layer
│   ├── DatabaseHelper.cs    # DB init, table creation, seeding
│   ├── BloodUnitRepository.cs
│   ├── DonorRepository.cs
│   ├── PatientRequestRepository.cs
│   └── UserRepository.cs
│
├── Interfaces/              # Repository contracts
│   ├── IBloodUnitRepository.cs
│   └── IPatientRequestRepository.cs
│
├── Services/                # Business logic layer
│   ├── AuthService.cs
│   ├── BloodUnitService.cs
│   ├── DonorService.cs
│   └── PatientRequestService.cs
│
├── Forms/                   # Dialogs / pop-up forms
│   ├── LoginForm.cs/.Designer.cs
│   ├── DashboardShell.cs/.Designer.cs
│   ├── DonorForm.cs/.Designer.cs
│   ├── BloodUnitForm.cs/.Designer.cs
│   ├── PatientForm.cs/.Designer.cs
│   └── UserForm.cs/.Designer.cs
│
├── Pages/                   # UserControl pages loaded in dashboard
│   ├── AdminDashboardPage.cs/.Designer.cs
│   ├── DonorPage.cs/.Designer.cs
│   ├── BloodUnitPage.cs/.Designer.cs
│   ├── PatientsPage.cs/.Designer.cs
│   ├── ReportsPage.cs/.Designer.cs
│   └── StaffPage.cs/.Designer.cs
│
├── Helpers/                 # Utility classes
│   ├── AppTheme.cs          # Colors, fonts, dark/light mode
│   ├── PaintHelper.cs       # Custom rounded UI rendering
│   └── EnumHelper.cs        # Enum ↔ description conversion
│
└── Program.cs               # Entry point
```

---

## ✨ Features

| Feature | Details |
|---|---|
| 🔐 Login | Email + BCrypt password authentication |
| 👥 Role-based access | Admin sees all pages; Operators see limited pages |
| 🩸 Blood inventory | Full CRUD, filter by group & status |
| 🏥 Patient requests | Track Pending / Fulfilled / Cancelled requests |
| 👤 Donor registry | Eligibility tracking, last & next donation dates |
| 📊 Reports | Bar chart (monthly donations), pie chart (request status), stock bars |
| ⏰ Auto-expiry | Units expire automatically; checked on startup + every hour |
| 🌙 Dark/Light theme | Smooth animated toggle switch in the header |
| 🔍 Search & filter | Live search across donors, blood units, and patient requests |

---

## 🖥️ Tech Stack

| Layer | Technology |
|---|---|
| Language | C# (.NET 8 / .NET 9) |
| UI Framework | Windows Forms (WinForms) |
| Database | SQLite (via `Microsoft.Data.Sqlite`) |
| Password Hashing | `BCrypt.Net-Next` |
| Charts | `LiveChartsCore.SkiaSharpView.WinForms` |
| Icons | `FontAwesome.Sharp` |

---

## 📦 NuGet Packages

Install the following packages via NuGet Package Manager or the .NET CLI:

```bash
dotnet add package Microsoft.Data.Sqlite
dotnet add package BCrypt.Net-Next
dotnet add package LiveChartsCore.SkiaSharpView.WinForms
dotnet add package FontAwesome.Sharp
```

Or search and install them directly in **Visual Studio → Tools → NuGet Package Manager → Manage NuGet Packages for Solution**.

---

## 🗄️ Database

BloodLink uses **SQLite** and creates its database automatically on first launch at:

```
%AppData%\BloodLink\bloodlink.db
```

> ✅ You do **not** need to create tables manually. The app creates all tables and seeds initial data on startup via `DatabaseHelper.Initialize()`.

### Tables Created Automatically

#### `Users`
| Column | Type | Notes |
|---|---|---|
| Id | TEXT (PK) | Format: `USR-YYYY-XXXXXX` |
| FullName | TEXT | |
| Email | TEXT (UNIQUE) | |
| Password | TEXT | BCrypt hashed |
| Role | TEXT | `Admin` or `Operator` |
| CreatedAt | TEXT | UTC datetime |

#### `Donors`
| Column | Type | Notes |
|---|---|---|
| Id | TEXT (PK) | Format: `DNR-YYYY-XXXXXX` |
| FullName | TEXT | |
| BloodGroup | TEXT | e.g. `A+`, `O-` |
| Phone | TEXT | |
| City | TEXT | |
| Area | TEXT | Optional |
| Age | INTEGER | |
| Weight | REAL | |
| Gender | TEXT | `Male` / `Female` |
| IsEligible | INTEGER | `1` = eligible, `0` = not |
| LastDonationDate | TEXT | Optional |
| NextEligibleDate | TEXT | Auto-calculated |
| UserId | TEXT (FK) | References `Users.Id` |
| CreatedAt | TEXT | |

#### `BloodUnits`
| Column | Type | Notes |
|---|---|---|
| Id | TEXT (PK) | Format: `A+ -— BL-YYYY-XXXXXX` |
| BloodGroup | TEXT | |
| CollectedDate | TEXT | |
| ExpiryDate | TEXT | CollectedDate + 35 days |
| DonorId | TEXT (FK) | References `Donors.Id` |
| Status | TEXT | `Available`, `Reserved`, `Used`, `Expired` |
| Notes | TEXT | Optional |
| UserId | TEXT (FK) | References `Users.Id` |
| CreatedAt | TEXT | |

#### `PatientRequests`
| Column | Type | Notes |
|---|---|---|
| Id | TEXT (PK) | Format: `PR-YYYY-XXXXXX` |
| PatientName | TEXT | |
| PatientAge | TEXT | Optional |
| BloodGroup | TEXT | |
| UnitsRequired | INTEGER | Default `1` |
| Ward | TEXT | Optional |
| DoctorName | TEXT | Optional |
| Status | TEXT | `Pending`, `Fulfilled`, `Cancelled` |
| Notes | TEXT | Optional |
| UserId | TEXT (FK) | References `Users.Id` |
| CreatedAt | TEXT | |

#### `BloodIssuances`
| Column | Type | Notes |
|---|---|---|
| Id | TEXT (PK) | Format: `ISS-YYYY-XXXXXX` |
| PatientRequestId | TEXT (FK) | |
| BloodUnitId | TEXT (FK) | |
| IssuedByUserId | TEXT (FK) | |
| IssuedDate | TEXT | |
| Notes | TEXT | Optional |

---

## 🚀 How to Run Locally

### Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/) (or later) with **.NET Desktop Development** workload
- .NET 8 SDK or later
- Windows OS (WinForms is Windows-only)

### Steps

**1. Clone the repository**
```bash
git clone https://github.com/your-username/BloodLink.git
cd BloodLink
```

**2. Open in Visual Studio**

Open `BloodLink.sln` in Visual Studio.

**3. Restore NuGet packages**

Visual Studio usually does this automatically. If not:
```bash
dotnet restore
```

Or go to **Tools → NuGet Package Manager → Manage NuGet Packages for Solution** and click **Restore**.

**4. Build the project**

Press `Ctrl + Shift + B` or go to **Build → Build Solution**.

**5. Run the app**

Press `F5` or click **Start**. The database and all tables are created automatically on first launch.

---

## 🔑 Default Login Credentials

The app seeds two accounts on first run:

| Role | Email | Password |
|---|---|---|
| Admin | `admin@bloodlink.com` | `Admin@123` |
| Operator | `abidhussainme1@gmail.com` | `whatsupmate` |

> ⚠️ Change these credentials after your first login, especially in production.

---

## 📋 Role Permissions

| Page | Admin | Operator |
|---|---|---|
| Dashboard | ✅ | ✅ |
| Donors | ✅ | ✅ |
| Blood Inventory | ✅ | ✅ |
| Patients | ✅ | ✅ |
| Reports | ✅ | ❌ |
| Staff Management | ✅ | ❌ |
| Settings | ✅ | ❌ |

---

## 🤝 Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you'd like to change.

---

## 📄 License

This project is open source and available under the [MIT License](LICENSE).

---

<p align="center">Made with ❤️ for blood bank staff everywhere</p>

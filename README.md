# E-Commerce Desktop Application

![C#](https://img.shields.io/badge/C%23-.NET%20Framework-239120) ![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-CC2927) ![3-Tier](https://img.shields.io/badge/Architecture-3--Tier-ff69b4)

A feature-rich and responsive desktop e-commerce platform built using **C# .NET Framework** and backed by **SQL Server** with **stored procedures** for efficient database operations.  
This application delivers a smooth and intuitive shopping experience for regular users, while offering powerful tools for sellers to manage products, promotions, and sales performance — all in one place.

---

## Interface Preview

[![Login](https://iili.io/F7xuKmu.md.png)](https://freeimage.host/i/F7xuKmu)
[![Store](https://iili.io/F7xxCl9.md.png)](https://freeimage.host/i/F7xxCl9)
[![Order](https://iili.io/F7xaG24.md.png)](https://freeimage.host/i/F7xaG24)
[![Dashboard](https://iili.io/F7xlVz7.md.png)](https://freeimage.host/i/F7xlVz7)
[![Account](https://iili.io/F7x0Saf.md.png)](https://freeimage.host/i/F7x0Saf)
[![Product](https://iili.io/F7xN171.md.png)](https://freeimage.host/i/F7xN171)
---

## Application Overview

The system supports two distinct roles:

- **Regular User**: Can browse products, make purchases, and manage orders.  
- **Seller**: Has all regular user features, plus inventory control, promo code management, and access to sales analytics.

---

## Core Features

### For All Users

#### Store Front
- Browse all products listed by registered sellers.
- View and apply available promotional codes.
- Promo codes are required at checkout to ensure proper seller commission tracking.

#### Shopping Cart
- Add items to a temporary cart before completing the purchase.
- Review selected products, adjust quantities, or remove items before checkout.

#### Order Management
- Full order history with live tracking.
- Details of returns and refunds included.
- View refunded amounts for returned orders.

#### Balance System
- In-app virtual wallet.
- Users must maintain a sufficient balance to place orders.
- Balance can be topped up from within the application.
- Refunds for returned items are processed automatically.
- Sellers can view their total earnings.

---

### Seller-Specific Tools

#### Dashboard
- Real-time product and profit tracking.
- Sales performance visualizations and analytics.

#### Product Management
- Add, update, or delete products from inventory.
- All listed products are instantly visible in the public store.
- Set prices, descriptions, and product details.

#### Promocode System
- Generate and manage discount codes.
- Track promo usage and monitor their performance.
- Set flat or percentage-based discounts.

#### Store Configuration
- Customize store name and description.
- Adjust store identity and branding settings.

---

## User Profile System
- Update personal information including name, contact details, and shipping address.
- Upload and manage profile photo.
- Change password securely.
- Upgrade user account to seller.
- Safe and secure logout process.

---

## Technical Specifications
- Developed using **C# .NET Framework**
- Desktop-based application
- Database: **SQL Server**
- All database operations handled via **Stored Procedures**
- Follows a layered structure for code maintainability and separation of concerns

---

## System Advantages  
- **Efficiency**: Automates product management, order processing, and refund handling, reducing manual effort and errors.  
- **User-Friendly**: Clean and intuitive interface for both users and sellers.  
- **Security**: Stores user and transaction data securely with proper role separation.  
- **Flexibility**: Supports various product types, promo codes, and user roles.  
- **Transparency**: Tracks all orders, returns, and payments with clear logs and history.

---

## How It Works  
1. **Account Registration**: Users or sellers create an account through the system.  
2. **Balance Deposit**: Users add balance to their virtual wallet to make purchases.  
3. **Product Browsing & Cart**: Users browse products, add to cart, and apply valid promo codes.  
4. **Order Placement**: Users confirm and place orders, balance is automatically deducted.  
5. **Seller Management**: Sellers add/edit products, view profits, and monitor analytics through their dashboard.  
6. **Returns & Refunds**: If a product is returned, the system automatically processes the refund to the user's balance.

---

## How to Run the System  
1. Make sure you have **Visual Studio Community 2022** and **SQL Server** installed.  
2. Import the required **SQL Server database** used by the application (located in the project folder).  
3. Open `E-commerceDB.bak` and configure your **connection string** with correct user ID and password.  
4. Build and run the project to start using the full system.
   `usename = john , password = 111`

---

## Contribution
Contributions are welcome!

---

Built with ❤️

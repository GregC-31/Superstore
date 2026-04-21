# Superstore
This project consists of a front-end written in React.js, a back-end written in C#, and MS SQL Stored Procedures.

## Superstore API

### Product
- **GET** /api/products
- **GET** /api/products/{id}
- **POST** /api/products
- **PUT** /api/products/{id}
- **DELETE** /api/products/{id}

### Customer
- **GET** /api/customers
- **GET** /api/customers/{id}

### Order
- **GET** /api/orders
- **GET** /api/orders/{id}
- **GET** /api/orders/{id}/orderdetails
- **POST** /api/orders
- **PUT** /api/orders/{id}
- **DELETE** /api/orders/{id}

### OrderDetail
- **GET** /api/orderdetails
- **GET** /api/orderdetails/{id}

### AddressType (Lookup Table)
- **GET** /api/addresstype

### Region (Lookup Table)
- **GET** /api/regions

### Segment (Lookup Table)
- **GET** /api/segments

### ShipMode (Lookup Table)
- **GET** /api/segments

### State (Lookup Table)

### Subcategory (Lookup Table)

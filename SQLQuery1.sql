SELECT TABLE_NAME 
FROM INFORMATION_SCHEMA.TABLES 
WHERE TABLE_TYPE = 'BASE TABLE';

select * from Users;
select * from Inventory;
select * from Customers;
select * from Suppliers;
select * from Purchases;
select * from Sales;

select * from Payments;

SELECT s.InvoiceNumber, c.Name AS Customer, i.ItemName, s.Quantity, s.TotalAmount, s.SaleDate 
FROM Sales s
JOIN Customers c ON s.CustomerID = c.CustomerID
JOIN Inventory i ON s.ItemID = i.ItemID
WHERE s.SaleDate BETWEEN '2025-06-22 10:24:34.190' AND '2025-06-23 08:37:13.097'
ORDER BY s.SaleDate;
SELECT s.InvoiceNumber, c.Name AS Customer, i.ItemName, s.Quantity, s.TotalAmount, s.SaleDate 
                           FROM Sales s
                           JOIN Customers c ON s.CustomerID = c.CustomerID
                           JOIN Inventory i ON s.ItemID = i.ItemID
                           WHERE s.SaleDate BETWEEN '2025-06-22 10:24:34.190' AND '2025-06-23 08:37:13.097' ORDER BY s.SaleDate;

SELECT p.PurchaseDate, s.Name AS Supplier, i.ItemName, p.Quantity, p.UnitPrice, p.TotalAmount 
                           FROM Purchases p
                           JOIN Suppliers s ON p.SupplierID = s.SupplierID
                           JOIN Inventory i ON p.ItemID = i.ItemID
                           WHERE p.PurchaseDate BETWEEN '2025-06-22 10:13:55.870' AND '2025-06-23 08:34:06.850' ORDER BY p.PurchaseDate;

                           SELECT ItemName, Quantity, Unit, MinimumStockLevel, LastUpdated FROM Inventory;

SELECT Date, Particulars, Debit, Credit FROM (
                    SELECT SaleDate AS Date, 'INV-20250622102446' + InvoiceNumber AS Particulars, TotalAmount AS Debit, 0 AS Credit FROM Sales
                    WHERE CustomerID = '1' AND SaleDate BETWEEN '2025-06-22 10:24:34.190' AND '2025-06-23 08:37:13.097'
                    UNION ALL
                    SELECT PaymentDate AS Date, 'Bank' + PaymentMethod AS Particulars, 0 AS Debit, Amount AS Credit FROM Payments
                    WHERE CustomerID = 1 AND PaymentDate BETWEEN '2025-06-22 22:15:38.273' AND '2025-06-23 08:35:36.653'
                ) AS Ledger
                ORDER BY Date;
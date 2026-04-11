-- =============================================
-- Smart POS Database Schema
-- =============================================
-- Instructions:
--   1. Open SSMS and connect to your SQL Server
--   2. Run this entire script (F5)
--   3. It will create the database and all tables
--   4. Then update App.config with your server name
-- =============================================

IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'smartPOS')
BEGIN
    CREATE DATABASE smartPOS;
END
GO

USE [smartPOS]
GO

-- =============================================
-- Table: Categories
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Categories')
BEGIN
    CREATE TABLE [dbo].[Categories] (
        [id]  INT          IDENTITY(1,1) NOT NULL,
        [DES] VARCHAR(50)  NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([id] ASC)
    )
END
GO

-- =============================================
-- Table: Payments
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Payments')
BEGIN
    CREATE TABLE [dbo].[Payments] (
        [id]  INT         IDENTITY(1,1) NOT NULL,
        [Des] VARCHAR(50) NULL,
        CONSTRAINT [PK_Payments] PRIMARY KEY CLUSTERED ([id] ASC)
    )
END
GO

-- =============================================
-- Table: Users
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Users')
BEGIN
    CREATE TABLE [dbo].[Users] (
        [id]       INT         IDENTITY(1,1) NOT NULL,
        [userName] VARCHAR(50) NULL,
        [password] VARCHAR(50) NULL,
        [fullName] VARCHAR(50) NULL,
        [email]    VARCHAR(50) NULL,
        [phone]    VARCHAR(50) NULL,
        [jobDes]   VARCHAR(50) NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([id] ASC)
    )
END
GO

-- =============================================
-- Table: Options
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Options')
BEGIN
    CREATE TABLE [dbo].[Options] (
        [id]           INT          IDENTITY(1,1) NOT NULL,
        [ResetName]    VARCHAR(50)  NULL,
        [printerName]  VARCHAR(100) NULL,
        [ResetAddress1] VARCHAR(50) NULL,
        [ResetAddress2] VARCHAR(50) NULL,
        [receiptLine1] VARCHAR(50)  NULL,
        [receiptLine2] VARCHAR(50)  NULL,
        [Phone]        VARCHAR(50)  NULL,
        [logo]         IMAGE        NULL,
        CONSTRAINT [PK_Options] PRIMARY KEY CLUSTERED ([id] ASC)
    )
END
GO

-- =============================================
-- Table: Items  (depends on Categories)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Items')
BEGIN
    CREATE TABLE [dbo].[Items] (
        [id]         INT           IDENTITY(1,1) NOT NULL,
        [DES]        VARCHAR(50)   NOT NULL,
        [CategoryId] INT           NOT NULL,
        [price]      DECIMAL(18,4) NOT NULL,
        [itemImg]    IMAGE         NULL,
        [notes]      VARCHAR(200)  NULL,
        CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED ([id] ASC),
        CONSTRAINT [FK_Items_Categories] FOREIGN KEY ([CategoryId])
            REFERENCES [dbo].[Categories] ([id])
    )
END
GO

-- =============================================
-- Table: Checks  (depends on Users)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Checks')
BEGIN
    CREATE TABLE [dbo].[Checks] (
        [id]         INT           IDENTITY(1,1) NOT NULL,
        [checkDate]  DATETIME      NULL,
        [userId]     INT           NULL,
        [totalCheck] DECIMAL(18,4) NULL,
        [status]     VARCHAR(10)   NULL,
        CONSTRAINT [PK_Checks] PRIMARY KEY CLUSTERED ([id] ASC),
        CONSTRAINT [FK_Checks_Users] FOREIGN KEY ([userId])
            REFERENCES [dbo].[Users] ([id])
    )
END
GO

-- =============================================
-- Table: ChecksItems  (depends on Checks, Items)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ChecksItmes')
BEGIN
    CREATE TABLE [dbo].[ChecksItmes] (
        [id]         INT           IDENTITY(1,1) NOT NULL,
        [CkeckId]    INT           NULL,
        [ItemId]     INT           NULL,
        [QTY]        DECIMAL(18,4) NULL,
        [price]      DECIMAL(18,4) NULL,
        [totalPrice] DECIMAL(18,4) NULL,
        CONSTRAINT [PK_ChecksItmes] PRIMARY KEY CLUSTERED ([id] ASC),
        CONSTRAINT [FK_ChecksItmes_Checks] FOREIGN KEY ([CkeckId])
            REFERENCES [dbo].[Checks] ([id]),
        CONSTRAINT [FK_ChecksItmes_Items] FOREIGN KEY ([ItemId])
            REFERENCES [dbo].[Items] ([id])
    )
END
GO

-- =============================================
-- Table: ChecksPay  (depends on Checks, Payments)
-- =============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'ChecksPay')
BEGIN
    CREATE TABLE [dbo].[ChecksPay] (
        [id]        INT           IDENTITY(1,1) NOT NULL,
        [paymentId] INT           NULL,
        [payVal]    DECIMAL(18,4) NULL,
        CONSTRAINT [PK_ChecksPay] PRIMARY KEY CLUSTERED ([id] ASC),
        CONSTRAINT [FK_ChecksPay_Payments] FOREIGN KEY ([paymentId])
            REFERENCES [dbo].[Payments] ([id])
    )
END
GO

-- =============================================
-- Default seed data: at least one payment method
-- so the POS payment combobox is not empty
-- =============================================
IF NOT EXISTS (SELECT * FROM [dbo].[Payments])
BEGIN
    INSERT INTO [dbo].[Payments] ([Des]) VALUES ('Cash')
    INSERT INTO [dbo].[Payments] ([Des]) VALUES ('Card')
END
GO

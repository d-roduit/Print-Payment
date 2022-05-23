-- Create ConversionTable table
CREATE TABLE [dbo].[ConversionTable] (
    [Id]      INT            NOT NULL,
    [Product] NVARCHAR (50)  NOT NULL,
    [Price]   DECIMAL (5, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

-- Create Users table
CREATE TABLE [dbo].[Users] (
    [UID]      INT            NOT NULL,
    [Username] NVARCHAR (50)  NOT NULL,
    [Credit]   DECIMAL (5, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([UID] ASC)
);

-- Insert data into ConversionTable table
INSERT INTO [dbo].[ConversionTable] ([Id], [Product], [Price]) VALUES (1, N'A4', CAST(0.50 AS Decimal(5, 2)))

-- Insert data into Users table
INSERT INTO [dbo].[Users] ([UID], [Username], [Credit]) VALUES (1, N'droduit', CAST(5.00 AS Decimal(5, 2)))

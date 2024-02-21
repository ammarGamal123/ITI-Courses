IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Departments] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [ManagerName] nvarchar(max) NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Students] (
    [Id] int NOT NULL IDENTITY,
    [Age] int NOT NULL,
    [Name] nvarchar(max) NULL,
    [Image] nvarchar(max) NULL,
    [Address] nvarchar(max) NULL,
    [DeptId] int NOT NULL,
    CONSTRAINT [PK_Students] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Students_Departments_DeptId] FOREIGN KEY ([DeptId]) REFERENCES [Departments] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_Students_DeptId] ON [Students] ([DeptId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20240220025107_init', N'8.0.2');
GO

COMMIT;
GO


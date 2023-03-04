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
    [Id] uniqueidentifier NOT NULL,
    [DepartmentName] nvarchar(max) NULL,
    [Idn] bigint NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastModifiedDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Departments] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [EmployeeRoles] (
    [Id] uniqueidentifier NOT NULL,
    [RoleNqme] nvarchar(max) NULL,
    [Idn] bigint NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastModifiedDate] datetime2 NOT NULL,
    CONSTRAINT [PK_EmployeeRoles] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [Requests] (
    [Id] uniqueidentifier NOT NULL,
    [EmployeeName] varchar(100) NOT NULL,
    [PlannedActivity] nvarchar(max) NULL,
    [Equipments] nvarchar(max) NULL,
    [WorkingStartDate] datetime2 NOT NULL,
    [Status] int NOT NULL,
    [WorkingEndDate] datetime2 NOT NULL,
    [DepartmentId] uniqueidentifier NOT NULL,
    [RoleId] uniqueidentifier NOT NULL,
    [EmployeeRoleId] uniqueidentifier NULL,
    [Idn] bigint NOT NULL,
    [CreatedDate] datetime2 NOT NULL,
    [LastModifiedDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Requests] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Requests_Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [Departments] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Requests_EmployeeRoles_EmployeeRoleId] FOREIGN KEY ([EmployeeRoleId]) REFERENCES [EmployeeRoles] ([Id]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Requests_DepartmentId] ON [Requests] ([DepartmentId]);
GO

CREATE INDEX [IX_Requests_EmployeeRoleId] ON [Requests] ([EmployeeRoleId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230302210448_Add Tables', N'5.0.0');
GO

COMMIT;
GO

BEGIN TRANSACTION;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DepartmentName', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] ON;
INSERT INTO [Departments] ([Id], [DepartmentName], [Idn], [CreatedDate], [LastModifiedDate])
VALUES ('101450a2-7d2c-49be-8a5a-59105b69dcae', N'HR', CAST(1 AS bigint), '2023-03-03T00:10:21.2239542+02:00', '2023-03-03T00:10:21.2248522+02:00');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DepartmentName', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230302215939_Seed Roles and Department', N'5.0.0');
GO

COMMIT;
GO


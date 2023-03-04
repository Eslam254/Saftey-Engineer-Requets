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
VALUES ('101450a2-7d2c-49be-8a5a-59105b69dcae', N'HR', CAST(1 AS bigint), '2023-03-03T00:16:34.6560354+02:00', '2023-03-03T00:16:34.6595069+02:00');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DepartmentName', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DepartmentName', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] ON;
INSERT INTO [Departments] ([Id], [DepartmentName], [Idn], [CreatedDate], [LastModifiedDate])
VALUES ('64a2a1b0-5c41-4625-8fea-4cffde06fd0e', N'Finacial', CAST(2 AS bigint), '2023-03-03T00:16:34.6622648+02:00', '2023-03-03T00:16:34.6622680+02:00');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DepartmentName', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DepartmentName', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] ON;
INSERT INTO [Departments] ([Id], [DepartmentName], [Idn], [CreatedDate], [LastModifiedDate])
VALUES ('64a2a1b0-5c41-4625-8fea-4cffde06fdea', N'Operation', CAST(3 AS bigint), '2023-03-03T00:16:34.6622709+02:00', '2023-03-03T00:16:34.6622711+02:00');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DepartmentName', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DepartmentName', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] ON;
INSERT INTO [Departments] ([Id], [DepartmentName], [Idn], [CreatedDate], [LastModifiedDate])
VALUES ('101450a2-7d2c-50be-8a5a-59105b69dcae', N'Legal', CAST(4 AS bigint), '2023-03-03T00:16:34.6622718+02:00', '2023-03-03T00:16:34.6622720+02:00');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DepartmentName', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[Departments]'))
    SET IDENTITY_INSERT [Departments] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'RoleNqme', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[EmployeeRoles]'))
    SET IDENTITY_INSERT [EmployeeRoles] ON;
INSERT INTO [EmployeeRoles] ([Id], [RoleNqme], [Idn], [CreatedDate], [LastModifiedDate])
VALUES ('511c351e-02c4-4a13-9eac-99fb53f0e8d6', N'Admin', CAST(1 AS bigint), '2023-03-03T00:16:34.6622729+02:00', '2023-03-03T00:16:34.6622730+02:00');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'RoleNqme', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[EmployeeRoles]'))
    SET IDENTITY_INSERT [EmployeeRoles] OFF;
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'RoleNqme', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[EmployeeRoles]'))
    SET IDENTITY_INSERT [EmployeeRoles] ON;
INSERT INTO [EmployeeRoles] ([Id], [RoleNqme], [Idn], [CreatedDate], [LastModifiedDate])
VALUES ('30880436-bf25-4989-a945-2544d79d8ad0', N'SuperVisor', CAST(1 AS bigint), '2023-03-03T00:16:34.6622880+02:00', '2023-03-03T00:16:34.6622882+02:00');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'RoleNqme', N'Idn', N'CreatedDate', N'LastModifiedDate') AND [object_id] = OBJECT_ID(N'[EmployeeRoles]'))
    SET IDENTITY_INSERT [EmployeeRoles] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230302215939_Seed Roles and Department', N'5.0.0');
GO

COMMIT;
GO


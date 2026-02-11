BEGIN TRANSACTION;
ALTER TABLE [Users] DROP CONSTRAINT [PK_Users];

DECLARE @var nvarchar(max);
SELECT @var = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'Department');
IF @var IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT ' + @var + ';');
ALTER TABLE [Users] DROP COLUMN [Department];

DECLARE @var1 nvarchar(max);
SELECT @var1 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'Discriminator');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT ' + @var1 + ';');
ALTER TABLE [Users] DROP COLUMN [Discriminator];

DECLARE @var2 nvarchar(max);
SELECT @var2 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'HireDate');
IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT ' + @var2 + ';');
ALTER TABLE [Users] DROP COLUMN [HireDate];

DECLARE @var3 nvarchar(max);
SELECT @var3 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'Qualifications');
IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT ' + @var3 + ';');
ALTER TABLE [Users] DROP COLUMN [Qualifications];

DECLARE @var4 nvarchar(max);
SELECT @var4 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Users]') AND [c].[name] = N'ResignationDate');
IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Users] DROP CONSTRAINT ' + @var4 + ';');
ALTER TABLE [Users] DROP COLUMN [ResignationDate];

EXEC sp_rename N'[Users]', N'Students', 'OBJECT';

DECLARE @var5 nvarchar(max);
SELECT @var5 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Major');
IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var5 + ';');
UPDATE [Students] SET [Major] = N'' WHERE [Major] IS NULL;
ALTER TABLE [Students] ALTER COLUMN [Major] nvarchar(max) NOT NULL;
ALTER TABLE [Students] ADD DEFAULT N'' FOR [Major];

DECLARE @var6 nvarchar(max);
SELECT @var6 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Level');
IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var6 + ';');
UPDATE [Students] SET [Level] = N'' WHERE [Level] IS NULL;
ALTER TABLE [Students] ALTER COLUMN [Level] nvarchar(max) NOT NULL;
ALTER TABLE [Students] ADD DEFAULT N'' FOR [Level];

DECLARE @var7 nvarchar(max);
SELECT @var7 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'GraduationDate');
IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var7 + ';');
UPDATE [Students] SET [GraduationDate] = '0001-01-01T00:00:00.0000000' WHERE [GraduationDate] IS NULL;
ALTER TABLE [Students] ALTER COLUMN [GraduationDate] datetime2 NOT NULL;
ALTER TABLE [Students] ADD DEFAULT '0001-01-01T00:00:00.0000000' FOR [GraduationDate];

DECLARE @var8 nvarchar(max);
SELECT @var8 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'EntranceDate');
IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var8 + ';');
UPDATE [Students] SET [EntranceDate] = '0001-01-01T00:00:00.0000000' WHERE [EntranceDate] IS NULL;
ALTER TABLE [Students] ALTER COLUMN [EntranceDate] datetime2 NOT NULL;
ALTER TABLE [Students] ADD DEFAULT '0001-01-01T00:00:00.0000000' FOR [EntranceDate];

DECLARE @var9 nvarchar(max);
SELECT @var9 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'ApplicationStatus');
IF @var9 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var9 + ';');
UPDATE [Students] SET [ApplicationStatus] = N'' WHERE [ApplicationStatus] IS NULL;
ALTER TABLE [Students] ALTER COLUMN [ApplicationStatus] nvarchar(max) NOT NULL;
ALTER TABLE [Students] ADD DEFAULT N'' FOR [ApplicationStatus];

ALTER TABLE [Students] ADD CONSTRAINT [PK_Students] PRIMARY KEY ([Id]);

CREATE TABLE [Instructors] (
    [Id] uniqueidentifier NOT NULL,
    [FirstName] nvarchar(max) NOT NULL,
    [LastName] nvarchar(max) NOT NULL,
    [EmailAddress] nvarchar(max) NULL,
    [Gender] nvarchar(1) NOT NULL,
    [Address] nvarchar(max) NOT NULL,
    [Nationality] nvarchar(max) NOT NULL,
    [DOB] datetime2 NOT NULL,
    [Telephone] nvarchar(max) NULL,
    [Password] nvarchar(max) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [UpdatedAt] datetime2 NOT NULL,
    [CreatedByUserId] uniqueidentifier NULL,
    [UpdatedByUserId] uniqueidentifier NULL,
    [ResignationDate] datetime2 NULL,
    [HireDate] datetime2 NOT NULL,
    [Department] nvarchar(max) NOT NULL,
    [Qualifications] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Instructors] PRIMARY KEY ([Id])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260210103148_apply_tpc', N'10.0.2');

COMMIT;
GO

BEGIN TRANSACTION;
DECLARE @var10 nvarchar(max);
SELECT @var10 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Nationality');
IF @var10 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var10 + ';');
ALTER TABLE [Students] DROP COLUMN [Nationality];

DECLARE @var11 nvarchar(max);
SELECT @var11 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Instructors]') AND [c].[name] = N'Nationality');
IF @var11 IS NOT NULL EXEC(N'ALTER TABLE [Instructors] DROP CONSTRAINT ' + @var11 + ';');
ALTER TABLE [Instructors] DROP COLUMN [Nationality];

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260210110641_apply_tpc_update1', N'10.0.2');

COMMIT;
GO

BEGIN TRANSACTION;
DECLARE @var12 nvarchar(max);
SELECT @var12 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'LastName');
IF @var12 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var12 + ';');
ALTER TABLE [Students] ALTER COLUMN [LastName] nvarchar(50) NOT NULL;

DECLARE @var13 nvarchar(max);
SELECT @var13 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'FirstName');
IF @var13 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var13 + ';');
ALTER TABLE [Students] ALTER COLUMN [FirstName] nvarchar(200) NOT NULL;

DECLARE @var14 nvarchar(max);
SELECT @var14 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Instructors]') AND [c].[name] = N'LastName');
IF @var14 IS NOT NULL EXEC(N'ALTER TABLE [Instructors] DROP CONSTRAINT ' + @var14 + ';');
ALTER TABLE [Instructors] ALTER COLUMN [LastName] nvarchar(50) NOT NULL;

DECLARE @var15 nvarchar(max);
SELECT @var15 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Instructors]') AND [c].[name] = N'FirstName');
IF @var15 IS NOT NULL EXEC(N'ALTER TABLE [Instructors] DROP CONSTRAINT ' + @var15 + ';');
ALTER TABLE [Instructors] ALTER COLUMN [FirstName] nvarchar(200) NOT NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260210114006_Update_User_Properties', N'10.0.2');

COMMIT;
GO

BEGIN TRANSACTION;
DECLARE @var16 nvarchar(max);
SELECT @var16 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Address');
IF @var16 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var16 + ';');
ALTER TABLE [Students] ALTER COLUMN [Address] nvarchar(50) NOT NULL;

DECLARE @var17 nvarchar(max);
SELECT @var17 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Instructors]') AND [c].[name] = N'Address');
IF @var17 IS NOT NULL EXEC(N'ALTER TABLE [Instructors] DROP CONSTRAINT ' + @var17 + ';');
ALTER TABLE [Instructors] ALTER COLUMN [Address] nvarchar(50) NOT NULL;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260210114726_Update_User_Properties_1', N'10.0.2');

COMMIT;
GO

BEGIN TRANSACTION;
DECLARE @var18 nvarchar(max);
SELECT @var18 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'LastName');
IF @var18 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var18 + ';');
ALTER TABLE [Students] ALTER COLUMN [LastName] nvarchar(max) NOT NULL;

DECLARE @var19 nvarchar(max);
SELECT @var19 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'EmailAddress');
IF @var19 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var19 + ';');
UPDATE [Students] SET [EmailAddress] = N'' WHERE [EmailAddress] IS NULL;
ALTER TABLE [Students] ALTER COLUMN [EmailAddress] nvarchar(50) NOT NULL;
ALTER TABLE [Students] ADD DEFAULT N'' FOR [EmailAddress];

DECLARE @var20 nvarchar(max);
SELECT @var20 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'Address');
IF @var20 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT ' + @var20 + ';');
ALTER TABLE [Students] ALTER COLUMN [Address] nvarchar(200) NOT NULL;

DECLARE @var21 nvarchar(max);
SELECT @var21 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Instructors]') AND [c].[name] = N'LastName');
IF @var21 IS NOT NULL EXEC(N'ALTER TABLE [Instructors] DROP CONSTRAINT ' + @var21 + ';');
ALTER TABLE [Instructors] ALTER COLUMN [LastName] nvarchar(max) NOT NULL;

DECLARE @var22 nvarchar(max);
SELECT @var22 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Instructors]') AND [c].[name] = N'EmailAddress');
IF @var22 IS NOT NULL EXEC(N'ALTER TABLE [Instructors] DROP CONSTRAINT ' + @var22 + ';');
UPDATE [Instructors] SET [EmailAddress] = N'' WHERE [EmailAddress] IS NULL;
ALTER TABLE [Instructors] ALTER COLUMN [EmailAddress] nvarchar(50) NOT NULL;
ALTER TABLE [Instructors] ADD DEFAULT N'' FOR [EmailAddress];

DECLARE @var23 nvarchar(max);
SELECT @var23 = QUOTENAME([d].[name])
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Instructors]') AND [c].[name] = N'Address');
IF @var23 IS NOT NULL EXEC(N'ALTER TABLE [Instructors] DROP CONSTRAINT ' + @var23 + ';');
ALTER TABLE [Instructors] ALTER COLUMN [Address] nvarchar(200) NOT NULL;

CREATE TABLE [SMSs] (
    [Id] int NOT NULL IDENTITY,
    [PhoneNumber] nvarchar(15) NOT NULL,
    [Body] nvarchar(160) NOT NULL,
    CONSTRAINT [PK_SMSs] PRIMARY KEY ([Id])
);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20260211060652_Add_SMS_Table', N'10.0.2');

COMMIT;
GO


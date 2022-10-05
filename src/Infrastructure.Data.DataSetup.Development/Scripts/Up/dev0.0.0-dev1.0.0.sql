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

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    CREATE TABLE [Courses] (
        [CourseId] uniqueidentifier NOT NULL DEFAULT (NEWID()),
        [Title] nvarchar(100) NOT NULL,
        [Credits] int NOT NULL,
        [Year] int NOT NULL,
        CONSTRAINT [PK_Courses] PRIMARY KEY ([CourseId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    CREATE TABLE [Students] (
        [StudentId] uniqueidentifier NOT NULL DEFAULT (NEWID()),
        [FirstName] nvarchar(50) NOT NULL,
        [LastName] nvarchar(50) NOT NULL,
        [House] int NULL,
        [Year] int NOT NULL,
        CONSTRAINT [PK_Students] PRIMARY KEY ([StudentId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    CREATE TABLE [Enrollments] (
        [EnrollmentId] uniqueidentifier NOT NULL DEFAULT (NEWID()),
        [CourseId] uniqueidentifier NOT NULL,
        [StudentId] uniqueidentifier NOT NULL,
        [Grade] int NULL,
        CONSTRAINT [PK_Enrollments] PRIMARY KEY ([EnrollmentId]),
        CONSTRAINT [FK_Enrollments_Courses_CourseId] FOREIGN KEY ([CourseId]) REFERENCES [Courses] ([CourseId]) ON DELETE CASCADE,
        CONSTRAINT [FK_Enrollments_Students_StudentId] FOREIGN KEY ([StudentId]) REFERENCES [Students] ([StudentId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CourseId', N'Credits', N'Title', N'Year') AND [object_id] = OBJECT_ID(N'[Courses]'))
        SET IDENTITY_INSERT [Courses] ON;
    EXEC(N'INSERT INTO [Courses] ([CourseId], [Credits], [Title], [Year])
    VALUES (''24e42ce8-6d38-4c5d-88e8-8310935bd886'', 2, N''Alchemy'', 2)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CourseId', N'Credits', N'Title', N'Year') AND [object_id] = OBJECT_ID(N'[Courses]'))
        SET IDENTITY_INSERT [Courses] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CourseId', N'Credits', N'Title', N'Year') AND [object_id] = OBJECT_ID(N'[Courses]'))
        SET IDENTITY_INSERT [Courses] ON;
    EXEC(N'INSERT INTO [Courses] ([CourseId], [Credits], [Title], [Year])
    VALUES (''578c9088-d00d-421f-b418-bb3e305fa32f'', 5, N''Defense Against the Dark Arts'', 1)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CourseId', N'Credits', N'Title', N'Year') AND [object_id] = OBJECT_ID(N'[Courses]'))
        SET IDENTITY_INSERT [Courses] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CourseId', N'Credits', N'Title', N'Year') AND [object_id] = OBJECT_ID(N'[Courses]'))
        SET IDENTITY_INSERT [Courses] ON;
    EXEC(N'INSERT INTO [Courses] ([CourseId], [Credits], [Title], [Year])
    VALUES (''680b9bd7-cae9-4126-9b22-2c700fbab340'', 3, N''Beasts'', 3)');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CourseId', N'Credits', N'Title', N'Year') AND [object_id] = OBJECT_ID(N'[Courses]'))
        SET IDENTITY_INSERT [Courses] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    CREATE INDEX [IX_Course_Student] ON [Enrollments] ([CourseId], [StudentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    CREATE INDEX [IX_Enrollments_StudentId] ON [Enrollments] ([StudentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221005112712_dev1.0.0', N'6.0.9');
END;
GO

COMMIT;
GO


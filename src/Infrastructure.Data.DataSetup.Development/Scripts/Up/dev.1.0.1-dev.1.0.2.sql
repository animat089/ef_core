BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807151128_dev.1.0.2')
BEGIN
    EXEC(N'UPDATE [Courses] SET [Title] = N''Alchemy''
    WHERE [CourseId] = ''24e42ce8-6d38-4c5d-88e8-8310935bd886'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807151128_dev.1.0.2')
BEGIN
    EXEC(N'UPDATE [Courses] SET [Title] = N''Defense Against the Dark Arts''
    WHERE [CourseId] = ''578c9088-d00d-421f-b418-bb3e305fa32f'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807151128_dev.1.0.2')
BEGIN
    EXEC(N'UPDATE [Courses] SET [Title] = N''Beasts''
    WHERE [CourseId] = ''680b9bd7-cae9-4126-9b22-2c700fbab340'';
    SELECT @@ROWCOUNT');
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807151128_dev.1.0.2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220807151128_dev.1.0.2', N'6.0.7');
END;
GO

COMMIT;
GO


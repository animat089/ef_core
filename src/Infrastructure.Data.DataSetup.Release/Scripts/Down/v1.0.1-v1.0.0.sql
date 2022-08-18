BEGIN TRANSACTION;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807151441_v1.0.1')
BEGIN
    EXEC(N'UPDATE [Courses] SET [Title] = N''Course2''
    WHERE [CourseId] = ''24e42ce8-6d38-4c5d-88e8-8310935bd886'';
    SELECT @@ROWCOUNT');
END;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807151441_v1.0.1')
BEGIN
    EXEC(N'UPDATE [Courses] SET [Title] = N''Course1''
    WHERE [CourseId] = ''578c9088-d00d-421f-b418-bb3e305fa32f'';
    SELECT @@ROWCOUNT');
END;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807151441_v1.0.1')
BEGIN
    EXEC(N'UPDATE [Courses] SET [Title] = N''Course3''
    WHERE [CourseId] = ''680b9bd7-cae9-4126-9b22-2c700fbab340'';
    SELECT @@ROWCOUNT');
END;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807151441_v1.0.1')
BEGIN
    DELETE FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20220807151441_v1.0.1';
END;
GO

COMMIT;
GO


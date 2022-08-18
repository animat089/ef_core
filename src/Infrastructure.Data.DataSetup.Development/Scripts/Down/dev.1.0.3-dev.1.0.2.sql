BEGIN TRANSACTION;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807152446_dev.1.0.3')
BEGIN
    EXEC(N'DROP PROCEDURE GetAllCourses')
END;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807152446_dev.1.0.3')
BEGIN
    EXEC(N'DROP PROCEDURE GetAllStudents')
END;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220807152446_dev.1.0.3')
BEGIN
    DELETE FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20220807152446_dev.1.0.3';
END;
GO

COMMIT;
GO


BEGIN TRANSACTION;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    DROP TABLE [Enrollments];
END;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    DROP TABLE [Courses];
END;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    DROP TABLE [Students];
END;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112712_dev1.0.0')
BEGIN
    DELETE FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20221005112712_dev1.0.0';
END;
GO

COMMIT;
GO


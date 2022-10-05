BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112853_dev1.0.2')
BEGIN
    SELECT @@VERSION as 'Version'
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112853_dev1.0.2')
BEGIN
    EXEC(N'SELECT @@LANGUAGE as ''DefaultLanguage''
    SELECT @@MAX_CONNECTIONS as ''MaxConnections''')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005112853_dev1.0.2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221005112853_dev1.0.2', N'6.0.9');
END;
GO

COMMIT;
GO


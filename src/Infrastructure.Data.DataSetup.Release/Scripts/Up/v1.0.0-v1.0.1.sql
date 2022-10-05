BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005115807_v1.0.1')
BEGIN
    SELECT @@VERSION as 'Version'
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005115807_v1.0.1')
BEGIN
    EXEC(N'SELECT @@LANGUAGE as ''DefaultLanguage''
    SELECT @@MAX_CONNECTIONS as ''MaxConnections''')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005115807_v1.0.1')
BEGIN
    EXEC(N'CREATE OR ALTER PROCEDURE GetAllCourses
    AS
    BEGIN
    	SELECT [C].*
    	FROM dbo.Courses C
    END')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005115807_v1.0.1')
BEGIN
    EXEC(N'CREATE OR ALTER PROCEDURE GetAllStudents
    AS
    BEGIN
    	SELECT [S].*
    	FROM dbo.Students S
    END')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20221005115807_v1.0.1')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20221005115807_v1.0.1', N'6.0.9');
END;
GO

COMMIT;
GO


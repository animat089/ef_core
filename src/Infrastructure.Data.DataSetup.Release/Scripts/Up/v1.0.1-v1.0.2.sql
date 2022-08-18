BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220818190301_v1.0.2')
BEGIN
    EXEC(N'CREATE OR ALTER PROCEDURE GetAllCourses
    AS
    BEGIN
    	SELECT [C].*
    	FROM dbo.Courses C
    END')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220818190301_v1.0.2')
BEGIN
    EXEC(N'CREATE OR ALTER PROCEDURE GetAllStudents
    AS
    BEGIN
    	SELECT [S].*
    	FROM dbo.Students S
    END')
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220818190301_v1.0.2')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20220818190301_v1.0.2', N'6.0.7');
END;
GO

COMMIT;
GO


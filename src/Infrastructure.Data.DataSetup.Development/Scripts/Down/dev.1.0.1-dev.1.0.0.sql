BEGIN TRANSACTION;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220128222040_dev.1.0.1')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Students]') AND [c].[name] = N'MiddleName');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Students] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Students] DROP COLUMN [MiddleName];
END;
GO

IF EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20220128222040_dev.1.0.1')
BEGIN
    DELETE FROM [__EFMigrationsHistory]
    WHERE [MigrationId] = N'20220128222040_dev.1.0.1';
END;
GO

COMMIT;
GO


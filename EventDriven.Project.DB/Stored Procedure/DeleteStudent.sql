CREATE PROCEDURE DeleteStudent @Id INT
AS
BEGIN
    IF @Id IS NULL OR @Id <= 0
    BEGIN
        RAISERROR('Invalid or missing Student ID.', 16, 1);
        RETURN;
    END;

    BEGIN TRY
        DELETE FROM Student WHERE ID = @Id;

        IF @@ROWCOUNT = 0
        BEGIN
            RAISERROR('No student found with the specified ID.', 16, 1);
        END;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        RAISERROR('Error deleting student: %s', 16, 1, @ErrorMessage);
    END CATCH;
END;
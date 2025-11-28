-- Assuming the Student table exists with an Id column (adjust if needed)
-- Example: CREATE TABLE Student (Id INT PRIMARY KEY, Name VARCHAR(100), ...);

CREATE PROCEDURE [dbo].[RegisterStudent]
    @StudentId INT,
    @Requirements VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    -- Basic validation: Check if StudentId exists in the Student table
    IF NOT EXISTS (SELECT 1 FROM Student WHERE Id = @StudentId)
    BEGIN
        RAISERROR('Invalid StudentId: Student does not exist.', 16, 1);
        RETURN;
    END

    -- Insert the registration record
    INSERT INTO [dbo].[tblStudentReg] (StudentId, Requirements)
    VALUES (@StudentId, @Requirements);

    -- Optional: Return the new Id for confirmation
    SELECT SCOPE_IDENTITY() AS NewRegistrationId;
END
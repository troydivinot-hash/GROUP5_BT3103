CREATE PROCEDURE UpdateStudentReg
    @StudentId INT,
    @Requirements NVARCHAR(MAX)
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE tblStudentReg
    SET Requirements = @Requirements
    WHERE StudentId = @StudentId;
END

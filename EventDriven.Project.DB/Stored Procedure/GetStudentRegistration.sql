CREATE PROCEDURE [dbo].[GetStudentRegistration]
    @StudentId INT   -- Required: return only this student's registration
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        sr.Id AS RegistrationID,
        sr.StudentId,
        sr.Section,
        sr.Requirements
    FROM [dbo].[tblStudentReg] sr
    WHERE sr.StudentId = @StudentId
    ORDER BY sr.Id;
END

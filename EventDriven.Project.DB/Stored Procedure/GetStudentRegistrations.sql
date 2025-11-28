-- Stored procedure to retrieve student registration data
CREATE PROCEDURE [dbo].[GetStudentRegistrations]
    @StudentId INT = NULL  -- Optional: Pass a specific StudentId to filter; NULL for all
AS
BEGIN
    SET NOCOUNT ON;

    -- Select registration data, optionally joining with Student table for full details
    SELECT 
        sr.Id,
        sr.StudentId,
        sr.Requirements
    FROM [dbo].[tblStudentReg] sr
    INNER JOIN Student s ON sr.StudentId = s.Id  -- Join to get student name
    WHERE (@StudentId IS NULL OR sr.StudentId = @StudentId)  -- Filter if StudentId provided
    ORDER BY sr.Id;  -- Order by registration ID
END
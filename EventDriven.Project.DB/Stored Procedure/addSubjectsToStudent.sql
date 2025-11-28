CREATE PROCEDURE addSubjectsToStudent
    @StudentId INT,
    @SubjectIds NVARCHAR(MAX)   -- ex: '1,2,5,7'
AS
BEGIN
    SET NOCOUNT ON;

    ;WITH SubjectList AS
    (
        SELECT value AS SubjectId
        FROM STRING_SPLIT(@SubjectIds, ',')
    )
    INSERT INTO tblStudentSubject (StudentId, SubjectId)
    SELECT @StudentId, SubjectId FROM SubjectList;
END

CREATE PROCEDURE addSubjectToStudent
    @StudentId INT,
    @SubjectId INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO tblStudentSubject (StudentId, SubjectId)
    VALUES (@StudentId, @SubjectId);
END

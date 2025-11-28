CREATE TABLE [dbo].[tblSchedule]
(
	[ScheduleID] INT PRIMARY KEY IDENTITY(1,1),
    [SectionID] INT,  -- Define the SectionID column first
    [TeacherID] INT,  -- Define the TeacherID column first
    [SubjectID] INT,  -- Define the SubjectID column first
    [StartTime] TIME,
    [EndTime] TIME,
    [Day] VARCHAR(10),  -- Optional: For Day of the Week (e.g., 'Monday')
    [GradeLevel] NVARCHAR(20) ,

    -- Define foreign key constraints
    CONSTRAINT FK_tblSchedules_Section FOREIGN KEY ([SectionID]) REFERENCES [dbo].[tblSection]([SectionID]),
    CONSTRAINT FK_tblSchedules_Teacher FOREIGN KEY ([TeacherID]) REFERENCES [dbo].[tblTeacher]([TeacherID]),
    CONSTRAINT FK_tblSchedules_Subject FOREIGN KEY ([SubjectID]) REFERENCES [dbo].[tblSubject]([SubjectID]),
)

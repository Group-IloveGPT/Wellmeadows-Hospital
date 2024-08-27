CREATE TABLE [dbo].[Staffs]
(
    Staff_ID INT PRIMARY KEY IDENTITY(1,1),
    S_Firstname VARCHAR(50) NOT NULL,
    S_Lastname VARCHAR(50) NOT NULL,
    Address VARCHAR(100),
    Phone VARCHAR(20),
    DOB DATE,
    Gender CHAR(1),
    SSN VARCHAR(15),
    Position VARCHAR(50),
    Salary DECIMAL(10,2),
    Qualifications VARCHAR(100),
    ContractType VARCHAR(50),
    WeeklyHours INT,
    HasExperience TINYINT
);

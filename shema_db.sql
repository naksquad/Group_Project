/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [adminID]
      ,[admin_username]
      ,[admin_password]
  FROM [schoolsystem].[dbo].[administrator_table]

SELECT TOP (1000) [studentID]
      ,[student_first_name]
      ,[student_last_name]
      ,[student_DOB]
      ,[student_sex]
      ,[student_full_name]
  FROM [schoolsystem].[dbo].[student_table]
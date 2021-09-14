use master
go

IF (EXISTS (SELECT name FROM master.dbo.sysdatabases 
WHERE name = 'SchoolDB'))
begin
    alter database SchoolDB set single_user with rollback immediate
    drop database SchoolDB
end
go

create database SchoolDB
go
use SchoolDB
go

create table Student (
Id int identity (1,1) Primary Key,
[Name] nvarchar(255),
Email nvarchar(255)
)

create table Teacher(
Id int identity (1,1) Primary Key,
[Name] nvarchar(255),
Email nvarchar(255)
)

create table Course(
Id int identity (1,1) Primary Key,
[Name] nvarchar(255),
Teacher nvarchar(255)
)

create table StudentCourse(
FK_StudentId int,
FK_CourseId int
)
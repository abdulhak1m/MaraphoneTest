use db1
go

create table RunnerConfidentialInfo
(
	id int identity primary key,
	[E-mail] varchar(150) not null,
	[Username] varchar(150) not null,
	[Password] nvarchar(40) not null,
);

create table RunnerPersonalInfo
(
	id int identity primary key,
	[Name] nvarchar(150)		not null,
	[Surname] nvarchar(150)		not null,
	[Gender] nvarchar(15)		not null,
	[DateOfBirth] date		    not null,
	[Contry] nvarchar(150)	    not null,
	[PictureName] nvarchar(150) not null,
	[Picture] image				not null
);
USE [EmployeeManagementDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[City] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AssignTasks]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AssignTasks](
	[AssignTaskId] [int] IDENTITY(1,1) NOT NULL,
	[AssignTaskName] [varchar](50) NOT NULL,
	[AssignTaskDec] [varchar](8000) NOT NULL,
	[AssignTaskEmployeeId] [int] NOT NULL,
	[Priority] [varchar](50) NULL,
 CONSTRAINT [PK_AssignTask] PRIMARY KEY CLUSTERED 
(
	[AssignTaskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[DpartmentID] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[DpartmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](50) NULL,
	[PhotoPath] [nvarchar](max) NULL,
	[DepartmentDpartmentID] [int] NULL,
	[PositionID] [int] NULL,
	[ScheduleId] [int] NULL,
	[AssignTaskId] [int] NULL,
	[LeaveReqId] [int] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Leaves]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Leaves](
	[LeaveId] [int] IDENTITY(1,1) NOT NULL,
	[LeaveReason] [varchar](8000) NOT NULL,
	[ReasonStatus] [varchar](50) NULL,
	[LeaveEmployeeId] [int] NULL,
 CONSTRAINT [PK_Leave] PRIMARY KEY CLUSTERED 
(
	[LeaveId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Positions]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Positions](
	[PositionID] [int] IDENTITY(1,1) NOT NULL,
	[PositionName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Positions] PRIMARY KEY CLUSTERED 
(
	[PositionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 3/28/2022 11:13:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[ScheduleId] [int] IDENTITY(1,1) NOT NULL,
	[TimeIn] [nvarchar](max) NULL,
	[TimeOut] [nvarchar](max) NULL,
	[ScheduleEmployeeId] [int] NULL,
 CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED 
(
	[ScheduleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201024101718_InitialMigration', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201025060436_SeedData', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201025061721_AddPhotoPathColumn', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201103024527_AddingIdentity', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201105053037_Extend_IdentityUser', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201106154240_Update_Connection', N'3.1.9')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201201184844_AddCloumnEmployee', N'3.1.9')
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c3c9e9eb-024b-43b4-b165-f5c43d9196bb', N'Admin', N'ADMIN', N'05a336ba-7475-45da-98de-300ef078701a')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'd17a1621-3b6b-4585-9d6d-fbe4c051c9a3', N'test', N'TEST', N'33e114bb-39c2-44d8-87af-3de8e8ad3535')
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 

INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (9, N'0993abdc-8d90-4ff6-9889-bce1454c60dd', N'Create Role', N'Create Role')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (10, N'0993abdc-8d90-4ff6-9889-bce1454c60dd', N'Delete Role', N'Delete Role')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (12, N'0993abdc-8d90-4ff6-9889-bce1454c60dd', N'Edit Role', N'Edit Role')
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO
INSERT [dbo].[AspNetUserLogins] ([LoginProvider], [ProviderKey], [ProviderDisplayName], [UserId]) VALUES (N'Google', N'113211133470479696360', N'Google', N'5adeaf96-e2f8-43d0-8b11-ca1ca659f169')
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0993abdc-8d90-4ff6-9889-bce1454c60dd', N'c3c9e9eb-024b-43b4-b165-f5c43d9196bb')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a3315f5b-2b6d-422f-80ec-d2e0af1fa0ea', N'd17a1621-3b6b-4585-9d6d-fbe4c051c9a3')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'b427edf7-9c16-4969-b256-f4845b0b2037', N'd17a1621-3b6b-4585-9d6d-fbe4c051c9a3')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'0993abdc-8d90-4ff6-9889-bce1454c60dd', N'Abhishek', N'ABHISHEK', N'ab@gmail.com', N'AB@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEObRbWbAOxEYhnFudc+mpkeqHb9GZHxHL+8utiID1rQuUgceRMwPXLkxFPmbZ5P5pA==', N'Z4T7OV4MVYRGCPVM4HTY3QK6LDZTHOCN', N'6c9ae7e5-277b-4d9b-a154-a6dcf2576607', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'22a6bfc3-02b7-41c0-b86f-bfff230751db', N'Himanshu', N'HIMANSHU', N'h@gmail.com', N'H@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAENP3T/Oc+ONkhUTnGFZkq0JEQrjV5jtaGlfIpBOpHn5QF/BiixawbnNOlAKPJEjtDA==', N'EXLLHZCFDPT5GEGZGDAWCH3KO5D64LVO', N'84176c36-669a-4607-a658-e1936edf4d4e', NULL, 0, 0, NULL, 1, 0, N'ahmedabad')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'2a7e49eb-466e-43e4-98c4-3396ff0f57a3', N'XYZ', N'XYZ', N'xyz@gmail.com', N'XYZ@GMAIL.COM', 0, NULL, N'DECORCGQKRSDHWI3XLLUZDKZJ66LJZHJ', N'929f06e3-dbf6-4110-9244-7d83bfba18d5', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'5adeaf96-e2f8-43d0-8b11-ca1ca659f169', N'mushfikur1123@gmail.com', N'MUSHFIKUR1123@GMAIL.COM', N'mushfikur1123@gmail.com', N'MUSHFIKUR1123@GMAIL.COM', 0, NULL, N'7XDH2UDYYA5T3KVVAZAWLQ2ZLFPIYMPE', N'd3f76483-55ed-447f-8e85-46ff0c3c6b6e', NULL, 0, 0, NULL, 1, 0, NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'a3315f5b-2b6d-422f-80ec-d2e0af1fa0ea', N'MokhlesRahman', N'MOKHLESRAHMAN', N'mo@gmail.com', N'MO@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEObRbWbAOxEYhnFudc+mpkeqHb9GZHxHL+8utiID1rQuUgceRMwPXLkxFPmbZ5P5pA==', N'KIYIT263XESE5JL7MUP6ZHSVLD6DARXP', N'759936cd-2d55-4625-b6c3-d27efa799369', NULL, 0, 0, NULL, 1, 0, N'Bogura')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'b1214097-0199-428a-9457-68ed45393b87', N'Abhishek1', N'ABHISHEK1', N'abhishek@gmail.com', N'ABHISHEK@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEObRbWbAOxEYhnFudc+mpkeqHb9GZHxHL+8utiID1rQuUgceRMwPXLkxFPmbZ5P5pA==', N'CSDU7I76RGTT4VVO55FAIZSGWRZXSELZ', N'a2ad2fce-1921-4465-ab51-71517783b8f1', NULL, 0, 0, NULL, 1, 0, N'Ahmedabad')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [City]) VALUES (N'b427edf7-9c16-4969-b256-f4845b0b2037', N'koduMollah', N'KODUMOLLAH', N'ko@gmail.com', N'KO@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEObRbWbAOxEYhnFudc+mpkeqHb9GZHxHL+8utiID1rQuUgceRMwPXLkxFPmbZ5P5pA==', N'BSVCJUSKUXOGNYHPCHP5BCVTFEC7KKNA', N'69179e31-c269-4013-964f-1ccb99992c49', NULL, 0, 0, NULL, 1, 0, NULL)
GO
SET IDENTITY_INSERT [dbo].[AssignTasks] ON 

INSERT [dbo].[AssignTasks] ([AssignTaskId], [AssignTaskName], [AssignTaskDec], [AssignTaskEmployeeId], [Priority]) VALUES (4, N'Task 1', N'Dec', 7, N'High')
INSERT [dbo].[AssignTasks] ([AssignTaskId], [AssignTaskName], [AssignTaskDec], [AssignTaskEmployeeId], [Priority]) VALUES (5, N'Task 2', N'alkdfhadslgh', 4, N'High')
SET IDENTITY_INSERT [dbo].[AssignTasks] OFF
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([DpartmentID], [DepartmentName]) VALUES (1, N'HR')
INSERT [dbo].[Departments] ([DpartmentID], [DepartmentName]) VALUES (2, N'Knit')
INSERT [dbo].[Departments] ([DpartmentID], [DepartmentName]) VALUES (3, N'Knit3')
INSERT [dbo].[Departments] ([DpartmentID], [DepartmentName]) VALUES (4, N'Account')
INSERT [dbo].[Departments] ([DpartmentID], [DepartmentName]) VALUES (5, N'Labour')
INSERT [dbo].[Departments] ([DpartmentID], [DepartmentName]) VALUES (6, N'Programming')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([ID], [Name], [Email], [Password], [PhotoPath], [DepartmentDpartmentID], [PositionID], [ScheduleId], [AssignTaskId], [LeaveReqId]) VALUES (1, N'Rabbi', N'ra@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Employees] ([ID], [Name], [Email], [Password], [PhotoPath], [DepartmentDpartmentID], [PositionID], [ScheduleId], [AssignTaskId], [LeaveReqId]) VALUES (2, N'kolu2 rahman', N'ko2@gmail.com', NULL, N'33fa5adc-ce53-403a-9325-f761d56136df_main.jpg', NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Employees] ([ID], [Name], [Email], [Password], [PhotoPath], [DepartmentDpartmentID], [PositionID], [ScheduleId], [AssignTaskId], [LeaveReqId]) VALUES (3, N'Sokhina', N'so@gmail.com', NULL, NULL, 2, 1, NULL, NULL, NULL)
INSERT [dbo].[Employees] ([ID], [Name], [Email], [Password], [PhotoPath], [DepartmentDpartmentID], [PositionID], [ScheduleId], [AssignTaskId], [LeaveReqId]) VALUES (4, N'kuddus', N'ku@gmail.com', NULL, NULL, 1, 2, 2, NULL, NULL)
INSERT [dbo].[Employees] ([ID], [Name], [Email], [Password], [PhotoPath], [DepartmentDpartmentID], [PositionID], [ScheduleId], [AssignTaskId], [LeaveReqId]) VALUES (5, N'JosephSaad', N'joseph@gmail.com', NULL, NULL, 1, 1, 1, NULL, NULL)
INSERT [dbo].[Employees] ([ID], [Name], [Email], [Password], [PhotoPath], [DepartmentDpartmentID], [PositionID], [ScheduleId], [AssignTaskId], [LeaveReqId]) VALUES (6, N'abhi', N'natasha@gmail.com', N'123', NULL, 1, 1, 3, NULL, NULL)
INSERT [dbo].[Employees] ([ID], [Name], [Email], [Password], [PhotoPath], [DepartmentDpartmentID], [PositionID], [ScheduleId], [AssignTaskId], [LeaveReqId]) VALUES (7, N'XYZ', N'xyz@gmail.com', N'123', NULL, 1, 2, 1, NULL, NULL)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Positions] ON 

INSERT [dbo].[Positions] ([PositionID], [PositionName]) VALUES (1, N'Programmer')
INSERT [dbo].[Positions] ([PositionID], [PositionName]) VALUES (2, N'Accountant')
INSERT [dbo].[Positions] ([PositionID], [PositionName]) VALUES (3, N'Developer')
INSERT [dbo].[Positions] ([PositionID], [PositionName]) VALUES (4, N'Manager')
SET IDENTITY_INSERT [dbo].[Positions] OFF
GO
SET IDENTITY_INSERT [dbo].[Schedules] ON 

INSERT [dbo].[Schedules] ([ScheduleId], [TimeIn], [TimeOut], [ScheduleEmployeeId]) VALUES (1, N'12:30am', N'1:30am', NULL)
INSERT [dbo].[Schedules] ([ScheduleId], [TimeIn], [TimeOut], [ScheduleEmployeeId]) VALUES (2, N'2:00am', N'6:00am', NULL)
INSERT [dbo].[Schedules] ([ScheduleId], [TimeIn], [TimeOut], [ScheduleEmployeeId]) VALUES (3, N'3:30am', N'5:00am', NULL)
INSERT [dbo].[Schedules] ([ScheduleId], [TimeIn], [TimeOut], [ScheduleEmployeeId]) VALUES (4, N'1:00am', N'2:00pm', NULL)
SET IDENTITY_INSERT [dbo].[Schedules] OFF
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AssignTasks]  WITH CHECK ADD  CONSTRAINT [FK_AssignTask_Employees] FOREIGN KEY([AssignTaskEmployeeId])
REFERENCES [dbo].[Employees] ([ID])
GO
ALTER TABLE [dbo].[AssignTasks] CHECK CONSTRAINT [FK_AssignTask_Employees]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Departments_DepartmentDpartmentID] FOREIGN KEY([DepartmentDpartmentID])
REFERENCES [dbo].[Departments] ([DpartmentID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Departments_DepartmentDpartmentID]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Positions_PositionID] FOREIGN KEY([PositionID])
REFERENCES [dbo].[Positions] ([PositionID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Positions_PositionID]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Schedules_ScheduleId] FOREIGN KEY([ScheduleId])
REFERENCES [dbo].[Schedules] ([ScheduleId])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Schedules_ScheduleId]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_Employees] FOREIGN KEY([ScheduleId])
REFERENCES [dbo].[Employees] ([ID])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_Employees]
GO

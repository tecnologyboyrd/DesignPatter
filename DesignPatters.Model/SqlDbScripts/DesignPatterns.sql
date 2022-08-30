USE [master]
GO
/****** Object:  Database [DesignPatterns]    Script Date: 29/8/2022 10:45:28 p. m. ******/
CREATE DATABASE [DesignPatterns]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DisignPatterns', FILENAME = N'C:\SQLDB\MDF\DisignPatterns.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DisignPatterns_log', FILENAME = N'C:\SQLDB\LDF\DisignPatterns_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DesignPatterns] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DesignPatterns].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DesignPatterns] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DesignPatterns] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DesignPatterns] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DesignPatterns] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DesignPatterns] SET ARITHABORT OFF 
GO
ALTER DATABASE [DesignPatterns] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DesignPatterns] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DesignPatterns] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DesignPatterns] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DesignPatterns] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DesignPatterns] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DesignPatterns] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DesignPatterns] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DesignPatterns] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DesignPatterns] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DesignPatterns] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DesignPatterns] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DesignPatterns] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DesignPatterns] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DesignPatterns] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DesignPatterns] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DesignPatterns] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DesignPatterns] SET RECOVERY FULL 
GO
ALTER DATABASE [DesignPatterns] SET  MULTI_USER 
GO
ALTER DATABASE [DesignPatterns] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DesignPatterns] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DesignPatterns] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DesignPatterns] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DesignPatterns] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DesignPatterns] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DesignPatterns', N'ON'
GO
ALTER DATABASE [DesignPatterns] SET QUERY_STORE = OFF
GO
USE [DesignPatterns]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 29/8/2022 10:45:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[IdLog] [int] IDENTITY(1,1) NOT NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Log] PRIMARY KEY CLUSTERED 
(
	[IdLog] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 29/8/2022 10:45:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[AutoSec] [int] IDENTITY(1,1) NOT NULL,
	[PermissionId] [uniqueidentifier] NOT NULL,
	[Desciption] [varchar](100) NOT NULL,
 CONSTRAINT [Pk_PermissionId] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Prueba]    Script Date: 29/8/2022 10:45:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prueba](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Prueba] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[REJEMPLO_PU]    Script Date: 29/8/2022 10:45:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[REJEMPLO_PU](
	[RecordId] [int] IDENTITY(1,1) NOT NULL,
	[Student] [varchar](20) NULL,
	[Semester] [int] NULL,
	[Qualification] [numeric](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 29/8/2022 10:45:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[AutoSec] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [uniqueidentifier] NOT NULL,
	[Description] [varchar](30) NULL,
 CONSTRAINT [Pk_RolId] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoleAssignment]    Script Date: 29/8/2022 10:45:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoleAssignment](
	[AutoSec] [int] IDENTITY(1,1) NOT NULL,
	[UserRoleAssignmentId] [uniqueidentifier] NOT NULL,
	[UserId] [uniqueidentifier] NOT NULL,
	[RolId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [Pk_UserRoleAssignmentId] PRIMARY KEY CLUSTERED 
(
	[UserRoleAssignmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 29/8/2022 10:45:28 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[AutoSeq] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [uniqueidentifier] ROWGUIDCOL  NOT NULL,
	[UserFullName] [varchar](50) NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](30) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Logs] ON 
GO
INSERT [dbo].[Logs] ([IdLog], [Description]) VALUES (1, N'Prueba 1')
GO
INSERT [dbo].[Logs] ([IdLog], [Description]) VALUES (2, N'Prueba 2')
GO
SET IDENTITY_INSERT [dbo].[Logs] OFF
GO
SET IDENTITY_INSERT [dbo].[Permission] ON 
GO
INSERT [dbo].[Permission] ([AutoSec], [PermissionId], [Desciption]) VALUES (1, N'34b943ad-af11-ed11-911f-40ec9920ec06', N'Pantalla de configuracion del sistema')
GO
SET IDENTITY_INSERT [dbo].[Permission] OFF
GO
SET IDENTITY_INSERT [dbo].[Prueba] ON 
GO
INSERT [dbo].[Prueba] ([Id], [Descripcion]) VALUES (1, N'tetera')
GO
SET IDENTITY_INSERT [dbo].[Prueba] OFF
GO
SET IDENTITY_INSERT [dbo].[REJEMPLO_PU] ON 
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (1, N'JHON PU', 1, CAST(70.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (2, N'JHON PU', 2, CAST(71.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (3, N'JHON PU', 3, CAST(72.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (4, N'JHON PU', 4, CAST(73.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (5, N'JHON PU', 5, CAST(74.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (6, N'JHON PU', 6, CAST(75.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (7, N'JHON PU', 7, CAST(75.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (8, N'LEONARD PEREZ', 1, CAST(95.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (9, N'LEONARD PEREZ', 2, CAST(96.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (10, N'LEONARD PEREZ', 3, CAST(97.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (11, N'LEONARD PEREZ', 4, CAST(98.00 AS Numeric(18, 2)))
GO
INSERT [dbo].[REJEMPLO_PU] ([RecordId], [Student], [Semester], [Qualification]) VALUES (12, N'LEONARD PEREZ', 5, CAST(99.00 AS Numeric(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[REJEMPLO_PU] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (27, N'a78db390-3115-4213-8f4b-37ed8c77851e', N'Patrona')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (1, N'3ae56e79-d80e-ed11-911e-40ec9920ec06', N'Administrator')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (2, N'65f1cb87-d80e-ed11-911e-40ec9920ec06', N'Guest')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (3, N'9cb79109-d90e-ed11-911e-40ec9920ec06', N'VENDOR')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (4, N'c3ac0418-d90e-ed11-911e-40ec9920ec06', N'CXC Manager')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (5, N'4e1891ac-e11d-ed11-9125-40ec9920ec06', N'Auditor')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (6, N'd13eb356-e31d-ed11-9125-40ec9920ec06', N'Visitante')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (9, N'edf9bb01-e51d-ed11-9125-40ec9920ec06', N'Desarrollador')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (11, N'c560ca5b-e51d-ed11-9125-40ec9920ec06', N'Veedor')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (13, N'5935d8d9-e51d-ed11-9125-40ec9920ec06', N'Contralor')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (15, N'8fd1821e-e61d-ed11-9125-40ec9920ec06', N'Mesa De Ayuda')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (17, N'a3b6899e-a71e-ed11-9125-40ec9920ec06', N'Consultor')
GO
INSERT [dbo].[Roles] ([AutoSec], [RoleId], [Description]) VALUES (28, N'cfa9748b-1369-40d7-b6ae-599f0144d47f', N'Jefa')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRoleAssignment] ON 
GO
INSERT [dbo].[UserRoleAssignment] ([AutoSec], [UserRoleAssignmentId], [UserId], [RolId]) VALUES (13, N'11374030-3f06-43e0-8794-3556b6510181', N'ec6489de-8b5e-4ab0-895e-83e9f3b14f60', N'cfa9748b-1369-40d7-b6ae-599f0144d47f')
GO
INSERT [dbo].[UserRoleAssignment] ([AutoSec], [UserRoleAssignmentId], [UserId], [RolId]) VALUES (1, N'78a65ee6-d80e-ed11-911e-40ec9920ec06', N'ec482236-c6fa-4605-8abe-6554a5438b89', N'3ae56e79-d80e-ed11-911e-40ec9920ec06')
GO
INSERT [dbo].[UserRoleAssignment] ([AutoSec], [UserRoleAssignmentId], [UserId], [RolId]) VALUES (2, N'a6e38331-d90e-ed11-911e-40ec9920ec06', N'4c13c304-b605-4f49-a21a-e5f61a07044d', N'9cb79109-d90e-ed11-911e-40ec9920ec06')
GO
INSERT [dbo].[UserRoleAssignment] ([AutoSec], [UserRoleAssignmentId], [UserId], [RolId]) VALUES (3, N'2a8fc63a-d90e-ed11-911e-40ec9920ec06', N'4c13c304-b605-4f49-a21a-e5f61a07044d', N'c3ac0418-d90e-ed11-911e-40ec9920ec06')
GO
INSERT [dbo].[UserRoleAssignment] ([AutoSec], [UserRoleAssignmentId], [UserId], [RolId]) VALUES (14, N'376e3d41-7cad-4516-9534-e34e85db4546', N'9c25d51c-254b-46e1-9a56-c36ca6bb0dc8', N'65f1cb87-d80e-ed11-911e-40ec9920ec06')
GO
SET IDENTITY_INSERT [dbo].[UserRoleAssignment] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (6, N'0b96e5c3-b982-4109-bcff-0a22fdfdbf2b', N'Ligio Garces', N'lgarces', N'Candy')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (7, N'caad4afd-5e37-4e2c-b017-142389dcad92', N'Juana Sartitopa', N'jsartitopa', N'Candy')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (5, N'6f590b20-8e65-47e1-ba19-5f74278f8981', N'Abigail Perez', N'aperez', N'Candy')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (3, N'ef0cd06c-ae7b-427d-b8a6-64a5fffc9ee3', N'Stephani Moncion', N'smoncion', N'mangamos')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (2, N'ec482236-c6fa-4605-8abe-6554a5438b89', N'Juan Menendez', N'jmenendez', N'123456')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (12, N'ec6489de-8b5e-4ab0-895e-83e9f3b14f60', N'Melanea Santana', N'msantana', N'1234564654')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (4, N'7b64187f-60e5-4237-ab65-8c98492eafe9', N'Charlotte Perez', N'cperez', N'kisco')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (9, N'31c496e2-711f-4c41-9f06-9dec3ea0eb29', N'Vivian Perez', N'vperez', N'Candy')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (11, N'2a3ac24f-42a3-4022-81d4-aed559ca8e96', N'Lisbet Perez', N'libeperez', N'123456')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (8, N'63c4cd04-fc7f-4722-9a7c-ba6ce952288d', N'Luis Medrano', N'lmedrano', N'Candy')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (10, N'8fbb7640-edc4-47e9-b81f-bd733c957690', N'Osvaldo Adames', N'oadames', N'123456')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (13, N'9c25d51c-254b-46e1-9a56-c36ca6bb0dc8', N'Miguel Perez Mendez', N'perezmendez', N'123654')
GO
INSERT [dbo].[Users] ([AutoSeq], [UserId], [UserFullName], [UserName], [Password]) VALUES (1, N'4c13c304-b605-4f49-a21a-e5f61a07044d', N'Leonard Perez', N'lperez', N'123456')
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Uq_Description]    Script Date: 29/8/2022 10:45:28 p. m. ******/
ALTER TABLE [dbo].[Roles] ADD  CONSTRAINT [Uq_Description] UNIQUE NONCLUSTERED 
(
	[Description] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [Uq_Users_Name]    Script Date: 29/8/2022 10:45:28 p. m. ******/
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [Uq_Users_Name] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Permission] ADD  DEFAULT (newsequentialid()) FOR [PermissionId]
GO
ALTER TABLE [dbo].[Roles] ADD  DEFAULT (newsequentialid()) FOR [RoleId]
GO
ALTER TABLE [dbo].[UserRoleAssignment] ADD  DEFAULT (newsequentialid()) FOR [UserRoleAssignmentId]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_UserId]  DEFAULT (newid()) FOR [UserId]
GO
ALTER TABLE [dbo].[UserRoleAssignment]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleAssignmentId_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[UserRoleAssignment] CHECK CONSTRAINT [FK_UserRoleAssignmentId_UserId]
GO
USE [master]
GO
ALTER DATABASE [DesignPatterns] SET  READ_WRITE 
GO

USE [master]
GO
/****** Object:  Database [bdregistroesc]    Script Date: 30/09/2022 12:22:07 p. m. ******/
CREATE DATABASE [bdregistroesc]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bdregistroesc', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.BARCO\MSSQL\DATA\bdregistroesc.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bdregistroesc_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.BARCO\MSSQL\DATA\bdregistroesc_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [bdregistroesc] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bdregistroesc].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bdregistroesc] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bdregistroesc] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bdregistroesc] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bdregistroesc] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bdregistroesc] SET ARITHABORT OFF 
GO
ALTER DATABASE [bdregistroesc] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bdregistroesc] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bdregistroesc] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bdregistroesc] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bdregistroesc] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bdregistroesc] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bdregistroesc] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bdregistroesc] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bdregistroesc] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bdregistroesc] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bdregistroesc] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bdregistroesc] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bdregistroesc] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bdregistroesc] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bdregistroesc] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bdregistroesc] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bdregistroesc] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bdregistroesc] SET RECOVERY FULL 
GO
ALTER DATABASE [bdregistroesc] SET  MULTI_USER 
GO
ALTER DATABASE [bdregistroesc] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bdregistroesc] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bdregistroesc] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bdregistroesc] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bdregistroesc] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bdregistroesc] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bdregistroesc', N'ON'
GO
ALTER DATABASE [bdregistroesc] SET QUERY_STORE = OFF
GO
USE [bdregistroesc]
GO
/****** Object:  UserDefinedFunction [dbo].[promedio]    Script Date: 30/09/2022 12:22:07 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[promedio](@idCali int) returns int
As 

Begin 

declare @promedio int

select @promedio = (Pparcial + Sparcial + Tparcial)/3 from calificaciones where idCali = @idCali

RETURN @promedio 

end 
GO
/****** Object:  Table [dbo].[alumno]    Script Date: 30/09/2022 12:22:07 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[alumno](
	[idAlumno] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](25) NOT NULL,
	[Apellido_Pa] [varchar](25) NOT NULL,
	[Apellido_Ma] [varchar](25) NOT NULL,
	[Edad] [int] NOT NULL,
	[Sexo] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idAlumno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[calificaciones]    Script Date: 30/09/2022 12:22:07 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[calificaciones](
	[idCali] [int] IDENTITY(1,1) NOT NULL,
	[idAlumno] [int] NOT NULL,
	[idMateria] [int] NOT NULL,
	[Pparcial] [int] NOT NULL,
	[Sparcial] [int] NOT NULL,
	[Tparcial] [int] NOT NULL,
	[calificaciones] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCali] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materias]    Script Date: 30/09/2022 12:22:07 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materias](
	[idMateria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMateria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[alumno] ON 

INSERT [dbo].[alumno] ([idAlumno], [Nombre], [Apellido_Pa], [Apellido_Ma], [Edad], [Sexo]) VALUES (4, N'ramces', N'tenorio', N'orozco', 26, N'Femenino ')
INSERT [dbo].[alumno] ([idAlumno], [Nombre], [Apellido_Pa], [Apellido_Ma], [Edad], [Sexo]) VALUES (6, N'jose', N'maria', N'chente', 35, N'Masculino')
INSERT [dbo].[alumno] ([idAlumno], [Nombre], [Apellido_Pa], [Apellido_Ma], [Edad], [Sexo]) VALUES (7, N'miguel', N'ronal', N'china', 25, N'Femenino ')
INSERT [dbo].[alumno] ([idAlumno], [Nombre], [Apellido_Pa], [Apellido_Ma], [Edad], [Sexo]) VALUES (12, N'fidel', N'cortez', N'juago', 24, N'Femenino ')
INSERT [dbo].[alumno] ([idAlumno], [Nombre], [Apellido_Pa], [Apellido_Ma], [Edad], [Sexo]) VALUES (15, N'angel', N'avelino', N'madrid', 22, N'masculino')
SET IDENTITY_INSERT [dbo].[alumno] OFF
GO
SET IDENTITY_INSERT [dbo].[calificaciones] ON 

INSERT [dbo].[calificaciones] ([idCali], [idAlumno], [idMateria], [Pparcial], [Sparcial], [Tparcial], [calificaciones]) VALUES (32, 7, 3, 8, 7, 9, 8)
INSERT [dbo].[calificaciones] ([idCali], [idAlumno], [idMateria], [Pparcial], [Sparcial], [Tparcial], [calificaciones]) VALUES (36, 4, 3, 10, 9, 9, 7)
INSERT [dbo].[calificaciones] ([idCali], [idAlumno], [idMateria], [Pparcial], [Sparcial], [Tparcial], [calificaciones]) VALUES (37, 7, 4, 8, 10, 10, 9)
INSERT [dbo].[calificaciones] ([idCali], [idAlumno], [idMateria], [Pparcial], [Sparcial], [Tparcial], [calificaciones]) VALUES (39, 12, 7, 9, 9, 9, 9)
INSERT [dbo].[calificaciones] ([idCali], [idAlumno], [idMateria], [Pparcial], [Sparcial], [Tparcial], [calificaciones]) VALUES (40, 7, 8, 9, 9, 9, 0)
SET IDENTITY_INSERT [dbo].[calificaciones] OFF
GO
SET IDENTITY_INSERT [dbo].[materias] ON 

INSERT [dbo].[materias] ([idMateria], [Descripcion]) VALUES (3, N'español2')
INSERT [dbo].[materias] ([idMateria], [Descripcion]) VALUES (4, N'history')
INSERT [dbo].[materias] ([idMateria], [Descripcion]) VALUES (6, N'quimica')
INSERT [dbo].[materias] ([idMateria], [Descripcion]) VALUES (7, N'matematicas')
INSERT [dbo].[materias] ([idMateria], [Descripcion]) VALUES (8, N'geografia')
INSERT [dbo].[materias] ([idMateria], [Descripcion]) VALUES (11, N'Programacion2')
INSERT [dbo].[materias] ([idMateria], [Descripcion]) VALUES (12, N'Programacion')
SET IDENTITY_INSERT [dbo].[materias] OFF
GO
ALTER TABLE [dbo].[calificaciones]  WITH CHECK ADD  CONSTRAINT [fk_alumno] FOREIGN KEY([idAlumno])
REFERENCES [dbo].[alumno] ([idAlumno])
GO
ALTER TABLE [dbo].[calificaciones] CHECK CONSTRAINT [fk_alumno]
GO
ALTER TABLE [dbo].[calificaciones]  WITH CHECK ADD  CONSTRAINT [fk_materias] FOREIGN KEY([idMateria])
REFERENCES [dbo].[materias] ([idMateria])
GO
ALTER TABLE [dbo].[calificaciones] CHECK CONSTRAINT [fk_materias]
GO
/****** Object:  StoredProcedure [dbo].[cargaralu]    Script Date: 30/09/2022 12:22:07 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cargaralu] 
as 
select idAlumno,Nombre,Apellido_Pa,Apellido_Ma from alumno
GO
/****** Object:  StoredProcedure [dbo].[cargarmat]    Script Date: 30/09/2022 12:22:07 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[cargarmat]
as 
select idMateria,Descripcion from materias
GO
USE [master]
GO
ALTER DATABASE [bdregistroesc] SET  READ_WRITE 
GO

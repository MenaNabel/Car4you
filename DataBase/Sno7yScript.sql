USE [master]
GO
/****** Object:  Database [Sno7y]    Script Date: 8/2/2019 11:39:55 PM ******/
CREATE DATABASE [Sno7y]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sno7y', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SNO7Y\MSSQL\DATA\Sno7y.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sno7y_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SNO7Y\MSSQL\DATA\Sno7y_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Sno7y] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sno7y].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sno7y] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sno7y] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sno7y] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sno7y] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sno7y] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sno7y] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sno7y] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sno7y] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sno7y] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sno7y] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sno7y] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sno7y] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sno7y] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sno7y] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sno7y] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Sno7y] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sno7y] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sno7y] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sno7y] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sno7y] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sno7y] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sno7y] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sno7y] SET RECOVERY FULL 
GO
ALTER DATABASE [Sno7y] SET  MULTI_USER 
GO
ALTER DATABASE [Sno7y] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sno7y] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sno7y] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sno7y] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sno7y] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Sno7y', N'ON'
GO
ALTER DATABASE [Sno7y] SET QUERY_STORE = OFF
GO
USE [Sno7y]
GO
/****** Object:  Table [dbo].[car]    Script Date: 8/2/2019 11:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[car](
	[CID] [int] IDENTITY(100,1) NOT NULL,
	[num] [nvarchar](255) NOT NULL,
	[price] [decimal](18, 0) NOT NULL,
	[type_car] [nvarchar](255) NOT NULL,
	[num_seats] [int] NOT NULL,
	[col] [nvarchar](255) NOT NULL,
	[pick] [nvarchar](max) NULL,
	[available] [bit] NOT NULL,
	[air_conditioning] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[num] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[client]    Script Date: 8/2/2019 11:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[client](
	[ssna] [nvarchar](14) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[ID_car] [int] NULL,
	[startDate] [datetime] NOT NULL,
	[endDate] [datetime] NOT NULL,
	[t_ID] [int] NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ssna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[type_client]    Script Date: 8/2/2019 11:39:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type_client](
	[type_ID] [int] NOT NULL,
	[type_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD FOREIGN KEY([ID_car])
REFERENCES [dbo].[car] ([CID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[client]  WITH CHECK ADD FOREIGN KEY([t_ID])
REFERENCES [dbo].[type_client] ([type_ID])
GO
USE [master]
GO
ALTER DATABASE [Sno7y] SET  READ_WRITE 
GO

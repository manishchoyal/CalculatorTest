USE [master]
GO

/****** Object:  Database [Calculator]    Script Date: 24-Jan-20 4:30:51 PM ******/
CREATE DATABASE [Calculator]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Calculator', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Calculator.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Calculator_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\Calculator_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO

USE [Calculator]
GO

/****** Object:  Table [dbo].[SimpleCalculatorResult]    Script Date: 24-Jan-20 4:32:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SimpleCalculatorResult](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FunctionName] [varchar](50) NULL,
	[FunctionTotal] [varchar](50) NULL,
	[CreatedOn] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[SimpleCalculatorResult] ADD  DEFAULT (getdate()) FOR [CreatedOn]
GO



USE [Tours]
GO
ALTER TABLE [dbo].[TypeOfTour] DROP CONSTRAINT [FK_TypeOfTour_Type]
GO
ALTER TABLE [dbo].[TypeOfTour] DROP CONSTRAINT [FK_TypeOfTour_Tour]
GO
ALTER TABLE [dbo].[HotelOfTour] DROP CONSTRAINT [FK_HotelOfTour_Tour]
GO
ALTER TABLE [dbo].[HotelOfTour] DROP CONSTRAINT [FK_HotelOfTour_Hotel]
GO
ALTER TABLE [dbo].[Hotelimage] DROP CONSTRAINT [FK_Hotelimage_Hotel]
GO
ALTER TABLE [dbo].[HotelComment] DROP CONSTRAINT [FK_HotelComment_Hotel]
GO
ALTER TABLE [dbo].[Hotel] DROP CONSTRAINT [FK_Hotel_Country]
GO
/****** Object:  Table [dbo].[TypeOfTour]    Script Date: 06.04.2023 15:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TypeOfTour]') AND type in (N'U'))
DROP TABLE [dbo].[TypeOfTour]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 06.04.2023 15:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Type]') AND type in (N'U'))
DROP TABLE [dbo].[Type]
GO
/****** Object:  Table [dbo].[Tour]    Script Date: 06.04.2023 15:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tour]') AND type in (N'U'))
DROP TABLE [dbo].[Tour]
GO
/****** Object:  Table [dbo].[HotelOfTour]    Script Date: 06.04.2023 15:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HotelOfTour]') AND type in (N'U'))
DROP TABLE [dbo].[HotelOfTour]
GO
/****** Object:  Table [dbo].[Hotelimage]    Script Date: 06.04.2023 15:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Hotelimage]') AND type in (N'U'))
DROP TABLE [dbo].[Hotelimage]
GO
/****** Object:  Table [dbo].[HotelComment]    Script Date: 06.04.2023 15:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HotelComment]') AND type in (N'U'))
DROP TABLE [dbo].[HotelComment]
GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 06.04.2023 15:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Hotel]') AND type in (N'U'))
DROP TABLE [dbo].[Hotel]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 06.04.2023 15:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Country]') AND type in (N'U'))
DROP TABLE [dbo].[Country]
GO
USE [master]
GO
/****** Object:  Database [Tours]    Script Date: 06.04.2023 15:38:48 ******/
DROP DATABASE [Tours]
GO

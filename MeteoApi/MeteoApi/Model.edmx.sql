
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/06/2017 09:20:42
-- Generated from EDMX file: C:\Users\Rafael Peixoto\Downloads\VisualStudio\MeteoApp\MeteoApi\MeteoApi\MeteoApi\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Database];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_WeatherCity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cities] DROP CONSTRAINT [FK_WeatherCity];
GO
IF OBJECT_ID(N'[dbo].[FK_CantonCity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cities] DROP CONSTRAINT [FK_CantonCity];
GO
IF OBJECT_ID(N'[dbo].[FK_CountryCanton]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Cantons] DROP CONSTRAINT [FK_CountryCanton];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Weathers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Weathers];
GO
IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Cantons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cantons];
GO
IF OBJECT_ID(N'[dbo].[Countries]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Countries];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Weathers'
CREATE TABLE [dbo].[Weathers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [TemperatureMin] float  NOT NULL,
    [TemperatureMax] nvarchar(max)  NOT NULL,
    [Humidity] float  NOT NULL,
    [Precipitation] nvarchar(max)  NOT NULL,
    [City_Id] int  NOT NULL,
    [State_Id] int  NOT NULL
);
GO

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Canton_Id] int  NOT NULL
);
GO

-- Creating table 'Cantons'
CREATE TABLE [dbo].[Cantons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Country_Id] int  NOT NULL
);
GO

-- Creating table 'Countries'
CREATE TABLE [dbo].[Countries] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'States'
CREATE TABLE [dbo].[States] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Weathers'
ALTER TABLE [dbo].[Weathers]
ADD CONSTRAINT [PK_Weathers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Cantons'
ALTER TABLE [dbo].[Cantons]
ADD CONSTRAINT [PK_Cantons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Countries'
ALTER TABLE [dbo].[Countries]
ADD CONSTRAINT [PK_Countries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'States'
ALTER TABLE [dbo].[States]
ADD CONSTRAINT [PK_States]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Canton_Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [FK_CantonCity]
    FOREIGN KEY ([Canton_Id])
    REFERENCES [dbo].[Cantons]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CantonCity'
CREATE INDEX [IX_FK_CantonCity]
ON [dbo].[Cities]
    ([Canton_Id]);
GO

-- Creating foreign key on [Country_Id] in table 'Cantons'
ALTER TABLE [dbo].[Cantons]
ADD CONSTRAINT [FK_CountryCanton]
    FOREIGN KEY ([Country_Id])
    REFERENCES [dbo].[Countries]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CountryCanton'
CREATE INDEX [IX_FK_CountryCanton]
ON [dbo].[Cantons]
    ([Country_Id]);
GO

-- Creating foreign key on [City_Id] in table 'Weathers'
ALTER TABLE [dbo].[Weathers]
ADD CONSTRAINT [FK_CityWeather]
    FOREIGN KEY ([City_Id])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CityWeather'
CREATE INDEX [IX_FK_CityWeather]
ON [dbo].[Weathers]
    ([City_Id]);
GO

-- Creating foreign key on [State_Id] in table 'Weathers'
ALTER TABLE [dbo].[Weathers]
ADD CONSTRAINT [FK_StateWeather]
    FOREIGN KEY ([State_Id])
    REFERENCES [dbo].[States]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StateWeather'
CREATE INDEX [IX_FK_StateWeather]
ON [dbo].[Weathers]
    ([State_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
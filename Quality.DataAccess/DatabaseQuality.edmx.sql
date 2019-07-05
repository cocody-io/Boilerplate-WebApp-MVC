
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/04/2019 14:45:14
-- Generated from EDMX file: C:\Sources\Michelin\sources\Quality.DataAccess\Database.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Quality];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AnomalyH]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[H] DROP CONSTRAINT [FK_AnomalyH];
GO
IF OBJECT_ID(N'[dbo].[FK_AnomalyPiece]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Anomaly] DROP CONSTRAINT [FK_AnomalyPiece];
GO
IF OBJECT_ID(N'[dbo].[FK_Anomalyref_ProductionArea]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Anomaly] DROP CONSTRAINT [FK_Anomalyref_ProductionArea];
GO
IF OBJECT_ID(N'[dbo].[FK_AnomalyTicketNC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TicketNC] DROP CONSTRAINT [FK_AnomalyTicketNC];
GO
IF OBJECT_ID(N'[dbo].[FK_ExpertiseNoCo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[NoCo] DROP CONSTRAINT [FK_ExpertiseNoCo];
GO
IF OBJECT_ID(N'[dbo].[FK_ExpertisePAF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PAF] DROP CONSTRAINT [FK_ExpertisePAF];
GO
IF OBJECT_ID(N'[dbo].[FK_Expertiseref_CauseZE]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expertise] DROP CONSTRAINT [FK_Expertiseref_CauseZE];
GO
IF OBJECT_ID(N'[dbo].[FK_HCQref_CQ]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HCQ] DROP CONSTRAINT [FK_HCQref_CQ];
GO
IF OBJECT_ID(N'[dbo].[FK_HHCQ]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[HCQ] DROP CONSTRAINT [FK_HHCQ];
GO
IF OBJECT_ID(N'[dbo].[FK_Pieceref_Supplier]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Piece] DROP CONSTRAINT [FK_Pieceref_Supplier];
GO
IF OBJECT_ID(N'[dbo].[FK_ref_TypePieceTicketNC]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TicketNC] DROP CONSTRAINT [FK_ref_TypePieceTicketNC];
GO
IF OBJECT_ID(N'[dbo].[FK_TicketNCExpertise]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expertise] DROP CONSTRAINT [FK_TicketNCExpertise];
GO
IF OBJECT_ID(N'[dbo].[FK_TicketNCref_Machine]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TicketNC] DROP CONSTRAINT [FK_TicketNCref_Machine];
GO
IF OBJECT_ID(N'[dbo].[FK_TicketNCref_ProductCode]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TicketNC] DROP CONSTRAINT [FK_TicketNCref_ProductCode];
GO
IF OBJECT_ID(N'[dbo].[FK_TicketNCref_ProductType]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TicketNC] DROP CONSTRAINT [FK_TicketNCref_ProductType];
GO
IF OBJECT_ID(N'[dbo].[FK_TicketNCref_Unit]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TicketNC] DROP CONSTRAINT [FK_TicketNCref_Unit];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Anomaly]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Anomaly];
GO
IF OBJECT_ID(N'[dbo].[Expertise]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Expertise];
GO
IF OBJECT_ID(N'[dbo].[HCQ]', 'U') IS NOT NULL
    DROP TABLE [dbo].[HCQ];
GO
IF OBJECT_ID(N'[dbo].[H]', 'U') IS NOT NULL
    DROP TABLE [dbo].[H];
GO
IF OBJECT_ID(N'[dbo].[NoCo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[NoCo];
GO
IF OBJECT_ID(N'[dbo].[PAF]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PAF];
GO
IF OBJECT_ID(N'[dbo].[Piece]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Piece];
GO
IF OBJECT_ID(N'[dbo].[ref_CauseZE]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ref_CauseZE];
GO
IF OBJECT_ID(N'[dbo].[ref_CQ]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ref_CQ];
GO
IF OBJECT_ID(N'[dbo].[ref_Machine]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ref_Machine];
GO
IF OBJECT_ID(N'[dbo].[ref_ProductCode]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ref_ProductCode];
GO
IF OBJECT_ID(N'[dbo].[ref_ProductionArea]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ref_ProductionArea];
GO
IF OBJECT_ID(N'[dbo].[ref_ProductType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ref_ProductType];
GO
IF OBJECT_ID(N'[dbo].[ref_Supplier]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ref_Supplier];
GO
IF OBJECT_ID(N'[dbo].[ref_TypePiece]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ref_TypePiece];
GO
IF OBJECT_ID(N'[dbo].[ref_Unit]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ref_Unit];
GO
IF OBJECT_ID(N'[dbo].[TicketNC]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TicketNC];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'AnomalySet'
CREATE TABLE [dbo].[Anomaly] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [PieceId] int  NULL,
    [ref_ProductionAreaId] int  NULL
);
GO

-- Creating table 'ref_ProductionArea'
CREATE TABLE [dbo].[ref_ProductionArea] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'PieceSet'
CREATE TABLE [dbo].[Piece] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ref_SupplierId] int  NOT NULL
);
GO

-- Creating table 'ref_SupplierSet'
CREATE TABLE [dbo].[ref_Supplier] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL
);
GO

-- Creating table 'HSet'
CREATE TABLE [dbo].[H] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PersonId] int  NOT NULL,
    [BarCodeUp] nvarchar(max)  NULL,
    [BarCodeDown] nvarchar(max)  NULL,
    [NkId] int  NULL,
    [NkDate] datetime  NULL,
    [Anomaly_Id] int  NOT NULL
);
GO

-- Creating table 'TicketNCSet'
CREATE TABLE [dbo].[TicketNC] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PersonId] int  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [PersonGroupId] int  NOT NULL,
    [ManufacturedDate] datetime  NOT NULL,
    [CQId] int  NOT NULL,
    [Observation] nvarchar(max)  NULL,
    [Quantity] decimal(18,0)  NOT NULL,
    [Order] int  NOT NULL,
    [ref_TypePieceId] int  NOT NULL,
    [ref_UnitId] int  NOT NULL,
    [ref_ProductCodeId] int  NOT NULL,
    [ref_ProductTypeId] int  NOT NULL,
    [Anomaly_Id] int  NOT NULL,
    [Machine_Id] int  NOT NULL
);
GO

-- Creating table 'ExpertiseSet'
CREATE TABLE [dbo].[Expertise] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [Commentaire] nvarchar(max)  NULL,
    [CQFixed] nvarchar(max)  NULL,
    [LostWeight] decimal(18,0)  NULL,
    [ref_CauseZEId] int  NOT NULL,
    [TicketNC_Id] int  NOT NULL
);
GO

-- Creating table 'NoCoSet'
CREATE TABLE [dbo].[NoCo] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Expertise_Id] int  NOT NULL
);
GO

-- Creating table 'PAFSet'
CREATE TABLE [dbo].[PAF] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Expertise_Id] int  NOT NULL
);
GO

-- Creating table 'HCQSet'
CREATE TABLE [dbo].[HCQ] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HId] int  NOT NULL,
    [Duration] int  NULL,
    [Weight] int  NULL,
    [ref_CQId] int  NOT NULL
);
GO

-- Creating table 'ref_CQ'
CREATE TABLE [dbo].[ref_CQ] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(150)  NOT NULL,
    [IsSupplierCQ] bit  NOT NULL,
    [ProductionAreaName] nvarchar(50)  NOT NULL,
    [IsRyoCQ] bit  NOT NULL
);
GO

-- Creating table 'ref_Machine'
CREATE TABLE [dbo].[ref_Machine] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(250)  NULL,
    [Code] nvarchar(90)  NOT NULL,
    [ProductionAreaName] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'ref_ProductTypeSet'
CREATE TABLE [dbo].[ref_ProductType] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'ref_ProductCodeSet'
CREATE TABLE [dbo].[ref_ProductCode] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Code] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ref_UnitSet'
CREATE TABLE [dbo].[ref_Unit] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'ref_TypePieceSet'
CREATE TABLE [dbo].[ref_TypePiece] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(90)  NOT NULL
);
GO

-- Creating table 'ref_CauseZE'
CREATE TABLE [dbo].[ref_CauseZE] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(250)  NOT NULL,
    [ProductionAreaName] nvarchar(50)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'AnomalySet'
ALTER TABLE [dbo].[Anomaly]
ADD CONSTRAINT [PK_Anomaly]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ref_ProductionArea'
ALTER TABLE [dbo].[ref_ProductionArea]
ADD CONSTRAINT [PK_ref_ProductionArea]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PieceSet'
ALTER TABLE [dbo].[Piece]
ADD CONSTRAINT [PK_Piece]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ref_SupplierSet'
ALTER TABLE [dbo].[ref_Supplier]
ADD CONSTRAINT [PK_ref_Supplier]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HSet'
ALTER TABLE [dbo].[H]
ADD CONSTRAINT [PK_H]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TicketNCSet'
ALTER TABLE [dbo].[TicketNC]
ADD CONSTRAINT [PK_TicketNC]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExpertiseSet'
ALTER TABLE [dbo].[Expertise]
ADD CONSTRAINT [PK_Expertise]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NoCoSet'
ALTER TABLE [dbo].[NoCo]
ADD CONSTRAINT [PK_NoCo]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PAFSet'
ALTER TABLE [dbo].[PAF]
ADD CONSTRAINT [PK_PAF]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'HCQSet'
ALTER TABLE [dbo].[HCQ]
ADD CONSTRAINT [PK_HCQ]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ref_CQ'
ALTER TABLE [dbo].[ref_CQ]
ADD CONSTRAINT [PK_ref_CQ]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ref_Machine'
ALTER TABLE [dbo].[ref_Machine]
ADD CONSTRAINT [PK_ref_Machine]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ref_ProductTypeSet'
ALTER TABLE [dbo].[ref_ProductType]
ADD CONSTRAINT [PK_ref_ProductType]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ref_ProductCodeSet'
ALTER TABLE [dbo].[ref_ProductCode]
ADD CONSTRAINT [PK_ref_ProductCode]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ref_UnitSet'
ALTER TABLE [dbo].[ref_Unit]
ADD CONSTRAINT [PK_ref_Unit]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ref_TypePieceSet'
ALTER TABLE [dbo].[ref_TypePiece]
ADD CONSTRAINT [PK_ref_TypePiece]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ref_CauseZE'
ALTER TABLE [dbo].[ref_CauseZE]
ADD CONSTRAINT [PK_ref_CauseZE]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Anomaly_Id] in table 'HSet'
ALTER TABLE [dbo].[H]
ADD CONSTRAINT [FK_AnomalyH]
    FOREIGN KEY ([Anomaly_Id])
    REFERENCES [dbo].[Anomaly]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnomalyH'
CREATE INDEX [IX_FK_AnomalyH]
ON [dbo].[H]
    ([Anomaly_Id]);
GO

-- Creating foreign key on [Anomaly_Id] in table 'TicketNCSet'
ALTER TABLE [dbo].[TicketNC]
ADD CONSTRAINT [FK_AnomalyTicketNC]
    FOREIGN KEY ([Anomaly_Id])
    REFERENCES [dbo].[Anomaly]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnomalyTicketNC'
CREATE INDEX [IX_FK_AnomalyTicketNC]
ON [dbo].[TicketNC]
    ([Anomaly_Id]);
GO

-- Creating foreign key on [TicketNC_Id] in table 'ExpertiseSet'
ALTER TABLE [dbo].[Expertise]
ADD CONSTRAINT [FK_TicketNCExpertise]
    FOREIGN KEY ([TicketNC_Id])
    REFERENCES [dbo].[TicketNC]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TicketNCExpertise'
CREATE INDEX [IX_FK_TicketNCExpertise]
ON [dbo].[Expertise]
    ([TicketNC_Id]);
GO

-- Creating foreign key on [Expertise_Id] in table 'NoCoSet'
ALTER TABLE [dbo].[NoCo]
ADD CONSTRAINT [FK_ExpertiseNoCo]
    FOREIGN KEY ([Expertise_Id])
    REFERENCES [dbo].[Expertise]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpertiseNoCo'
CREATE INDEX [IX_FK_ExpertiseNoCo]
ON [dbo].[NoCo]
    ([Expertise_Id]);
GO

-- Creating foreign key on [Expertise_Id] in table 'PAFSet'
ALTER TABLE [dbo].[PAF]
ADD CONSTRAINT [FK_ExpertisePAF]
    FOREIGN KEY ([Expertise_Id])
    REFERENCES [dbo].[Expertise]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExpertisePAF'
CREATE INDEX [IX_FK_ExpertisePAF]
ON [dbo].[PAF]
    ([Expertise_Id]);
GO

-- Creating foreign key on [HId] in table 'HCQSet'
ALTER TABLE [dbo].[HCQ]
ADD CONSTRAINT [FK_HHCQ]
    FOREIGN KEY ([HId])
    REFERENCES [dbo].[H]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HHCQ'
CREATE INDEX [IX_FK_HHCQ]
ON [dbo].[HCQ]
    ([HId]);
GO

-- Creating foreign key on [Machine_Id] in table 'TicketNCSet'
ALTER TABLE [dbo].[TicketNC]
ADD CONSTRAINT [FK_TicketNCref_Machine]
    FOREIGN KEY ([Machine_Id])
    REFERENCES [dbo].[ref_Machine]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TicketNCref_Machine'
CREATE INDEX [IX_FK_TicketNCref_Machine]
ON [dbo].[TicketNC]
    ([Machine_Id]);
GO

-- Creating foreign key on [ref_TypePieceId] in table 'TicketNCSet'
ALTER TABLE [dbo].[TicketNC]
ADD CONSTRAINT [FK_ref_TypePieceTicketNC]
    FOREIGN KEY ([ref_TypePieceId])
    REFERENCES [dbo].[ref_TypePiece]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ref_TypePieceTicketNC'
CREATE INDEX [IX_FK_ref_TypePieceTicketNC]
ON [dbo].[TicketNC]
    ([ref_TypePieceId]);
GO

-- Creating foreign key on [ref_UnitId] in table 'TicketNCSet'
ALTER TABLE [dbo].[TicketNC]
ADD CONSTRAINT [FK_TicketNCref_Unit]
    FOREIGN KEY ([ref_UnitId])
    REFERENCES [dbo].[ref_Unit]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TicketNCref_Unit'
CREATE INDEX [IX_FK_TicketNCref_Unit]
ON [dbo].[TicketNC]
    ([ref_UnitId]);
GO

-- Creating foreign key on [ref_ProductCodeId] in table 'TicketNCSet'
ALTER TABLE [dbo].[TicketNC]
ADD CONSTRAINT [FK_TicketNCref_ProductCode]
    FOREIGN KEY ([ref_ProductCodeId])
    REFERENCES [dbo].[ref_ProductCode]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TicketNCref_ProductCode'
CREATE INDEX [IX_FK_TicketNCref_ProductCode]
ON [dbo].[TicketNC]
    ([ref_ProductCodeId]);
GO

-- Creating foreign key on [ref_ProductTypeId] in table 'TicketNCSet'
ALTER TABLE [dbo].[TicketNC]
ADD CONSTRAINT [FK_TicketNCref_ProductType]
    FOREIGN KEY ([ref_ProductTypeId])
    REFERENCES [dbo].[ref_ProductType]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TicketNCref_ProductType'
CREATE INDEX [IX_FK_TicketNCref_ProductType]
ON [dbo].[TicketNC]
    ([ref_ProductTypeId]);
GO

-- Creating foreign key on [ref_CQId] in table 'HCQSet'
ALTER TABLE [dbo].[HCQ]
ADD CONSTRAINT [FK_HCQref_CQ]
    FOREIGN KEY ([ref_CQId])
    REFERENCES [dbo].[ref_CQ]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_HCQref_CQ'
CREATE INDEX [IX_FK_HCQref_CQ]
ON [dbo].[HCQ]
    ([ref_CQId]);
GO

-- Creating foreign key on [ref_CauseZEId] in table 'ExpertiseSet'
ALTER TABLE [dbo].[Expertise]
ADD CONSTRAINT [FK_Expertiseref_CauseZE]
    FOREIGN KEY ([ref_CauseZEId])
    REFERENCES [dbo].[ref_CauseZE]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Expertiseref_CauseZE'
CREATE INDEX [IX_FK_Expertiseref_CauseZE]
ON [dbo].[Expertise]
    ([ref_CauseZEId]);
GO

-- Creating foreign key on [ref_SupplierId] in table 'PieceSet'
ALTER TABLE [dbo].[Piece]
ADD CONSTRAINT [FK_Pieceref_Supplier]
    FOREIGN KEY ([ref_SupplierId])
    REFERENCES [dbo].[ref_Supplier]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Pieceref_Supplier'
CREATE INDEX [IX_FK_Pieceref_Supplier]
ON [dbo].[Piece]
    ([ref_SupplierId]);
GO

-- Creating foreign key on [PieceId] in table 'AnomalySet'
ALTER TABLE [dbo].[Anomaly]
ADD CONSTRAINT [FK_AnomalyPiece]
    FOREIGN KEY ([PieceId])
    REFERENCES [dbo].[Piece]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnomalyPiece'
CREATE INDEX [IX_FK_AnomalyPiece]
ON [dbo].[Anomaly]
    ([PieceId]);
GO

-- Creating foreign key on [ref_ProductionAreaId] in table 'AnomalySet'
ALTER TABLE [dbo].[Anomaly]
ADD CONSTRAINT [FK_Anomalyref_ProductionArea]
    FOREIGN KEY ([ref_ProductionAreaId])
    REFERENCES [dbo].[ref_ProductionArea]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Anomalyref_ProductionArea'
CREATE INDEX [IX_FK_Anomalyref_ProductionArea]
ON [dbo].[Anomaly]
    ([ref_ProductionAreaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
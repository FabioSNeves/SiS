CREATE TABLE [dbo].[FABIO_incident] (
    [Id]               BIGINT        IDENTITY (1, 1) NOT NULL,
    [Title]            VARCHAR (50)  NOT NULL,
    [DateOpen]         DATETIME      NOT NULL,
    [DateClose]        DATETIME      NULL,
    [Description]      VARCHAR (500) NOT NULL,
    [Response]         VARCHAR (300) NULL,
    [User_Id]          BIGINT        NOT NULL,
    [FABIO_statusId]   INT           NOT NULL,
    [FABIO_categoryId] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([FABIO_categoryId]) REFERENCES [dbo].[FABIO_category] ([Id]),
    FOREIGN KEY ([FABIO_statusId]) REFERENCES [dbo].[FABIO_status] ([Id]),
    FOREIGN KEY ([User_Id]) REFERENCES [dbo].[User] ([id])
);






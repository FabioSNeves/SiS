CREATE PROCEDURE [dbo].[FABIO_insertIncident] 
		   @Title varchar(50),
           @dateOpen datetime,
           @Description varchar(500),
           @User_Id bigint,
           @statusId int,
           @categoryId int
 AS  

INSERT INTO [dbo].[FABIO_incident]
           ([Title]
           ,[DateOpen]
           ,[Description]
		   ,[User_Id]
           ,[FABIO_statusId]
           ,[FABIO_categoryId])
     VALUES
           (@Title,
           @dateOpen,
           @Description,
		   @User_Id,
           @statusId,
           @categoryId)

	SELECT @@IDENTITY
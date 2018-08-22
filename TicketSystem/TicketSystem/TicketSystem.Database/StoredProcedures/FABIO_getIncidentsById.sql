CREATE PROCEDURE [dbo].[FABIO_getIncidentsById]
    @id BIGINT
AS

SELECT  FA_I.Id as 'Id', 
		FA_I.Title as 'Title', 
		FA_I.DateOpen as 'DateOpen', 
		FA_I.DateClose as 'DateClose',
		FA_I.[Description] as 'Description',
		FA_I.Response as 'Response',
		FA_S.[Description] as 'StatusDescription',
		FA_S.[Id] as 'StatusId',
		FA_C.[Description] as 'CategoryDescription',
		FA_C.[Id] as 'CategoryId',
		FA_U.[id] as 'User_Id',
		FA_U.[name] as 'Name'

From FABIO_incident AS FA_I
                
  inner join FABIO_status as FA_S on 
  FA_S.Id = FA_I.FABIO_statusId
  inner join FABIO_category as FA_C on
  FA_C.Id = FA_I.FABIO_categoryId
  inner join [User] as FA_U on
  FA_U.id = FA_I.User_Id
  INNER JOIN [User] as Collaborator ON FA_i.[User_Id] = Collaborator.id
  WHERE FA_i.Id = @id
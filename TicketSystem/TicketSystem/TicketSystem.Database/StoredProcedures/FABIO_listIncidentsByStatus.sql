CREATE PROCEDURE [dbo].[FABIO_listIncidentsByStatus]

AS

SELECT  FA_S.Id as 'Id', 
		FA_S.[Description] as 'Description'
	
From FABIO_status AS FA_S
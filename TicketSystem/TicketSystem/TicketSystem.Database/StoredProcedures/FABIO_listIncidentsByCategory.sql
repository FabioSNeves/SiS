CREATE PROCEDURE [dbo].[FABIO_listIncidentsByCategory]

AS

SELECT  FA_C.Id as 'Id', 
		FA_C.[Description] as 'Description'
	
From FABIO_category AS FA_C
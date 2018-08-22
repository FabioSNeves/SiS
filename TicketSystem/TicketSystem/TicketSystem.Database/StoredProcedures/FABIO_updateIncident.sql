CREATE PROCEDURE [dbo].[FABIO_updateIncident]
	@Id bigint,
	@statusId int,
	@response varchar(300)
AS
	UPDATE FABIO_incident SET 
		[FABIO_statusId] = @statusId,
		[Response] = @response
	WHERE Id = @id
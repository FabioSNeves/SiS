CREATE PROCEDURE [dbo].[GetUser]
	@username VARCHAR(30),
	@password VARCHAR(40)
AS
	SELECT [id] as [Id],
		   [name] as [Name],
		   [type] as [Type]

    FROM [User]

	WHERE [password] = @password 
	  AND [username] = @username

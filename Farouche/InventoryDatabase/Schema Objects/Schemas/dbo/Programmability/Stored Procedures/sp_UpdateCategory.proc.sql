﻿	
/*Object: StoredProcedure [dbo].[sp_UpdateCategory] */
CREATE PROCEDURE [sp_UpdateCategory]
	(@category varchar(50),
	 @orig_category varchar(50))
AS
	UPDATE [dbo].[Categories]
		SET [Category] = @category
	WHERE [Category] = @orig_category
	RETURN @@ROWCOUNT
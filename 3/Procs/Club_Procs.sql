if  exists (select * from dbo.sysobjects where id = OBJECT_ID(N'[dbo].[sProc_Club_Write]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sProc_Club_Write]

GO

if  exists (select * from dbo.sysobjects where id = OBJECT_ID(N'[dbo].[sProc_Club_Read]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sProc_Club_Read]

GO

if  exists (select * from dbo.sysobjects where id = OBJECT_ID(N'[dbo].[sProc_Club_Delete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sProc_Club_Delete]

GO


if  exists (select * from dbo.sysobjects where id = OBJECT_ID(N'[dbo].[sProc_Club_ReadEverything]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
DROP PROCEDURE [dbo].[sProc_Club_ReadEverything]

GO

CREATE PROCEDURE [dbo].[sProc_Club_Write]
	@ClubId int,
	@ClubName nvarchar(100),
	@Country nvarchar(100),
	@Stadium nvarchar(100),
	@YearFounded int,
	@ClubLogo varbinary(max)
AS

/*
	Description
	-----------
	Inserts or updates the TblClub table dependant on Primary keys.
	Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)
*/

--Check to see if the record exists.
if exists(select [ClubId] from TblClub where [ClubId] = @ClubId)
	begin
		-- If the record does exist, it updates it.
		update TblClub set
			[ClubName] = @ClubName,
			[Country] = @Country,
			[Stadium] = @Stadium,
			[YearFounded] = @YearFounded,
			[ClubLogo] = @ClubLogo
		where
			[ClubId] = @ClubId
	end
else
	begin
		-- If the record does not exist, inserts it.
		insert into TblClub
		(
			[ClubName],
			[Country],
			[Stadium],
			[YearFounded],
			[ClubLogo]
		)
		values
		(
			@ClubName,
			@Country,
			@Stadium,
			@YearFounded,
			@ClubLogo
		)

		--Returns the new primary key for the record. Auto Increment.
		select scope_identity() as InsertKey
	End
GO



CREATE PROCEDURE [dbo].[sProc_Club_Read]
	@ClubId int
AS

/*
	Description
	-----------
	Reads one record from the TblClub table based on the primary keys.
	Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)
*/

Select *
From
	TblClub
Where
	[ClubId] = @ClubId
GO



CREATE PROCEDURE [dbo].[sProc_Club_Delete]
	@ClubId int
AS

/*
	Description
	-----------
	Deletes the record from the TblClub table based on primary keys.
	Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)
*/

Delete From TblClub 
Where 
	[ClubId] = @ClubId
GO



CREATE PROCEDURE [dbo].[sProc_Club_ReadEverything]
AS

/*
	Description
	-----------
	Reads all records from the TblClub table.
	Created by ES.OrmTool Code Generator (19 Mar 2024 - Version : 2.0.0)
*/

		Select * From TblClub
		Order by ClubName asc
GO




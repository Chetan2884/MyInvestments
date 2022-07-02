USE [MyInvestments]
GO
/****** Object:  StoredProcedure [dbo].[TestProc]    Script Date: 07-Apr-2022 02:45:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[TestProc] 
	
AS
BEGIN
	Select ctm.CompanyId,cm.CompanyName, ctm.CompanyTypeId, ct.CompanyTypeName
FROM CompanyMaster cm JOIN CompanyTypesMapping ctm on cm.CompanyId = ctm.CompanyId
JOIN CompanyTypesMaster ct on ctm.CompanyTypeId = ct.CompanyTypeId
Order By cm.CompanyName

END

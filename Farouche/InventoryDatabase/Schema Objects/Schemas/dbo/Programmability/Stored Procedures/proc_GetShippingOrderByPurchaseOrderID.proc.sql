﻿CREATE PROCEDURE [proc_GetShippingOrderByPurchaseOrderID]
(
	@purchaseOrderID int
)
AS
	SELECT so.[ShippingOrderID], so.[PurchaseOrderID], so.[UserID], u.[LastName], u.[FirstName],
	so.[Picked],so.[ShipDate], so.[ShippingTermID],st.[Description],sv.[Name],
	so.[ShipToName], so.[ShipToAddress], so.[ShipToCity], so.[ShipToState], so.[ShipToZip]
	FROM [dbo].[Users] u
	RIGHT OUTER JOIN [dbo].[ShippingOrders] so
	ON u.[UserID] = so.[UserID]
	JOIN [dbo].[ShippingTermsLookup] st
	ON so.[ShippingTermID] = st.[ShippingTermID]
	JOIN [dbo].[ShippingVendors] sv
	ON st.[ShippingVendorID] = sv.[ShippingVendorID]
	WHERE so.[PurchaseOrderID] = @purchaseOrderID
	ORDER BY so.[PurchaseOrderID]



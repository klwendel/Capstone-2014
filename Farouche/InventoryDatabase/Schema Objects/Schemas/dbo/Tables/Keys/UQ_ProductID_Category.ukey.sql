﻿ALTER TABLE [dbo].[ProductCategories]
    ADD CONSTRAINT [UQ_ProductID_Category] UNIQUE NONCLUSTERED ([ProductID] ASC, [Category] ASC) WITH (ALLOW_PAGE_LOCKS = ON, ALLOW_ROW_LOCKS = ON, PAD_INDEX = OFF, IGNORE_DUP_KEY = OFF, STATISTICS_NORECOMPUTE = OFF) ON [PRIMARY];


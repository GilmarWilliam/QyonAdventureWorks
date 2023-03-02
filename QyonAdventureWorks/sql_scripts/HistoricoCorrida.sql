SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoricoCorrida](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CompetidorId] [int] NOT NULL,
	[PistaCorridaId] [int] NOT NULL,
	[DataCorrida] [datetime2](7) NOT NULL,
	[TempoGasto] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_HistoricoCorrida] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_HistoricoCorrida_CompetidorId] ON [dbo].[HistoricoCorrida]
(
	[CompetidorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
CREATE NONCLUSTERED INDEX [IX_HistoricoCorrida_PistaCorridaId] ON [dbo].[HistoricoCorrida]
(
	[PistaCorridaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[HistoricoCorrida]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoCorrida_Competidores_CompetidorId] FOREIGN KEY([CompetidorId])
REFERENCES [dbo].[Competidores] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HistoricoCorrida] CHECK CONSTRAINT [FK_HistoricoCorrida_Competidores_CompetidorId]
GO
ALTER TABLE [dbo].[HistoricoCorrida]  WITH CHECK ADD  CONSTRAINT [FK_HistoricoCorrida_PistaCorrida_PistaCorridaId] FOREIGN KEY([PistaCorridaId])
REFERENCES [dbo].[PistaCorrida] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HistoricoCorrida] CHECK CONSTRAINT [FK_HistoricoCorrida_PistaCorrida_PistaCorridaId]
GO

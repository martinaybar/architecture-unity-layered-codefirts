﻿ALTER TABLE [dbo].[Users] ADD [RowVersion] [varbinary](max)
INSERT [dbo].[__MigrationHistory]([MigrationId], [ContextKey], [Model], [ProductVersion])
VALUES (N'201604211547285_RowVersion for User table', N'Data.Migrations.Configuration',  0x1F8B0800000000000400D559DB6EE336107D2FD07F10F4D416D928C9A2401BD8BB489D4D617473419C5DF46D414B63872845AA2495B551F4CBFAD04FEA2F74A8BB48C9961367D3222F11C53973E1991167FCCF5F7F8FDEAE62E63D805454F0B17F7C78E47BC0431151BE1CFBA95EBCFAC17FFBE6EBAF46EFA278E57D2CF7BD36FB5092ABB17FAF75721A042ABC8798A8C398865228B1D087A188031289E0E4E8E8C7E0F8380084F011CBF346B729D73486EC011F27828790E894B04B110153C53ABE9965A8DE158941252484B17F4E343944010D2BED7B678C12B461066CE17B8473A189460B4F3F28986929F87296E0026177EB0470DF82300585E5A7F5F6A14E1C9D1827825AB0840A53A545BC23E0F1EB222A812DFEA8D8FA55D4306EEF30BE7A6DBCCE6237F63120D2F76C45A71326CDA6B19F0950508766E381573E1E54678ED4307F07DE24653A9530E6906A49D8817793CE190D7F81F59DF80DF898A78C356D416BF05D6B01976EA44840EAF52D2C1A164E23DF0BDAB2812D5C895A72B91F53AE5F9FF8DE151A41E60CAA236FF83CD342C2CFC041120DD10DD11A249ED834822C688E0596BE0B2A9536FF962A9168982DBE774956EF812FF53DE6D1F7981F17740551B95298F181534C2E14D232850E3337AB7E4F5E4AB309F216CD03156FD6734394FA2C64B4410FFEBB0745C621A3623B7336E3DC8ACF458694383F514E24B2C814B5544AACA6EBCBCCACCCE661AE583AAFC8035D66E4EDF1C2F76E81651BD43D4DF27A9865F2A77AC78514F1AD608554F5E2D34CA43234072BBADEDE11B904DDB66814D4E5656BD1C9950F2C3C66E9C58A4F4987C714A06154DA5F112A75BE4C353807154A9AE806EBF797A81BC9AE9EC2F492CBDD4C2FF36008D3CF941221CDCC6818579BD0F6E81D8FBC8D999747B0F40483882CA709F21A558FFDEF9C10F501560EB601F3A8B4418F7D3B29AEF93930D0E09D85F9156642544822F7803026517B05F308A4212E6158F5146626E5DA4D3ACA439A10B6C9744B68C75C35C6556AEC37E7900037E9B5E92C9EAEBF5263056D5B8C464183546E5535375E940059A6205E83AB5BB0535DD1C4A2C0AA22CB6C0219CC19E8766AD5646FD1D1619F2B9CA9EA01C8E96781349C6D2335F2B8B1A733D1EDD86FCBB3CAF0CA61E7F8B665960551B86D2748DBB98E7A529D66DDE90479AB53B644414F4F34BA24498295B6D123152BDE2C6F9026AF66BBF70F718E1184AAA38DA8ACAD34E1C78B2CC17A8BAAD1D2EC7A6CD83927A6D64FA2D8D9D6E46E0FB54A4D4D7ABA675592ADDC5D7E11DB5D62CE6237B30BA90B7425366521FB245B07EC8A654D296144F6B42113C1D2986F6A6936A1349A8B265063793856DD2D34A1EAD5E148F5EDDFF66E57A4FA7EDF44AA5777B3A9ACC2B6557DD5B91FAD798D6FA235D75DB4516071C8F91A381C753EA56DC20F4E87BCF23C2925BA6AE8C0B4E816FD3247D5BEFA76E1ED4ACAD675B609D87AF1858FDFF954D85B2AEDD527C3FA348C8A32BD7DA6E6D4ED7C8BEF61A01E68646AF66CAD34C487198966BFB309A3E86FBDE19270BA00A5F32ECC3F393A3EB18673FF9D4159A054C4064CCB5E6C86454D64B736883BF66CCED88A3F1019DE13E9368C4F9C4AED0DD81E3A7502B7711F33632A61BF89C9EADB5DC1DCE63F3B3DE7463EC59E6035F6FFC8C44EBDE9AF9F6AC903EF5A620E9D7A47DE9F7B1840A13BF36C0635C0A1DD47392F3E5C7996ECE89AA7EC8DC71DE3921D38F71C3388BCBFFAD26382B60D8F987B3C7ACED073D579D6D9C2FF6796E0B66DDB1BFEDE61417E7518FBD15CE009E7A4EEECB67BE7081BC7087DF0DD9DF8F34F199A06B7AFC7DB860B8ED4F3CC11DC4B20F2A7F1F32B7257D1650D617E8CE510B69853ED99F28528496C59546EB16ADF25681221ADCEA4A60B126A7C1D8252D9ACF82361A9F905209E4334E5D7A94E528D2E433C67AD01B849844DFAB36149DBE6D175566ED53E5C403329BA00D7FCA794B2A8B2FBC2ADFD7D1026C38AAF95394B6DBE5ACB75857425F840A0227C5561B883386108A6AEF98C3CC0636C43EABD872509D7E55DBE1F64FB41B4C33E3AA7642949AC0A8C5A1E1F91C351BC7AF32F284B9D9485200000 , N'6.1.3-40302')

/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

if not exists (select 1 from dbo.RoomTypes)
begin
    INSERT INTO dbo.RoomTypes (Title, Description, Price)
    VALUES ('Single', 'A cosy room with a single bed', 50),
            ('Double', 'A larger room with a dobule bed', 70),
            ('King', 'Our largest room with a king sized bed', 100);
end

if not exists (select 1 from dbo.Rooms)
begin
    declare @roomId1 int;
    declare @roomId2 int;
    declare @roomId3 int;

    select @roomId1 = Id from dbo.RoomTypes where Title = 'Single'
    select @roomId2 = Id from dbo.RoomTypes where Title = 'Double'
    select @roomId3 = Id from dbo.RoomTypes where Title = 'King'

    INSERT INTO dbo.Rooms (RoomNumber, RoomTypeId)
    VALUES ('101', @roomId1),
            ('102', @roomId1),
            ('103', @roomId1),
            ('201', @roomId2),
            ('202', @roomId2),
            ('301', @roomId3);
end
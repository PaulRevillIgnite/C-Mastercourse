CREATE PROCEDURE [dbo].[spBookings_Search]
	@lastName varChar(50),
	@startDate datetime
	
AS
begin
	set nocount on;

	SELECT B.*, G.FirstName, G.LastName, R.RoomTypeId, RT.Title, RT.Description, RT.Price
	FROM dbo.Bookings B
		INNER JOIN dbo.Guests G on B.GuestId = G.Id
		INNER JOIN dbo.Rooms R on B.RoomId = R.Id
		INNER JOIN dbo.RoomTypes RT on R.RoomTypeId = rt.Id
	WHERE G.LastName = @lastName
		AND B.StartDate = @startDate

end
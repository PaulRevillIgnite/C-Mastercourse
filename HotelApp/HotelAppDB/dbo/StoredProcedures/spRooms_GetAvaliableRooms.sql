CREATE PROCEDURE [dbo].[spRooms_GetAvaliableRooms]
	@startDate date,
	@endDate date,
	@roomTypeID int

AS
begin
	set nocount on;

SELECT DISTINCT R.*
	FROM dbo.Rooms R
		INNER JOIN dbo.RoomTypes T ON T.Id = R.RoomTypeId
	WHERE R.RoomTypeId = @roomTypeId
		AND R.Id NOT IN (SELECT B.RoomId
						FROM dbo.Rooms R
							INNER JOIN dbo.RoomTypes RT ON RT.Id = R.RoomTypeId
							INNER JOIN Bookings B ON B.RoomId = R.Id
						WHERE (@startDate < B.StartDate AND @endDate > B.EndDate)
							OR (B.StartDate <= @endDate AND @endDate < b.EndDate)
							OR (B.StartDate <= @startDate AND @startDate < B.EndDate)
						);

end

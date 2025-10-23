CREATE PROCEDURE [dbo].[spRoomTypes_GetAvaliableTypes]
	@startDate date,
	@endDate date
AS
BEGIN
	SET NOCOUNT ON;
	
	SELECT DISTINCT T.*
	FROM dbo.Rooms R
		INNER JOIN dbo.RoomTypes T ON T.Id = R.RoomTypeId
	WHERE R.Id NOT IN (SELECT B.RoomId
						FROM dbo.Rooms R
							INNER JOIN dbo.RoomTypes RT ON RT.Id = R.RoomTypeId
							INNER JOIN Bookings B ON B.RoomId = R.Id
						WHERE (@startDate < B.StartDate AND @endDate > B.EndDate)
							OR (B.StartDate <= @endDate AND @endDate < b.EndDate)
							OR (B.StartDate <= @startDate AND @startDate < B.EndDate)
						)
	GROUP BY T.Id, T.Title, T.Description, T.Price;
END
SELECT id, 
       FirstName, 
       LastName, 
       FORMAT(HiredDate, 'MM/dd/yyyy') AS hd
FROM ForumExample.dbo.employee;
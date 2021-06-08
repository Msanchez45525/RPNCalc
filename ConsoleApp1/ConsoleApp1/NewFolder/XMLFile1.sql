use Prsdb;
-- User Data
Insert into Users(Username, Password, Firstname, Lastname, Phone, Email, IsReviewer, IsAdmin)
	values ('WCronkito', 'NewPass1', 'Walter', 'Kronkite', '885458', 'Wkronkite@aol.com', 0,0);
	go
	Insert Into Vendors ( Code, Name, Address, City, State, Zip, Phone, Email)
		values ('AMZ', 'Amazon', '1 Amazon St', 'Seattle', 'WA', 12345 , '8135552515', 'Jbezos@amazon.com');
go
DECLARE @Amazon varchar(10);
SELECT @amazon = Id from Vendors where Code = 'AMZ';

Insert into Products (PartNbr, Name, Price, Unit, PhotoPath, VendorId)
	values ('Echo','Amazon Echo1', 100, 'Each', null, @Amazon);
alter Proc UserAdd
@FirstName varchar(50),
@LastName varchar(50),
@Username varchar(50),
@Password varchar(50)

as

insert into Table2(UserName, FirstName, LastName, Password)
Values (@Username,@FirstName,@LastName,@Password)
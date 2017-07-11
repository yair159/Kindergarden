/*create procedure deleteKid(@kid varchar(20),@bit BIT OUT)
   AS
   begin	 
	if exists(select *
				from Kids
				where kidID = @kid) 
		begin
		delete from Kids
		where kidID = @kid 
		set @bit = 1
		end
	else set @bit = 0
   end*/

   create procedure deleteKid(@kid varchar(20))
   AS
   begin	 
		delete from Kids
		where kidID = @kid 
   end
   
   
   drop proc deleteKid
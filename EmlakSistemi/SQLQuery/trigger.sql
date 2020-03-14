create trigger trg_SilinenEkle on sahipbilgileri
after delete
as begin
insert into eskievsahipleri select id,adý,telefon from deleted
end
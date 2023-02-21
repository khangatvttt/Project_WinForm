create table Hoc_Sinh (MaHS nvarchar(20) primary key,HoTen nvarchar(50) not null,QueQuan nvarchar(50) not null, NgaySinh DATE not null, 
CMND nvarchar(12) not null, Email nvarchar(50) not null, SDT varchar(10) not null)
Insert into Hoc_Sinh(MaHS,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('A001','Nguyen Van A','HCM','2003-12-29','0809080900','ABC@gmail.com','0123456789')
Insert into Hoc_Sinh(MaHS,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('A002','Nguyen Van B','Long An','2003-9-16','0809080901','BBC@gmail.com','0123456789')
Insert into Hoc_Sinh(MaHS,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('A003','Nguyen Van C','Ha Noi','2003-8-5','0809080902','CBC@gmail.com','0123456787')
Insert into Hoc_Sinh(MaHS,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('A004','Nguyen Van D','Dong Nai','2003-2-19','0809080903','DBC@gmail.com','0123456786')
Insert into Hoc_Sinh(MaHS,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('A005','Nguyen Van E','Nha Trang','2003-1-9','0809080904','EBC@gmail.com','0123456785')

Select * from Hoc_Sinh

create table Giao_Vien (MaGV nvarchar(20) primary key,HoTen nvarchar(50) not null,QueQuan nvarchar(50) not null, NgaySinh DATE not null, 
CMND nvarchar(12) not null, Email nvarchar(50) not null, SDT varchar(10) not null)
Insert into Giao_Vien(MaGV,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('B001','Nguyen Thi A','HCM','2003-12-29','0809080900','ABC@gmail.com','0123456789')
Insert into Giao_Vien(MaGV,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('B002','Nguyen Thi B','Long An','2003-9-16','0809080901','BBC@gmail.com','0123456789')
Insert into Giao_Vien(MaGV,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('B003','Nguyen Thi C','Ha Noi','2003-8-5','0809080902','CBC@gmail.com','0123456787')
Insert into Giao_Vien(MaGV,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('B004','Nguyen Thi D','Dong Nai','2003-2-19','0809080903','DBC@gmail.com','0123456786')
Insert into Giao_Vien(MaGV,HoTen,QueQuan,NgaySinh,CMND,Email,SDT) values ('B005','Nguyen Thi E','Nha Trang','2003-1-9','0809080904','EBC@gmail.com','0123456785')

Select * from Giao_Vien
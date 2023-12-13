/* Not null program */

SELECT 
    name
FROM 
    master.sys.databases
ORDER BY 
    name;


create table stud(rno int ,name varchar(20) not null)

select * from stud

insert into stud(rno,name)values(6,'ravi')
insert into stud(rno ,name)values(7,'mohit')
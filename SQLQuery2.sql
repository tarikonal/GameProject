--select * from Products order by UnitPrice

select count (*) as ToplamUrun, p.CategoryID, c.CategoryName,p.UnitPrice 
from Products as p 
inner join Categories as c on p.CategoryID = c.CategoryID
--where UnitPrice>20
--group by p.CategoryID, c.CategoryName 
having count(*)<10


select * from Products as p 
inner join [Order Details] as od on p.ProductID=od.ProductID
inner join Orders o on o.OrderID=od.OrderID

select c.* from Customers as c
left join [Orders] as o on c.CustomerID=o.CustomerID
where o.CustomerID is null


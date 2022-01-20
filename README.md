                                                                  1 Задание
Всем мышам даем по по 100 капель из разных пробирок.<br>
Прошли сутки, умирает мышка. Оставшимся грызунам даем по 11+- капель.<br>
Прошли сутки, умирает мышка. Разделили 12 пробирок среди оставшихся 8 мышек сутки.<br>
Прошли сутки, умирает мышка. На этот момент уже максимум две пробирки остается и 7 мышей живых.<br>
Прошли сутки, умирает мышка. Понимаем в какой пробирке яд.<br>
Ответ 4 суток.

                                                                  2 Задание
Не понял задачу.  

                                                                  3 Задание
Решается за одну попытку, методом исключения.<br> Нужно делать попытку на автомате выдающим "случайный" чай. <br>
Если маркировки автоматов перепутаны, значит если "случайный" автомат выдает зеленый чай,<br> тогда там где написано "черный чай" там автомат выдает случайный, потому что ни черным и ни<br> зеленым он уже быть не может, а там где "зеленый" будет черный.     

                                                                    SQL
                                                                   1 Задание
Select * From Cars 
Where BaseID is not null
Order By BaseID ASC
                                                                    2 Задание
                                                                    
With Result As
(
Select MAX(Brands.ID) As BrandsID, Count(Cars.ID) AS CarsID From Brands as brands Join
Cars as cars On
brands.ID = cars.BrandID
Group by brands.ID
)
Select Name From Brands As brands Join
Result as res On
res.BrandsID = brands.ID
Where CarsID >3;
                                                                     3 Задание


With Result As
(
Select MAX(Brands.ID) As BrandsID, SUM(Cars.Price) as Price From Brands as brands Join
Cars as cars On
brands.ID = cars.BrandID
Group by brands.ID
)
Select Name, Price From Brands As brands Join
Result as res On
res.BrandsID = brands.ID
                                                                      4 Задание

With Result As
(
Select MAX(Brands.ID) As BrandsID, AVG(cars.Pow) AS CarsPower From Brands as brands Join
Cars as cars On
brands.ID = cars.BrandID Join
Countries as countr ON
countr.ID = brands.ID
Group by brands.ID
)
Select Top(2) Name, res.CarsPower As brands Join
Result as res On
res.BrandsID = brands.ID
Order By Power Desc
                                                                      5 Задание

With Result As
(
Select MAX(Brands.ID) As BrandsID, MIN(cars.Price) AS Price From Brands as brands Join
Cars as cars On
brands.ID = cars.BrandID Join
Group by brands.ID
)
Select Name, res.Price As brands Join
Result as res On
res.BrandsID = brands.ID
















                                                                   

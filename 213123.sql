                                                                   --SQL
                                                                   --1 Задание
Select * From Cars 
Where BaseID is not null
Order By BaseID ASC
                                                                    --2 Задание
                                                                    
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
                                                                     --3 Задание


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
                                                                      --4 Задание

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
                                                                      --5 Задание

With Result As
(
Select MAX(Brands.ID) As BrandsID, MIN(cars.Price) AS Price From Brands as brands Join
Cars as cars On
brands.ID = cars.BrandID 
Group by brands.ID
)
Select Name, res.Price From Brands As brands Join
Result as res On
res.BrandsID = brands.ID

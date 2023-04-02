# My code coverage 
![CodeCoverage](https://github.com/Mandurang/CalculateArea/blob/master/CodeCoverage.png)


# Task 2 (SQL) 
Вопрос №2
В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.
По возможности — положите ответ рядом с кодом из первого вопроса.


SELECT Products.ProductName, Categories.CatigoryName
FROM Products
LEFT JOIN Categories
ON Products.IdCategory=Categories.Id;
 
 
 
<Many to Many> withe one more tables 
SELECT Products.ProductName, Categories.CatigoryName
FROM Products
LEFT JOIN ProductsCategoryes ON Products.Id = ProductsCategoryes.Id
LEFT JOIN Categories ON ProductsCategories.IdCategory = Categories.Id;

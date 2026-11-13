РАЗРАБОТКА НА СОФТУЕР - Практика и добри практики.
1.	Създаване на приложение за изчисляване на периметър и лице на кръг след въвеждане на радиус. Използва се изучаваното в IX клас по основи на програмирането. За входно ниво.
2.	Създаване на модел на Кръг с съдържащ логиката за изчисляване на периметър и лице. Използване на този модел в предходната задача.
3.	Създаване на модел на квадрат. За в клас.
4.	Създаване на модел на правоъгълник. За домашно.
5.	Създаване на модел на стадион. За изпитване.
6.	Начини за комуникация на клас по смисъла на ООП с околния свят (други класове). Използва се изученото в IX и X клас.
7.	Създаване на изглед на Кръг с съдържащ входно-изходните операции.
8.	Създаване на клас наречен контролер на Кръг свързващ модел и изглед на кръга.
9.	Списък от модели – според предмета – ПРОГРАМИРАНЕ, УАСД, 
10.	Модел, Изглед, Контролер (MVC) – Пример за конзолно приложение.
11.	MVC – Пример за потребители и влизане в система - конзолно приложение. За домашно.
12.	Настолно приложение (Desktop) в средата на Windows (Windows Form Application). Използва се изучаваното в IX клас по основи на програмирането.
13.	Настолно приложение (Desktop) в средата на Windows (Windows Form Application). – Създаване на изглед на Кръг (FormCircleView).
14.	Настолно приложение (Desktop) в средата на Windows (Windows Form Application). – Преобразуване на изглед в диалогов прозорец.
15.	Настолно приложение (Desktop) в средата на Windows (Windows Form Application). – Създаване на контролер на Кръг (FormCircles).
16.	Реализация на CRUD (Create, Read, Update, Delete) операции.
17.	Реализация на тестово хранилище и интерфейс към хранилище (FakeRepository, IRepository).
18.	Реализация на хранилища за XML и JSON. За в клас. За изпитване.
19.	Реализация на хранилище за CSV. За домашно.
20.	Реализация на хранилища за MS Access и MS SQL Server. За в клас. За изпитване.
21.	Реализация на хранилища за MS SQL Server EF. За в клас. За изпитване.



# Създава се решение, което садържа следните елемрнти:
# [Модели]
### Поставя се в библиотека: [Circle.cs - Модел](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/Circle.cs)
# [ConsoleApp]
### [ViewCircle.cs - Изглед](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/ViewCircle.cs)
### [CircleController.cs Контролер](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/CircleController.cs)
### [Program.cs - Входна точка на програмата](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/Program.cs)
# [WinFormApp]
## [Изглед]
### Преглеждаме как изглежда формата на следващата картинка: [FormCircleView.png - Снимка на Дизайна](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/FormCircleView.png)
### Проверяваме иманата на контролите и техния тип: [FormCircleView.Designer.cs - Дизайн](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/FormCirclesView.Designer.cs)
### Бизнес логика: [FormCircleView.cs - Код](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/FormCircleView.cs)
## [Контролер]
### Преглеждаме как изглежда формата на следващата картинка: [FormCircles.png - Снимка на Дизайна](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/FormCircles.png)
### Проверяваме иманата на контролите и техния тип: [FormCircles.Designer.cs - Дизайн](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/FormCircles.Designer.cs) 
### Бизнес логика: [FormCircles.cs - Код](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/FormCircles.cs)
# [Хранилище]
## [IRepository](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/IRepository.cs)
## [Файлове с базите от данни]
### [DatabasePSD.accdb - Файл с базата от данни на Access](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/DatabasePSD.accdb)
### [DatabasePSD.mdf - Файл с базата от данни на MS SQL Server](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/DatabasePSD.mdf)
## [SQL код за създаване на таблици]
### [CircleAccess.sql - Създавате на таблица в Access](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/CircleAccess.sql)
### [CircleMSSQLServer.sql - Създаване на таблица в MS SQL Server](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/CircleMSSQLServer.sql)
## [Използване на бази от данни от Visual Studio 2022]
### [Тема DFA.pdf - Използване на база от данни от Access](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/%D0%A2%D0%B5%D0%BC%D0%B0%20DFA.pdf)
### [Тема DFMSSQL.pdf - Използване на база от данни от MS SQL Server](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/%D0%A2%D0%B5%D0%BC%D0%B0%20DFMSSQL.pdf)

### [Качествен програмен код] (https://introprogramming.info/intro-csharp-book/read-online/glava21-kachestven-programen-kod/)
### [Задача за упражнение на модели и изгледи] (https://csharp-book.softuni.bg/Content/Chapter-3-2-simple-conditions-exam-problems/exam-problems/ticket-price/ticket-price.html)
### [Microsoft Access 2013 Runtime] (https://www.microsoft.com/en-us/download/details.aspx?id=39358)

Задача: страница 41 от https://www.mon.bg/nfs/2021/03/nip_programist_010321.pdf 
## Entity Relationship Diagram vs. UML Class Diagram
### [Entity Relationship Diagram](https://www.geeksforgeeks.org/introduction-of-er-model/)
### [UML Class Diagram](https://www.geeksforgeeks.org/unified-modeling-language-uml-class-diagrams/?ref=gcse_outind)
### [ORM](https://github.com/vakovsky/11/blob/main/part1(mvc)/source/%D0%A2%D0%B5%D0%BC%D0%B0%20CFMSSQL.pdf)

### [Тестване](https://rahulshettyacademy.com/blog/index.php/2021/07/13/software-testing-levels-and-testing-types/)
### [Practical-Software-Development](https://github.com/BG-IT-Edu/School-Programming/tree/main/Courses/Applied-Programmer/Practical-Software-Development)


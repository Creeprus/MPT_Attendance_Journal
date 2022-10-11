![image](https://user-images.githubusercontent.com/92712690/195069654-f3eebe95-bedd-4b3c-a866-2c481e7ce2dc.png)
Рисунок 5  - Схема базы данных

Перед началом работы следует сделать схему базы данных магазина машин. В данном случае будет 9 сущностей, подлежащих реализации
Для каждой таблицы понадобится сделать модель и класс

1.	Car

 ![image](https://user-images.githubusercontent.com/92712690/195069774-844ade8e-daee-4e15-9cec-d13102b41b14.png)
 
Рисунок 6 - car.dart
![image](https://user-images.githubusercontent.com/92712690/195069793-1cb43f68-379a-4b43-8a1d-c005324aa370.png) 

Рисунок 7 - car_entity.dart

2.	 Engine


 ![image](https://user-images.githubusercontent.com/92712690/195069840-8d724c8a-77b9-4353-9d35-4e5c2bb11114.png)
 
Рисунок 8 - engine.dart
 ![image](https://user-images.githubusercontent.com/92712690/195069856-b8608de2-81d1-4bc8-969d-4a728e8d8f69.png)
 
Рисунок 9 - engine_entity.dart

3.	 Favorite


 ![image](https://user-images.githubusercontent.com/92712690/195069885-9a5e63b8-366d-401b-b19b-d0fa2a901fe1.png)
 
Рисунок 10 - favorite_entity.dart
 ![image](https://user-images.githubusercontent.com/92712690/195069908-6c723679-9ad9-42f3-b143-0c280e890600.png)
 
Рисунок 11 – favorite.dart
4.	 Manufacturer


 ![image](https://user-images.githubusercontent.com/92712690/195069924-af3b25fd-a089-42fd-a972-01116c43afcc.png)
 
Рисунок 12 -manufacturer_entity.dart
 ![image](https://user-images.githubusercontent.com/92712690/195069945-268f0f27-8a76-4b94-b25e-275e6e038f01.png)
 
Рисунок 13 - manufacturer.dart
5.	 Mark


 ![image](https://user-images.githubusercontent.com/92712690/195069962-54f94403-0840-444e-b4f5-f865c93972fb.png)
 
Рисунок 14 - mark_entity.dart
 ![image](https://user-images.githubusercontent.com/92712690/195069985-515dbc18-ae85-4ba0-8f64-9b4a39e97f8d.png)
 
Рисунок 15 - mark.dart

6.	 Owner


 ![image](https://user-images.githubusercontent.com/92712690/195070011-ae85e74a-2181-45ff-ab02-88bce1fb2506.png)
 
Рисунок 16 - owner_entity.dart
 ![image](https://user-images.githubusercontent.com/92712690/195070037-6aada10b-083e-435f-981a-f5ba255a30f5.png)
 
Рисунок 17 - owner.dart

7.	  Role


 ![image](https://user-images.githubusercontent.com/92712690/195070058-89f07163-3d3c-4389-807f-b11e5b1a8a66.png)
 
Рисунок 18 - role_entity.dart
 ![image](https://user-images.githubusercontent.com/92712690/195070083-74af742d-342e-4421-861f-869845e5a468.png)
 
Рисунок 19 - role.dart

8.	  User


 ![image](https://user-images.githubusercontent.com/92712690/195070143-06c85bdb-8558-43bc-b278-df94598c6336.png)
 
Рисунок 20 - user_entity.dart
 ![image](https://user-images.githubusercontent.com/92712690/195070212-3797ded8-9963-4bb7-ad96-24213e59caed.png)
 
Рисунок 21 - user_entity.dart

9.	 UserInfo


![image](https://user-images.githubusercontent.com/92712690/195070230-64b195d9-44d9-4aa1-9e1f-2295904cc439.png)

Рисунок 22 - userinfo_entity.dart
 ![image](https://user-images.githubusercontent.com/92712690/195070255-4249f661-2f7b-4b23-8a92-06befc24768d.png)
 
Рисунок 23 - userinfo.dart


По итогу структура проекта выглядит следующим образом:

 ![image](https://user-images.githubusercontent.com/92712690/195070276-c1386df9-da5a-40fe-a291-0bf5ed5ca4ee.png)
 
Рисунок 24 - Структура проекта

И в итоге получиться файл с базой данных

 ![image](https://user-images.githubusercontent.com/92712690/195070290-b8222b3a-af07-41c5-9097-98f3a5ffcf7d.png)
 
Рисунок 25 - Файл базы данных

Вывод: В процессе практической работы были получены навыки по составлению таблиц сущностей на SQLite в Flutter

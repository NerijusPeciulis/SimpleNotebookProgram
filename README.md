## Simple Notebook Program:

![restss](https://i.im.ge/2022/07/20/F2opQ9.png)

# Entities:

1. User. Has: many Categories.
2. Categories. Has: many Notes.

# Functionalities:

1. User can register.
2. User can login.
3. User can create new category (when login).
4. User can edit category (when login).
5. User can delete category (when login).
6. User can create new note (when login).
7. User can edit note (when login).
8. User can delete note (when login).
9. User can add note to category (when login).
10. User can search notes by name (when login).
11. User can filter notes by categories id (when login).
12. Program is coneccted with SQL database.

# Note:

if you want to try the program you must have:
1. Your`s SQL database.
2. In C# code delete Migrations folder

![rests](https://i.im.ge/2022/07/20/F2onnh.png)

3. In DBContext folder NotebookDBContext class change your`s SQL database connection string.

![rests](https://i.im.ge/2022/07/20/F2Xbj4.png)

4. In Package Manager Console add-migration adn update-database.

![rests](https://i.im.ge/2022/07/20/F2X8oq.png)

5. Start program.
6. Enjoy!

# JET-cookie-challenge

## Application
The JET cookies application is developed as a multi-container application. The front end, API service and database each run on separate containers, this way changes can be made to one part of the application without disrupting the work of the other containers. Since Docker(docker-compose) puts all containers on the same network this makes communication between the containers easy to achieve.

## Database
The database consists of three tables:

1. **Cookie table** : this table contains all information about a cookie [d (unique), name, weight, calories, image]
2. **Ingredient table** : this table contains all information about an ingredient [id (unique), name, image]
3. **CookieIngredient table** : this a join table which is used to resolve the relationship between the other two tables. Since cookies and ingredients have many-to-many relationship (one cookie can have many ingredients and one ingredient can be used in many cookies) a third table is introduced. This table has two columns CookieID & IngredientID which contain references to their respective objects. </li>


### Code first approach
For this project a code-first approach was taken when designing the database. With this approach a database can be designed purely from C# code, 
by first creating the classes for the objects which are going to be stored in the database. 
The entity framework can then use these classes to create a database and tables based on the already designed classes and configuration. 
The benefits of this approach are that changes to the database can be easily made by altering the model classes and then updating the database, 
additionally developers can use only C# code to design their DB's instead of using SQL and other design tools.

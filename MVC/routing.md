# Scaffolding
- it is a technique used by many MVC frameworks to generate code for basic CRUD operations against database effectively.
- in ASP.NET scaffold templates are used to generate code against db with the help of Entity framework.


# Routing
- in the traditional ASP.NET app, browser requests are mapped to pages, in MVC app, the browser request is mapped to controller actions

- A browser request gets mapped to a controller action through a feature called routing
```
/Product/Details/3 : Controller/Action/Id

/Product : Controller/Action
- here the action is Index

http://localhost : Controller = home / action = index
- the request is routed to Index() action on HomeController class.
```

## Controller
- controller is responsible for controlling the way user interacts with an mvc application
- determines what response to send back to the user when a user makes a browser request
- any public method in a controller is exposed as a controller action and can be invoked.

### Route
- it defines the URL pattern and the handler information.
- handler is a class that processes the request
- all the routes are stored in RouteTable and then the routing engine uses the routing table to determine the appropiate handler class for an incoming HTTP request.

#### Routing
- pattern matching mechanism that handles the incoming HTTP request and figures out what to do with the incoming HTTP request.
- routing is implemented by System.Web.Routing

- the default value of Controller is Home, the default action method is index and id parameter is optional.
- other routes can be configured using MapRoute method of RouteCollection.
```
{controller}/{action}/{id}
```

## Types of Routing
1. Convention Based Routing
2. Attribute Based Routing

### how is the routing table created 
- when MVC starts, the Application_Start() method in global.asax is called.
- The method calls RegisterRoutes() method, this method creates the routing table for mvc application.
 

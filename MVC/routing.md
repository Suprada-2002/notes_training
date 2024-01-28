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
- determines what response to send back to user when a user makes a browser request
- any public method in a controller is exposed as a controller action and can be invoked.

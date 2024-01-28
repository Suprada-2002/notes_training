# MVC
- lightweight framework, high testable presentation framework that is integrated with existing ASP.NET features
- MVC framework is defined in the System.Web.Mvc namespace and is a fundamental supported part of SYstem.Web namespace
- an architectural pattern that separates an application into 3 main components

## 1. Model
- parts of the application that implement the logic for the application's data domain.
- retrieve and store model state in the database.

## 2. View
- views are the components that display the application's UI
- they are created from model data.
- handles & responds to user input and interaction
```
- make a sub-folder under Views folder and make .aspx files

path for HomeController.Index() action:
\Views\Home\Index.aspx

path for HomeController.About() action:
\Views\Home\About.aspx
```

## 3. Controller
- are components that handle user interaction, work with the model and ultimately select a view to render that displays UI

## Advantages of MVC
1. mvc pattern helps create different aspects of the application while providing a loose coupling between these elements.
```
input logic - controller
business logic - model
UI logic - view
```
2. this separation helps manage complexity & enables the developer to focus on one aspect of the implementation at a time
3. MVC pattern makes it easy to test applications as compared to web-based ASP.NET web applications ( better support for TDD)
4. also promotes parallel development
5. it uses a FRONT CONTROLLER(a powerful URL-mapping component) that processes web application requests through a single controller. This helps us design an app that supports a rich routing infrastructure.

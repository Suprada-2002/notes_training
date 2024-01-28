# MVC
- lightweight framework, high testable presentation framework that is integrated with existing ASP.NET features
- MVC framework is defined in the System.Web.Mvc namespace and is a fundamental supported part of SYstem.Web namespace
- an architectural pattern that separates an application into 3 main components

## 1. Model
- parts of the application that implement the logic for the application's data domain.
- retrieve and store model state in the database.
- represent business data/domain data as well as logic to manage the business data

## 2. View
- views are the components that display the application's UI
- they are created from model data.
- handles & responds to user input and interaction
```
- make a sub-folder under Views folder and make .cshtml files

path for HomeController.Index() action:
\Views\Home\Index.cshtml

path for HomeController.About() action:
\Views\Home\About.cshtml
```
- as we are returning a view from the index action method of the home controller, by default the MVC framework will look for a file with the name Index.aspx/Index.ascx within Home/Shared folder of the application if the view engine is APSX. if not found it will search for a view file with the name Index.cshtml/Index.vbhtml within the Home/Shared folder

## Razor Syntax 
- it is a markup syntax for embedding .NET-based code into webpages.
- it consists of Razor markup, c# , html.
- files containing razor have a .cshtml file extension

- its default language is HTML and supports @ keyword transition from HTML to c#.
- it evaluates c# expressions and renders them in HTML output
```
<p> @@username </p> : to escape @ symbol in razor markup
```

### Razor code blocks
- code inside blocks are not rendered
```
@{

var quote = "having a good day";

}
<p>@quote</p>
```

## 3. Controller
- are components that handle user interaction, work with the model and ultimately select a view to render that displays UI
```
client  -><-   controller -> view, model
- the model does not interact with views
```
- the heart of the application
- contains a set of public methods called action which handle the incoming HTTP Requests. 
- while processing a request, it works with the model, then it selects a view and if needed passes the model object to view.


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

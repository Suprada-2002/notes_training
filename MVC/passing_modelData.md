# Pass Model data from Controller to View
- different ways to transfer data from controller action method to view.

## Loosey type views
- does not provide compile time error checking as well as intelligence support

### 1. View Data
- View data is defined as a property in the ControllerBase class and its type is ViewDataDictionary
```
public ViewDataDuctionary ViewData { get; set; }

[DefaultMember("Item")]
public class ViewDataDictionary : IDictionary<string, object>
```
-  so, View Data is a dictionary object, it stores data in the form of key-value pair
-  each key must be a string and the value is going to be stored as an object type.
- View data is resolved dynamically at runtime.
- can only transfer data from the controller action method to a view, so only valid during the current request.
- while retrieving data type casting is required except for string data from view data.

### 2. View Bag
- defined as a property in ControllerBase class with signature: -
```
[Dynamic]
public dynamic ViewBag {get; }
```
- it is a dynamic property  which means at runtime based on the value data type is decided.
- typecasting is not required as it operates on the dynamic data type

- internally ViewBag is a wrapper around ViewData, so it will throw a runtime exception if the ViewBag property name matches the key of ViewData

#### Differences & similarities between viewbag and viewdata
1. viewdata is a dictionary object - viewdata is a dynamic property
2. viewdata requires typecasting for complex data types & checks for null values to avoid any exceptions - does not require typecasting for complex data types.
3. both are dynamic properties and resolved at runtime
4. both are rarely used

### 3. Temp Data
- the limitation of both ViewData & ViewBag is that they are limited to one HTTP request only, so if redirection occurs then their values become null means they will loose the data they hold.
- to pass data from one HTTP Request to the next subsequent HTTP request, Tempdata is used in this scenario.
- it is a mechanism to pass a small amount of temporary data from a controller action method to view as well as from a controller action method to another action method
- TempData value becomes null once the subsequent request is completed by default.
```
public TempDataDictionary TempData{ get; set; }

public class TempDataDictionary : IDictionary <string, object>
```

## Strongly typed views
- the best way to transfer data is to use a strongly typed model as it provides compile-time error checking as well as intelligence support

### View Model
- it is a model which contains more than one model data required for a particular view.

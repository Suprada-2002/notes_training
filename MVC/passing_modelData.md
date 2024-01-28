# Pass Model data from Controller to View

## Loosey type views
### 1. View Data
- view data is deined as a property in the ControllerBase class and its type is ViewDataDictionary
```
public ViewDataDuctionary ViewData { get; set; }

[DefaultMember("Item")]
public class ViewDataDictionary : IDictionary<string, object>
```
-  so, View Data is a dictionary object, it stores data in the form of key-value pair
-  each key must be a string and value is going to be stored as an object type.

### 2. View Bag


### 3. Temp Data

## stringly typed views

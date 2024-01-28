// in models folder : create a Employee.cs to hold data in memeory
public class Employee{
  public int id { get; set:}
  public string name { get; set;}
  public decimal salary {get; set:}
}

// business layer to manage employee data : method to take id as a params and return employee details
public class EmployeeBusinessLayer {
  public Employee GetEmployeeDeatils(int id){
    Employee emp = new Employee (){
     id = id,
    name = "john doe",
    salary = 7800
      }
    return emp;
  }
}

// modify the index action of Controller to retrieve employee data
public class HomeController : Controller{
  public ActionResult Index() {
    EmployeeBusinessLayer empBl = new EmployeeBusinessLayer();
    Employee employee = empBl.GetEmployeeDetails(101);

   // pass employee object to index view along with page header using View Data
    ViewData["Employee"] = employee;
    ViewData["Header"] = "Employee Details";
    
    return View();
  }
}

// to access view data
@{
  var employee - ViewData["Employee] as DemoMvc.Models.Employee;
}
<h2>@ViewData["Header"]</h2>

    <table>
    
    <tr>
        <td>EMployee Id:</td>
        <td>@employee.id</td>
    </tr>

</table>




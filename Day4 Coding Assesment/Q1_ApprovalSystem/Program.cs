using Q1_ApprovalSystem;

var tl = new TeamLead("Rohit");
var mgr = new Manager("Sneha");
var dir = new Director("Kapoor");

tl.SetNext(mgr);
mgr.SetNext(dir);

var requests = new List<ExpenseRequest>
{
    new ExpenseRequest("Office Supplies" , 5000),
    new ExpenseRequest("Team Outing" , 25000),
    new ExpenseRequest("New Server" , 80000),
    new ExpenseRequest("Laptop" , 45000)
};

foreach(var req in requests)
    tl.ProcessRequest(req);

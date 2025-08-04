using BethanysPieShopHRM.Components.Services;
using Microsoft.AspNetCore.Components;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Components.Pages;

public partial class EmployeeOverview : ComponentBase
{
    public List<Employee> Employees { get; set; } = default!;
    protected async override Task OnInitializedAsync()
    {
        Employees = MockDataService.Employees;
    }
}
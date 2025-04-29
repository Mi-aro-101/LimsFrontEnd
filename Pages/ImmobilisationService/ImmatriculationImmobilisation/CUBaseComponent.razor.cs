using Microsoft.AspNetCore.Components;


    public class CUBaseComponent : ComponentBase
    {
        [Inject] protected HttpClient Http { get; set; }
        [Inject] protected NavigationManager NavigationManager { get; set; }
       

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
        }
    }

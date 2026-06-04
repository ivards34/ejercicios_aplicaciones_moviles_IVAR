using CatalogoProductos.Models;
using CommunityToolkit.Mvvm.Input;

namespace CatalogoProductos.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}
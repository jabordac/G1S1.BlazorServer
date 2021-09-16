using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Threading.Tasks;

namespace G1S1.BlazorServer.Shared
{
    partial class MessageBoxComponent
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }

        [Parameter] public DialogStyle Style { get; set; }

        [Parameter] public string Title { get; set; }
        [Parameter] public string Subtitle1 { get; set; }
        [Parameter] public string Subtitle2 { get; set; }

        [Parameter] public string YesText { get; set; }
        [Parameter] public string NoText { get; set; }
        [Parameter] public string CancelText { get; set; }

        private string IconDialog { get; set; }
        private Color IconColorDialog { get; set; }

        protected override async Task OnInitializedAsync()
        {
            IconDialog = Style switch
            {
                DialogStyle.Confirm => Icons.Material.Filled.CheckCircle,
                DialogStyle.Error => Icons.Material.Filled.Cancel,
                DialogStyle.Info => Icons.Material.Filled.Info,
                DialogStyle.Question => Icons.Material.Filled.Help,
                DialogStyle.Warning => Icons.Material.Filled.Error
            };

            IconColorDialog = Style switch
            {
                DialogStyle.Confirm => Color.Success,
                DialogStyle.Error => Color.Error,
                DialogStyle.Info => Color.Info,
                DialogStyle.Question => Color.Info,
                DialogStyle.Warning => Color.Warning
            };
        }

        private void OnCancel()
        {
            MudDialog.Cancel();
        }

        private void OnYes()
        {
            MudDialog.Close(DialogResult.Ok(true));
        }

        private void OnNot()
        {
            MudDialog.Close(DialogResult.Ok(false));
        }

        public enum DialogStyle
        {
            Error,
            Question,
            Warning,
            Info,
            Confirm
        }
    }
}

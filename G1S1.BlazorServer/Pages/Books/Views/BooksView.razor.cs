using G1S1.BlazorServer.Data;
using G1S1.BlazorServer.Model;
using G1S1.BlazorServer.Pages.Books.Dialogs;
using G1S1.BlazorServer.Services;
using G1S1.BlazorServer.Shared;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace G1S1.BlazorServer.Pages.Books.Views
{
    public partial class BooksView
    {
        [Inject] private ISnackbar snackBar { get; set; }
        [Inject] private IDialogService dialogService { get; set; }
        [Inject] private IBookService bookService { get; set; }

        private List<Book> Books { get; set; }
        private string searchString = string.Empty;
        private bool isLoading = true;

        protected override async Task OnInitializedAsync()
        {
            await UpdateGrid();
        }

        private async Task UpdateGrid()
        {
            isLoading = true;

            Books = await bookService.GetAll();

            isLoading = false;
        }

        private bool FilterFunc(Book element)
        {
            if (string.IsNullOrWhiteSpace(searchString)) return true;
            if (element.Name.Contains(searchString, StringComparison.OrdinalIgnoreCase)) return true;
            if (element.Pages.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase)) return true;

            return false;
        }

        private async Task ShowBookModal(int idBook, string accion)
        {
            var parameters = new DialogParameters()
            {
                { nameof(SetBookDialog.BookId), idBook},
                { nameof(SetBookDialog.Action), accion }
            };

            var options = new DialogOptions
            {
                CloseButton = true,
                MaxWidth = MaxWidth.Large,
                FullWidth = true,
                DisableBackdropClick = true
            };

            var dialog = dialogService.Show<SetBookDialog>("Cargando...", parameters, options);
            var result = await dialog.Result;

            if (!result.Cancelled)
            {
                await UpdateGrid();
            }
        }


        #region Eventos Grid

        private async Task OnAddBook()
        {
            await ShowBookModal(0, "ADD");
        }

        private async Task OnEditBook(int BookId)
        {
            //await ShowBookModal(idPelicula, "EDIT");
        }

        private async Task OnViewBook(int BookId)
        {
            //await ShowPeliculaModal(idPelicula, "VIEW");
        }

        private async Task OnDeleteBook(int BookId)
        {
            //var parameters = new DialogParameters()
            //{
            //    { nameof(MessageBox.Style), MessageBox.DialogStyle.Question },
            //    { nameof(MessageBox.Title), "Eliminar Película" },
            //    { nameof(MessageBox.Subtitle1), "¿Confirma la eliminación del registro seleccionado?" },
            //    { nameof(MessageBox.Subtitle2), null },
            //    { nameof(MessageBox.YesText), "Si" },
            //    { nameof(MessageBox.NoText), "No" },
            //    { nameof(MessageBox.CancelText), null },
            //};

            //var options = new DialogOptions
            //{
            //    CloseButton = false,
            //    MaxWidth = MaxWidth.Small,
            //    DisableBackdropClick = true
            //};

            //var dialog = dialogService.Show<MessageBox>("Iniciando...", parameters, options);
            //var result = await dialog.Result;

            //if (!result.Cancelled)
            //{
            //    if ((bool)(result.Data ?? false))
            //    {
            //        var httpResponse = await repositoryService.Del($"api/peliculas/{idPelicula}");

            //        if (httpResponse.StatusCode == HttpStatusCode.OK) // Éxito
            //        {
            //            snackbar.Add("Estado actualizado.", Severity.Success);
            //            await UpdateGrid();
            //        }
            //        else // Error
            //        {
            //            snackbar.Add($"Error: {httpResponse.RequestMessage.ToString()}", Severity.Error);
            //        }
            //    }
            //}
        }

        #endregion

    }
}

using G1S1.BlazorServer.Model;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G1S1.BlazorServer.Pages.Books.Dialogs
{
    public partial class SetBookDialog
    {
        [CascadingParameter] MudDialogInstance MudDialog { get; set; }
        [Parameter] public int BookId { get; set; }
        [Parameter] public string Action { get; set; }

        private Book Book { get; set; }

        private string title;
        private string subtitle;
        private bool isLoading = true;
        private bool isDisabled = false;

        #region Eventos

        protected override async Task OnInitializedAsync()
        {
            title = Action switch
            {
                "ADD" => "Nuevo Libro",
                "EDIT" => "Modificar Libro",
                "VIEW" => "Consultar Libro",
                _ => title
            };

            subtitle = Action switch
            {
                "ADD" => "Para crear una Libro debes completar los campos.",
                "EDIT" => "Para modificar un Libro debes actualizar los campos requeridos.",
                _ => subtitle
            };

            if (Action == "ADD")
            {
                Book = new Book();
            }
            else
            {
                Book = await GetBook();
            }

            isDisabled = (Action == "VIEW");

            isLoading = false;
        }

        private async Task OnValidSubmit()
        {
            //isLoading = true;

            //var httpResponse = await Book.Set(Accion, "api/peliculas", Pelicula);

            //if (httpResponse.StatusCode == HttpStatusCode.OK) // Éxito
            //{
            //    MudDialog.Close(DialogResult.Ok(true));
            //    snackbar.Add("Registro actualizado.", Severity.Success);
            //}
            //else // Error
            //{
            //    snackbar.Add($"Error: {httpResponse.RequestMessage.ToString()}", Severity.Error);
            //}

            //isLoading = false;
        }

        private void OnCancel()
        {
            MudDialog.Cancel();
        }

        private void OnLoaded()
        {
            isLoading = false;
        }

        #endregion

        #region Métodos para Obtener Datos

        private async Task<Book> GetBook()
        {
            //PeliculaResponse peliculaResponse = (await repositoryService.Get<IEnumerable<PeliculaResponse>>($"api/peliculas/{IdPelicula}/null")).LastOrDefault();

            //PeliculaRequest peliculaRequest = new PeliculaRequest
            //{
            //    IdPelicula = peliculaResponse.IdPelicula,
            //    Codigo = peliculaResponse.Codigo,
            //    Nombre = peliculaResponse.Nombre,
            //    Descripcion = peliculaResponse.Descripcion,
            //    Imagen = peliculaResponse.Imagen,
            //};

            return Book;
        }

        #endregion

    }
}

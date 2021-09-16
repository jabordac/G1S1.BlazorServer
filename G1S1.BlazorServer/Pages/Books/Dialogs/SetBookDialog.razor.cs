using G1S1.BlazorServer.Model;
using G1S1.BlazorServer.Services;
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
        [Parameter] public Guid? BookId { get; set; }
        [Parameter] public string Action { get; set; }
        [Inject] private IBookService bookService { get; set; }
        [Inject] private IAuthorService authorService { get; set; }

        private Book Book { get; set; }
        private List<Author> Authors { get; set; }

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
                "ADD" => "Para crear un Libro debes completar los campos.",
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

            Authors = await GetAuthors();

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

        private void OnSelectedValuesChanged(HashSet<Guid> authors)
        {
            string listAuthors = string.Join(",", authors.Select(x => x.ToString()).ToArray());
        }

        #endregion

        #region Métodos para Obtener Datos

        private async Task<Book> GetBook()
        {
            return (await bookService.GetById(BookId.GetValueOrDefault()));
        }

        private async Task<List<Author>> GetAuthors()
        {
            return (await authorService.GetAll());
        }

        private async Task<IEnumerable<Guid>> SearchAuthors(string value)
        {
            //await Task.Delay(5);

            if (string.IsNullOrEmpty(value))
            {
                return Authors.Select(x => x.AuthorId);
            }

            return Authors.Where(x => x.Name.Contains(value, StringComparison.InvariantCultureIgnoreCase)).Select(x => x.AuthorId);
        }

        private async Task OnChangedAuthor(Guid value)
        {
            Book.AuthorId = value;
        }
        #endregion

    }
}

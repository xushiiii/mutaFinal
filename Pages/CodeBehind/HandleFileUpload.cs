using Microsoft.AspNetCore.Components.Forms;
using mutaFinal.Pages;

namespace mutaFinal.Pages.CodeBehind
{
    public static class FileUploadService
    {
        public static async Task HandleFileUpload(InputFileChangeEventArgs e, int rowId, InputRow inputRow)
        {
            foreach (var file in e.GetMultipleFiles())
            {
                GlobalState.UploadedFiles.Add(file);
                using var stream = file.OpenReadStream();
                using var reader = new StreamReader(stream);
                var content = await reader.ReadToEndAsync();
                GlobalState.FileContents[rowId] = content;
                GlobalState.SelectedFileName = file.Name;
                inputRow.FileName = file.Name;
            }
        }
    }
}
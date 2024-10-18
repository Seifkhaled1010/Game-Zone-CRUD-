using Game_Zone_CRUD_.Attributes;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Game_Zone_CRUD_.ViewModel
{
    public class CreateGameFormViewModel : GameFormViewModel
    {
        [AllowedExtensions(FileSettings.AllowedExtensions), 
            MaxFileSize(FileSettings.MaxFileSizeInBytes)]
        public IFormFile Cover { get; set; } = default!;
    }
}

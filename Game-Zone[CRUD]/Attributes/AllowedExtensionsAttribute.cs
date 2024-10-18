namespace Game_Zone_CRUD_.Attributes
{
    public class AllowedExtensionsAttribute : ValidationAttribute
    {
        private readonly string _allowdExtensions;

        public AllowedExtensionsAttribute(string allowdExtensions)
        {
            _allowdExtensions = allowdExtensions;
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var file = value as IFormFile;

            if(file is not null)
            {
                var extension = Path.GetExtension(file.FileName);

                var isAllowed = _allowdExtensions.Split(',').Contains(extension, StringComparer.OrdinalIgnoreCase);

                if(!isAllowed)
                {
                    return new ValidationResult($"Only {_allowdExtensions} are allowed!");
                }
            }

            return ValidationResult.Success;
        }
    }
}

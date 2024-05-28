using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories
{
    public class DeleteCategoryRequest : Request
    {
        [Required(ErrorMessage = "Necessário um ID")]
        public long Id { get; set; }
    }
}

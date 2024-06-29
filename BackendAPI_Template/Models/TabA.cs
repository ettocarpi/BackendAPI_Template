using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackendAPI_Template.Models
{
    public class TabA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CampoA1 { get; set; }
        public string CampoA2 { get; set; }
        public string CampoA3 { get; set; }
    }
}

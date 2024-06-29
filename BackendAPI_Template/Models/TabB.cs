using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BackendAPI_Template.Models
{
    public class TabB
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string CampoB1 { get; set; }
        public string CampoB2 { get; set; }
        public string CampoB3 { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class CreateServiceDto
    {
        [Required(ErrorMessage = "Hizmet ikon libki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(50, ErrorMessage = "Hizmet başlığı en fazla 50 karakter olabilir")]
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

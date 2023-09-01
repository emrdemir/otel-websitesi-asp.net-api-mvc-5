using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.ServiceDto
{
    public class UpdateServiceDto
    {
        public int ServiceID { get; set; }
        [Required(ErrorMessage = "Hizmet ikon libki giriniz")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz")]
        [StringLength(50, ErrorMessage = "Hizmet başlığı en fazla 50 karakter olabilir")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Hizmet açıklaması giriniz")]
        [StringLength(400, ErrorMessage = "Hizmet başlığı en fazla 400 karakter olabilir")]
        public string Description { get; set; }
    }
}

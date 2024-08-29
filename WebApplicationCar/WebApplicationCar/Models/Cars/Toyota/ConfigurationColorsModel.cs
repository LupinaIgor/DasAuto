using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCar.Models.Cars.Toyota;

public class ConfigurationColorsModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string MainImageUrl { get; set; }
    
    public int ColorId { get; set; }
    
    [ForeignKey("ColorId")]
    public ColorModel Color { get; set; }
    
    public int ConfigurationId { get; set; }
    
    [ForeignKey("ConfigurationId")]
    public ConfigurationModel Configuration { get; set; }

    public List<ConfigurationColorsModel> Colors { get; set; } = new List<ConfigurationColorsModel>();
}
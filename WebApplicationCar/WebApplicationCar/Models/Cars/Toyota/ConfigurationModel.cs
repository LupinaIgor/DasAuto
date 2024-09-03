using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCar.Models.Cars.Toyota;

public class ConfigurationModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int ModelId { get; set; }
    
    [ForeignKey("ModelId")]
    public ToyotaModel Model { get; set; }
    
    public List<ConfigurationColorsModel> Colors { get; set; } = new List<ConfigurationColorsModel>();

}
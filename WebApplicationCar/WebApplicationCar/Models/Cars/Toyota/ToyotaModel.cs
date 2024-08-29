using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationCar.Models.Cars.Toyota;

public class ToyotaModel
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Name { get; set; }

    public List<ConfigurationModel> Configurations { get; set; } = new List<ConfigurationModel>();

}
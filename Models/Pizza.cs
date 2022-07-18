using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Pizza
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }

    [Column (TypeName = "text")]
    public string Description { get; set; }

    public string Image { get; set; }

    public double Price { get; set; }

    public List<Ingrediente> ingredients { get; set; }

    public Pizza(string name, string description, string image, double price, int id)
    {
        Name = name;
        Description = description;
        Image = image;
        Price = price;
        Id = id;
    }
}

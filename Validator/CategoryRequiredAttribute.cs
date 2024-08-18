using ListaDeCompras.Models;    
using System.ComponentModel.DataAnnotations;

public class CategoryRequiredAttribute : ValidationAttribute
{
    public override bool IsValid(object? value)
    {
        var category = (ProductCategory?)value;
        return category != ProductCategory.Nenhum;
    }
}
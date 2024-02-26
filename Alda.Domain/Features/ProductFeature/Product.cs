namespace Alda.Domain.Features.ProductFeature;

public class Product
{
    public Category Category { get; set; }
    public string Title { get; set; }
    public double Price { get; set; }
    public List<TechnicalProperty> TechnicalProperties { get; set; }
    public List<Translation> Translations { get; set; }
}

public class Translation
{
    public string LanguageCode { get; set; }
    public string Value { get; set; }
}

public class Category
{
    public string CategoryName { get; set; }
}

public class TechnicalProperty
{
    public TechnicalPropertyType PropType { get; set; }
    public object Value { get; set; } // 10
}

public static class TechnicalPropertyTypes
{
    public static string GetMeasurementUnit(TechnicalPropertyType type)
    {
        return type switch
        {
            TechnicalPropertyType.Gramaj => "Gram",
            TechnicalPropertyType.Helal => "",
            _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
        };
    }
}

public enum TechnicalPropertyType
{
    Gramaj,
    Helal,
}
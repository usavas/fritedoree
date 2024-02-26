using Alda.Domain.Features.ProductFeature;

namespace Alda.Domain.Test;

public class ProductTests
{
    [Fact]
    public void Test1()
    {
        Category category = new Category()
        {
            CategoryName = "Patates",
        };

        var product = new Product()
        {
            Title = "Patatoes",
            Category = category,
            Price = 10.0,
            Translations =
            [
                new Translation
                {
                    LanguageCode = "tr",
                    Value = "Patates Kizartmasi",
                },

                new Translation
                {
                    LanguageCode = "en",
                    Value = "Chips",
                }
            ],
            TechnicalProperties =
            [
                new TechnicalProperty
                {
                    PropType = TechnicalPropertyType.Gramaj,
                    Value = 10.0,
                }
            ]
        };
    }
}
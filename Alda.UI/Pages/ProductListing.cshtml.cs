using Alda.Domain.Features.ProductFeature;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Alda.UI.Pages;

public class ProductListing : PageModel
{
    public static List<Category> categories = new()
    {
        new Category()
        {
            CategoryName = "Patates"
        },
        new Category()
        {
            CategoryName = "Tavuk",
        }
    };
    
    public static List<Product> Products { get; set; } = [
        new Product
        {
            Title = "Patatoes",
            Category = categories[0],
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
        },
        new Product
        {
            Title = "Patates Kizartma",
            Category = categories[0],
            Price = 10.0,
            Translations =
            [
                new Translation
                {
                    LanguageCode = "tr",
                    Value = "Patates Balik",
                },

                new Translation
                {
                    LanguageCode = "en",
                    Value = "Fish and Chips",
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
        },
        new Product
        {
            Title = "Chicken",
            Category = categories[0],
            Price = 10.0,
            Translations =
            [
                new Translation
                {
                    LanguageCode = "tr",
                    Value = "Chick chicken",
                },

                new Translation
                {
                    LanguageCode = "en",
                    Value = "Chicky Chick Chiken",
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
        },
        new Product
        {
            Title = "Chicken Breast",
            Category = categories[0],
            Price = 10.0,
            Translations =
            [
                new Translation
                {
                    LanguageCode = "tr",
                    Value = "Tavuk Gogus",
                },

                new Translation
                {
                    LanguageCode = "en",
                    Value = "Chicken Breasts",
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
        },
        new Product
        {
            Title = "Patatoes",
            Category = categories[0],
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
        },
    ];
    
    public void OnGet()
    {
        
    }
}
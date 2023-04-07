using Microsoft.AspNetCore.Components;

namespace MyWebSite.Components;

public partial class Profile : ComponentBase
{
    public Profile()
    {
        this.Tags = new[]
        {
            "C#/.NET",
            "Azure",
            "AWS",
            "Vue.js",
            "Nuxt.js",
            "TypeScript",
            "JavaScript",
            "Python3",
            "Java",
        };
    }

    public string[] Tags { get; }
}
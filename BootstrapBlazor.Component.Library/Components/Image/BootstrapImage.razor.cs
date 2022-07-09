using BootstrapBlazor.Component.Library.Builder;
using Microsoft.AspNetCore.Components;

namespace BootstrapBlazor.Component.Library.Components.Image;

public class BootstrapImageBase : ComponentBase
{
    [Inject] private IClassBuilder ClassBuilder { get; set; }
    [Parameter] public string Src { get; set; }
    [Parameter] public string Alt { get; set; }
    [Parameter] public string Class { get; set; }
    [Parameter] public string Style { get; set; }
    [Parameter] public ImageTypes ImageType { get; set; } = ImageTypes.None;
    [Parameter] public RoundedTypes RoundedType { get; set; } = RoundedTypes.None;
    protected string ClassStr = string.Empty;
    protected override void OnInitialized()
    {
        ClassStr = CreateClassString();
    }
    public string CreateClassString()
    {
        var classStr = Class;
        classStr += " " + ClassBuilder.CreateImagineClass(ImageType);
        classStr += " " + ClassBuilder.CreateRoundedClass(RoundedType);
        return classStr;
    }
}

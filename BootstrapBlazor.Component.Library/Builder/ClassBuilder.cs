namespace BootstrapBlazor.Component.Library.Builder;

public class ClassBuilder : IClassBuilder
{
    public string ClassName = string.Empty;
    public string CreateImagineClass(ImageTypes imageType)
    {
        switch(imageType)
        {
            case ImageTypes.None:
                ClassName = string.Empty;
                break;
            case ImageTypes.Responsive:
                ClassName = "img-fluid";
                break;
            case ImageTypes.Thumbnail:
                ClassName = "img-thumbnail";
                break;            
        }
        return ClassName;
    }
    public string CreateFloatClass(FloatTypes floatType)
    {
        switch(floatType)
        {
            case FloatTypes.None:
                ClassName = "float-none";
                break;
            case FloatTypes.Start:
                ClassName = "float-start";
                break;
            case FloatTypes.End:
                ClassName = "float-end";
                break;
            case FloatTypes.SmNone:
                ClassName = "float-sm-none";
                break;
            case FloatTypes.SmStart:
                ClassName = "float-sm-start";
                break;
            case FloatTypes.SmEnd:
                ClassName = "float-sm-end";
                break;
            case FloatTypes.MdNone:
                ClassName = "float-md-none";
                break;
            case FloatTypes.MdStart:
                ClassName = "float-md-start";
                break;
            case FloatTypes.MdEnd:
                ClassName = "float-md-end";
                break;
            case FloatTypes.LgNone:
                ClassName = "float-lg-none";
                break;
            case FloatTypes.LgStart:
                ClassName = "float-lg-start";
                break;
            case FloatTypes.LgEnd:
                ClassName = "float-lg-end";
                break;
            case FloatTypes.XlNone:
                ClassName = "float-xl-none";
                break;
            case FloatTypes.XlStart:
                ClassName = "float-xl-start";
                break;
            case FloatTypes.XlEnd:
                ClassName = "float-xl-end";
                break;
        }
        return ClassName;
    }
    public string CreatePositionClass(PositionTypes positionType)
    {
        switch(positionType)
        {
            case PositionTypes.None:
                ClassName = string.Empty;
                break;
            case PositionTypes.Static:
                ClassName = "position-static";
                break;
            case PositionTypes.Relative:
                ClassName = "position-relative";
                break;
            case PositionTypes.Absolute:
                ClassName = "position-absolute";
                break;
            case PositionTypes.Fixed:
                ClassName = "position-fixed";
                break;
            case PositionTypes.Sticky:
                ClassName = "position-sticky";
                break;
        }
        return ClassName;
    }
    public string CreateRoundedClass(RoundedTypes roundedType)
    {
        switch(roundedType)
        {
            case RoundedTypes.None:
                ClassName = string.Empty;
                break;
        }
        return ClassName;
    }
}

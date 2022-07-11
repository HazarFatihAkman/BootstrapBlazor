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
                ClassName = "img-fluid ";
                break;
            case ImageTypes.Thumbnail:
                ClassName = "img-thumbnail ";
                break;            
        }
        return ClassName;
    }
    public string CreateFloatClass(FloatTypes floatType)
    {
        switch(floatType)
        {
            case FloatTypes.None:
                ClassName = "float-none ";
                break;
            case FloatTypes.Start:
                ClassName = "float-start ";
                break;
            case FloatTypes.End:
                ClassName = "float-end ";
                break;
            case FloatTypes.SmNone:
                ClassName = "float-sm-none ";
                break;
            case FloatTypes.SmStart:
                ClassName = "float-sm-start ";
                break;
            case FloatTypes.SmEnd:
                ClassName = "float-sm-end ";
                break;
            case FloatTypes.MdNone:
                ClassName = "float-md-none ";
                break;
            case FloatTypes.MdStart:
                ClassName = "float-md-start ";
                break;
            case FloatTypes.MdEnd:
                ClassName = "float-md-end ";
                break;
            case FloatTypes.LgNone:
                ClassName = "float-lg-none ";
                break;
            case FloatTypes.LgStart:
                ClassName = "float-lg-start ";
                break;
            case FloatTypes.LgEnd:
                ClassName = "float-lg-end ";
                break;
            case FloatTypes.XlNone:
                ClassName = "float-xl-none ";
                break;
            case FloatTypes.XlStart:
                ClassName = "float-xl-start ";
                break;
            case FloatTypes.XlEnd:
                ClassName = "float-xl-end ";
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
                ClassName = "position-static ";
                break;
            case PositionTypes.Relative:
                ClassName = "position-relative ";
                break;
            case PositionTypes.Absolute:
                ClassName = "position-absolute ";
                break;
            case PositionTypes.Fixed:
                ClassName = "position-fixed ";
                break;
            case PositionTypes.Sticky:
                ClassName = "position-sticky ";
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
    public string CreateBackgroundColorClass(BackgroundTypes backgroundType)
    {
        switch (backgroundType)
        {
            case BackgroundTypes.Transparent:
                ClassName = "bg-transparent ";
                break;
            case BackgroundTypes.Primary:
                ClassName = "bg-primary ";
                break;
            case BackgroundTypes.Seconday:
                ClassName = "bg-secondary ";
                break;
            case BackgroundTypes.Success:
                ClassName = "bg-success ";
                break;
            case BackgroundTypes.Danger:
                ClassName = "bg-danger ";
                break;
            case BackgroundTypes.Warning:
                ClassName = "bg-warning ";
                break;
            case BackgroundTypes.Info:
                ClassName = "bg-info ";
                break;
            case BackgroundTypes.Light:
                ClassName = "bg-light ";
                break;
            case BackgroundTypes.Dark:
                ClassName = "bg-dark ";
                break;
            case BackgroundTypes.Body:
                ClassName = "bg-body ";
                break;
            case BackgroundTypes.White:
                ClassName = "bg-white ";
                break;
            case BackgroundTypes.DarkGradient:
                ClassName = "bg-dark bg-gradient ";
                break;
            case BackgroundTypes.LightGradient:
                ClassName = "bg-light bg-gradient ";
                break;
            case BackgroundTypes.InfoGradient:
                ClassName = "bg-info bg-gradient ";
                break;
            case BackgroundTypes.WarningGradient:
                ClassName = "bg-warning bg-gradient ";
                break;
            case BackgroundTypes.DangerGradient:
                ClassName = "bg-danger bg-gradient ";
                break;
            case BackgroundTypes.SuccessGradient:
                ClassName = "bg-success bg-gradient ";
                break;
            case BackgroundTypes.SecondayGradient:
                ClassName = "bg-secondary bg-gradient ";
                break;
            case BackgroundTypes.PrimaryGradient:
                ClassName = "bg-primary bg-gradient ";
                break;
        }
        return ClassName;
    }
}

namespace BootstrapBlazor.Component.Library.Builder;

public interface IClassBuilder
{
    string CreateImagineClass(ImageTypes imageType);
    string CreateFloatClass(FloatTypes floatType);
    string CreatePositionClass(PositionTypes positionType);
    string CreateRoundedClass(RoundedTypes roundedType);
}
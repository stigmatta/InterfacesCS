
namespace InterfacesCS
{
    public interface ICalc
    {
        int Less(int valueToCompare);
        int Greater(int valueToCompare);
    }

    public interface ICalc2
    {
        int CountDistinct();
        int EqualToValue(int valueToCompare);
    }

    public interface IOutput
    {
        void ShowEven();
        void ShowOdd();
    }

    
}

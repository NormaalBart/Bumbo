namespace BumboServices.Surcharges.SurchargeRules;

public enum SurchargeType
{
    Holiday,
    Surcharge33,
    Surcharge50,
    Sick
}

public static class SurchargeTypeExtensions
{
    public static int SurchargePercentage(this SurchargeType type)
    {
        switch (type)
        {
            case SurchargeType.Holiday:
                return 100;
            case SurchargeType.Surcharge33:
                return 33;
            case SurchargeType.Surcharge50:
                return 50;
            case SurchargeType.Sick:
                return 70;
            default:
                throw new ArgumentOutOfRangeException(nameof(type), type, null);
        }
    }
}
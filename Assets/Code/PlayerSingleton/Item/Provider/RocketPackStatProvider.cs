public class RocketPackStatProvider
{
    public RocketPackStats CreateStats(RocketPackConfig config)
    {
        return new RocketPackStats(
            charges: config.Charges
        );
    }
}
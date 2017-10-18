namespace AdapterPattern.Object
{
    public class PowerAdapter : ThreeHole
    {
        public TwoHole TwoHoleAdapter = new TwoHole();

        public override void Request()
        {
            TwoHoleAdapter.SpecificRequest();
        }
    }
}

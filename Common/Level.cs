using CSRTS.Common.Unit;

namespace CSRTS.Common
{
    internal class Level
    {
        public HeightMapNode[] Map { get; init; }
        public List<BaseUnit> Units { get; set; }
        public void Update()
        {
            foreach (BaseUnit unit in Units)
            {
                unit.Update();
            }
        }
    }
}

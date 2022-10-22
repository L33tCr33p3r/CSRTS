using CSRTS.Source.Muzzle;

namespace CSRTS.Source.Abstract {
    internal abstract class Weapon {
        private float _range;
        private float _firerate;
        private List<BaseMuzzle> _muzzles;
    }
}

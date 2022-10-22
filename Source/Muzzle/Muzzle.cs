namespace CSRTS.Source.Muzzle {
    internal abstract class BaseMuzzle {
        private int _damage { get; init; }
        public abstract void Fire();
    }
}

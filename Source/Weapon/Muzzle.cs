namespace CSRTS.Source.Weapon
{
    internal abstract class Muzzle
    {
        private int _damage { get; init; }
        public abstract void Fire();
    }
}

namespace syntaxApp.Patterns.Decorator
{
    public interface IGun
    {
        string GetName();
        void Reload();
        void AimDown();
        void Shoot();
    }
}

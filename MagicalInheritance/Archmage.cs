namespace MagicalInheritance;

public class Archmage : Mage
{
    public Archmage(string title) : base(title)
    {
    }
    
    public override Storm CastRainStorm()
    {
        return new Storm("rain", true, Title);
    }
    
#pragma warning disable CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
    public Storm CastLightningStorm()
#pragma warning restore CS0108 // El miembro oculta el miembro heredado. Falta una contraseña nueva
    {
        return new Storm("lightning", true, Title);
    }
}
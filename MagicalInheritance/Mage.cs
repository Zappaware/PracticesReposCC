﻿namespace MagicalInheritance;

public class Mage : Pupil
{
    public Mage(string title) : base(title)
    {
    }
    
    public virtual Storm CastRainStorm()
    {
        return new Storm("rain", false, Title);
        
    }
    
    public Storm CastLightningStorm()
    {
        return new Storm("lightning", true, Title);
    }
}
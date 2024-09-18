using UnityEngine;

public class Rabbit : Animal, IWalk
{
    public void Walk()
    {
        Debug.Log("≈‰≥¢∞° ∞…¿Ω");
    }

    public override void Eat()
    {
        Debug.Log("≈‰≥¢∞° ∏‘¿Ω");
    }
}

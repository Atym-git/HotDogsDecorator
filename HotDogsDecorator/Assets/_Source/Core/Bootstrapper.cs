using UnityEngine;

public class Bootstrapper : MonoBehaviour
{
    private void Start()
    {
        ClassicHotDog hotDog = new ClassicHotDog();

        Debug.Log($"{hotDog.GetName()} - {hotDog.GetCost()}");

        PicklesHotDog picklesHotDog = new PicklesHotDog(hotDog);

        Debug.Log($"{picklesHotDog.GetName()} - {picklesHotDog.GetCost()}");

        OnionHotDog onionHotDog = new OnionHotDog(hotDog);

        Debug.Log($"{onionHotDog.GetName()} - {onionHotDog.GetCost()}");
    }
}

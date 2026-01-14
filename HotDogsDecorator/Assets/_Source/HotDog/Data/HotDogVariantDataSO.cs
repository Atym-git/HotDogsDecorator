using UnityEngine;

[CreateAssetMenu(fileName = "HotDogVariantData",
    menuName = "SO/HotDogVariantSO")]
public class HotDogVariantDataSO : ScriptableObject
{
    [field:SerializeField]
    public string Name { get; private set; }

    [field:SerializeField]
    public int Cost { get; private set; }

    [field:SerializeField]
    public int Weight { get; private set; }
}

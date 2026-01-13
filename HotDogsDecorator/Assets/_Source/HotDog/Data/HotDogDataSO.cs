using UnityEngine;

[CreateAssetMenu(fileName = "HotDogData",
    menuName = "SO/HotDogSO")]
public class HotDogDataSO : ScriptableObject
{
    [field:SerializeField]
    public string Name { get; private set; }

    [field:SerializeField]
    public int Cost { get; private set; }

    [field:SerializeField]
    public int Weight { get; private set; }
}

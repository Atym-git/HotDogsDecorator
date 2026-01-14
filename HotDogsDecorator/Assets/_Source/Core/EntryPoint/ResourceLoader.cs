using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceLoader
{
    public List<HotDogVariantDataSO> LoadVariantsData()
    {
        List<HotDogVariantDataSO> variants = Resources.LoadAll<HotDogVariantDataSO>("SO/HotDogSO/HotDogVariantsSO")
            .Cast<HotDogVariantDataSO>()
            .ToList();
        Debug.Log(variants.Count);
        return variants;
    }
    
    public List<HotDogDecoratorDataSO> LoadDecoratorData()
    {
        List<HotDogDecoratorDataSO> variants = Resources.LoadAll<HotDogDecoratorDataSO>("SO/HotDogSO/DecoratorSO")
            .Cast<HotDogDecoratorDataSO>()
            .ToList();
        Debug.Log(variants.Count);
        return variants;
    }
}

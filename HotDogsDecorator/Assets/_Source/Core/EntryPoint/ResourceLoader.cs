using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ResourceLoader<T>
{
    public List<HotDogVariantDataSO> LoadVariantsData()
    {
        List<HotDogVariantDataSO> variants = Resources.LoadAll<HotDogVariantDataSO>("SO/HotDogSO/HotDogVariantsSO")
            .Cast<HotDogVariantDataSO>()
            .ToList();
        return variants;
    }
    
    public List<HotDogDecoratorDataSO> LoadDecoratorData()
    {
        List<HotDogDecoratorDataSO> variants = Resources.LoadAll<HotDogDecoratorDataSO>("SO/HotDogSO/DecoratorSO")
            .Cast<HotDogDecoratorDataSO>()
            .ToList();
        return variants;
    }
    
    public static bool LoadSODataFromResources<T>(string resourcePath, out List<T> downloadedObjectsList) where T : ScriptableObject
    {
        downloadedObjectsList = null;
        downloadedObjectsList = Resources.LoadAll<T> (resourcePath)
            .Cast<T>()
            .ToList();
        if (downloadedObjectsList.Count > 0)
        {
            return true;
        }
        return false;
    }
}

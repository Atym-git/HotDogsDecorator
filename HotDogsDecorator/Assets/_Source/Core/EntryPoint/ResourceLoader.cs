using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class ResourceLoader
{
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

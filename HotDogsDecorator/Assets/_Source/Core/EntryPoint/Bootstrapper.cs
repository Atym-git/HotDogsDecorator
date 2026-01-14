using UnityEngine;
using System;
using System.Collections.Generic;
using _Source.HotDog.HotDogDecorator;

public class Bootstrapper : MonoBehaviour
{
    const string HOTDOG_DECORATOR_SO_PATH = "SO/HotDogSO/DecoratorSO";
    const string HOTDOG_VARIANT_SO_PATH = "SO/HotDogSO/HotDogVariantsSO";
    private void Start()
    {
        //Task 1
        //ClassicHotDog hotDog = new ClassicHotDog();

        //Debug.Log($"{hotDog.GetName()} - {hotDog.GetCost()}");

        //PicklesHotDog picklesHotDog = new PicklesHotDog(hotDog);

        //Debug.Log($"{picklesHotDog.GetName()} - {picklesHotDog.GetCost()}");

        //OnionHotDog onionHotDog = new OnionHotDog(hotDog);

        //Debug.Log($"{onionHotDog.GetName()} - {onionHotDog.GetCost()}");
        
        //Task 2

        System.Random rand =  new System.Random();

        List<HotDogVariantDataSO> hotDogVariantsData = new();
        List<HotDogDecoratorDataSO> hotDogDecoratorsData = new();
        
        if (ResourceLoader.LoadSODataFromResources(HOTDOG_VARIANT_SO_PATH, out hotDogVariantsData)
            && ResourceLoader.LoadSODataFromResources(HOTDOG_DECORATOR_SO_PATH, out hotDogDecoratorsData))
        {
            HotDogVariantDataSO currHotDogVariantData = hotDogVariantsData[rand.Next(0, hotDogVariantsData.Count)];
            HotDogDecoratorDataSO currHotDogDecoratorData = hotDogDecoratorsData[rand.Next(0, hotDogDecoratorsData.Count)];
        
            HotDogVariant hotDog = new HotDogVariant(currHotDogVariantData.Name,
                currHotDogVariantData.Cost,
                currHotDogVariantData.Weight);
        
            Debug.Log($"{hotDog.GetName()} - {hotDog.GetCost()} ({hotDog.Weight}г)");
            
            HotDogDecorator hotDogDecorator = new HotDogDecorator(hotDog,
                currHotDogDecoratorData.Name,
                currHotDogDecoratorData.Cost,
                currHotDogDecoratorData.Weight);
        
            Debug.Log($"{hotDogDecorator.GetName()} - {hotDogDecorator.GetCost()} ({hotDogDecorator.Weight}г)");
        }
    }
}

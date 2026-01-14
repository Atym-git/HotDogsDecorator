using UnityEngine;
using System;
using System.Collections.Generic;
using _Source.HotDog.HotDogDecorator;

public class Bootstrapper : MonoBehaviour
{
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
        
        ResourceLoader loader = new ResourceLoader();

        List<HotDogVariantDataSO> hotDogVariantsData = loader.LoadVariantsData();
        List<HotDogDecoratorDataSO>  hotDogDecoratorsData = loader.LoadDecoratorData();
        
        HotDogVariantDataSO currHotDogVariantData = hotDogVariantsData[rand.Next(0, hotDogVariantsData.Count - 1)];
        HotDogDecoratorDataSO currHotDogDecoratorData = hotDogDecoratorsData[rand.Next(0, hotDogDecoratorsData.Count - 1)];
        
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

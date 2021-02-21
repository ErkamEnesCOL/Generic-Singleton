using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSingleton<T> : MonoBehaviour where T: GenericSingleton<T>
{
    private static volatile T instance = null; //Instance is null by default


    public static T Instance
    {
        get
        {
            if (instance == null) // If the instance is null
            {
                instance = FindObjectOfType(typeof(T)) as T; //Instance is selected as whatever class that derives from this
            }

        return instance;
        }
    }

}

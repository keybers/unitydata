﻿using UnityEngine;

[CreateAssetMenu(menuName = "Singletons/MasterManager")]
public class MasterManager : SingletonScriptableObject<MasterManager>
{
    [SerializeField]
    private GameSettings _gameSettings;

    public static GameSettings GameSettings
    {
        get
        {
            return Instance._gameSettings;
        }
    }

    [SerializeField]
    private AddressablePrefabPool _addressablePrefabPool;
    
    public static AddressablePrefabPool AddressablePrefabPool
    {
        get
        {
            return Instance._addressablePrefabPool;
        }
    }
}

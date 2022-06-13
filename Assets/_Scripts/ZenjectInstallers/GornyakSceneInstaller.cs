using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GornyakSceneInstaller : MonoInstaller
{
    [SerializeField] private GornyakAudioController baseAudioController;
    [SerializeField] private GornyakUIController _gornyakUIController;
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<GornyakAudioController>().
            FromInstance(baseAudioController).AsSingle();
        
        Container.BindInterfacesAndSelfTo<GornyakUIController>().
            FromInstance(_gornyakUIController).AsSingle();
    }
}


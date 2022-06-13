using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GornyakSceneInstaller : MonoInstaller
{
    [SerializeField] private GornyakAudioController baseAudioController;
    public override void InstallBindings()
    {
        Container.BindInterfacesAndSelfTo<GornyakAudioController>().
            FromInstance(baseAudioController).AsSingle();
    }
}


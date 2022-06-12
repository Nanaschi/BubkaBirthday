using UnityEngine;
using Zenject;

public class ProjectInstaller : MonoInstaller
{
    [SerializeField] private AudioController _audioController;
    
    public override void InstallBindings()
    {
        var audioController = 
            Container.InstantiatePrefabForComponent<AudioController>(_audioController);
        
    }
}
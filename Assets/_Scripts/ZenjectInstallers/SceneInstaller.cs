using UnityEngine;
using Zenject;

namespace _Scripts.ZenjectInstallers
{
    public class SceneInstaller : MonoInstaller
    {
        [SerializeField] private AudioController _audioController;
        public override void InstallBindings()
        {
            Container.InstantiatePrefabForComponent<AudioController>
                (_audioController, transform.position, Quaternion.identity, transform);
        }
    }
}
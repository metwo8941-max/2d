using UnityEngine;

namespace RMC.d.Gameplay.Casual2D
{
    public class Classic2DGameBootstrap : MonoBehaviour
    {
        [SerializeField] private string _firstPlayableScene = "Scene01_Intro";

        private void Start()
        {
            Debug.Log($"Preparing {_firstPlayableScene} for 2d.");
        }
    }
}

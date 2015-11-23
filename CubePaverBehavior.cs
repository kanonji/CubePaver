using UnityEngine;
using System.Collections;

namespace kanonji.CubePaver
{
    public class CubePaverBehavior : MonoBehaviour
    {
        [SerializeField]
        private int width = 10;
        [SerializeField]
        private int height = 10;

        void Start()
        {
            CubePaver cubePaver = new CubePaver(this.width, this.height);
            cubePaver.Generate();
        }
    }

}
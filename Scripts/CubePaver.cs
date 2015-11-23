using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace kanonji.CubePaver
{

    public class CubePaver
    {
        private Grid grid;

        public CubePaver(int width, int height)
        {
            this.grid = new Grid(width, height);
        }

        public void Generate()
        {
            GameObject origin = GameObject.CreatePrimitive(PrimitiveType.Cube);
            foreach (Vector3 pos in this.grid)
            {
                GameObject.Instantiate(origin, pos, origin.transform.rotation);
            }
            GameObject.Destroy(origin);
        }
    }

    public class Grid : IEnumerable<Vector3>
    {
        private int width;
        private int height;

        public Grid(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public IEnumerator<Vector3> GetEnumerator()
        {
            foreach (int h in Enumerable.Range(0, this.height-1))
            {
                foreach (int w in Enumerable.Range(0, this.width-1))
                {
                    yield return new Vector3(w, h, w+h%2);
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
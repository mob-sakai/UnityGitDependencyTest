using UnityEngine;

namespace Coffee.Ugd
{
    public class RotateIt : MonoBehaviour
    {
        [SerializeField]
        private Vector3 m_Rotate;

        private void Update()
        {
            Rotate(transform, m_Rotate);
        }

        public static void Rotate(Transform t, Vector3 v)
        {
            t.Rotate(v.x, v.y, v.z);
        }
    }
}

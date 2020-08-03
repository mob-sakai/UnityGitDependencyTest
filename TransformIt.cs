using UnityEngine;

namespace Coffee.Ugd
{
    public class TransformIt : MonoBehaviour
    {
        [SerializeField] private Vector3 m_Translate;

        [SerializeField] private Vector3 m_Rotate;

        private void Update()
        {
            Translate(transform, m_Translate);
            Rotate(transform, m_Rotate);
        }

        public static void Translate(Transform t, Vector3 v)
        {
            t.Translate(v.x, v.y, v.z);
        }

        public static void Rotate(Transform t, Vector3 v)
        {
            t.Rotate(v.x, v.y, v.z);
        }
    }
}

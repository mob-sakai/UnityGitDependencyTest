using UnityEngine;

namespace Coffee.Ugd
{
    public class TranslateIt : MonoBehaviour
    {
        [SerializeField]
        private Vector3 m_Translate;

        private void Update()
        {
            Translate(transform, m_Translate);
        }

        public static void Translate(Transform t, Vector3 v)
        {
            t.Translate(v.x, v.y, v.z);
        }
    }
}

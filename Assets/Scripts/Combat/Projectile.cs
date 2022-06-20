using UnityEngine;

namespace Combat
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Projectile : MonoBehaviour
    {
        private float dmg;

        public void Init(Vector3 dir, float speed, float dmg)
        {
            GetComponent<Rigidbody2D>().velocity = dir * speed;
            transform.up = dir;
            this.dmg = dmg;
        }
        
    }
}
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Spaceship : MonoBehaviour
{
    public float speed;
    public float shotDelay;
    public GameObject bullet;

    public bool canShot;

    public GameObject explosion;

    public void Explosion(){
        Instantiate(explosion, this.transform.position, this.transform.rotation);
    }

    public void Shot(Transform origin){
        Instantiate(bullet, origin.position, origin.rotation);
    }

    public void Move(Vector2 direction){
        GetComponent<Rigidbody2D>().velocity = direction * speed;
    }
}

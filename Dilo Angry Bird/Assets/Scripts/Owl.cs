using UnityEngine;

public class Owl : Bird
{
    public GameObject explosion;        

    public void Explode()
    {
        Vector3 explosionPos = transform.position;
        Instantiate(explosion, explosionPos, Quaternion.identity);
        Destroy(this.gameObject);

        
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Explode();
    }
}

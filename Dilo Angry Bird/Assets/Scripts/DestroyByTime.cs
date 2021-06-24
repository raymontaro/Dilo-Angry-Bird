using UnityEngine;

public class DestroyByTime : MonoBehaviour
{
    public float time;
    float t = 0;    

    // Update is called once per frame
    void Update()
    {
        if (t < time)
            t += Time.deltaTime;
        else
            Destroy(this.gameObject);
    }
}

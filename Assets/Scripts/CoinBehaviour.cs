using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinBehaviour : MonoBehaviour
{
    public Healthbar healthBar;
    public GameObject winscr;
    public int maxCoins = 25;
    public ParticleSystem ps;
    public bool once = true;
    public AudioSource audioSource;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(10, 60, 0) * Time.deltaTime * 2);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && once)
        {
            healthBar.SetCoins(healthBar.GetCoins() + 1);
            audioSource.Play();
            var em = ps.emission;
            var dur = ps.duration;
            em.enabled = true;
            ps.Play();
            once = false;
            GetComponent<Renderer>().enabled = false;
            if (healthBar.GetCoins()>24)
            {
                winscr.gameObject.SetActive(true);
            }
            Invoke(nameof(destroy), dur);
        }
    }
    void destroy()
    {
        this.gameObject.SetActive(false);
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ShootingGun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public GameObject impactEffect;

    public GUIText scoreText;
    private int score;

    public Camera fpsCam;

    private void Start()
    {
        score = 0;
        UpdateScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            

            if (target != null)
            {
                target.TakeDamage(damage);
                
            }

            GameObject impactG = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactG, 2f); 
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "TARGETS: " + score;
    }


}
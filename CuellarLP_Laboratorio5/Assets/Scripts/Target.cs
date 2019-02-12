using UnityEngine;

public class Target : MonoBehaviour
{

    public float Health = 5f;
    public int scoreValue;
    private ShootingGun shootingGun;

    private void Start()
    {
        GameObject gameshootingGun = GameObject.FindWithTag("Player");
        if (gameshootingGun != null)
        {
            shootingGun = gameshootingGun.GetComponent<ShootingGun>();
        }

        if (gameshootingGun == null)
        {
            Debug.Log("sorry broski! :( ");
        }
    }

    public void TakeDamage (float amount )
    {
        Health -= amount; 

        if (Health <= 0f)
        {
            Vanish();
        }
    }

    void Vanish()
    {
        Destroy(gameObject);

        shootingGun.AddScore(scoreValue);

    }




}

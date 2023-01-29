using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Increase : MonoBehaviour
{

    [SerializeField]
    AudioClip ps;

    [SerializeField]
    [Range(0, 100)]
    int MaxHealth;

    [SerializeField]
    [Range(0, 100)]
    int Health;

    void awake()
    {
        GetComponent<AudioSource>().PlayOneShot(ps) ;


        MaxHealth = 100;
        Health = 50;
        int damage = 10;
        damage = 10;

        Health = MaxHealth - damage;
    }
    void NewAwake() {}
    // Start is called before the first frame update
    void Start()
    {
        bool discload;
       discload = false;
       discload = true;

        Debug.Log(discload);

        Debug.Log("health is: " + Health);

        Debug.Log(Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z) * ((Time.deltaTime)/4);
        

    }

}

using UnityEngine;

public class GlowingA : MonoBehaviour
{
    //public Transform targetA;
    //public Transform targetB;
    //public GameObject glow;
    //public float opacity;
    //public Material glowColor;

    private Vector2 startPos;
    private SpriteRenderer sr;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //float dist = Vector2.Distance(targetA.position, targetB.position);
        //opacity = dist;



        //glow.GetComponent<SpriteRenderer> ().color = new Color (glowColor.color.r, glowColor.color.g, glowColor.color.b, opacity);


        sr.color = new Color(1, 1, 1,(startPos.y - transform.position.y) / 2);
    }
}

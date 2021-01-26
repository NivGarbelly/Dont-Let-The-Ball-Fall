using UnityEngine;

public class Destructable : MonoBehaviour
{
   [SerializeField] private GameManeger gameManeger;
   [SerializeField] private GameObject VFX;
   [SerializeField] private GameObject SFX;
   private void OnMouseDown()
       {
           Instantiate(VFX,transform.position,transform.rotation);
           Instantiate(SFX,transform.position,transform.rotation);
           gameManeger.des.Remove(this.gameObject);
           Destroy(this.gameObject);
       }

   private void Awake()
   {
       gameManeger = FindObjectOfType<GameManeger>();
       var rigidBody = GetComponent<Rigidbody>();
       rigidBody.mass = transform.localScale.x;
   }

   private void OnDestroy()
   {
       gameManeger.des.Remove(this.gameObject);
   }
} 

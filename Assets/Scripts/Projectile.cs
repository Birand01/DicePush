using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public Rigidbody dicePrefab;
    public GameObject cursor;
    public LayerMask layer;
    public Transform shootPoint;
    private Camera cam;
    public float timer = 5.0f;
    public LineRenderer lineVisual;
    public int lineSegment;
     public GameObject win;
    

    void Start()
    {
      
        cam = Camera.main;
        lineVisual.positionCount = lineSegment;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;


        LaunchProjectile();
           
        


    }
    void LaunchProjectile()
    {
        Ray camRay = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(camRay, out hit, 100f, layer)) 
        {
            cursor.SetActive(true);
            cursor.transform.position = hit.point + Vector3.up * 0.1f;
            Vector3 Vo = CalculateVelocity(hit.point, shootPoint.position, 1.0f);
            transform.rotation = Quaternion.LookRotation(Vo);
            VisualLİne(Vo); 
            if (Input.GetMouseButtonDown(0) && timer<=1 && win.GetComponent<Win>().gameOver==false)
            {
                
                Rigidbody obj = Instantiate(dicePrefab, shootPoint.position, Quaternion.identity);
                obj.velocity = Vo;
                timer = 5.0f;
            }
            
        }
        else
        {
            cursor.SetActive(false);
        }
    }
    

    Vector3 CalculateVelocity(Vector3 target,Vector3 origin,float time)
    {
        //Definition of the distance x and y
        Vector3 distance = target - origin;
        Vector3 distanceXZ = distance;
        distanceXZ.y = 0.0f;
        //Creation of float for representation of distance
        float Sy = distance.y;
        float Sxz = distanceXZ.magnitude;
        float Vxz = Sxz / time;
        float Vy = Sy / time + 0.5f * Mathf.Abs(Physics.gravity.y) * time;

        Vector3 result = distanceXZ.normalized;
        result *= Vxz;
        result.y = Vy;

        return result;

    }
    void VisualLİne(Vector3 vo) // Drawing Line Renderer
    {
        for (int i = 0; i < lineSegment; i++)
        {
            Vector3 pos = CalculatePosInTime(vo, i / (float)(lineSegment));
            lineVisual.SetPosition(i, pos);
        }
    }
            
    Vector3 CalculatePosInTime(Vector3 vo,float time) // Math Equation of Drawing curved line
    {
        Vector3 Vxz = vo;
        Vxz.y = 0.0f;
        Vector3 result = shootPoint.position + vo * time;
        float sY=(-0.5f*Mathf.Abs(Physics.gravity.y)*(time*time))+(vo.y*time)+shootPoint.position.y;
        result.y = sY;
        return result;
    }
     
}

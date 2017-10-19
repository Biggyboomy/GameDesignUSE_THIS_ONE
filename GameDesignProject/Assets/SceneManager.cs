using UnityEngine;

public class SceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("n"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                EndTrigger obj = hit.collider.GetComponent<EndTrigger>();
                if (obj)
                {
                    
                        Application.LoadLevel("LivingRoom_01");
                    
                }
            }
        }

        }
    
}

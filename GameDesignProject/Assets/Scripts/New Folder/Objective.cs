using UnityEngine;
using System.Collections;

namespace SpawnPoop
{
    public class Objective : MonoBehaviour
    {
        public GameObject ObjectiveSign_01;

        void OnTriggerStay(Collider other)
        {
            if (other.gameObject.name == "Objective_01" && (Input.GetKeyDown("r")))
            {
                ObjectiveSign_01.SetActive(false);
            }
        }
    }
}
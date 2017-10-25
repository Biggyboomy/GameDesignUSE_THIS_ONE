using UnityEngine;
using System.Collections;

namespace SpawnPoop
{
    public class Objective : MonoBehaviour
    {
        public GameObject ObjectiveSign_01;
        public GameObject ObjectiveSign_02;
        public GameObject ObjectiveSign_03;
        public GameObject ObjectiveSign_04;
        public GameObject ObjectiveSign_05;
        public GameObject ThirdPersonController;
        private SpawnPoop poopCountScript;
        private int PoopCount;

        void OnTriggerStay(Collider other)
        {
            poopCountScript = ThirdPersonController.GetComponent<SpawnPoop>();
            PoopCount = poopCountScript.poopCount;

            if (other.gameObject.name == "Objective_01" && (Input.GetKeyDown("r")) && PoopCount != 0)
            {
                ObjectiveSign_01.SetActive(false);
                ScoreScript.scoreValue += 1;
            }

            if (other.gameObject.name == "Objective_02" && (Input.GetKeyDown("r")) && PoopCount != 0)
            {
                ObjectiveSign_02.SetActive(false);
                ScoreScript.scoreValue += 1;
            }

            if (other.gameObject.name == "Objective_03" && (Input.GetKeyDown("r")) && PoopCount != 0)
            {
                ObjectiveSign_03.SetActive(false);
                ScoreScript.scoreValue += 1;
            }

            if (other.gameObject.name == "Objective_04" && (Input.GetKeyDown("r")) && PoopCount != 0)
            {
                ObjectiveSign_04.SetActive(false);
                ScoreScript.scoreValue += 1;
            }

            if (other.gameObject.name == "Objective_05" && (Input.GetKeyDown("r")) && PoopCount != 0)
            {
                ObjectiveSign_05.SetActive(false);
                ScoreScript.scoreValue += 1;
            }
        }
    }
}
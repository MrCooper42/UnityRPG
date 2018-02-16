using System.Runtime.Serialization.Formatters;
using UnityEngine;

namespace Quests
{
    public class Quest001Take : MonoBehaviour
    {
        public float TheDistance;
        public GameObject ActionDisplayGameObject;
        public GameObject ActionTextGameObject;
        public GameObject UiQuestGameObject;
        public GameObject PlayerGameObject;
        public GameObject NoticeCamGameObject;

        private void Update()
        {
            TheDistance = PlayerCasting.DistanceFromTarget;
        }

        private void OnMouseOver()
        {
            if (TheDistance <= 3)
            {
                ActionDisplayGameObject.SetActive(true);
                ActionTextGameObject.SetActive(true);
            }

            if (!Input.GetButtonDown("Action")) return;
            if (!(TheDistance <= 3)) return;
            ActionDisplayGameObject.SetActive(false);
            ActionTextGameObject.SetActive(false);
            UiQuestGameObject.SetActive(true);
            NoticeCamGameObject.SetActive(true);
            PlayerGameObject.SetActive(false);
        }

        private void OnMouseExit()
        {
            ActionDisplayGameObject.SetActive(false);
            ActionTextGameObject.SetActive(false);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Script
{
    public class Plane : MonoBehaviour
    {
        public GameObject[] characters;
        public Image imageGrean;
        [SerializeField]
        private int NumberGamer;
       public Log log = new Log();
        void Start()
        {
           
            characters = new GameObject[transform.childCount - 1];
            for (int i = 0; i < transform.childCount - 1; i++)
            {
                characters[i] = transform.GetChild(i).gameObject;
            }
            if (PlayerPrefs.HasKey("Number Gamer"))
            {
                NumberGamer = PlayerPrefs.GetInt("Number Gamer");
              
            }
            else 
            {


                NumberGamer = 0;
            } 
            imageGrean.transform.position = characters[NumberGamer].transform.position;
        }
        public void Ganerate()
        {
            SetNumberGame(log.Ganerate());
        }
        public void CharectorNumber(int count)
        {
            SetNumberGame(count);
          
        }

        public void CharacterPlay()
        {
           // PlayerPrefs.SetInt("Number Gamer", NumberGamer);
            ChangeScene();

        }
        public void ChangeScene()
        {
            SceneManager.LoadScene(1);
        }

        private void SetNumberGame(int Number)
        {
            NumberGamer = Number;
            PlayerPrefs.SetInt("Number Gamer", NumberGamer);
            imageGrean.transform.position = characters[NumberGamer].transform.position;
        }
    }
}

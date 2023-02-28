using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HyperCasual.Runner
{
    public class Tutorial : Spawnable
    {
        [SerializeField] GameObject m_tutorialAsset;
        const string k_PlayerTag = "Player";

        void OnTriggerEnter(Collider col)
        {
            if (col.CompareTag(k_PlayerTag))
            {
                Time.timeScale = 0;
                m_tutorialAsset.SetActive(true);
            }
        }
        public void close(){
            Time.timeScale = 1;
            Destroy(this.gameObject);
        }
    }

}
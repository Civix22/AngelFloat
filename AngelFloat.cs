using Utilla;
using HarmonyLib;
using System.Collections.Generic;
using BepInEx;
using UnityEngine;
using GorillaLocomotion;




namespace TP
{
    [BepInPlugin("com.gorillatag.AngleFloat.civix", "AngelFloat", "1.0.0")]
    class TP2 : BaseUnityPlugin
    {
        bool inRoom => NetworkSystem.Instance.InRoom && NetworkSystem.Instance.GameModeString.Contains("MODDED");
        void Update()
        {
            if (inRoom)
            {

                {
                    GorillaLocomotion.GTPlayer.Instance.transform.position += GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime * 2;

                    Rigidbody rb = GTPlayer.Instance.GetComponent<Rigidbody>();
                    rb.velocity = Vector3.zero;
                    rb.AddForce(-Physics.gravity * rb.mass * GTPlayer.Instance.scale);
                }
            }
        }
    }
}

                
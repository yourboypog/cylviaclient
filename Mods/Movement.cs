using GorillaLocomotion;
using StupidTemplate.Classes;
using UnityEngine;
using UnityEngine.XR;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate.Mods
{
    public class Movement
    {
        public static bool platGravity = true;
        public static GameObject rightPlat;
        public static GameObject leftPlat;
        public static void Platforms()
        {
            if (ControllerInputPoller.instance.rightGrab)
            {
                if (rightPlat == null)
                {
                    rightPlat = GameObject.CreatePrimitive((PrimitiveType)3);
                    rightPlat.transform.localScale = new Vector3(0.0125f, 0.28f, 0.3825f);
                    rightPlat.transform.position = new Vector3(0, -0.01f, 0) + GorillaLocomotion.GTPlayer.Instance.RightHand.controllerTransform.position;
                    rightPlat.transform.rotation = GorillaLocomotion.GTPlayer.Instance.RightHand.controllerTransform.rotation;
                    rightPlat.AddComponent<GorillaSurfaceOverride>().overrideIndex = rightPlat.GetComponent<GorillaSurfaceOverride>().overrideIndex;
                    rightPlat.GetComponent<Renderer>().material.color = new Color32(25, 25, 25, byte.MaxValue);
                }
            }
            else
            {
                if (rightPlat != null)
                {
                    if (platGravity)
                    {
                        GameObject.Destroy(rightPlat.GetComponent<Collider>());
                        Rigidbody rigid = rightPlat.AddComponent<Rigidbody>();
                        rigid.velocity = GorillaLocomotion.GTPlayer.Instance.RightHand.velocityTracker.GetAverageVelocity(true, 5);
                        GameObject.Destroy(rightPlat, 2.0f);
                    }
                    else
                    {
                        rightPlat.Destroy();
                    }
                    rightPlat = null;
                }
            }
        }
    }
}

using StupidTemplate.Classes;
using UnityEngine;
using static StupidTemplate.Menu.Main;

namespace StupidTemplate
{
    public class Settings
    {
        /*
         * These are the settings for the menu.
         * 
         * To change the colors, you need to modify the ExtGradient variables.
         * Here are some examples on how to use ExtGradient:
         * 
         * Solid Color:
         *  new ExtGradient { colors = ExtGradient.GetSolidGradient(Color.black) }
         *  
         * Simple Gradient:
         *  new ExtGradient { colors = ExtGradient.GetSimpleGradient(Color.black, Color.white) }
         * 
         * Rainbow Color:
         *   new ExtGradient { rainbow = true }
         *   
         * Epileptic Color (random color every frame):
         *   new ExtGradient { epileptic = true }
         *   
         * Self Color:
         *   new ExtGradient { copyRigColor = true }
         *   
         * To change the font, you may use the following code:
         *   Font.CreateDynamicFontFromOSFont("Comic Sans MS", 24)
         */

        public static ExtGradient backgroundColor = new ExtGradient { rainbow = false};
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            new ExtGradient { colors = ExtGradient.GetSolidGradient(new Color32(41, 41, 41, byte.MaxValue)) }, // Disabled
            new ExtGradient { colors = ExtGradient.GetSolidGradient(new Color32(89, 203, 89, byte.MaxValue)) } // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };
        public static int buttonIncremental = 3;
        public static int soundAmount = 3;
        public static void ChangeButtonSound()
        {
            buttonIncremental++;
            if (buttonIncremental > soundAmount)
            {
                buttonIncremental = 1;
            }
            if (buttonIncremental == 1)
            {
                Button.buttonSound = 8;
                GetIndex("cbs").overlapText = "Change Button Sound: Wood";
            }
            if (buttonIncremental == 2)
            {
                Button.buttonSound = 66;
                GetIndex("cbs").overlapText = "Change Button Sound: Keyboard";
            }
            if (buttonIncremental == 3)
            {
                Button.buttonSound = 67;
                GetIndex("cbs").overlapText = "Change Button Sound: Default";
            }
        }

        public static Font currentFont = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded;
        public static bool disableNotifications;

        public static KeyCode keyboardButton = KeyCode.Q;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, width, height
        public static int buttonsPerPage = 4;

        public static float gradientSpeed = 0.5f; // Speed of colors
    }
}

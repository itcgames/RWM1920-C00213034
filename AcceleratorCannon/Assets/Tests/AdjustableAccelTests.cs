using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class AdjustableAccelTests
    {
        GameObject Object = Resources.Load("Accelerator") as GameObject;
        GameObject Slider = Resources.Load("Accelerator/Slider") as GameObject;
        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator TestDragActive()
        {
            //Slider.GetComponent<CheckForClickAccel>().OnMouseDown();
            //yield return new WaitForSeconds(0.1f);

            //Assert.AreEqual(Slider.GetComponent<CheckForClickAccel>().m_drag, true);
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
